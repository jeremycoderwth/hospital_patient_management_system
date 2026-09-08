Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim connectionString = ConfigurationManager.ConnectionStrings("HPMSConnectionString").ConnectionString

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open

                MessageBox.Show("Successfully connected to MySQL 8.0!", "Connection Test")
            Catch ex As MySqlException
                MessageBox.Show("Database Error: " & ex.Message, "Connection Failed")
            Catch ex As Exception
                MessageBox.Show("General Error: " & ex.Message, "Error")
            End Try
        End Using
    End Sub
End Class
