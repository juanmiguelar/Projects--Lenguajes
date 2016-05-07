Imports ObjectosTransferencia
Imports System.Data.SqlClient
Public Class DAODisenno
    Dim comando As SqlCommand
    Dim connection As ConnectionManager

    Sub New()
        connection = New ConnectionManager
    End Sub

    Function guardar(disenno As TODisenno) As TODisenno
        Dim query As String = "INSERT INTO Disenno VALUES(@nombre, @descripcion, @tipo, @precio); SELECT SCOPE_IDENTITY() AS ID"
        comando = New SqlCommand(query, connection.getConnection)

        comando.Parameters.AddWithValue("@nombre", disenno.Nombre)
        comando.Parameters.AddWithValue("@descripcion", disenno.Descripcion)
        comando.Parameters.AddWithValue("@tipo", disenno.Tipo)
        comando.Parameters.AddWithValue("@precio", disenno.Precio)

        Try
            connection.abrir()
            Dim cod As Integer = Int32.Parse(comando.ExecuteScalar.ToString)
            disenno.ID_Disenno = cod
        Catch ex As Exception
            System.Console.WriteLine(ex.Message)
        Finally
            connection.cerrar()
        End Try

        Return disenno

    End Function

End Class
