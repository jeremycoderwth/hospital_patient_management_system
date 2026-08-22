Public Class MedicalRecord
    Public Property RecordID As Integer
    Public Property PatientID As Integer
    Public Property DoctorID As Integer
    Public Property AppointmentID As Integer
    Public Property VisitDate As DateTime = DateTime.Now
    Public Property Diagnosis As String
    Public Property Symptoms As String
    Public Property TreatmentPlan As String
    Public Property DoctorNotes As String
    Public Property Prescriptions As New List(Of Prescription)
End Class
