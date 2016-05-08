Public Class TOFactura
    Property ID_Factura As Integer
    Property Fecha As Date
    Property Cliente As TOCliente
    Property Detalle As TOListaProductos
    Property Total As Integer

    Sub New()

    End Sub

    Sub New(id As Integer, f As Date, c As TOCliente, d As TOListaProductos, t As Integer)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
        Me.Total = t
    End Sub

    Sub New(id As Integer, f As Date, c As TOCliente, t As Integer)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New TOListaProductos()
        Me.Total = t
    End Sub

    Sub New(f As Date, c As TOCliente, d As TOListaProductos, t As Integer)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
        Me.Total = t
    End Sub

    Sub New(f As Date, c As TOCliente, t As Integer)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New TOListaProductos()
        Me.Total = t
    End Sub
End Class
