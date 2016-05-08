Public Class TOFactura
    Property ID_Factura As Integer
    Property Fecha As Date
    Property Cliente As TOCliente
    Property Detalle As TOListaProductos

    Sub New()

    End Sub

    Sub New(id As Integer, f As Date, c As TOCliente, d As TOListaProductos)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
    End Sub

    Sub New(id As Integer, f As Date, c As TOCliente)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New TOListaProductos()
    End Sub

    Sub New(f As Date, c As TOCliente, d As TOListaProductos)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
    End Sub

    Sub New(f As Date, c As TOCliente)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New TOListaProductos()
    End Sub
End Class
