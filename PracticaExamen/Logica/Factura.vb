Public Class Factura
    Property ID_Factura As Integer
    Property Fecha As Date
    Property Cliente As Cliente
    Property Detalle As ListaProductos

    Sub New()
        Detalle = New ListaProductos()
    End Sub

    Sub New(id As Integer, f As Date, c As Cliente, d As ListaProductos)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
    End Sub

    Sub New(id As Integer, f As Date, c As Cliente)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New ListaProductos()
    End Sub

    Sub New(f As Date, c As Cliente, d As ListaProductos)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = d
    End Sub

    Sub New(f As Date, c As Cliente)
        Me.Fecha = f
        Me.Cliente = c
        Me.Detalle = New ListaProductos()
    End Sub

End Class
