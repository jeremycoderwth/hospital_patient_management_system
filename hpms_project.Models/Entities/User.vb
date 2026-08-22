Imports hpms_project.Models
Public Class User
    Public Property UserID As Integer
    Public Property Username As String
    Public Property PasswordHash As String
    Public Property FullName As String
    Public Property Role As UserRole.UserRoles
    Public Property IsActive As Boolean = True
    Public Property LastLoginAt As DateTime
    Public Property CreatedAt As DateTime = DateTime.Now
    Public Property UpdatedAt As DateTime = DateTime.Now
End Class
