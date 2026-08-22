Public Class Prescription
    Public Property ID As UInteger
    Public Property VisitId As UInteger
    Public Property PrescribedBy As UInteger?
    Public Property PrescriptionDate As DateTime
    Public Property Status As PrescriptionStatus
    Public Property Instructions As String

    Public Property Visit As Visit
    Public Property Doctor As Staff
    Public Property Items As List(Of PrescriptionItem) = New List(Of PrescriptionItem)()
End Class

Public Class PrescriptionItems
    Public Property Id As UInteger
    Public Property PrescriptionId As UInteger
    Public Property MedicationId As UInteger
    Public Property Dosage As String
    Public Property Frequency As String
    Public Property Route As String
    Public Property DurationDays As UShort?
    Public Property Quantity As Decimal?
    Public Property Instructions As String

    Public Property Precription As Prescription
    Public Property Medication As Medication
End Class
