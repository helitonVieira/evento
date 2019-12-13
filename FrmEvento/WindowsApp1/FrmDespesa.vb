Public Class FrmDespesa
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim despesa As New ClDespesa
    Dim atualizar As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtPresquisa.Click
        If TxbCodDespesa.Text = "" Then
            despesa.cod_despesa = 0
        Else
            despesa.cod_despesa = TxbCodDespesa.Text
        End If


        despesa.des_despesa = TxbNomDespesa.Text
        If TxbCodEvento.Text = "" Then
            despesa.cod_evento = 0
        Else
            despesa.cod_evento = TxbCodEvento.Text
        End If

        If TxbCodFavorecido.Text = "" Then
            despesa.cod_pessoa_favorecido = 0
        Else
            despesa.cod_pessoa_favorecido = TxbCodFavorecido.Text
        End If

        If txbCodTipoDespesa.Text = "" Then
            despesa.cod_tipo_despesa = 0
        Else
            despesa.cod_tipo_despesa = txbCodTipoDespesa.Text
        End If

        If TxbCodFuncionario.Text = "" Then
            despesa.cod_pessoa_funcionario = 0
        Else
            despesa.cod_pessoa_funcionario = TxbCodFuncionario.Text
        End If

        If TxbValDespesa.Text = "" Then
            despesa.val_despesa = 0
        Else
            despesa.val_despesa = TxbValDespesa.Text
        End If
        despesa.des_observacao = TxbObservacao.Text
        atualizaDadosPesquisa()
        limpar()
    End Sub
    Public Sub atualizaDadosPesquisa()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = despesa.ConsultardespesaPesquisa()
        tabela = ds.Tables(0)


        If tabela.Rows.Count > 0 Then
            DgvDespesa.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        'limpar()

    End Sub
    Public Sub atualizaDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = despesa.Consultardespesa()
        tabela = ds.Tables(0)


        If tabela.Rows.Count > 0 Then
            DgvDespesa.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        'limpar()

    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        Try
            'Dim ultimo As DataSet
            ' ultimo = despesa.ConsultarDespesaVenda
            '  Label7.Text = ultimo.Tables(0).Rows.Despesa(1).ToString
            If TxbNomDespesa.Text = "" Then
                MsgBox("INFORME DESCRIÇÃO DESPESA")
                TxbNomDespesa.Select()
                Exit Sub
            End If
            despesa.des_despesa = TxbNomDespesa.Text

            If TxbCodEvento.Text = "" Then
                MsgBox("INFORME O EVENTO")
                TxbCodEvento.Select()
                Exit Sub
            End If
            despesa.cod_evento = TxbCodEvento.Text

            If TxbCodFavorecido.Text = "" Then
                MsgBox("INFORME O FAVORECIDO")
                TxbCodFavorecido.Select()
                Exit Sub
            End If
            despesa.cod_pessoa_favorecido = TxbCodFavorecido.Text

            If txbCodTipoDespesa.Text = "" Then
                MsgBox("INFORME O TIPO DESPESA")
                txbCodTipoDespesa.Select()
                Exit Sub
            End If
            despesa.cod_tipo_despesa = txbCodTipoDespesa.Text

            If TxbCodFuncionario.Text = "" Then
                MsgBox("INFORME O FUNCIONARIO")
                TxbCodFuncionario.Select()
                Exit Sub
            End If
            despesa.cod_pessoa_funcionario = TxbCodFuncionario.Text
            despesa.dta_despesa = DtpDtaDespesa.Value.ToShortDateString

            despesa.des_observacao = TxbObservacao.Text

            If TxbValDespesa.Text = "" Then
                MsgBox("INFORME O VALOR DESPESA")
                TxbValDespesa.Select()
                Exit Sub
            End If
            despesa.val_despesa = TxbValDespesa.Text.Replace(",", ".")

            If atualizar = 1 Then
                despesa.Cadastrardespesa()
                MsgBox("Despesa cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                despesa.cod_despesa = TxbCodDespesa.Text
                despesa.Atualizardespesa()
                MsgBox("Despesa Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If


        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub BtExcluir_Click_1(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If MsgBox("Deseja excluir o despesa" & TxbNomDespesa.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                despesa.cod_despesa = TxbCodDespesa.Text
                despesa.Excluirdespesa()
                MsgBox("Despesa excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir Despesa, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        limpar()

    End Sub
    Public Sub limpar()
        TxbCodDespesa.Text = ""
        TxbNomDespesa.Text = ""
        TxbCodEvento.Text = ""
        txbnomEvento.Text = ""
        TxbCodFavorecido.Text = ""
        TxbNomFavorecido.Text = ""
        txbCodTipoDespesa.Text = ""
        txbDesTipoDespesa.Text = ""
        TxbCodFuncionario.Text = ""
        TxbNomFuncionario.Text = ""
        TxbValDespesa.Text = ""
        TxbObservacao.Text = ""
        atualizar = 1
        TxbCodDespesa.Enabled = True

    End Sub
    Public Sub formatarGrid()
        With DgvDespesa
            .Columns(0).HeaderText = "Cód"
            .Columns(1).HeaderText = "Despesa"
            .Columns(2).HeaderText = "Cód.Evento"
            .Columns(3).HeaderText = "Evento"
            .Columns(4).HeaderText = "Cód.Favorecido"
            .Columns(5).HeaderText = "Nom.Favorecido"
            .Columns(6).HeaderText = "Cód.Tipo"
            .Columns(7).HeaderText = "Des.Tipo"
            .Columns(8).HeaderText = "Cód.Funcionário"
            .Columns(9).HeaderText = "Nom.Funcionário"
            .Columns(10).HeaderText = "Data"
            .Columns(11).HeaderText = "Observação"
            .Columns(12).HeaderText = "Valor"
            .Columns(0).Width = 60
            .Columns(1).Width = 100
            .Columns(2).Width = 60
            .Columns(3).Width = 100
            .Columns(4).Width = 60
            .Columns(5).Width = 100
            .Columns(6).Width = 60
            .Columns(7).Width = 100
            .Columns(8).Width = 60
            .Columns(9).Width = 100
            .Columns(10).Width = 60
            .Columns(11).Width = 100
            .Columns(12).Width = 60


        End With
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            TxbCodDespesa.Text = DgvDespesa.CurrentRow.Cells(0).Value
            TxbNomDespesa.Text = DgvDespesa.CurrentRow.Cells(1).Value
            TxbCodEvento.Text = DgvDespesa.CurrentRow.Cells(2).Value
            txbnomEvento.Text = DgvDespesa.CurrentRow.Cells(3).Value
            TxbCodFavorecido.Text = DgvDespesa.CurrentRow.Cells(4).Value
            TxbNomFavorecido.Text = DgvDespesa.CurrentRow.Cells(5).Value
            txbCodTipoDespesa.Text = DgvDespesa.CurrentRow.Cells(6).Value
            txbDesTipoDespesa.Text = DgvDespesa.CurrentRow.Cells(7).Value
            TxbCodFuncionario.Text = DgvDespesa.CurrentRow.Cells(8).Value
            TxbNomFuncionario.Text = DgvDespesa.CurrentRow.Cells(9).Value
            DtpDtaDespesa.Text = DgvDespesa.CurrentRow.Cells(10).Value
            TxbObservacao.Text = DgvDespesa.CurrentRow.Cells(11).Value
            TxbValDespesa.Text = DgvDespesa.CurrentRow.Cells(12).Value
            TxbCodDespesa.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvDespesa_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDespesa.CellEnter
        carregaFormulario()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtEvento.Click

        FrmPesquisa.tabela = "tab_evento_despesa"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub btTipoDespesa_Click(sender As Object, e As EventArgs) Handles btTipoDespesa.Click
        FrmPesquisa.tabela = "tab_tipo_despesa"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub BtFavorecido_Click(sender As Object, e As EventArgs) Handles BtFavorecido.Click
        FrmPesquisa.tabela = "tab_pessoa_despesa"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub BtCadPessoa_Click(sender As Object, e As EventArgs) Handles BtCadPessoa.Click
        FrmPessoa.ShowDialog()

    End Sub

    Private Sub BtFuncionario_Click(sender As Object, e As EventArgs) Handles BtFuncionario.Click
        FrmPesquisa.tabela = "funcionarioDespesa"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub TxbCodDespesa_TextChanged(sender As Object, e As EventArgs) Handles TxbCodDespesa.TextChanged
        If Not IsNumeric(TxbCodDespesa.Text) Then
            TxbCodDespesa.Text = ""
        End If
    End Sub

    Private Sub TxbCodEvento_TextChanged(sender As Object, e As EventArgs) Handles TxbCodEvento.TextChanged
        If Not IsNumeric(TxbCodEvento.Text) Then
            TxbCodEvento.Text = ""
        End If
    End Sub

    Private Sub txbCodTipoDespesa_TextChanged(sender As Object, e As EventArgs) Handles txbCodTipoDespesa.TextChanged
        If Not IsNumeric(txbCodTipoDespesa.Text) Then
            txbCodTipoDespesa.Text = ""
        End If
    End Sub

    Private Sub TxbCodFavorecido_TextChanged(sender As Object, e As EventArgs) Handles TxbCodFavorecido.TextChanged
        If Not IsNumeric(TxbCodFavorecido.Text) Then
            TxbCodFavorecido.Text = ""
        End If
    End Sub

    Private Sub TxbCodFuncionario_TextChanged(sender As Object, e As EventArgs) Handles TxbCodFuncionario.TextChanged
        If Not IsNumeric(TxbCodFuncionario.Text) Then
            TxbCodFuncionario.Text = ""
        End If
    End Sub

    Private Sub TxbValDespesa_TextChanged(sender As Object, e As EventArgs) Handles TxbValDespesa.TextChanged
        If Not IsNumeric(TxbValDespesa.Text) Then
            TxbValDespesa.Text = ""
        End If
    End Sub

    Private Sub txbnomEvento_TextChanged(sender As Object, e As EventArgs) Handles txbnomEvento.TextChanged

    End Sub
End Class
