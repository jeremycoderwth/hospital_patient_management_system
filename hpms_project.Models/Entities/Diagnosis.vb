Public Class Diagnosis
    Public Property ID As UInteger
    Public Property DiagnosisCode As String
    Public Property DiagnosisName As String
    Public Property Description As String
    Public Property IsActive As Boolean
End Class

Public Class VisitDiagnosis
    Public Property ID As UInteger
    Public Property VisitID As UInteger
    Public Property DiagnosisID As UInteger
    Public Property DiagnosisType As DiagnosisType
    Public Property Notes As String
    Public Property CreatedAt As DateTime = DateTime.Now

    Public Property Visit As Visit
    Public Property Diagnosis As Diagnosis
End Class