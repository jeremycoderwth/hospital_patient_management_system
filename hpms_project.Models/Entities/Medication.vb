Public Class Medication
    Public Property ID As UInteger
    Public Property MedicationCode As String
    Public Property GenericName As String
    Public Property BrandName As String
    Public Property DosageForm As String
    Public Property Strength As String
    Public Property IsActive As Boolean
    Public Property CreatedAt As DateTime = DateTime.Now
End Class
