Public Class TOCliente
    Property Cedula As String
    Property Nombre As String

    Sub New()

    End Sub

    Sub New(ced As String, nom As String)
        Me.Cedula = ced
        Me.Nombre = nom
    End Sub
End Class
