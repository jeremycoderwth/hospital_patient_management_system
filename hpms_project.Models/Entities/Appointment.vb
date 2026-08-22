Imports hpms_project.Models

Public Class Appointment
    Public Property AppointmentID As Integer
    Public Property CreatedBy As Integer
    Public Property PatientID As Integer
    Public Property DoctorID As Integer
    Public Property AppointmentDate As DateTime
    Public Property ReasonForVisit As String
    Public Property Status As AppointmentStatus.Statuses = AppointmentStatus.Statuses.Scheduled
    Public Property Notes As String
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public Property Patient As Patient
    Public Property Doctor As Staff
    Public Property Creator As User
End Class
