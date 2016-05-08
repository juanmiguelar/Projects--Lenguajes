Public Class TOListaProductos
    Property lista As List(Of TOProducto)
    Property numeroFactura As Integer

    Sub New()
        lista = New List(Of TOProducto)
    End Sub
End Class
