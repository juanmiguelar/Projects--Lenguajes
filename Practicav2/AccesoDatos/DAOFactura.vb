Imports ObjetosTransferencia
Imports System.Data
Imports System.Data.SqlClient

Public Class DAOFactura
    Dim conex As ConnectionManager
    Dim comando As SqlCommand

    Sub New()
        conex = New ConnectionManager
    End Sub

    Function guardar(f As TOFactura) As TOFactura

        Dim daoD As DAODetalleFactura = New DAODetalleFactura
        Dim num As Integer = getNum() + 1
        f.Numero = num
        f.detalle.NumeroFactura = num

        conex.abrir()
        comando = Me.insertCommand(f)

        comando.ExecuteNonQuery()

        conex.cerrar()

        daoD.guardarDetalle(f.detalle)

        Return f
    End Function

    Private Function insertCommand(f As TOFactura) As SqlCommand

        Dim query As String = "Insert into Factura Values(@num, GETDATE(), @ced, @total)"

        Dim c As SqlCommand = New SqlCommand(query, conex.connection)
        c.Parameters.AddWithValue("num", f.Numero)
        c.Parameters.AddWithValue("ced", f.ClienteF.Cedula)
        c.Parameters.AddWithValue("total", f.Total)

        Return c
    End Function

    Private Function getNum() As Integer
        conex.abrir()
        comando = Me.countCommand
        Dim num As Integer = comando.ExecuteScalar()
        conex.cerrar()
        Return num
    End Function

    Private Function countCommand() As SqlCommand
        Dim query As String = "Select Count(*) From Factura"
        Dim c As SqlCommand = New SqlCommand(query, conex.connection)

        Return c
    End Function

End Class
