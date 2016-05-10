Imports Logica
Public Class VerDisennos

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        refreshDGrid()
    End Sub

    Private Sub refreshDGrid()
        Dim l As ListaDisennos = New ListaDisennos
        l.refresh()

        dgridVerDisennos.DataSource = Nothing
        dgridVerDisennos.DataSource = l.lista
    End Sub
End Class