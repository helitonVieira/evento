Public Class FrmParametroSistema
    Dim conectar As New ConexaoSQ
    Dim ds As New DataSet
    Dim paramSistem As New ClParametroSistema

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub btGravar_Click(sender As Object, e As EventArgs) Handles btGravar.Click
        If txbFontProduto.Text = "" Then
            txbFontProduto.Text = "0"
        End If

        If txb_fontIngresso.Text = "" Then
            txb_fontIngresso.Text = "0"
        End If

        Try
            paramSistem.dimFontIngresso = txb_fontIngresso.Text
            paramSistem.dimFontProduto = txbFontProduto.Text
            paramSistem.Atualizar()
            MsgBox("Parametros atualizados com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao tentar atualizar", MsgBoxStyle.Critical, "Erro")
        End Try


    End Sub

    Private Sub FrmParametroSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tabela As DataRow
            ds = paramSistem.consultarParametro()
            tabela = ds.Tables(0).Rows(0)

            txbFontProduto.Text = tabela.Item(0).ToString
            txb_fontIngresso.Text = tabela.Item(1).ToString
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txbFontProduto_TextChanged(sender As Object, e As EventArgs) Handles txbFontProduto.TextChanged
        If Not IsNumeric(txbFontProduto.Text) Then
            txbFontProduto.Text = ""
        End If
    End Sub

    Private Sub txb_fontIngresso_TextChanged(sender As Object, e As EventArgs) Handles txb_fontIngresso.TextChanged
        If Not IsNumeric(txb_fontIngresso.Text) Then
            txb_fontIngresso.Text = ""
        End If
    End Sub
End Class