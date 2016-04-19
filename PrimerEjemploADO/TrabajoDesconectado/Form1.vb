Imports System.Data.SqlClient
Public Class Form1

    Dim conexion As New SqlConnection(My.Settings.connectionString)
    Dim tablaDatos As New DataTable
    Dim adaptador As New SqlDataAdapter

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        adaptador.DeleteCommand = crearDelete()
        adaptador.InsertCommand = crearInsert()
        adaptador.UpdateCommand = crearUpdate()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        ' Vaciamos la datable
        tablaDatos.Clear()

        ' Setteamos el comando
        adaptador.SelectCommand = New SqlCommand("SELECT * FROM Personas", conexion)

        ' Llenamos la datable
        adaptador.Fill(tablaDatos)

        grdDatos.DataSource = tablaDatos
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Esto es lo que hace que se guarden los cambios en la base de datos
        adaptador.Update(tablaDatos)
    End Sub

    Private Function crearDelete() As SqlCommand
        Dim retorno As New SqlCommand(
            "DELETE Personas WHERE Codigo=@cod", conexion)

        ' Es un objeto de tipo parametro que nos va a ayudar a ingresar el parametro a la sentencia
        Dim param1 As New SqlParameter("cod", SqlDbType.Int, 4, "Codigo")

        ' Le digo al comando que parametro
        retorno.Parameters.Add(param1)

        Return retorno
    End Function

    Private Function crearInsert() As SqlCommand
        Dim retorno As New SqlCommand(
            "INSERT INTO Personas VALUES(@cod, @nombre, @apellido)", conexion)

        ' Es un objeto de tipo parametro que nos va a ayudar a ingresar el parametro a la sentencia
        Dim paramCod As New SqlParameter("cod", SqlDbType.Int, 4, "Codigo")
        Dim paramNombre As New SqlParameter("nombre", SqlDbType.NVarChar, 50, "Nombre")
        Dim paramApellido As New SqlParameter("apellido", SqlDbType.NVarChar, 50, "Apellido")

        ' Le digo al comando que parametro
        retorno.Parameters.Add(paramCod)
        retorno.Parameters.Add(paramNombre)
        retorno.Parameters.Add(paramApellido)

        Return retorno
    End Function

    Private Function crearUpdate() As SqlCommand
        Dim retorno As New SqlCommand()
        retorno.Connection = conexion
        retorno.CommandType = CommandType.StoredProcedure
        retorno.CommandText = "ModificarPersonas"


        ' Es un objeto de tipo parametro que nos va a ayudar a ingresar el parametro a la sentencia
        Dim paramCod As New SqlParameter("codigo", SqlDbType.Int, 4, "Codigo")
        Dim paramNombre As New SqlParameter("nombre", SqlDbType.NVarChar, 50, "Nombre")
        Dim paramApellido As New SqlParameter("apellido", SqlDbType.NVarChar, 50, "Apellido")

        ' Le digo al comando que parametro
        retorno.Parameters.Add(paramCod)
        retorno.Parameters.Add(paramNombre)
        retorno.Parameters.Add(paramApellido)

        Return retorno
    End Function
End Class
