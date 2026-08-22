Public Class Visit
    Public Property ID As UInteger
    Public Property PatientID As UInteger
    Public Property AppointmentID As UInteger?
    Public Property DoctorID As UInteger?
    Public Property VisitType As VisitType
    Public Property VisitSchedule As DateTime
    Public Property ChiefComplaint As String
    Public Property IllnessHistory As String
    Public Property PhysicalExamination As String
    Public Property Assessment As String
    Public Property TreatmentPlan As String
    Public Property Notes As String
    Public Property Status As VisitStatus
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public Property Patient As Patient
    Public Property Doctor As Staff
    Public Property Appointment As Appointment
    Public Property VitalSigns As List(Of VitalSign) = New List(Of VitalSign)()
    Public Property Diagnoses As List(Of VisitDiagnosis) = New List(Of VisitDiagnosis)()
    Public Property Prescriptions As List(Of Prescription) = New List(Of Prescription)()
End Class

Public Class VitalSign
    Public Property VitalSignID As UInteger
    Public Property VisitID As UInteger
    Public Property TemperatureCelsius As Decimal?
    Public Property SystolicBp As UShort?
    Public Property DiastolicBp As UShort?
    Public Property PulseRate As UShort?
    Public Property RespiratoryRate As UShort?
    Public Property OxygenSaturation As Decimal?
    Public Property HeightCm As Decimal?
    Public Property WeightKg As Decimal?
    Public Property RecordedBy As UInteger?
    Public Property RecordedAt As DateTime = DateTime.Now

    Public Property Visit As Visit
    Public Property RecordedByStaff As Staff
End Class