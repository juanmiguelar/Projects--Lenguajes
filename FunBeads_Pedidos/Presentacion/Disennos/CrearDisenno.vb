Public Class CrearDisenno
    Private Sep As Char
    Private nombre As String
    Private descripcion As String
    Private precio As Integer

    Private Sub CrearDisenno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        validarCampos()

        nombre = txtNombre.Text
        descripcion = txtDescripcion.Text
        precio = Int32.Parse(txtPrecio.Text)
    End Sub

    Function validarCampos() As Boolean
        If txtNombre.Text.Equals("") Then
            MsgBox("Debe tener un nombre")
            Return False
        End If

        If txtDescripcion.Text.Equals("") Then
            MsgBox("Debe tener una descripcion")
            Return False
        End If

        If txtPrecio.Text.Equals("") Then
            MsgBox("Debe tener un precio")
            Return False
        End If

        Return True
    End Function

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub


End Class