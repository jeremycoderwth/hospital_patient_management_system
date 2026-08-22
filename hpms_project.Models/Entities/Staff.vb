Public Class Staff
    Public Property StaffID As UInteger
    Public Property UserID As UInteger
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property LastName As String
    Public Property StaffType As StaffType
    Public Property LicenseNumber As String
    Public Property PhoneNumber As String
    Public Property IsActive As Boolean = True
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now

    Public Property AccountUser As User
End Class
