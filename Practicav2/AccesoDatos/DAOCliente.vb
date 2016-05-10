Imports ObjetosTransferencia
Imports System.Data
Imports System.Data.SqlClient
Public Class DAOCliente
    Dim conex As ConnectionManager
    Dim comando As SqlCommand

    Sub New()
        conex = New ConnectionManager
    End Sub

    Public Function selectClientes() As TOListaClientes
        comando = Me.selectCommand
        Dim lista As TOListaClientes = New TOListaClientes
        Try
            conex.abrir()
            Dim reader As SqlDataReader

            reader = comando.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    Dim cedula, nombre As String

                    cedula = reader("Cedula").ToString()
                    nombre = reader("NombreCompleto").ToString()

                    lista.lista.Add(New TOCliente(cedula, nombre))
                End While
                reader.Close()
            End If

            Return lista
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        Finally
            conex.cerrar()
        End Try
    End Function

    Function buscar(cod As String) As TOCliente
        comando = Me.buscarCommand(cod)
        Dim ced, nombre As String

        Try
            conex.abrir()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    ced = reader("Cedula").ToString()
                    nombre = reader("NombreCompleto").ToString()
                    Exit While
                End While
            End If
            reader.Close()
            Return New TOCliente(ced, nombre)
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        Finally
            conex.cerrar()
        End Try

    End Function

    Private Function buscarCommand(cod As String) As SqlCommand
        Dim query As String = "SELECT * FROM Clientes WHERE Cedula=@cod"

        Dim c As SqlCommand = New SqlCommand(query, conex.connection)
        c.Parameters.AddWithValue("@cod", cod)

        Return c
    End Function

    Private Function selectCommand() As SqlCommand
        Dim query As String = "SELECT * FROM Clientes"

        Dim c As SqlCommand = New SqlCommand(query, conex.connection)

        Return c
    End Function

End Class
