Public Class FrmAnimal
    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        TabControl1.SelectedIndex = 0
        TxbCodProprietario.Select()
    End Sub

    Private Sub BtnVacina_Click(sender As Object, e As EventArgs) Handles BtnVacina.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub BtnControleParasitario_Click(sender As Object, e As EventArgs) Handles BtnControleParasitario.Click
        TabControl1.SelectedIndex = 3
        TxbDtaParasita.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub DtpDtaNasc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaNasc.ValueChanged
        TxbDtaNasc.Text = DtpDtaNasc.Value
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DtpProximaParasita.ValueChanged
        TxbDtaProximaParasita.Text = DtpProximaParasita.Value
    End Sub

    Private Sub DtpDtaParasita_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaParasita.ValueChanged
        TxbDtaParasita.Text = DtpDtaParasita.Value
    End Sub
End Class