Public Class ListaProductos
    Private lista As List(Of Producto)
    Property numeroFactura As Integer

    Sub New()
        lista = New List(Of Producto)
    End Sub

    Sub agregar(p As Producto)
        lista.Add(p)
    End Sub

    Sub cargar()

    End Sub

    Function obtener() As List(Of Producto)
        Return lista
    End Function

    Function total() As Integer
        Dim precioTotal As Integer
        For Each p As Producto In lista
            precioTotal += p.Precio
        Next

        Return precioTotal
    End Function
End Class
