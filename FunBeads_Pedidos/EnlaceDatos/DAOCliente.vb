Imports System.Data
Imports System.Data.SqlClient
Imports ObjectosTransferencia

Public Class DAOCliente
    Dim connection As ConnectionManager
    Dim comando As SqlCommand

    Sub New()
        connection = New ConnectionManager
    End Sub

    Function guardar(cliente As TOCliente) As TOCliente
        Dim query As String = "INSERT INTO Cliente VALUES(@nombre); SELECT SCOPE_IDENTITY() AS ID"
        Dim cod As Integer

        comando = New SqlCommand(query, connection.getConnection)
        comando.Parameters.AddWithValue("@nombre", cliente.Nombre)

        Try
            connection.abrir()
            cod = Int32.Parse(comando.ExecuteScalar.ToString)
        Catch ex As Exception
            System.Console.WriteLine(ex.Message)
        Finally
            connection.cerrar()
        End Try

        cliente.ID_Cliente = cod

        Return cliente

    End Function

End Class
