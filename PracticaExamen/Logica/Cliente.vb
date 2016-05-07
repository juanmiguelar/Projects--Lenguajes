Imports ObjetosTransferencia
Imports AccesoDatos

Public Class Cliente
    Property Cedula As String
    Property Nombre As String

    Sub New()

    End Sub

    Sub New(ced As String, nom As String)
        Me.Cedula = ced
        Me.Nombre = nom
    End Sub

    Sub guardar()
        Dim daoC As DAOCliente = New DAOCliente()
        Dim toC As TOCliente = New TOCliente(Me.Cedula, Me.Nombre)

        daoC.guardar(toC)

    End Sub
End Class
