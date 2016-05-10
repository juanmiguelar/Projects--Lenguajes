Imports ObjetosTransferencia
Imports System.Data
Imports System.Data.SqlClient

Public Class DAODetalleFactura
    Dim conex As ConnectionManager
    Dim comando As SqlCommand

    Sub New()
        conex = New ConnectionManager
    End Sub

    Function guardarDetalle(detalle As TODetalleFactura) As Boolean
        Dim daoP As DAOProducto = New DAOProducto

        For Each item As TOProducto In detalle.lista
            If Not daoP.guardar(item, detalle.NumeroFactura) Then
                Throw New Exception("No se pudo guardar el detalle de la factura")
            End If
        Next

        Return True
    End Function


End Class
