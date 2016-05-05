Imports System.Windows.Forms

Public Class Principal

    Private Sub CrearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearToolStripMenuItem1.Click
        ' Creo instancia de lo que quiero mostrar
        Dim crearDisenno As CrearDisenno = New CrearDisenno()
        ' Le digo que el mdiparent es la ventana actual
        crearDisenno.MdiParent = Me
        ' muestro la ventana que quiero mostrar
        crearDisenno.Show()
    End Sub

    Private Sub VerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem1.Click
        ' Creo la instancia de lo que quiero mostrar
        Dim verDisennos As VerDisennos = New VerDisennos
        ' Le digo que su padre es la ventana actual
        verDisennos.MdiParent = Me
        ' Muestro la ventana
        verDisennos.Show()
    End Sub
End Class
