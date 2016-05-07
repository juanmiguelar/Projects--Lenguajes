Public Class Factura
    Property ID_Factura As Integer
    Property Fecha As Date
    Property Cliente As Cliente
    Property Total As Integer
    Property Detalle As ListaProductos

    Sub New()

    End Sub

    Sub New(id As Integer, f As Date, c As Cliente, t As Integer, d As ListaProductos)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Total = t
        Me.Detalle = d
    End Sub

    Sub New(id As Integer, f As Date, c As Cliente, t As Integer)
        Me.ID_Factura = id
        Me.Fecha = f
        Me.Cliente = c
        Me.Total = t
        Me.Detalle = New ListaProductos()
    End Sub

    Sub New(f As Date, c As Cliente, t As Integer, d As ListaProductos)
        Me.Fecha = f
        Me.Cliente = c
        Me.Total = t
        Me.Detalle = d
    End Sub

    Sub New(f As Date, c As Cliente, t As Integer)
        Me.Fecha = f
        Me.Cliente = c
        Me.Total = t
        Me.Detalle = New ListaProductos()
    End Sub



End Class
