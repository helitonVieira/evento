Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class FrmAnimalPelagem

    Dim conectar As New ConexaoSQ
    Dim ds, dsUltimo As New DataSet
    Dim pelagem, pelagem2 As New ClAnimalPelagem
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAutepelagemo()

        If TxbCodPelagem.Text = "" Then
            cod = 0
        Else
            cod = TxbCodPelagem.Text
        End If
        desc = TxbDesPelagem.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = pelagem.ConsultarPelagem(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvPelagem.DataSource = Nothing
            DgvPelagem.DataSource = ds.Tables(0)
            formatarGrid()
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDesPelagem.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesPelagem.Select()
                Exit Sub
            End If

            pelagem.des_pelagem = TxbDesPelagem.Text
            desc = TxbDesPelagem.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = pelagem2.UltimoPelagemCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                pelagem.cod_pelagem = Convert.ToInt16(ult) + 1

                pelagem.CadastrarPelagem()
                ultimo.Clear()
                MsgBox("Pelagem cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                pelagem.cod_pelagem = TxbCodPelagem.Text
                pelagem.AtualizarPelagem()
                MsgBox("Pelagem Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodPelagem.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a Pelagem:   " & TxbDesPelagem.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pelagem.cod_pelagem = TxbCodPelagem.Text
                pelagem.ExcluirPelagem()
                MsgBox("Pelagem excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Pelagem, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAutepelagemo()
        limpar()

        TxbCodPelagem.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Public Sub limpar()
        TxbCodPelagem.Text = ""
        TxbDesPelagem.Text = ""
        DgvPelagem.DataSource = Nothing
        atualizar = 1


    End Sub
    Public Sub formatarGrid()
        Try
            With DgvPelagem
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
            TxbCodPelagem.Text = ds.Tables(0).Rows(i)("cod_pelagem").ToString
            TxbDesPelagem.Text = ds.Tables(0).Rows(i)("des_pelagem").ToString
            desc = TxbDesPelagem.Text
            TxbCodPelagem.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAutepelagemo()
        If TxbCodPelagem.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDesPelagem.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDesPelagem.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmPelagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvPelagem_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPelagem.CellEnter
        i = DgvPelagem.CurrentRow.Index
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
        verificarAutepelagemo()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAutepelagemo()

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
        verificarAutepelagemo()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAutepelagemo()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub

    Private Sub TxbCodPelagem_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodPelagem.TextChanged
        If Not IsNumeric(TxbCodPelagem.Text) Then
            TxbCodPelagem.Text = ""
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



        nomArquivo = "AnimalPelagem_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\AnimalPelagem_" & nomArquivo & ".csv"
                                                                           )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvPelagem.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvPelagem.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvPelagem.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvPelagem.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvPelagem.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvPelagem.Rows(i).Cells(x).Value.ToString())

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

    Private Sub TxbCodPelagem_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TxbCodPelagem.Text) Then
            TxbCodPelagem.Text = ""
        End If
    End Sub

    Private Sub DgvPelagem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPelagem.CellClick
        Me.TxbCodPelagem.Text = DgvPelagem.CurrentRow.Cells(0).Value
        Me.TxbDesPelagem.Text = DgvPelagem.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.TxbDesPelagem.Select()
    End Sub
End Class
