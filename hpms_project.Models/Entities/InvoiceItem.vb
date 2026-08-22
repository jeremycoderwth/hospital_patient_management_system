Public Class InvoiceItem
    Public Property Id As UInteger
    Public Property InvoiceId As UInteger
    Public Property ItemType As InvoiceType.ItemTypes
    Public Property Description As String
    Public Property Quantity As Decimal
    Public Property UnitPrice As Decimal
    Public Property LineTotal As Decimal

    Public Property Invoice As Invoice

    Public ReadOnly Property SubTotal As Decimal
        Get
            Return Quantity * UnitPrice
        End Get
    End Property
End Class
