Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmDespesas
    Dim conectar As New ConexaoSQL
    Dim ds, dsUltimo As New DataSet
    Dim despesa, despesa2 As New ClDespesa
    Dim frmDtaFinal As New FrmDataFinal
    Dim frmPagamento As New FrmPagamentoRecebimento
    Dim atualizar As Integer = 1
    Dim seq_despesa_old, dta_despesa_old, num_documento_old, val_despesa_old, cod_tipo_despesa_old, cod_pessoa_favorecido_old,
      des_observacao_old As String
    Public cod_recebimento_especie_old, val_recebimento_especie_old, des_recebimento_especie_old, dta_liquidacao_old, val_total_old,
        val_desconto_old, val_desconto_porcentagem_old, val_despesa_acessoria_old, val_multa_old, val_juros_old, val_juros_porcentagem_old,
        val_acrescimo_old As String
    Dim cod_empresa_old As Integer = ModParametroSistema.cod_empresa
    Public dta_final_old As String
    Dim i As Integer = 0
    Private Sub Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
        Dgv.DataSource = Nothing
        BtnPagamento.Enabled = False
    End Sub

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAuteracao()
        carregaOld()
        atualizaDados()
        carregaOld()
    End Sub
    Private Sub carregaOld()
        If TxbSeq.Text = "" Then
            seq_despesa_old = 0
        Else
            seq_despesa_old = TxbSeq.Text
        End If
        dta_despesa_old = TxbDta.Text
        num_documento_old = txbNumero.Text
        val_despesa_old = TxbValor.Text
        cod_tipo_despesa_old = TxbCodTipo.Text
        cod_pessoa_favorecido_old = TxbCodFavorecido.Text
        des_observacao_old = TxbObservacao.Text

    End Sub
    Public Sub atualizaDados()
        If seq_despesa_old = "" Then
            seq_despesa_old = 0
        End If
        If dta_final_old = "" Then
            dta_final_old = dta_despesa_old
        End If
        If cod_tipo_despesa_old = "" Then
            cod_tipo_despesa_old = "0"
        End If
        If cod_pessoa_favorecido_old = "" Then
            cod_pessoa_favorecido_old = "0"
        End If
        Try

            Dim tabela As DataTable
            ds = despesa.Consultar(seq_despesa_old, cod_empresa_old, dta_despesa_old, dta_final_old, num_documento_old, val_despesa_old,
                                   cod_tipo_despesa_old, cod_pessoa_favorecido_old, des_observacao_old)

            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                Dgv.DataSource = Nothing
                Dgv.DataSource = ds.Tables(0)
                formatarGrid()
                carregaFormulario()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDta.Text = "" Then
                MsgBox("Informe a data despesa")
                TxbDta.Select()
                Exit Sub
            End If
            If TxbValor.Text = "" Then
                MsgBox("Informe o valor")
                TxbValor.Select()
                Exit Sub
            End If
            If TxbCodTipo.Text = "" Then
                MsgBox("Informe tipo despesa")
                TxbCodTipo.Select()
                Exit Sub
            End If
            If TxbCodFavorecido.Text = "" Then
                MsgBox("Informe favorecido")
                TxbCodFavorecido.Select()
                Exit Sub
            End If
            If cod_recebimento_especie_old = "" Then
                despesa.cod_recebimento_especie = Nothing
            Else
                despesa.cod_recebimento_especie = cod_recebimento_especie_old
            End If

            If cod_recebimento_especie_old = "" Then
                despesa.val_recebimento_especie = "0"
            Else
                despesa.val_recebimento_especie = val_recebimento_especie_old
            End If
            despesa.dta_liquidacao = dta_liquidacao_old
            If val_total_old = "" Then
                despesa.val_total = "0"
            Else
                despesa.val_total = val_total_old
            End If
            If val_desconto_old = "" Then
                despesa.val_desconto = "0"
            Else
                despesa.val_desconto = val_desconto_old
            End If
            If val_desconto_porcentagem_old = "" Then
                despesa.val_desconto_porcentagem = "0"
            Else
                despesa.val_desconto_porcentagem = val_desconto_porcentagem_old
            End If
            If val_despesa_acessoria_old = "" Then
                despesa.val_despesa_acessoria = "0"
            Else
                despesa.val_despesa_acessoria = val_despesa_acessoria_old
            End If
            If val_multa_old = "" Then
                despesa.val_multa = "0"
            Else
                despesa.val_multa = val_multa_old
            End If
            If val_juros_old = "" Then
                despesa.val_juros = "0"
            Else
                despesa.val_juros = val_juros_old
            End If
            If val_juros_porcentagem_old = "" Then
                despesa.val_juros_porcentagem = "0"
            Else
                despesa.val_juros_porcentagem = val_juros_porcentagem_old
            End If
            If val_acrescimo_old = "" Then
                despesa.val_acrescimo = "0"
            Else
                despesa.val_acrescimo = val_acrescimo_old
            End If

            carregaOld()

            despesa.cod_empresa = cod_empresa_old
            despesa.dta_despesa = dta_despesa_old
            despesa.num_documento = num_documento_old
            despesa.val_despesa = val_despesa_old
            despesa.cod_tipo_despesa = cod_tipo_despesa_old
            despesa.cod_pessoa_favorecido = cod_pessoa_favorecido_old
            despesa.des_observacao = des_observacao_old

            If atualizar = 1 Then
                'pegar o ultimo registro
                Try
                    Dim ultimo As New DataSet
                    ultimo = despesa2.UltimoCadastrado
                    Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                    despesa.seq_despesa = Convert.ToInt16(ult) + 1

                    ultimo.Clear()
                Catch ex As Exception
                    despesa.seq_despesa = 1
                End Try
                despesa.Cadastrar()
                MsgBox(" cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
            Else
                despesa.seq_despesa = TxbSeq.Text
                despesa.Atualizar()
                If atualizar = 2 Then
                    MsgBox(" Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                Else
                    atualizar = 2
                End If
            End If
                atualizaDados()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbSeq.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a :   " & TxbSeq.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                despesa.seq_despesa = TxbSeq.Text
                despesa.Excluir()
                MsgBox(" Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        Dgv.DataSource = Nothing
        TxbSeq.Enabled = True
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub limpar()
        TxbSeq.Text = ""
        TxbDta.Text = ""
        txbNumero.Text = ""
        TxbValor.Text = "0,00"
        TxbCodTipo.Text = ""
        TxbDesTipo.Text = ""
        TxbCodFavorecido.Text = ""
        TxbNomFavorecido.Text = ""
        TxbObservacao.Text = ""
        carregaOld()
        val_recebimento_especie_old = ""
        cod_recebimento_especie_old = ""
        dta_liquidacao_old = ""
        val_total_old = ""
        val_desconto_old = ""
        val_desconto_porcentagem_old = ""
        val_despesa_acessoria_old = ""
        val_multa_old = ""
        val_juros_old = ""
        val_juros_porcentagem_old = ""
        val_acrescimo_old = ""
        atualizar = 1
        TxbSeq.Enabled = True
        BtnPagamento.Enabled = False
        TxbSeq.Select()
    End Sub
    Public Sub formatarGrid()
        Try
            With Dgv
                .Columns(0).HeaderText = "Seq."
                .Columns(2).HeaderText = "Data"
                .Columns(3).HeaderText = "Número"
                .Columns(4).HeaderText = "Valor"
                .Columns(5).HeaderText = "Tipo."
                .Columns(7).HeaderText = "Favorecido"
                .Columns(9).HeaderText = "Observação"
                .Columns(0).Width = 80
                .Columns(2).Width = 80
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 80
                .Columns(6).Width = 130
                .Columns(7).Width = 80
                .Columns(8).Width = 130
                .Columns(9).Width = 80
                .Columns(1).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDtaFinal.tela = "dtaDespesa"
        frmDtaFinal.DtpDtaFinal.Value = CDate(TxbDta.Text)
        frmDtaFinal.TxbDtaFinal.Text = ""
        frmDtaFinal.ShowDialog()
    End Sub
    Private Sub BtnBuscaFavorecido_Click(sender As Object, e As EventArgs) Handles BtnBuscaFavorecido.Click
        FrmPesquisa.tabela = "tab_pessoa_despesa"
        FrmPesquisa.ShowDialog()
    End Sub
    Private Sub BtnBuscaTipo_Click(sender As Object, e As EventArgs) Handles BtnBuscaTipo.Click
        FrmPesquisa.tabela = "tab_tipo_despesa"
        FrmPesquisa.ShowDialog()
    End Sub
    Private Sub BtnPagamento_Click(sender As Object, e As EventArgs) Handles BtnPagamento.Click
        frmPagamento.Text = "Pagamento"
        frmPagamento.TxbValOriginal.Text = TxbValor.Text
        frmPagamento.sequencia = TxbSeq.Text
        frmPagamento.TxbValLiquidado.Text = dta_liquidacao_old
        frmPagamento.TxbValTotal.Text = val_total_old
        frmPagamento.TxbValDesconto.Text = val_desconto_old
        frmPagamento.TxbValDescontoPorc.Text = val_desconto_porcentagem_old
        frmPagamento.TxbValDespAcess.Text = val_despesa_acessoria_old
        frmPagamento.TxbValMulta.Text = val_multa_old
        frmPagamento.TxbValJuroPrinc.Text = val_juros_old
        frmPagamento.TxbValJurosPrincPorc.Text = val_juros_porcentagem_old
        frmPagamento.TxbValAcrescimo.Text = val_acrescimo_old
        If val_recebimento_especie_old <> "" And CDbl(val_recebimento_especie_old) > 0 Then
            frmPagamento.TxbValEspecie.Text = val_recebimento_especie_old
            frmPagamento.TxbCodEspecie.Text = cod_recebimento_especie_old
            frmPagamento.txbDesEspecie.Text = des_recebimento_especie_old
        End If
        frmPagamento.tabela = "tab_despesa"
        frmPagamento.ShowDialog()
        atualizar = 3
        salvaRegistro()
    End Sub
    Public Sub carregaFormulario()
        Try
            limpar()
            If ds.Tables(0).Rows.Count > 0 Then
                atualizar = 2
                TxbSeq.Text = ds.Tables(0).Rows(i)("seq_despesa").ToString
                TxbDta.Text = ds.Tables(0).Rows(i)("dta_despesa").ToString
                txbNumero.Text = ds.Tables(0).Rows(i)("num_documento").ToString
                TxbValor.Text = FormatNumber(Convert.ToDouble(ds.Tables(0).Rows(i)("val_despesa").ToString), 2)
                TxbCodTipo.Text = ds.Tables(0).Rows(i)("cod_tipo_despesa").ToString
                TxbDesTipo.Text = ds.Tables(0).Rows(i)("des_tipo_despesa").ToString
                TxbCodFavorecido.Text = ds.Tables(0).Rows(i)("cod_pessoa_favorecido").ToString
                TxbNomFavorecido.Text = ds.Tables(0).Rows(i)("nom_pessoa_favorecido").ToString
                TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString
                cod_recebimento_especie_old = ds.Tables(0).Rows(i)("cod_recebimento_especie").ToString
                val_recebimento_especie_old = ds.Tables(0).Rows(i)("val_recebimento_especie").ToString
                des_recebimento_especie_old = ds.Tables(0).Rows(i)("des_recebimento_especie").ToString
                dta_liquidacao_old = ds.Tables(0).Rows(i)("dta_liquidacao").ToString
                val_total_old = ds.Tables(0).Rows(i)("val_total").ToString
                val_desconto_old = ds.Tables(0).Rows(i)("val_desconto").ToString
                val_desconto_porcentagem_old = ds.Tables(0).Rows(i)("val_desconto_porcentagem").ToString
                val_despesa_acessoria_old = ds.Tables(0).Rows(i)("val_despesa_acessoria").ToString
                val_multa_old = ds.Tables(0).Rows(i)("val_multa").ToString
                val_juros_old = ds.Tables(0).Rows(i)("val_juros").ToString
                val_juros_porcentagem_old = ds.Tables(0).Rows(i)("val_juros_porcentagem").ToString
                val_acrescimo_old = ds.Tables(0).Rows(i)("val_acrescimo").ToString
                carregaOld()
                TxbSeq.Enabled = False
                BtnPagamento.Enabled = True
            Else
                atualizar = 1

            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub verificarAuteracao()
        Dim msg As String = ""
        If TxbSeq.Text = "" Then
            Exit Sub
        End If
        If dta_despesa_old <> TxbDta.Text Then
            msg = "Deseja salvar alteração data" & vbCrLf & "Anterior: " & dta_despesa_old & vbCrLf & " Nova : " & TxbDta.Text
        End If
        If num_documento_old <> txbNumero.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração num Doc" & vbCrLf & "Anterior: " & num_documento_old & vbCrLf & " Nova : " & txbNumero.Text & "?"
        End If

        If val_despesa_old <> TxbValor.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Valor" & vbCrLf & "Anterior: " & val_despesa_old & vbCrLf & " Nova : " & TxbValor.Text
        End If
        If cod_tipo_despesa_old <> TxbCodTipo.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Tipo Despesa" & vbCrLf & "Anterior: " & cod_tipo_despesa_old & vbCrLf & " Nova : " & TxbCodTipo.Text
        End If
        If cod_pessoa_favorecido_old <> TxbCodFavorecido.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Favorecido" & vbCrLf & "Anterior: " & cod_pessoa_favorecido_old & vbCrLf & " Nova : " & TxbCodFavorecido.Text
        End If
        If des_observacao_old <> TxbObservacao.Text Then
            msg = msg & vbCrLf & "Deseja salvar alteração Observação" & vbCrLf & "Anterior: " & des_observacao_old & vbCrLf & " Nova : " & TxbObservacao.Text
        End If
        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If

    End Sub
    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0

        Else
            TabControl1.SelectedIndex = 1

        End If
    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracao()
        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub


    Private Sub Dgv_DoubleClick(sender As Object, e As EventArgs) Handles Dgv.DoubleClick
        Try
            TxbSeq.Text = Dgv.CurrentRow.Cells(0).Value
            TxbDta.Text = Dgv.CurrentRow.Cells(2).Value
            txbNumero.Text = Dgv.CurrentRow.Cells(3).Value
            TxbValor.Text = Dgv.CurrentRow.Cells(4).Value
            TxbCodTipo.Text = Dgv.CurrentRow.Cells(5).Value
            TxbDesTipo.Text = Dgv.CurrentRow.Cells(6).Value
            TxbCodFavorecido.Text = Dgv.CurrentRow.Cells(7).Value
            TxbNomFavorecido.Text = Dgv.CurrentRow.Cells(8).Value
            TxbObservacao.Text = Dgv.CurrentRow.Cells(9).Value
            cod_recebimento_especie_old = Dgv.CurrentRow.Cells(10).Value
            val_recebimento_especie_old = Dgv.CurrentRow.Cells(11).Value
            dta_liquidacao_old = Dgv.CurrentRow.Cells(12).Value
            val_total_old = Dgv.CurrentRow.Cells(13).Value
            val_desconto_old = Dgv.CurrentRow.Cells(14).Value
            val_desconto_porcentagem_old = Dgv.CurrentRow.Cells(15).Value
            val_despesa_acessoria_old = Dgv.CurrentRow.Cells(16).Value
            val_multa_old = Dgv.CurrentRow.Cells(17).Value
            val_juros_old = Dgv.CurrentRow.Cells(18).Value
            val_juros_porcentagem_old = Dgv.CurrentRow.Cells(19).Value
            val_acrescimo_old = Dgv.CurrentRow.Cells(20).Value
            TabControl1.SelectedIndex = 1
            Me.TxbSeq.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            If i = 0 Then
                i = ds.Tables(0).Rows.Count - 1
            Else
                i = i - 1
            End If
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub
    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
        Try
            If ds.Tables(0).Rows.Count < 1 Then
                Exit Sub
            End If

            'My.Computer.FileSystem.CreateDirectory("C:\\CashMonitor")
            Dim nomArquivo As String
            Dim dataAtual As String
            Dim nomPasta As String

            'localizar a pasta
            Dim pasta As New FolderBrowserDialog
            Dim dr As DialogResult = pasta.ShowDialog()
            If dr = System.Windows.Forms.DialogResult.OK Then
                nomPasta = pasta.SelectedPath
            End If

            Dim horaMin As String
            dataAtual = Format(Today, "ddmmyyyy")
            dataAtual = Replace(dataAtual, "00", "10")
            horaMin = Format(Now, "hhmm")

            nomArquivo = Me.Text & "_" & dataAtual & "_" & horaMin

            Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & nomArquivo & ".csv")
            Dim i As Integer, x As Integer

            Dim QtdColunas As Integer = Dgv.ColumnCount - 1

            For i = 0 To QtdColunas
                If Dgv.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                    CSV.Write(Dgv.Columns(i).HeaderText)

                    If (i < QtdColunas) Then

                        CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    End If
                End If
            Next i

            ' CSV.Write(CSV.NewLine)

            Dim QtdRows As Integer = Dgv.Rows.Count - 1

            For i = 0 To QtdRows

                For x = 0 To QtdColunas

                    If (Not Dgv.Rows(i).Cells(x).Value Is Nothing) Then
                        CSV.Write(Dgv.Rows(i).Cells(x).Value.ToString())

                    End If

                    If (x < QtdColunas) Then
                        CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    End If

                Next x
                CSV.Write(CSV.NewLine)
            Next i
            MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

            CSV.Close()
        Catch ex As Exception
            MsgBox("Erro ao Salvar o arquivo " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub
    Private Sub DtpDta_ValueChanged(sender As Object, e As EventArgs) Handles DtpDta.ValueChanged
        TxbDta.Text = DtpDta.Value.ToShortDateString
    End Sub
End Class
