Public Class ProductForm

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cbxList.ValueMember = "cod"
        cbxList.DisplayMember = "name"
    End Sub

    Private list As New List(Of Producto)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Obtengo los valores ingresados por el usuario
        Dim cod As String = txtCod.Text
        Dim name As String = txtName.Text

        ' Declara el nuevo producto
        Dim newproduct As New Producto(cod, name)

        If Not isDuplicated(cod) Then
            ' Agrega el nuevo producto
            list.Add(newproduct)
            cbxList.DataSource = list.ToArray
        Else
            MsgBox("The code already exits")
        End If

        ' Limpia los campos
        txtCod.Text = String.Empty
        txtName.Text = String.Empty
    End Sub

    Private Sub cbxList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxList.SelectedIndexChanged

        lblShowCod.Text = "Cod: " + cbxList.SelectedValue.ToString
    End Sub

    Function isDuplicated(codx As String) As Boolean

        For x As Integer = 0 To (list.Count - 1) Step 1

            If list.Item(x).cod = codx Then
                isDuplicated = True
            End If
        Next
        isDuplicated = False
    End Function
End Class