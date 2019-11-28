Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmAnimalRaca

    Dim conectar As New ConexaoSQ
    Dim ds, dsUltimo As New DataSet
    Dim raca, raca2 As New ClAnimalRaca
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAuteracao()

        If TxbCodRaca.Text = "" Then
            cod = 0
        Else
            cod = TxbCodRaca.Text
        End If
        desc = TxbDesRaca.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = raca.ConsultarRaca(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvRaca.DataSource = Nothing
            DgvRaca.DataSource = ds.Tables(0)
            formatarGrid()
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDesRaca.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesRaca.Select()
                Exit Sub
            End If

            raca.des_raca = TxbDesRaca.Text
            desc = TxbDesRaca.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = raca2.UltimoRacaCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                raca.cod_raca = Convert.ToInt16(ult) + 1

                raca.CadastrarRaca()
                ultimo.Clear()
                MsgBox("Raca cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                raca.cod_raca = TxbCodRaca.Text
                raca.AtualizarRaca()
                MsgBox("Raca Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodRaca.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a Raca:   " & TxbDesRaca.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                raca.cod_raca = TxbCodRaca.Text
                raca.ExcluirRaca()
                MsgBox("Raca excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Raca, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        DgvRaca.DataSource = Nothing
        TxbCodRaca.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Public Sub limpar()
        TxbCodRaca.Text = ""
        TxbDesRaca.Text = ""
        atualizar = 1


    End Sub
    Public Sub formatarGrid()
        Try
            With DgvRaca
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
            TxbCodRaca.Text = ds.Tables(0).Rows(i)("cod_raca").ToString
            TxbDesRaca.Text = ds.Tables(0).Rows(i)("des_raca").ToString
            desc = TxbDesRaca.Text
            TxbCodRaca.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAuteracao()
        If TxbCodRaca.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDesRaca.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDesRaca.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmRaca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvRaca_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRaca.CellEnter
        i = DgvRaca.CurrentRow.Index
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
        verificarAuteracao()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

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

    Private Sub TxbCodRaca_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodRaca.TextChanged
        If Not IsNumeric(TxbCodRaca.Text) Then
            TxbCodRaca.Text = ""
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



        nomArquivo = "AnimalRaca_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\AnimalRaca_" & nomArquivo & ".csv"
                                                                           )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvRaca.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvRaca.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvRaca.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvRaca.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvRaca.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvRaca.Rows(i).Cells(x).Value.ToString())

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

    Private Sub TxbCodRaca_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TxbCodRaca.Text) Then
            TxbCodRaca.Text = ""
        End If
    End Sub

    Private Sub DgvRaca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRaca.CellClick
        Me.TxbCodRaca.Text = DgvRaca.CurrentRow.Cells(0).Value
        Me.TxbDesRaca.Text = DgvRaca.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.TxbDesRaca.Select()
    End Sub
    End Class
