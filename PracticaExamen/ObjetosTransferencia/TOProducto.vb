Public Class TOProducto
    Property Codigo As String
    Property Descripcion As String
    Property Precio As Integer

    Sub New()

    End Sub

    Sub New(cod As String, desc As String, pre As Integer)
        Me.Codigo = cod
        Me.Descripcion = desc
        Me.Precio = pre
    End Sub
End Class
