Imports PetSystem.FrmControleParasita
Public Class FrmPrincipal
    Dim conectar As New ConexaoSQ
    Dim dsParamSist, dsVenda, dsItem, dsPessoa, dsFormaPgto As New DataSet
    Dim item As New ClItem
    Dim clVenda As New ClVenda
    Dim evento As New ClEvento
    Dim pessoa As New ClPessoa
    Dim formaPagto As New ClFormaPagtoPdv
    Dim despesa As New ClDespesa
    Dim paramSistem As New ClParametroSistema
    Dim clLicencia As New ClLicencia
    Dim emp As New ClEmpresa
    Dim valTotalItem, valCustoTotal As String
    Public nomEmpresa, nomEvento As String
    Public codEvento As Integer
    Dim linha As Integer = 0
    Dim totalGeral As Double = 0
    Dim troco As Double = 0
    Dim saldoRestante As Double = 0
    Dim cod_item As Integer
    Dim des_item As String
    Dim frmContoleParasita As New PetSystem.FrmControleParasita
    Dim frmVacina As New PetSystem.FrmVacina
    Dim frmPelagem As New PetSystem.FrmPelagem
    Dim frmRaca As New PetSystem.FrmRaca
    Dim frmEspecie As New PetSystem.FrmEspecie
    Dim frmAnimal As New PetSystem.FrmAnimal

    Public Sub carregarGropVenda()

        Dim ds1 As New DataSet
        ds1 = emp.ConsultarEmpresa
        Dim linha As DataRow
        linha = ds1.Tables(0).Rows(0)
        nomEmpresa = linha.Item(1).ToString
        buscaItem(txbBuscaDesItem.Text)
        formatarGridItem()
        buscaPessoa(TxbBuscaNomPessoa.Text)
        LbCodCliente.Text = DgvPessoa.Rows(0).Cells(0).Value.ToString
        LbNomCliente.Text = DgvPessoa.Rows(0).Cells(1).Value.ToString
        buscaFormaPagto()

        TxbCodItem.Select()
        TxbQtde.Enabled = False
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub formatarGridItem()
        With DgvItem
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Descrição"
            .Columns(2).HeaderText = "Preço Venda"
            .Columns(0).Width = 75
            .Columns(1).Width = 505
            .Columns(2).Width = 75
            DgvItem.Columns.Item(3).Visible = False
            DgvItem.Columns.Item(4).Visible = False
            DgvItem.Columns.Item(5).Visible = False
        End With
        formatarGridVenda()
    End Sub

    Private Sub TxtQtde_LostFocus(sender As Object, e As EventArgs) Handles TxbQtde.LostFocus
        If TxbQtde.Text = "" Then
            TxbQtde.Select()
            Exit Sub
        End If

        If LbDescricaoItem.Text = "" Then
            TxbCodItem.Select()
            Exit Sub
        End If
        If TxbCodItem.Text = "" Or LbDescricaoItem.Text = "" Then
            MsgBox("ITEM INVALIDO")
            TxbCodItem.Select()
            Exit Sub
        End If
        If TxbQtde.Text > 10 Then
            If MsgBox("Mais de 10 itens confirma?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.No Then
                TxbQtde.Text = ""
                TxbQtde.Select()
                Exit Sub
            End If
        End If

        carregaGridVenda()
        limpar()
        TxbCodItem.Select()
    End Sub

    Private Sub FrmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TECLA ENTER
        InsereEnter(Me)
    End Sub

    Public Sub salvarBancoImprimirFicha()

        Try
            For Each linha As DataGridViewRow In DgvVenda.Rows
                If Not linha.IsNewRow Then

                    clVenda.cod_evento = LbCodEvento.Text
                    clVenda.cod_item = linha.Cells(0).Value.ToString
                    des_item = linha.Cells(1).Value.ToString
                    clVenda.qtd_item = linha.Cells(2).Value.ToString.Replace(",", ".")
                    valTotalItem = linha.Cells(4).Value.ToString.Replace(",", ".")
                    valCustoTotal = linha.Cells(5).Value.ToString * clVenda.qtd_item
                    clVenda.val_total_item = valTotalItem
                    clVenda.val_total_custo_item = valCustoTotal.Replace(",", ".")
                    clVenda.ind_tipo = "P"
                    clVenda.InserirVenda()

                    For index As Integer = 1 To linha.Cells(2).Value
                        '    imprimirFicha()
                    Next
                End If
            Next
            DgvVenda.Rows.Clear()
            DgvVenda.Refresh()
            valTotalItem = 0
            valCustoTotal = 0
            totalGeral = 0
            limparGeral()
            TxbCodItem.Select()
        Catch ex As Exception
            MsgBox("ITEM NAO ESTA CADASTRADO NO BANCO" & ex.Message, MsgBoxStyle.Critical, "Erro")
            TxbCodItem.Select()
        End Try
        TxbCodItem.Select()
    End Sub

    Public Sub limpar()
        TxbQtde.Text = ""
        LbDescricaoItem.Text = ""
        TxbQtde.Enabled = False
        TxbCodItem.Text = ""
        TxbValorUnitario.Text = ""
        TxbValorTotal.Text = ""

        TxbCodItem.Select()
    End Sub

    Public Sub limparGeral()
        TxbQtde.Text = ""
        LbDescricaoItem.Text = ""
        TxbQtde.Enabled = False
        TxbCodItem.Text = ""
        TxbValorUnitario.Text = ""
        TxbValorTotal.Text = ""
        TxbTotalGeral.Text = ""
        TxbCodItem.Select()
    End Sub

    Private Sub BarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarToolStripMenuItem.Click
        Exit Sub
        licenciaVerifica()

        Try
            If Today > clLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & clLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If

            FrmEscolherEvento.ShowDialog()
            If LbCodEvento.Text = "" Then
                Exit Sub
            End If
            CarregaTelaVenda()
            carregarGropVenda()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CarregaTelaVenda()
        GbCabecalho.Visible = True
        GbBotaoAtalho.Visible = True
        TabControl1.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        TxbCodItem.Visible = True
        TxbQtde.Visible = True
        TxbValorUnitario.Visible = True
        TxbValorTotal.Visible = True
        TxbTotalGeral.Visible = True
        btnRemoverLinha.Visible = True
        BtnImprimirFicha.Visible = True
        DgvVenda.Visible = True
        LbNomEvento.Visible = True
        LbCodEvento.Visible = True
    End Sub
    Public Sub DescarregarTelaVenda()

        GbCabecalho.Visible = False
        GbBotaoAtalho.Visible = False
        TabControl1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        TxbCodItem.Visible = False
        TxbQtde.Visible = False
        TxbValorUnitario.Visible = False
        TxbValorTotal.Visible = False
        TxbTotalGeral.Visible = False
        btnRemoverLinha.Visible = False
        BtnImprimirFicha.Visible = False
        DgvVenda.Visible = False
        LbNomEvento.Visible = False
        LbCodEvento.Visible = False

    End Sub
    Private Sub EventoToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ItemToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DescarregarTelaVenda()
        limpar()
        licenciaVerifica()
    End Sub
    Public Sub formatarGridVenda()
        With DgvVenda
            .Columns.Add("codigo", "Cód.")
            .Columns.Add("descrição", "Descrição")
            .Columns.Add("quantidade", "Qtde")
            .Columns.Add("vlrUnitario", "Vl.Unit")
            .Columns.Add("Total", "Total")
            .Columns.Add("Custo", "Custo")

            .Columns(0).Width = 30
            .Columns(1).Width = 130
            .Columns(2).Width = 50
            .Columns(3).Width = 60
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(5).Visible = False
            .AllowUserToAddRows = False
        End With
    End Sub
    Public Sub licenciaVerifica()
        clLicencia.verificarLicencia()

    End Sub


    Private Sub TxtQtde_Focus(sender As Object, e As EventArgs) Handles TxbQtde.GotFocus
        If TxbCodItem.Text = "" Then
            TxbQtde.Enabled = False
            TxbCodItem.Select()
        End If
    End Sub
    Public Sub carregaGridVenda()

        Try
            DgvVenda.Rows.Add(TxbCodItem.Text, LbDescricaoItem.Text, FormatNumber(TxbQtde.Text, 2), TxbValorUnitario.Text, TxbValorTotal.Text, Convert.ToString(valCustoTotal))
            totalGeral = TxbValorTotal.Text + totalGeral
            TxbTotalGeral.Text = Convert.ToString(FormatNumber(totalGeral, 2))
            TxbCodItem.Select()
            linha = linha + 1
        Catch ex As Exception
            MsgBox("Erro carregar grid")
        End Try


    End Sub
    Private Sub TxtCodItem_Enter(sender As Object, e As EventArgs) Handles TxbCodItem.Enter
        TxbQtde.Enabled = False
    End Sub
    Private Sub TxtCodItem_LostFocus(sender As Object, e As EventArgs) Handles TxbCodItem.LostFocus
        If TxbCodItem.Text = "" Or LbDescricaoItem.Text = "" Then
            TxbCodItem.Text = ""
            TxbCodItem.Select()
            Exit Sub
        End If
        If TxbQtde.Enabled = False Then
            TxbQtde.Text = "1"
        End If
        TxbQtde.Enabled = True
        If TxbCodItem.Text = "" Then
            LbDescricaoItem.Text = ""
        End If
        TxbQtde.Select()
    End Sub

    Private Sub TxtCodItem_TextChanged(sender As Object, e As EventArgs) Handles TxbCodItem.TextChanged
        Try
            If Not IsNumeric(TxbCodItem.Text) Then
                TxbCodItem.Text = ""
            End If

            For Each row In DgvItem.Rows
                If TxbCodItem.Text = row.Cells(0).Value.ToString Then
                    LbDescricaoItem.Text = row.Cells(1).Value.ToString
                    valTotalItem = row.Cells(2).Value.ToString
                    valCustoTotal = row.Cells(3).Value.ToString
                    TxbValorUnitario.Text = FormatNumber(row.Cells(2).Value, 2).ToString
                    Exit For
                End If
            Next
            '   Dim caminho As String = "C:\evento\itemPdv\" & TxbCodItem.Text
            ' PictureBox1.Image = Image.FromFile('"& caminho &"' )

        Catch ex As Exception
        End Try
    End Sub
    Public Sub imprimirFicha()
        Try
            PrintDocument1.Print()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ResumoVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumoVendasToolStripMenuItem.Click
        If LbCodEvento.Text = "" Then
            MsgBox("Um evento tem que estar logado")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocRelResumoVenda.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDocRelResumoVenda_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocRelResumoVenda.PrintPage
        imprimiRelResumoVenda(e, LbCodEvento.Text, LbNomEvento.Text, "P")
    End Sub
    Public Sub imprimiRelResumoVenda(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String, tipo As String)

        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
        clVenda.cod_evento = codEvento
        Dim tabela As DataTable
        If tipo = "P" Then
            dsVenda = clVenda.ResumoVendas()
        Else
            dsVenda = clVenda.ResumoVendasIngresso()
        End If

        tabela = dsVenda.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RESUMO EVENTO ", reportFont2, Brushes.Black, 90, x)
            x = x + 20
            e.Graphics.DrawString(codEvento & " " & nomEvento, reportFont2, Brushes.Black, 0, x)
            x = 60
            For Each Row In dsVenda.Tables(0).Rows

                If x = 60 Then
                    e.Graphics.DrawString("ITEM", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("QTDE", reportFont2, Brushes.Black, 190, x)
                    e.Graphics.DrawString("VALOR", reportFont2, Brushes.Black, 240, x)
                    x = x + 15
                End If
                x = x + 20
                e.Graphics.DrawString(Row.Item(1), reportFont2, Brushes.Black, 0, x)
                e.Graphics.DrawString(Row.Item(2), reportFont2, Brushes.Black, 190, x)
                e.Graphics.DrawString(Row.Item(3), reportFont2, Brushes.Black, 240, x)

            Next
            x = x + 40
            e.Graphics.DrawString("TOTAL:", reportFont2, Brushes.Black, 0, x)
            e.Graphics.DrawString(Row.Item(4), reportFont2, Brushes.Black, 190, x)
            e.Graphics.DrawString(Row.Item(5), reportFont2, Brushes.Black, 240, x)
        End If
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim tabela As DataRow
            dsParamSist = paramSistem.consultarParametro()
            tabela = dsParamSist.Tables(0).Rows(0)
            Dim DiminuiFontProduto As Integer = tabela.Item(0)

            Dim reportFont6 As Font = New Drawing.Font("Time New Roman", 6)
            Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 8)
            Dim reportFont12 As Font = New Drawing.Font("Time New Roman", 12)
            Dim reportFont14 As Font = New Drawing.Font("Time New Roman", 14)
            Dim reportFont16 As Font = New Drawing.Font("Time New Roman", 16)
            Dim reportFont18 As Font = New Drawing.Font("Time New Roman", 18)
            Dim reportFont20 As Font = New Drawing.Font("Time New Roman", 20 - (DiminuiFontProduto))
            Dim rept As Font
            If des_item.Count <= 17 Then
                rept = reportFont20
            ElseIf des_item.Count <= 20 Then
                rept = reportFont18
            ElseIf des_item.Count <= 21 Then
                rept = reportFont16
            ElseIf des_item.Count < 27 Then
                rept = reportFont14
            ElseIf des_item.Count > 28 Then
                rept = reportFont12
            End If
            Dim newImageEmpresa As Image
            Try
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.png")

            Catch ex As Exception
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.jpg")

            End Try
            ' Create coordinates for upper-left corner
            ' of image and for size of image.
            Dim x1 As Integer = 0
            Dim y1 As Integer = 0
            Dim width1 As Integer = 50
            Dim height1 As Integer = 50

            ' Draw image to screen.
            e.Graphics.DrawImage(newImageEmpresa, x1, y1, width1, height1)
            e.Graphics.DrawString(nomEmpresa, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(nomEmpresa.Count), 0)

            e.Graphics.DrawString(des_item, rept, Brushes.Black, paramSistem.posicaoTamanho20(des_item.Count), 45)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 80)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 90)

            e.Graphics.DrawString("Válido apenas para dia:" & Today, reportFont8, Brushes.Black, 50, 100)
            ' e.Graphics.DrawString(" ", reportFont1, Brushes.Black, 100, 160)
        Catch ex As Exception

        End Try
    End Sub
    Public Function posicaoTamanho20(ByVal x As Integer) As Integer
        If x <= 3 Then
            Return 100
        ElseIf x <= 6 Then
            Return 85
        ElseIf x <= 9 Then
            Return 65
        ElseIf x <= 12 Then
            Return 40
        ElseIf x <= 15 Then
            Return 10
        Else
            Return 0
        End If
    End Function

    Private Sub LicenciaToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem.Click


    End Sub
    Private Sub PessoaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoaToolStripMenuItem.Click
        FrmPessoa.ShowDialog()
    End Sub

    Private Sub InventarioRapidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioRapidoToolStripMenuItem.Click
        FrmInventarioRapido.ShowDialog()
    End Sub

    Private Sub RelMargemDeLucroBrutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelMargemDeLucroBrutoToolStripMenuItem.Click
        If LbCodEvento.Text = "" Then
            MsgBox("selecione um evento para busca")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocument2.Print()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim eventoFrm As New FrmEvento
        eventoFrm.relMargemLucro(e, LbCodEvento.Text, LbNomEvento.Text)
    End Sub

    Private Sub RelResumoIngressosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelResumoIngressosToolStripMenuItem.Click
        If LbCodEvento.Text = "" Then
            MsgBox("selecione um evento para busca")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocument3.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        imprimiRelResumoVenda(e, LbCodEvento.Text, LbNomEvento.Text, "I")
    End Sub


    Private Sub DgvItemVenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellClick
        Try
            TxbCodItem.Text = DgvItem.CurrentRow.Cells(0).Value
            LbDescricaoItem.Text = DgvItem.CurrentRow.Cells(1).Value
            txbBuscaDesItem.Text = ""
            TabControl1.SelectedIndex = 0
            TxbQtde.Enabled = True
            TxbQtde.Select()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesaToolStripMenuItem.Click
        FrmDespesa.ShowDialog()
    End Sub

    Private Sub RelDespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelDespesaToolStripMenuItem.Click
        FrmPesquisa.tabela = "tab_evento_principal"
        FrmPesquisa.ShowDialog()
        Try
            PrintDocumentDespesa.Print()
        Catch ex As Exception
            MsgBox("erro")
        End Try
    End Sub

    Private Sub PrintDocumentDespesa_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentDespesa.PrintPage
        imprimiRelDespesa(e, codEvento, nomEvento)
    End Sub

    Private Sub TxtQtde_TextChanged(sender As Object, e As EventArgs) Handles TxbQtde.TextChanged
        If Not IsNumeric(TxbQtde.Text) Then
            TxbQtde.Text = ""
        End If
        If TxbQtde.Text = "" Then
            TxbValorTotal.Text = FormatNumber(0, 2)
            Exit Sub
        End If
        If LbDescricaoItem.Text = "" Then
            TxbQtde.Text = ""
            TxbCodItem.Text = ""
            LbDescricaoItem.Text = ""
            TxbValorTotal.Text = FormatNumber(0, 2)
            TxbValorUnitario.Text = ""
            TxbCodItem.Select()
            Exit Sub
        End If

        Dim total As Double
        total = TxbQtde.Text * TxbValorUnitario.Text
        TxbValorTotal.Text = Convert.ToString(FormatNumber(total, 2))

    End Sub

    Public Sub imprimiRelDespesa(e As Printing.PrintPageEventArgs, codEvento As String, nomEvento As String)

        Dim reportFont2 As Font = New Drawing.Font("Time New Roman", 8)
        Dim reportFont10 As Font = New Drawing.Font("Time New Roman", 10)
        Dim reportFont12 As Font = New Drawing.Font("Time New Roman", 12)
        despesa.cod_evento = codEvento
        Dim tabela As DataTable
        Dim dsDespesa As New DataSet
        dsDespesa = despesa.ConsultaRelDespesa()

        tabela = dsDespesa.Tables(0)
        Dim Row As DataRow
        Dim x As Integer = 0
        If tabela.Rows.Count > 0 Then

            e.Graphics.DrawString("RESUMO DESPESA ", reportFont12, Brushes.Black, 0, x)
            x = x + 20

            x = 40
            Dim nome As String = ""
            Dim qtd_pessoa, qtd_total, val_pessoa, val_total As Double
            qtd_pessoa = 0
            qtd_total = 0
            val_pessoa = 0
            val_total = 0
            For Each Row In dsDespesa.Tables(0).Rows

                If x = 40 Then
                    e.Graphics.DrawString("DESPESA", reportFont2, Brushes.Black, 0, x)
                    e.Graphics.DrawString("VALOR", reportFont2, Brushes.Black, 230, x)
                    x = x + 15
                End If

                If nome <> Row.Item(2) Then
                    If val_pessoa <> 0 Then
                        x = x + 20
                        e.Graphics.DrawString("TOTAL:", reportFont10, Brushes.Black, 0, x)
                        e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 250, x)
                        val_pessoa = 0
                    End If
                    x = x + 20
                    e.Graphics.DrawString(Row.Item(2), reportFont12, Brushes.Black, 90, x)
                    nome = Row.Item(2)
                End If


                x = x + 20
                e.Graphics.DrawString(Row.Item(0), reportFont2, Brushes.Black, 0, x)
                e.Graphics.DrawString(Row.Item(3), reportFont2, Brushes.Black, 250, x)
                val_pessoa = val_pessoa + Row.Item(3)
                val_total = val_total + Row.Item(3)

            Next
            x = x + 15
            e.Graphics.DrawString("TOTAL:", reportFont10, Brushes.Black, 0, x)
            e.Graphics.DrawString(val_pessoa, reportFont10, Brushes.Black, 250, x)

            x = x + 40
            e.Graphics.DrawString("TOTAL GERAL:", reportFont10, Brushes.Black, 0, x)
            e.Graphics.DrawString(val_total, reportFont10, Brushes.Black, 250, x)
        End If
    End Sub

    Private Sub BtnImprimirFicha_Click(sender As Object, e As EventArgs) Handles BtnImprimirFicha.Click
        salvarBancoImprimirFicha()
    End Sub

    Private Sub ImToolStripMenuItem_Click(sender As Object, e As EventArgs)
        imprimirIngresso()
    End Sub

    Public Sub imprimirIngresso()
        Try
            licenciaVerifica()
            If Today > clLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & clLicencia.dataVectoLicencia & " PRECISA ENTRAR EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            DescarregarTelaVenda()
            FrmImprimirIngressos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VendasToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.MouseEnter, BarToolStripMenuItem.MouseEnter
        VendasToolStripMenuItem.ForeColor = BackColor
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btItemVenda.Click
        TabControl1.SelectedIndex = 0
        TxbCodItem.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtBuscaItem.Click
        TabControl1.SelectedIndex = 1
        buscaItem(txbBuscaDesItem.Text)
    End Sub
    Public Sub buscaItem(busca As String)
        cbBuscaItem.Items.Clear()
        cbBuscaItem.Items.Add("Codigo")
        cbBuscaItem.Items.Add("Descricao")
        Dim tab As DataTable
        dsItem = item.ConsultarItemPesquisa(busca)
        tab = dsItem.Tables(0)
        If tab.Rows.Count > 0 Then
            DgvItem.DataSource = dsItem.Tables(0)

        End If
    End Sub
    Private Sub txbBuscaDesItem_TextChanged(sender As Object, e As EventArgs) Handles txbBuscaDesItem.TextChanged
        buscaItem(txbBuscaDesItem.Text)
    End Sub

    '/ Remover linha selecionada
    Private Sub btnRemoverLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoverLinha.Click
        '/se não tem linhas então sai
        If DgvVenda.RowCount = 0 Then Exit Sub
        '//remove a linha atual selecionada
        totalGeral = totalGeral - DgvVenda.CurrentRow.Cells(4).Value
        TxbTotalGeral.Text = Convert.ToString(FormatNumber(totalGeral, 2))
        DgvVenda.Rows.Remove(DgvVenda.CurrentRow)
        DgvVenda.Refresh()
        '//se existem linhas calcula a soma 
        ' If DgvVenda.RowCount > 0 Then Call CalculaSomaTotal()
    End Sub


    Private Sub BtBuscaPessoa_Click(sender As Object, e As EventArgs) Handles BtBuscaPessoa.Click
        TabControl1.SelectedIndex = 3
        buscaPessoa(TxbBuscaNomPessoa.Text)
    End Sub

    Public Sub buscaPessoa(busca As String)
        CbBuscaPessoa.Items.Clear()
        ' cbBuscaItem.Items.Add("Codigo")
        cbBuscaItem.Items.Add("Nome")
        Dim tab As DataTable
        dsPessoa = pessoa.ConsultarPessoaCliente(busca)
        tab = dsPessoa.Tables(0)
        If tab.Rows.Count > 0 Then
            DgvPessoa.DataSource = dsPessoa.Tables(0)
            With DgvPessoa
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Nome"
                .Columns(0).Width = 100
                .Columns(1).Width = 555
            End With
        End If
    End Sub

    Private Sub TxbCodFormaPagto_TextChanged(sender As Object, e As EventArgs) Handles TxbCodFormaPagto.TextChanged
        If Not IsNumeric(TxbCodFormaPagto.Text) Then
            TxbCodFormaPagto.Text = ""
        End If
        Try

            For Each row In DgvFormaPagto.Rows
                If TxbCodFormaPagto.Text = row.Cells(0).Value.ToString Then
                    LbDesFormaPagto.Text = row.Cells(1).Value.ToString
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub


    Private Sub TxbCodFormaPagto_LostFocus(sender As Object, e As EventArgs) Handles TxbCodFormaPagto.LostFocus
        If TxbCodFormaPagto.Text = "" Then
            TxbCodFormaPagto.Select()
            Exit Sub
        End If
        TxbValorPagto.Select()
    End Sub

    Private Sub TxbValorPagto_TextChanged(sender As Object, e As EventArgs) Handles TxbValorPagto.LostFocus

        '    salvarBancoImprimirFicha()
    End Sub

    Private Sub BtPagamento_Click_1(sender As Object, e As EventArgs) Handles BtPagamento.Click
        informarPagamento()

    End Sub
    Public Sub formatarGridPagto()
        With DgvPagamento
            .Columns.Add("Código", "Código")
            .Columns.Add("Descrição", "Descrição")
            .Columns.Add("Valor", "Valor")
            .Columns(0).Width = 50
            .Columns(1).Width = 160
            .Columns(2).Width = 80

            .AllowUserToAddRows = False
        End With
    End Sub
    Private Sub TxbCodItem_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbCodItem.KeyUp
        Select Case e.KeyCode
            Case 123
                TabControl1.SelectedIndex = 1 'F12 busca item
            Case 121
                TxbQtde.Enabled = True 'F10 quantidade
                TxbQtde.Text = ""
            Case 114
                MsgBox("Tecla F3")
            Case 117
                TabControl1.SelectedIndex = 3 'F6 cliente
            Case 116
                informarPagamento() 'F5 pagamento
        End Select
    End Sub
    Public Sub informarPagamento()
        If totalGeral = 0 Then
            TabControl1.SelectedIndex = 0
            Exit Sub
        End If
        TabControl1.SelectedIndex = 2
        formatarGridPagto()
        TxbTotalGeralPg.Text = Convert.ToString(FormatNumber(totalGeral, 2))
        TxbSaldoRestante.Text = Convert.ToString(FormatNumber(totalGeral, 2))
        saldoRestante = totalGeral
        troco = totalGeral
        TxbCodFormaPagto.Select()
    End Sub



    Private Sub TxbNomPessoa_TextChanged(sender As Object, e As EventArgs) Handles TxbBuscaNomPessoa.TextChanged
        buscaPessoa(TxbBuscaNomPessoa.Text)
    End Sub

    Private Sub TxbValorPagto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbValorPagto.KeyUp

        Select Case e.KeyCode
            Case 13

            Case 121                'F10

            Case 9
                If LbDesFormaPagto.Text = "" Then
                    TxbCodFormaPagto.Select()
                Else
                    TxbValorPagto.Select()
                End If
                If LbDesFormaPagto.Text <> "" And TxbValorPagto.Text <> "" Then
                    carregaGridPagto()
                End If

            Case 114

            Case 116
                'F5
        End Select
    End Sub

    Private Sub TxbCodFormaPagto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxbCodFormaPagto.KeyUp
        Select Case e.KeyCode
            Case 123
                TabControl1.SelectedIndex = 4 'F12
            Case 112
                TabControl1.SelectedIndex = 0 'F1
            Case 114
              '  MsgBox("Tecla F3")
            Case 114
               ' MsgBox("Tecla F3")
            Case 116
                ' informarPagamento() 'F5
        End Select
    End Sub

    Private Sub DgvPessoa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPessoa.CellClick
        Me.LbCodCliente.Text = DgvPessoa.CurrentRow.Cells(0).Value
        Me.LbNomCliente.Text = DgvPessoa.CurrentRow.Cells(1).Value
        TxbBuscaNomPessoa.Text = ""
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub ImprimirIngressoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirIngressoToolStripMenuItem.Click
        imprimirIngresso()
    End Sub

    Private Sub PDV1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDV1ToolStripMenuItem.Click
        licenciaVerifica()

        Try
            If Today > clLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & clLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If

            FrmEscolherEvento.ShowDialog()
            If LbCodEvento.Text = "" Then
                Exit Sub
            End If
            FrmPdv1.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AnimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimalToolStripMenuItem.Click
        FrmAnimal.ShowDialog()
    End Sub

    Private Sub EspécieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspécieToolStripMenuItem.Click
        frmEspecie.ShowDialog()
    End Sub

    Private Sub ParasitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParasitaToolStripMenuItem.Click
        frmContoleParasita.ShowDialog()
    End Sub

    Private Sub VacinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacinaToolStripMenuItem.Click
        frmVacina.ShowDialog()
    End Sub

    Private Sub PelagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelagemToolStripMenuItem.Click
        frmPelagem.ShowDialog()
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        DescarregarTelaVenda()
        FrmItem.ShowDialog()
    End Sub

    Private Sub EventoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EventoToolStripMenuItem2.Click
        DescarregarTelaVenda()
        FrmEvento.ShowDialog()
    End Sub

    Private Sub ImprimirIngressoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimirIngressoToolStripMenuItem1.Click
        imprimirIngresso()
    End Sub

    Private Sub ParametrosSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosSistemaToolStripMenuItem.Click
        FrmParametroSistema.ShowDialog()
    End Sub

    Private Sub LicençaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicençaToolStripMenuItem.Click
        FrmLicencia.ShowDialog()
    End Sub

    Private Sub FunçãoFuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunçãoFuncionarioToolStripMenuItem.Click
        FrmFuncaoFuncionario.ShowDialog()
    End Sub

    Private Sub AlmoxarifadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlmoxarifadoToolStripMenuItem1.Click
        FrmAlmoxarifado.ShowDialog()
    End Sub

    Private Sub SeçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeçãoToolStripMenuItem.Click
        FrmSecao.Show()
    End Sub

    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Close()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        FrmCategoria.ShowDialog()
    End Sub

    Private Sub SubCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriaToolStripMenuItem.Click
        FrmSubCategoria.ShowDialog()
    End Sub

    Private Sub RaçaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaçaToolStripMenuItem.Click
        frmRaca.ShowDialog()
    End Sub

    Private Sub TxbValorPagto_TextChanged_1(sender As Object, e As EventArgs) Handles TxbValorPagto.TextChanged
        If Not IsNumeric(TxbValorPagto.Text) Then
            TxbValorPagto.Text = ""
        End If
    End Sub



    Public Sub buscaFormaPagto()
        Dim tab As DataTable
        dsFormaPgto = formaPagto.ConsultarFormaPagtoPdv()
        tab = dsFormaPgto.Tables(0)
        If tab.Rows.Count > 0 Then
            DgvFormaPagto.DataSource = dsFormaPgto.Tables(0)
            With DgvFormaPagto
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(0).Width = 100
                .Columns(1).Width = 555
            End With
        End If
    End Sub
    Private Sub DgvFormaPagto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFormaPagto.CellClick
        Me.TxbCodFormaPagto.Text = DgvFormaPagto.CurrentRow.Cells(0).Value
        Me.LbDesFormaPagto.Text = DgvFormaPagto.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 2
        TxbValorPagto.Select()
        'valor troco zero ai volta para principal e finaliza tudo  TabControl1.SelectedIndex = 0
    End Sub
    Public Sub carregaGridPagto()
        If LbDesFormaPagto.Text = "" Then
            TxbCodFormaPagto.Select()
            Exit Sub
        End If
        If TxbValorPagto.Text = "" Then
            TxbValorPagto.Select()
            Exit Sub
        End If
        Try
            saldoRestante = saldoRestante - Convert.ToDouble(TxbValorPagto.Text)
            If saldoRestante < 0 Then
                TxbSaldoRestante.Text = "0,00"
            Else
                TxbSaldoRestante.Text = FormatNumber(Convert.ToString(saldoRestante), 2)
            End If

            troco = troco - Convert.ToDouble(TxbValorPagto.Text)
            If troco > 0 Then
                TxbTroco.Text = "0,00"
            Else
                TxbTroco.Text = FormatNumber(Convert.ToString(troco * (-1)), 2)
            End If
            DgvPagamento.Rows.Add(TxbCodFormaPagto.Text, LbDesFormaPagto.Text, TxbValorPagto.Text)

            limparpagamento()
            TxbCodFormaPagto.Select()
        Catch ex As Exception
            MsgBox("Erro carregar gridPgto")
        End Try
    End Sub
    Public Sub limparpagamento()
        TxbCodFormaPagto.Text = ""
        TxbValorPagto.Text = ""
        LbDesFormaPagto.Text = ""
    End Sub
End Class