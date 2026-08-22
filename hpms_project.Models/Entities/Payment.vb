Public Class Payment
    Public Property ID As UInteger
    Public Property InvoiceID As UInteger
    Public Property PaymentReference As String
    Public Property Amount As Decimal
    Public Property PaymentMethod As PaymentMethod
    Public Property PaymentDate As DateTime
    Public Property ReceivedBy As UInteger?
    Public Property Notes As String

    Public Property Invoice As Invoice
    Public Property ReceivedByUser As User
End Class
