Imports AccesoDatos
Imports ObjetosTransferencia
Public Class ListaClientes
    Private lista As List(Of Cliente)

    Sub New()
        lista = New List(Of Cliente)
    End Sub

    Sub agregar(c As Cliente)
        lista.Add(c)
    End Sub

    Function obtener(i As Integer) As Cliente
        Return lista.Item(i)
    End Function

    Function obtener() As List(Of Cliente)
        Return Me.lista
    End Function

    Sub cargar()
        Dim daoC As DAOCliente = New DAOCliente()

        For Each c As TOCliente In daoC.cargar
            Me.agregar(New Cliente(c.Cedula, c.Nombre))
        Next

    End Sub
End Class
