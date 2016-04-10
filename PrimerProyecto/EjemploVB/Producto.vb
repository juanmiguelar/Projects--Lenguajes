Public Class Producto

    ' Se crean automatica mente tienen su get y su set
    ' Autodeclaradas el get y un set 
    Property cod As Integer
    Property name As String


    ' Declarar un método void
    ' Constructor vacio
    Sub New()

    End Sub
    'Contructor con parametros
    Sub New(cod As Integer, name As String)
        Me.cod = cod
        Me.name = name
    End Sub

End Class
