Imports System.Data.SqlClient

Public Class ConnectionManager
    Property connection As SqlConnection
    Dim connectionString As String

    Sub New()
        connection = New SqlConnection()
        connectionString = My.Settings.connectionStr
        connection.ConnectionString = connectionString
    End Sub

    Sub abrir()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If
    End Sub

    Sub cerrar()
        If connection.State <> ConnectionState.Closed Then
            connection.Close()
        End If
    End Sub
End Class
