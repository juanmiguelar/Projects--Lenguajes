Imports ObjetosTransferencia
Imports AccesoDatos

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

    Sub guardar()
        Dim daof As DAOFactura = New DAOFactura()
        Dim tol As TOListaProductos = listaTO()
        Dim toc As TOCliente = New TOCliente(Me.Cliente.Cedula, Me.Cliente.Nombre)
        Dim tof As TOFactura = New TOFactura(Me.Fecha, toc, tol, Me.Detalle.total)

        'Guardar

    End Sub

    Private Function listaTO() As TOListaProductos
        Dim tol As TOListaProductos = New TOListaProductos()

        For Each p As Producto In Me.Detalle.obtener()
            tol.lista.Add(New TOProducto(p.Codigo, p.Descripcion, p.Precio))
        Next

        Return tol
    End Function
End Class
