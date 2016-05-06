Imports ObjectosTransferencia
Imports System.Data.SqlClient
Public Class DAODisenno
    Dim comando As SqlCommand
    Dim connection As ConnectionManager

    Sub New()
        connection = New ConnectionManager
    End Sub

    Function guardar(disenno As TODisenno) As TODisenno
        Dim query As String = "INSERT INTO Disennos VALUES()"
    End Function

End Class
