Imports PetSystem.FrmControleParasita
Public Class FrmPrincipal
    Dim ClLicencia As New ClLicencia
    Dim frmContoleParasita As New PetSystem.FrmControleParasita
    Dim frmVacina As New PetSystem.FrmVacina
    Dim frmPelagem As New PetSystem.FrmPelagem
    Dim frmRaca As New PetSystem.FrmRaca
    Dim frmEspecie As New PetSystem.FrmEspecie
    Dim frmAnimal As New PetSystem.FrmAnimal
    Public codEvento, nomEmpresa, nomEvento As String
    Dim despesa As New ClDespesa

    Public Sub licenciaVerifica()
        ClLicencia.verificarLicencia()

    End Sub
    Private Sub BarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarToolStripMenuItem.Click
        Exit Sub
        licenciaVerifica()

        Try
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If

            FrmEscolherEvento.ShowDialog()
            If codEvento = "" Then
                Exit Sub
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ResumoVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumoVendasToolStripMenuItem.Click
        If codEvento = "" Then
            MsgBox("Um evento tem que estar logado")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocRelResumoVenda.Print()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PessoaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PessoaToolStripMenuItem.Click
        FrmPessoa.Show()
    End Sub

    Private Sub InventarioRapidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioRapidoToolStripMenuItem.Click
        FrmInventarioRapido.Show()
    End Sub



    Private Sub RelMargemDeLucroBrutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelMargemDeLucroBrutoToolStripMenuItem.Click
        If codEvento = "" Then
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
        eventoFrm.relMargemLucro(e, codEvento, nomEvento)
    End Sub

    Private Sub RelResumoIngressosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelResumoIngressosToolStripMenuItem.Click
        If codEvento = "" Then
            MsgBox("selecione um evento para busca")
            Exit Sub
        End If
        '  Form1.Show()
        Try
            PrintDocument3.Print()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DespesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesaToolStripMenuItem.Click
        FrmDespesa.Show()
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

    Public Sub imprimirIngresso()
        Try
            licenciaVerifica()
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & " PRECISA ENTRAR EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If
            FrmImprimirIngressos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VendasToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.MouseEnter, BarToolStripMenuItem.MouseEnter
        VendasToolStripMenuItem.ForeColor = BackColor
    End Sub

    Private Sub PDV1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PDV1ToolStripMenuItem.Click
        licenciaVerifica()

        Try
            If Today > ClLicencia.dataVectoLicencia Then
                MsgBox("LICENCIA VENCIDA " & ClLicencia.dataVectoLicencia & "ENTRE EM CONTATO COM ADMINISTRADOR PARA RENOVAR A LICENCIA")
                Exit Sub
            End If

            FrmEscolherEvento.ShowDialog()
            If codEvento = "" Then
                Exit Sub
            End If
            FrmPdv1.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AnimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimalToolStripMenuItem.Click
        frmAnimal.Show()
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

        FrmItem.Show()
    End Sub

    Private Sub EventoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EventoToolStripMenuItem2.Click

        FrmEvento.Show()
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
        FrmCategoria.Show()
    End Sub

    Private Sub AlmoxarifadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmAlmoxarifado.ShowDialog()
    End Sub

    Private Sub UnidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeToolStripMenuItem.Click
        FrmUnidade.ShowDialog()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        FrmMarca.ShowDialog()
    End Sub

    Private Sub SubCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubCategoriaToolStripMenuItem.Click
        FrmSubCategoria.Show()
    End Sub

    Private Sub RaçaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaçaToolStripMenuItem.Click
        frmRaca.ShowDialog()
    End Sub



End Class