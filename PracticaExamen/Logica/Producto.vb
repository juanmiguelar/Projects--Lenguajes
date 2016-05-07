Imports ObjetosTransferencia
Imports AccesoDatos

Public Class Producto
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

    Function buscarme(cod As String) As Producto
        Dim daop As DAOProducto = New DAOProducto()
        Dim top As TOProducto

        top = daop.search(cod)

        Return New Producto(top.Codigo, top.Descripcion, top.Precio)
    End Function
End Class
