Imports hpms_project.Models.InvoiceStatus

Public Class Invoice
    Public Property Id As UInteger
    Public Property PatientId As UInteger
    Public Property VisitId As UInteger?
    Public Property InvoiceNumber As String
    Public Property InvoiceDate As DateTime
    Public Property Subtotal As Decimal
    Public Property DiscountAmount As Decimal
    Public Property TotalAmount As Decimal
    Public Property Status As InvoiceStatus
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public Property Patient As Patient
    Public Property Visit As Visit
    Public Property Items As List(Of InvoiceItem) = New List(Of InvoiceItem)()
    Public Property Payments As List(Of Payment) = New List(Of Payment)()
End Class
