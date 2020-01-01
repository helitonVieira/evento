Public Class FrmLogin
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim clUsuario As New ClUsuario


    Private Sub CbExibirSenha_CheckedChanged(sender As Object, e As EventArgs) Handles CbExibirSenha.CheckedChanged
        If CbExibirSenha.Checked = False Then
            TxtSenha.PasswordChar = "*"
        Else
            TxtSenha.PasswordChar = ""
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Select()
    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            TxtSenha.Select()
        End If
    End Sub

    Private Sub TxtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSenha.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtEntrar.Select()
        End If
    End Sub

    Private Sub BtEntrar_Click(sender As Object, e As EventArgs) Handles BtEntrar.Click
        verificacao()

    End Sub
    Public Sub verificacao()
        Try
            If TxtUsuario.Text = "" Then
                MsgBox("Informe o Usuário", MsgBoxStyle.Information, "INFORMAÇÃO")
                TxtUsuario.Select()
            End If
            If TxtSenha.Text = "" Then
                MsgBox("Informe o SENHA", MsgBoxStyle.Information, "INFORMAÇÃO")
                TxtSenha.Select()
            End If
            clUsuario.nom_usuario = TxtUsuario.Text
            clUsuario.des_senha = TxtSenha.Text
            ds = clUsuario.ConsultarUsuario()
            Dim linha As DataRow
            For x As Integer = 0 To ds.Tables.Count
                linha = ds.Tables(0).Rows(x)

                '    linha = ds.Tables(0).Rows(1)
                ' MsgBox(linha.Item(1))
                If linha.Item(1) = TxtUsuario.Text And linha.Item(2) = TxtSenha.Text Then
                    FrmEscolhaEmpresa.ShowDialog()
                    FrmPrincipal.Show()
                    FrmPrincipal.LbNomeUsuario.Text = linha.Item(1)
                    FrmPrincipal.LbPermissaoUsuario.Text = linha.Item(3)
                    ModParametroSistema.nom_usuario = linha.Item(1)
                    ModParametroSistema.permissaoUsuario = linha.Item(3)
                    Me.Hide()
                    Exit Sub
                End If
            Next

            MsgBox("USUÁRIO OU SENHA incorretos", MsgBoxStyle.Information, "INFORMAÇÃO")



        Catch ex As Exception
            MsgBox("erro ao tentar fazer login", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub BtEntrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BtEntrar.KeyPress
        verificacao()

    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Me.Close()

    End Sub
End Class