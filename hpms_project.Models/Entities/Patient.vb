Imports hpms_project.Models
Public Class Patient
    Public Property ID As UInteger
    Public Property PatientNumber As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property Suffix As String
    Public Property DateOfBirth As DateTime
    Public Property Gender As Gender.Genders
    Public Property CivilStatus As CivilStatus.Statuses
    Public Property BloodType As BloodType.Types
    Public Property PhoneNumber As String
    Public Property Email As String
    Public Property Address As String
    Public Property Barangay As String
    Public Property City As String
    Public Property Province As String
    Public Property RegistrationDate As DateTime
    Public Property IsActive As Boolean = True
    Public Property EmergencyContactPerson As String
    Public Property EmergencyContactNumber As String
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public ReadOnly Property PatientFullName As String
        Get
            Dim fullName As String = $"{FirstName} "

            If Not String.IsNullOrEmpty(MiddleName) Then
                fullName &= $"{MiddleName} "
            End If

            fullName &= $"{LastName}"

            If Not String.IsNullOrEmpty(Suffix) Then
                fullName &= $" {Suffix}"
            End If

            Return fullName
        End Get
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim today = DateTime.Today
            Dim calculatedAge = today.Year - DateOfBirth.Year

            If DateOfBirth.Date > today.AddYears(-calculatedAge) Then
                calculatedAge -= 1
            End If

            Return calculatedAge
        End Get
    End Property

    Public Property Contacts As List(Of PatientContact) = New List(Of PatientContact)()

    Public Property Visits As List(Of Visit) = New List(Of Visit)()

    Public Property Appointments As List(Of Appointment) = New List(Of Appointment)()

    Public Property Invoices As List(Of Invoice) = New List(Of Invoice)()
End Class

Public Class PatientContact
    Public Property ContactID As UInteger
    Public Property PatientID As UInteger
    Public Property ContactName As String
    Public Property Relationship As String
    Public Property PhoneNumber As String
    Public Property Address As String
    Public Property IsEmergencyContact As Boolean
    Public Property IsPrimary As Boolean
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public Property Patient As Patient
End Class