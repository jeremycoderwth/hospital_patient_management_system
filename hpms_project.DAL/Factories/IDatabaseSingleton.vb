Imports MySql.Data.MySqlClient

Public Interface IDatabaseSingleton
    Inherits IAsyncDisposable

    Function BeginTransactionAsync() As Task
    Function CommitAysnc() As Task
    Function RollbackAsync() As Task
End Interface

Public Class DatabaseSingleton
    Implements IDatabaseSingleton

    Private ReadOnly _connectionString As String
    Private _connection As MySqlConnection
    Private _transaction As MySqlTransaction

    Public Sub New(connectionString As String)
        _connectionString = connectionString
        '_connection = New MySqlConnection(_connectionString)
    End Sub

    Public Async Function BeginTransactionAsync() As Task Implements IDatabaseSingleton.BeginTransactionAsync
        _connection = New MySqlConnection(_connectionString)
        Await _connection.OpenAsync()
        _transaction = Await _connection.BeginTransactionAsync()
    End Function

    Public Async Function CommitAsync() As Task Implements IDatabaseSingleton.CommitAysnc
        Dim cleanupTask As Task = Task.CompletedTask
        Try
            If _transaction IsNot Nothing Then
                Await _transaction.CommitAsync()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error committing transaction: {ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cleanupTask = CleanupAsync()
        End Try
        Await cleanupTask
    End Function

    Public Async Function RollbackAsync() As Task Implements IDatabaseSingleton.RollbackAsync
        Dim cleanupTask As Task = Task.CompletedTask
        Try
            If _transaction IsNot Nothing Then
                Await _transaction.RollbackAsync()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error rolling back transaction: {ex.Message}", "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cleanupTask = CleanupAsync()
        End Try
        Await cleanupTask
    End Function

    Private Async Function CleanupAsync() As Task
        If _transaction IsNot Nothing Then
            Await _transaction.DisposeAsync()
            _transaction = Nothing
        End If

        If _connection IsNot Nothing Then
            Await _connection.CloseAsync()
            Await _connection.DisposeAsync()
            _connection = Nothing
        End If
    End Function

    Public Function DisposeAsync() As ValueTask Implements IAsyncDisposable.DisposeAsync
        Return New ValueTask(CleanupAsync())
    End Function
End Class