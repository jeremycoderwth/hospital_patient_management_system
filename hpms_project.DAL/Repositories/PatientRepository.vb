Imports System.Data
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient
Imports hpms_project.Models

Public Class PatientRepository
    Private ReadOnly _connectionString As MySqlConnection
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(connectionString As MySqlConnection, transaction As MySqlTransaction)
        _connectionString = connectionString
        _transaction = transaction
    End Sub

    Public Async Function AddPatient(patient As Patient) As Task(Of UInteger)
        Const sqlInsert As String = "
           INSERT INTO patients (
            patient_number, first_name, middle_name, last_name, suffix, date_of_birth, sex, civil_status, blood_type, phone_number, email, address, barangay, city, province, is_active
           ) VALUES (
            @patient_number, @first_name, @middle_name, @last_name, @suffix, @date_of_birth, @sex, @civil_status, @blood_type, @phone_number, @email, @address, @barangay, @city, @province, @is_active
           );

           SELECT LAST_INSERT_ID();
        "

        Using cmd As New MySqlCommand(sqlInsert, _connectionString, _transaction)
            AddPatientParameters(cmd, patient)

            Dim result = Await cmd.ExecuteScalarAsync()
            Dim newID = Convert.ToUInt32(result)
            patient.ID = newID

            Return newID
        End Using
    End Function

    Public Async Function GetById(id As UInteger) As Task(Of Patient)
        Const sqlSelect = "SELECT * FROM patients WHERE id = @id LIMIT 1;"

        Using cmd As New MySqlCommand(sqlSelect, _connectionString, _transaction)
            cmd.Parameters.AddWithValue("@id", id)

            Using reader = Await cmd.ExecuteReaderAsync()
                If Await reader.ReadAsync() Then
                    Return MapDataReaderToPatient(reader)
                End If
            End Using
        End Using

        Return Nothing
    End Function

    Private Async Function SearchByNameOrPatietnNumber(searchTerm As String) As Task(Of List(Of Patient))
        Dim list As New List(Of Patient)()

        Const sqlSearch As String = "
            SELECT * FROM patients
            WHERE is_active  = 1
            AND (
                patient_number LIKE @search
                OR first_name LIKE @search
                OR last_name LIKE @search
            )
            ORDER BY last_name, first_name
            LIMIT 100;
        "

        Using cmd As New MySqlCommand(sqlSearch, _connectionString, _transaction)
            cmd.Parameters.AddWithValue("search", $"{searchTerm}%")

            Using reader = Await cmd.ExecuteReaderAsync()
                While Await reader.ReadAsync()
                    list.Add(MapDataReaderToPatient(reader))
                End While
            End Using
        End Using

        Return list
    End Function

    Public Async Function UpdatePatient(patient As Patient) As Task(Of Boolean)
        Const sqlUpdate As String = "
            UPDATE patients SET
            first_name = @first_name,
            last_name = @last_name,
            middle_name = @middle_name,
            suffix = @suffix,
            date_of_birth = @date_of_birth,
            sex = @sex,
            civil_status = @civil_status,
            blood_type = @blood_type,
            phone_number = @phone_number,
            email = @email,
            address = @address,
            barangay = @barangay,
            city = @city,
            province = @province
            is_active = @is_active,
            WHERE id = @id;
        "

        Using cmd As New MySqlCommand(sqlUpdate, _connectionString, _transaction)
            cmd.Parameters.AddWithValue("id", patient.ID)

            AddPatientParameters(cmd, patient)

            Dim rowsAffected = Await cmd.ExecuteNonQueryAsync()

            Return rowsAffected > 0
        End Using
    End Function

    Public Async Function DeletePatient(id As UInteger) As Task(Of Boolean)
        Const deleteSql As String = "
            UPDATE patients SET is_active = 0, updated_at = CURRENT_TIMESTAMP
            WHERE id = @id;
        "

        Using cmd As New MySqlCommand(deleteSql, _connectionString, _transaction)
            cmd.Parameters.AddWithValue("id", id)

            Dim rowsAffected = Await cmd.ExecuteNonQueryAsync()

            Return rowsAffected > 0
        End Using
    End Function

    Private Sub AddPatientParameters(cmd As MySqlCommand, patient As Patient)
        cmd.Parameters.AddWithValue("@patient_number", patient.PatientNumber)
        cmd.Parameters.AddWithValue("@first_name", patient.FirstName)
        cmd.Parameters.AddWithValue("@middle_name", If(String.IsNullOrWhiteSpace(patient.MiddleName), DBNull.Value, patient.MiddleName))
        cmd.Parameters.AddWithValue("@last_name", patient.LastName)
        cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrWhiteSpace(patient.Suffix), DBNull.Value, patient.Suffix))
        cmd.Parameters.AddWithValue("@date_of_birth", patient.DateOfBirth.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@sex", patient.Gender.ToString().ToLower())
        cmd.Parameters.AddWithValue("@civil_status", patient.CivilStatus.ToString().ToLower())
        cmd.Parameters.AddWithValue("@blood_type", ConvertBloodTypeToString(patient.BloodType))
        cmd.Parameters.AddWithValue("@phone_number", If(String.IsNullOrWhiteSpace(patient.PhoneNumber), DBNull.Value, patient.PhoneNumber))
        cmd.Parameters.AddWithValue("@email", If(String.IsNullOrWhiteSpace(patient.Email), DBNull.Value, patient.Email))
        cmd.Parameters.AddWithValue("@address", patient.Address)
        cmd.Parameters.AddWithValue("@barangay", patient.Barangay)
        cmd.Parameters.AddWithValue("@city", patient.City)
        cmd.Parameters.AddWithValue("@province", patient.Province)
        cmd.Parameters.AddWithValue("@is_active", If(patient.IsActive, 1, 0))
    End Sub

    Private Function MapDataReaderToPatient(reader As MySqlDataReader) As Patient
        Return New Patient With {
            .ID = Convert.ToUInt32(reader("id")),
            .PatientNumber = reader("patient_number").ToString(),
            .FirstName = reader("first_name").ToString(),
            .MiddleName = ReadNullableString(reader, "middle_name"),
            .LastName = reader("last_name").ToString(),
            .Suffix = ReadNullableString(reader, "suffix"),
            .DateOfBirth = Convert.ToDateTime(reader("date_of_birth")),
            .Gender = ParseEnum(Of Gender.Genders)(reader("sex").ToString()),
            .CivilStatus = ParseEnum(Of CivilStatus.Statuses)(reader("civil_status").ToString()),
            .BloodType = ParseBloodType(reader("blood_type").ToString()),
            .PhoneNumber = ReadNullableString(reader, "phone_number"),
            .Email = ReadNullableString(reader, "email"),
            .Address = reader("address").ToString(),
            .Barangay = reader("barangay").ToString(),
            .City = reader("city").ToString(),
            .Province = reader("province").ToString(),
            .RegistrationDate = Convert.ToDateTime(reader("registration_date")),
            .IsActive = Convert.ToBoolean(reader("is_active")),
            .CreatedAt = Convert.ToDateTime(reader("created_at")),
            .UpdatedAt = Convert.ToDateTime(reader("updated_at"))
        }
    End Function

    Private Function ReadNullableString(reader As MySqlDataReader, columnName As String) As String
        Dim ordinal = reader.GetOrdinal(columnName)

        If reader.IsDBNull(ordinal) Then Return Nothing

        Return reader.GetString(ordinal)
    End Function

    Private Function ParseEnum(Of T As Structure)(value As String) As T
        Dim result As T = Nothing

        If [Enum].TryParse(Of T)(value, True, result) Then
            Return result
        End If

        Dim values = [Enum].GetValues(GetType(T))
        If values.Length > 0 Then
            Return CType(values.GetValue(0), T)
        End If

        Return CType(Nothing, T)
    End Function

    Private Function ParseBloodType(value As String) As BloodType.Types
        Select Case value.ToUpper()
            Case "A+" : Return BloodType.Types.APositive
            Case "A-" : Return BloodType.Types.ANegative
            Case "B+" : Return BloodType.Types.BPositive
            Case "B-" : Return BloodType.Types.BNegative
            Case "AB+" : Return BloodType.Types.ABPositive
            Case "AB-" : Return BloodType.Types.ABNegative
            Case "O+" : Return BloodType.Types.OPositive
            Case "O-" : Return BloodType.Types.ONegative
            Case Else : Return Nothing
        End Select
    End Function

    Private Function ConvertBloodTypeToString(value As BloodType.Types) As String
        Select Case value
            Case BloodType.Types.APositive : Return "A+"
            Case BloodType.Types.ANegative : Return "A-"
            Case BloodType.Types.BPositive : Return "B+"
            Case BloodType.Types.BNegative : Return "B-"
            Case BloodType.Types.ABPositive : Return "AB+"
            Case BloodType.Types.ABNegative : Return "AB-"
            Case BloodType.Types.OPositive : Return "O+"
            Case BloodType.Types.ONegative : Return "O-"
            Case Else : Return "unknown"
        End Select
    End Function
End Class
