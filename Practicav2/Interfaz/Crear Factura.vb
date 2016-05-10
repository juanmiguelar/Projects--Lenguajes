Imports Logica

Public Class CrearFactura

    Dim listaClientes As ListaClientes
    Dim managerProducto As ManejadorProductos
    Dim Detalle As DetalleFactura
    Dim p As Producto
    Dim f As Factura

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        listaClientes = New ListaClientes
        managerProducto = New ManejadorProductos
        Detalle = New DetalleFactura
    End Sub

    Private Sub CrearFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshcbx()
    End Sub

    Sub refreshcbx()
        cbxClientes.DataSource = Nothing
        listaClientes.refresh()

        cbxClientes.DataSource = listaClientes.lista
        cbxClientes.ValueMember = "Cedula"
        cbxClientes.DisplayMember = "Nombre"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cod As String = txtCod.Text

        p = managerProducto.buscar(cod)

        If p.Codigo IsNot Nothing Then
            btnAgregar.Enabled = True
            txtCod.Text = p.Codigo
            txtDes.Text = p.Descripcion
            txtPrecio.Text = p.Precio
        Else
            btnAgregar.Enabled = False
            notFound()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If p IsNot Nothing Then
            Detalle.lista.Add(p)
            refreshGrid()
            txtTotal.Text = Detalle.total
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub refreshGrid()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Detalle.lista
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim c As Cliente = cbxClientes.SelectedItem
            f = New Factura()
            f.ClienteF = c
            f.detalle = Me.Detalle

            Dim cod As Integer = f.guardar()

            MsgBox("Su factura tiene numero: " + cod.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            clear()
        End Try
    End Sub

    Private Sub clear()
        listaClientes = New ListaClientes
        managerProducto = New ManejadorProductos
        Detalle = New DetalleFactura
        refreshcbx()
        refreshGrid()
        btnAceptar.Enabled = False
    End Sub

    Private Sub notFound()
        txtCod.Text = "Not found"
        txtDes.Text = String.Empty
        txtPrecio.Text = String.Empty
    End Sub
End Class
