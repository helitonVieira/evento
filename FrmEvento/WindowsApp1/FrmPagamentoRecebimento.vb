Public Class FrmPagamentoRecebimento
    Dim conectar As New Controles.ConexaoSQL
    Dim ds, dsUltimo, dsBanco As New DataSet

    Dim atualizarBanco As Integer = 1
    Dim atualizarParcela As Integer = 1
    Public tabela As String
    Public sequencia As Integer
    Dim banco, banco2 As New ClPagamentoBanco
    Dim i As Integer = 0
    Private Sub calculaValorLiquidado(valor As Double)
        Dim val_liquidado As Double = 0
        If TxbValEspecie.Text = "" Then
            TxbValEspecie.Text = "0,00"
        End If
        val_liquidado = CDbl(TxbValEspecie.Text) + valor
        TxbValLiquidado.Text = CStr(val_liquidado)
        calculaValorPendente()
    End Sub
    Private Sub calculaValorPendente()
        TxbValPendente.Text = CStr(CDbl(TxbValTotal.Text) - CDbl(TxbValLiquidado.Text))
    End Sub
    Private Sub calculaValorTotal()
        Try
            Dim total As Double = 0
            total = CDbl(TxbValOriginal.Text)
            If TxbValDesconto.Text <> "" Then
                total = total - CDbl(TxbValDesconto.Text)
            End If
            If TxbValDescontoPorc.Text <> "" Then
                total = total - (CDbl(TxbValOriginal.Text) * CDbl(TxbValDescontoPorc.Text) / 100)
            End If
            If TxbValDespAcess.Text <> "" Then
                total = total + CDbl(TxbValDespAcess.Text)
            End If
            If TxbValAcrescimo.Text <> "" Then
                total = total + CDbl(TxbValAcrescimo.Text)
            End If
            If TxbValMulta.Text <> "" Then
                total = total + CDbl(TxbValMulta.Text)
            End If
            If TxbValJuroPrinc.Text <> "" Then
                total = total + CDbl(TxbValJuroPrinc.Text)
            End If
            If TxbValDescontoPorc.Text <> "" Then
                total = total + (CDbl(TxbValOriginal.Text) * CDbl(TxbValJurosPrincPorc.Text) / 100)
            End If
            TxbValTotal.Text = CStr(total)
            calculaValorPendente()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TxbValDesconto_LostFocus(sender As Object, e As EventArgs) Handles TxbValDesconto.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValDescontoPorc_LostFocus(sender As Object, e As EventArgs) Handles TxbValDescontoPorc.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValDespAcess_LostFocus(sender As Object, e As EventArgs) Handles TxbValDespAcess.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValMulta_LostFocus(sender As Object, e As EventArgs) Handles TxbValMulta.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValJurosPrinc_LostFocus(sender As Object, e As EventArgs) Handles TxbValJuroPrinc.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValJurosPrincPorc_LostFocus(sender As Object, e As EventArgs) Handles TxbValJurosPrincPorc.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub TxbValAcrescimo_LostFocus(sender As Object, e As EventArgs) Handles TxbValAcrescimo.LostFocus
        calculaValorTotal()
    End Sub
    Private Sub FrmPagamentoRecebimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculaValorTotal()
        calculaValorLiquidado(0)
        atualizaDadosBanco()
        limparBanco()
        TxbCodEspecie.Select()
    End Sub
    Private Sub FrmPagamentoRecebimento_Closed(sender As Object, e As EventArgs) Handles MyBase.Closing
        If TxbValEspecie.Text <> "" And TxbCodEspecie.Text = "" Then
            TxbCodEspecie.Select()
            Exit Sub
        End If
        FrmDespesas.val_recebimento_especie_old = TxbValEspecie.Text
        FrmDespesas.cod_recebimento_especie_old = TxbCodEspecie.Text
        FrmDespesas.dta_liquidacao_old = TxbDtaLiquidacao.Text
        FrmDespesas.val_total_old = TxbValTotal.Text
        FrmDespesas.val_desconto_old = TxbValDesconto.Text
        FrmDespesas.val_desconto_porcentagem_old = TxbValDescontoPorc.Text
        FrmDespesas.val_despesa_acessoria_old = TxbValDespAcess.Text
        FrmDespesas.val_multa_old = TxbValMulta.Text
        FrmDespesas.val_juros_old = TxbValJuroPrinc.Text
        FrmDespesas.val_juros_porcentagem_old = TxbValJurosPrincPorc.Text
        FrmDespesas.val_acrescimo_old = TxbValAcrescimo.Text
    End Sub

    Private Sub BtnBuscaEspecie_Click(sender As Object, e As EventArgs) Handles BtnBuscaEspecie.Click
        FrmPesquisa.tabela = "tab_especie_pagamento"
        FrmPesquisa.ShowDialog()
        TxbCodEspecie.Text = ModVariavelGlobal.pesquisaCodigo
        txbDesEspecie.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub BtnValEspecie_Click(sender As Object, e As EventArgs) Handles BtnValEspecie.Click
        If TxbValEspecie.Text = "" Then
            TxbValEspecie.Text = "0,00"
        End If
        TxbValEspecie.Text = CStr(CDbl(TxbValEspecie.Text) + CDbl(TxbValPendente.Text))
        calculaValorLiquidado(TxbValPendente.Text)
    End Sub
    Private Sub TxbValEspecie_lostFocus(sender As Object, e As EventArgs) Handles TxbValEspecie.LostFocus
        If TxbValPendente.Text < 0 Then
            MsgBox("Valor maior soma total")
            TxbValEspecie.Text = ""
            TxbValEspecie.Select()
            Exit Sub
        End If
        If TxbValEspecie.Text <> "" And IsNumeric(TxbValEspecie.Text) = True Then
            calculaValorLiquidado(0)
        End If
        If txbDesEspecie.Text = "" Then

            MsgBox("Informe especíe do pagamento")
            txbDesEspecie.Select()
            Exit Sub
        End If

    End Sub
    '#####################################################
    'Banco
    '####################################################

    Private Sub DgvBanco_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DgvBanco.CellClick
        Try
            lbSeqPagamento.Text = DgvBanco.CurrentRow.Cells(0).Value
            TxbCodBanco.Text = DgvBanco.CurrentRow.Cells(2).Value
            Me.TxbNomBanco.Text = DgvBanco.CurrentRow.Cells(3).Value
            Me.txbAgencia.Text = DgvBanco.CurrentRow.Cells(4).Value
            Me.TxbConta.Text = DgvBanco.CurrentRow.Cells(5).Value
            Me.TxbDtaPredatado.Text = DgvBanco.CurrentRow.Cells(6).Value
            Me.TxbValBanco.Text = DgvBanco.CurrentRow.Cells(7).Value

            Me.TxbCodBanco.Select()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub atualizaDadosBanco()
        If IsNumeric(sequencia) = False Then
            Exit Sub
        End If
        Try
            Dim tabela As DataTable
            dsBanco = banco.Consultar(sequencia, "tab_despesa")
            tabela = dsBanco.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvBanco.DataSource = Nothing
                DgvBanco.DataSource = dsBanco.Tables(0)
                formatarGridBanco()
                carregaFormularioBanco()
                If dsBanco.Tables(0).Rows.Count > 0 Then
                    calculaValorLiquidado(dsBanco.Tables(0).Rows(1)("val_total"))
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnSalvaBanco_Click(sender As Object, e As EventArgs) Handles BtnSalvaBanco.Click
        If TxbValBanco.Text > TxbValPendente.Text Then
            MsgBox("Valor não pode ser maior que valor pendênte")
            TxbValBanco.Select()
            Exit Sub
        End If
        If TxbValBanco.Text = "" Or CDbl(TxbValBanco.Text) = 0 Then
            Exit Sub
        End If
        If TxbCodBanco.Text = "" Then
            MsgBox("Informe Banco!")
            Exit Sub
            TxbCodBanco.Select()
        End If
        If txbAgencia.Text = "" Then
            MsgBox("Informe Agência!")
            Exit Sub
            txbAgencia.Select()
        End If
        If TxbConta.Text = "" Then
            MsgBox("Informe Conta!")
            Exit Sub
            TxbConta.Select()
        End If
        salvaRegistroBanco()
        calculaValorLiquidado(TxbValBanco.Text)
        limparBanco()
    End Sub
    Public Sub salvaRegistroBanco()
        Try
            If TxbCodBanco.Text = "" Then
                MsgBox("INFORME BANCO")
                TxbCodBanco.Select()
                Exit Sub
            End If
            If TxbConta.Text = "" Then
                MsgBox("INFORME NUMERO CONTA")
                TxbConta.Select()
                Exit Sub
            End If
            If txbAgencia.Text = "" Then
                MsgBox("INFORME NUMERO AGENCIA")
                txbAgencia.Select()
                Exit Sub
            End If
            If TxbValBanco.Text = "" Then
                MsgBox("INFORME VALOR")
                TxbConta.Select()
                Exit Sub
            End If
            If tabela = "tab_despesa" Then
                banco.seq_despesa = sequencia
                banco.seq_titulo = 0
            ElseIf tabela = "tab_titulo" Then
                banco.seq_despesa = 0
                banco.seq_titulo = sequencia
            End If
            banco.cod_banco = TxbCodBanco.Text
            banco.num_conta = TxbConta.Text
            banco.num_agencia = txbAgencia.Text
            banco.dta_pre_datado = TxbDtaPredatado.Text
            banco.val_pagamento = TxbValBanco.Text


            If atualizarBanco = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                Try
                    ultimo = banco2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    banco.seq_pagamento = Convert.ToInt16(ult) + 1

                    banco.Cadastrar()
                    ultimo.Clear()
                Catch ex As Exception
                    banco.seq_pagamento = 1
                End Try
                MsgBox(" Cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                banco.seq_pagamento = lbSeqPagamento.Text
                banco.Atualizar()
                MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
        atualizaDadosBanco()
    End Sub
    Private Sub BtnExcluirBanco_Click(sender As Object, e As EventArgs) Handles BtnExcluiBanco.Click
        If lbSeqPagamento.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbNomBanco.Text & " Valor:" & TxbValBanco.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                banco.seq_pagamento = lbSeqPagamento.Text
                banco.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDadosBanco()
                limparBanco()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub
    Private Sub BtnBanco_Click(sender As Object, e As EventArgs) Handles BtnMenmonico.Click
        FrmPesquisa.tabela = "tab_banco_pagamento"
        FrmPesquisa.ShowDialog()
        TxbCodBanco.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomBanco.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub DtpDtaPredatado_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaPredatado.ValueChanged
        TxbDtaPredatado.Text = DtpDtaPredatado.Value.ToShortDateString
    End Sub

    Private Sub BtnValBanco_Click(sender As Object, e As EventArgs) Handles BtnValBanco.Click
        TxbValBanco.Text = TxbValPendente.Text
    End Sub

    Private Sub BtnLimpaBanco_Click(sender As Object, e As EventArgs) Handles BtnLimpaBanco.Click
        limparBanco()
    End Sub
    Private Sub limparBanco()
        txbAgencia.Text = ""
        TxbCodBanco.Text = ""
        TxbNomBanco.Text = ""
        TxbConta.Text = ""
        TxbValBanco.Text = ""
        TxbDtaPredatado.Text = ""
        atualizarBanco = 1
    End Sub

    Public Sub formatarGridBanco()
        Try
            With DgvBanco
                .Columns(0).HeaderText = "Seq."
                .Columns(1).HeaderText = "Despesa."
                .Columns(2).HeaderText = "Banco"
                .Columns(3).HeaderText = "Banco"
                .Columns(4).HeaderText = "Agencia"
                .Columns(5).HeaderText = "Conta."
                .Columns(6).HeaderText = "Pré-Datado"
                .Columns(7).HeaderText = "Valor"
                .Columns(8).HeaderText = "Total"
                .Columns(3).Width = 140
                .Columns(4).Width = 61
                .Columns(5).Width = 61
                .Columns(6).Width = 61
                .Columns(7).Width = 80
                .Columns(7).Width = 61
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub carregaFormularioBanco()
        Try
            limparBanco()
            If dsBanco.Tables(0).Rows.Count > 0 Then
                atualizarBanco = 2
                lbSeqPagamento.Text = dsBanco.Tables(0).Rows(i)("seq_pagamento").ToString
                TxbCodBanco.Text = dsBanco.Tables(0).Rows(i)("cod_banco").ToString
                TxbNomBanco.Text = dsBanco.Tables(0).Rows(i)("nom_banco").ToString
                TxbConta.Text = dsBanco.Tables(0).Rows(i)("num_conta").ToString
                txbAgencia.Text = dsBanco.Tables(0).Rows(i)("num_agencia").ToString
                TxbDtaPredatado.Text = dsBanco.Tables(0).Rows(i)("dta_pre_datado").ToString
                TxbValBanco.Text = dsBanco.Tables(0).Rows(i)("val_pagamento").ToString

            Else
                atualizarBanco = 1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DtpDtaLiquidacao_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaLiquidacao.ValueChanged
        TxbDtaLiquidacao.Text = DtpDtaLiquidacao.Value.ToShortDateString
    End Sub

    '******************************************
    'Parcelamento
    '*****************************************
    Private Sub BtnTipoParcelamento_Click(sender As Object, e As EventArgs) Handles BtnTipoParcelamento.Click
        FrmPesquisa.tabela = "tab_tipo_parcelamento_pagamento"
        FrmPesquisa.ShowDialog()
        TxbCodBanco.Text = ModVariavelGlobal.pesquisaCodigo
        TxbNomBanco.Text = ModVariavelGlobal.pesquisaNome
        ModVariavelGlobal.pesquisaCodigo = ""
        ModVariavelGlobal.pesquisaNome = ""
    End Sub

    Private Sub DtpDtaVenctoParc_ValueChanged(sender As Object, e As EventArgs) Handles DtpDtaVenctoParc.ValueChanged
        TxbDtaVencimentoParc.Text = DtpDtaVenctoParc.Value.ToShortDateString
    End Sub

    Private Sub BtnValParc_Click(sender As Object, e As EventArgs) Handles BtnValParc.Click
        TxbValParcela.Text = TxbValPendente.Text

    End Sub

End Class
