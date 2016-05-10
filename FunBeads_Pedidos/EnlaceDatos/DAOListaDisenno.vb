Imports System.Data.SqlClient
Imports System.Data
Imports ObjectosTransferencia

Public Class DAOListaDisenno
    Dim comando As SqlCommand
    Dim connection As ConnectionManager

    Sub New()
        connection = New ConnectionManager
    End Sub

    Function cargar() As TOListaDisennos

        Dim reader As SqlDataReader
        Dim lista As TOListaDisennos = New TOListaDisennos

        connection.abrir()
        comando = selectCommand()

        reader = comando.ExecuteReader

        If reader.HasRows Then
            While reader.Read
                Dim nombre, descripcion, tipo As String
                Dim ID_Disenno, precio As Integer

                ID_Disenno = Int32.Parse(reader("ID_Disenno").ToString)
                nombre = reader("Nombre").ToString
                descripcion = reader("Descripcion").ToString
                tipo = reader("Tipo").ToString
                precio = Int32.Parse(reader("Precio").ToString)

                lista.lista.Add(New TODisenno(ID_Disenno, nombre, descripcion, tipo, precio))

            End While
            reader.Close()
        End If

        connection.cerrar()
        Return lista
    End Function

    Private Function selectCommand() As SqlCommand
        Dim query As String = "select * from Disenno"
        Dim c As SqlCommand = New SqlCommand(query, connection.getConnection)

        Return c
    End Function
End Class
