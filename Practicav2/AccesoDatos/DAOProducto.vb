Imports ObjetosTransferencia
Imports System.Data
Imports System.Data.SqlClient

Public Class DAOProducto
    Dim conex As ConnectionManager
    Dim comando As SqlCommand

    Sub New()
        conex = New ConnectionManager
    End Sub

    Function buscar(cod As String) As TOProducto
        comando = Me.buscarCommand(cod)
        Dim codigo, descripcion As String
        Dim precio As Integer

        Try
            conex.abrir()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            If reader.HasRows Then
                While reader.Read
                    codigo = reader("Codigo").ToString()
                    descripcion = reader("Descripcion").ToString()
                    precio = Int32.Parse(reader("PrecioUnitario").ToString(), Globalization.NumberStyles.Currency)
                    Exit While
                End While
            End If
            reader.Close()
            Return New TOProducto(codigo, descripcion, precio)
        Catch ex As SqlException
            Throw New Exception(ex.Message)
        Finally
            conex.cerrar()
        End Try

    End Function

    Function guardar(p As TOProducto, num As Integer) As Boolean

        conex.abrir()
        comando = Me.insertCommand(p, num)

        Dim i As Integer = comando.ExecuteNonQuery()

        conex.cerrar()

        Return i <> 0


    End Function

    Private Function buscarCommand(cod As String) As SqlCommand
        Dim query As String = "SELECT * FROM Productos WHERE Codigo=@cod"

        Dim c As SqlCommand = New SqlCommand(query, conex.connection)
        c.Parameters.AddWithValue("@cod", cod)

        Return c
    End Function

    Private Function insertCommand(p As TOProducto, num As Integer) As SqlCommand
        Dim query As String = "Insert into DetalleFactura Values(@num, @cod, @des, @precio)"
        Dim c As SqlCommand = New SqlCommand(query, conex.connection)

        c.Parameters.AddWithValue("num", num)
        c.Parameters.AddWithValue("cod", p.Codigo)
        c.Parameters.AddWithValue("des", p.Descripcion)
        c.Parameters.AddWithValue("precio", p.Precio)

        Return c
    End Function
End Class
