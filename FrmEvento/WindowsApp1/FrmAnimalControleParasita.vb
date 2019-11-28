Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmAnimalControleParasita

    Dim conectar As New ConexaoSQ
    Dim ds, dsUltimo As New DataSet
    Dim controleParasita, controleParasita2 As New ClAnimalControleParasita
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAutecontroleParasitao()

        If TxbCodControleParasita.Text = "" Then
            cod = 0
        Else
            cod = TxbCodControleParasita.Text
        End If
        desc = TxbDesControleParasita.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = controleParasita.ConsultarControleParasita(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvControleParasita.DataSource = Nothing
            DgvControleParasita.DataSource = ds.Tables(0)
            formatarGrid()
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDesControleParasita.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesControleParasita.Select()
                Exit Sub
            End If

            controleParasita.nom_controle_parasita = TxbDesControleParasita.Text
            desc = TxbDesControleParasita.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = controleParasita2.UltimoControleParasitaCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                controleParasita.cod_controle_parasita = Convert.ToInt16(ult) + 1

                controleParasita.CadastrarControleParasita()
                ultimo.Clear()
                MsgBox("ControleParasita cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                controleParasita.cod_controle_parasita = TxbCodControleParasita.Text
                controleParasita.AtualizarControleParasita()
                MsgBox("ControleParasita Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodControleParasita.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a ControleParasita:   " & TxbDesControleParasita.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                controleParasita.cod_controle_parasita = TxbCodControleParasita.Text
                controleParasita.ExcluirControleParasita()
                MsgBox("ControleParasita excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir ControleParasita, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAutecontroleParasitao()
        limpar()
        DgvControleParasita.DataSource = Nothing
        TxbCodControleParasita.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Public Sub limpar()
        TxbCodControleParasita.Text = ""
        TxbDesControleParasita.Text = ""
        atualizar = 1


    End Sub
    Public Sub formatarGrid()
        Try
            With DgvControleParasita
                .Columns(0).HeaderText = "Código"
                .Columns(1).HeaderText = "Descrição"
                .Columns(0).Width = 60
                .Columns(1).Width = 294

            End With

        Catch ex As Exception

        End Try
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            TxbCodControleParasita.Text = ds.Tables(0).Rows(i)("cod_controle_parasita").ToString
            TxbDesControleParasita.Text = ds.Tables(0).Rows(i)("nom_controle_parasita").ToString
            desc = TxbDesControleParasita.Text
            TxbCodControleParasita.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAutecontroleParasitao()
        If TxbCodControleParasita.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDesControleParasita.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDesControleParasita.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmControleParasita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvControleParasita_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvControleParasita.CellEnter
        i = DgvControleParasita.CurrentRow.Index
        carregaFormulario()
    End Sub

    Private Sub BtnGrid_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If


    End Sub
    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAutecontroleParasitao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAutecontroleParasitao()

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
        verificarAutecontroleParasitao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAutecontroleParasitao()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub

    Private Sub TxbCodControleParasita_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodControleParasita.TextChanged
        If Not IsNumeric(TxbCodControleParasita.Text) Then
            TxbCodControleParasita.Text = ""
        End If
    End Sub

    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
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



        nomArquivo = "AnimalControleParasita_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\AnimalControleParasita_" & nomArquivo & ".csv"
                                                                           )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvControleParasita.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvControleParasita.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvControleParasita.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvControleParasita.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvControleParasita.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvControleParasita.Rows(i).Cells(x).Value.ToString())

                End If

                If (x < QtdColunas) Then
                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            Next x
            CSV.Write(CSV.NewLine)
        Next i
        MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

        CSV.Close()
    End Sub

    Private Sub TxbCodControleParasita_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TxbCodControleParasita.Text) Then
            TxbCodControleParasita.Text = ""
        End If
    End Sub

    Private Sub DgvControleParasita_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvControleParasita.CellClick
        Me.TxbCodControleParasita.Text = DgvControleParasita.CurrentRow.Cells(0).Value
        Me.TxbDesControleParasita.Text = DgvControleParasita.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.TxbDesControleParasita.Select()
    End Sub
End Class
