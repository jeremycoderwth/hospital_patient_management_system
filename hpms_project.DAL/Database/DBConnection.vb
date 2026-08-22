Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class DBConnection
    Private Shared Function GetConnectionString() As String
        ' Retrieve the connection string from the configuration file
        If ConfigurationManager.ConnectionStrings("HPMSConnectionString") Is Nothing Then
            Throw New Exception("No valid database connection string found")
        End If

        Return ConfigurationManager.ConnectionStrings("HPMSConnectionString").ConnectionString
    End Function

    Public Shared Function GetConnection() As MySqlConnection
        Dim connectionString As String = GetConnectionString()
        Return New MySqlConnection(connectionString)
    End Function

    Public Shared Function TestConnection() As Boolean
        Try
            Using connection As MySqlConnection = GetConnection()
                connection.Open()
                Return True
            End Using
        Catch ex As MySqlException
            Throw New Exception($"MySQL Connection Error [{ex.Number}]: {ex.Message}", ex)
            'Return False
        End Try
    End Function
End Class
