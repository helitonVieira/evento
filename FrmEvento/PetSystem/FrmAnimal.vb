Public Class FrmAnimal
    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub BtnVacina_Click(sender As Object, e As EventArgs) Handles BtnVacina.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub BtnControleParasitario_Click(sender As Object, e As EventArgs) Handles BtnControleParasitario.Click
        TabControl1.SelectedIndex = 3
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BtEvento_Click(sender As Object, e As EventArgs) Handles BtEvento.Click

    End Sub
End Class