Imports System.Data.SqlClient
Public Class ConnectionManager
    Private sqlConnection As SqlConnection
    Private connectionString As String

    Sub New()
        connectionString = My.Settings.connectionString
        sqlConnection = New SqlConnection
        sqlConnection.ConnectionString = connectionString

    End Sub

    Sub abrir()
        If sqlConnection.State <> ConnectionState.Open Then
            sqlConnection.Open()

        End If

    End Sub

    Sub cerrar()
        If sqlConnection.State <> ConnectionState.Closed Then
            sqlConnection.Close()

        End If

    End Sub

    Function getConnection() As SqlConnection
        Return sqlConnection
    End Function
End Class
