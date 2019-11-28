Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmAnimalEspecie
    Dim conectar As New ConexaoSQ
    Dim ds, dsUltimo As New DataSet
    Dim especie, especie2 As New ClAnimalEspecie
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAuteracao()

        If TxbCodEspecie.Text = "" Then
            cod = 0
        Else
            cod = TxbCodEspecie.Text
        End If
        desc = TxbDesEspecie.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = especie.ConsultarEspecie(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvEspecie.DataSource = Nothing
            DgvEspecie.DataSource = ds.Tables(0)
            formatarGrid()
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDesEspecie.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesEspecie.Select()
                Exit Sub
            End If

            especie.des_especie = TxbDesEspecie.Text
            desc = TxbDesEspecie.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = especie2.UltimoEspecieCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                especie.cod_especie = Convert.ToInt16(ult) + 1

                especie.CadastrarEspecie()
                ultimo.Clear()
                MsgBox("Especie cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                especie.cod_especie = TxbCodEspecie.Text
                especie.AtualizarEspecie()
                MsgBox("Especie Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodEspecie.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a Especie:   " & TxbDesEspecie.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                especie.cod_especie = TxbCodEspecie.Text
                especie.ExcluirEspecie()
                MsgBox("Especie excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Especie, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracao()
        limpar()
        DgvEspecie.DataSource = Nothing
        TxbCodEspecie.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Public Sub limpar()
        TxbCodEspecie.Text = ""
        TxbDesEspecie.Text = ""
        atualizar = 1


    End Sub
    Public Sub formatarGrid()
        Try
            With DgvEspecie
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
            TxbCodEspecie.Text = ds.Tables(0).Rows(i)("cod_especie").ToString
            TxbDesEspecie.Text = ds.Tables(0).Rows(i)("des_especie").ToString
            desc = TxbDesEspecie.Text
            TxbCodEspecie.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAuteracao()
        If TxbCodEspecie.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDesEspecie.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDesEspecie.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmEspecie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvEspecie_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEspecie.CellEnter
        i = DgvEspecie.CurrentRow.Index
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

    Private Sub TxbCodEspecie_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodEspecie.TextChanged
        If Not IsNumeric(TxbCodEspecie.Text) Then
            TxbCodEspecie.Text = ""
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



        nomArquivo = "AnimalEspecie_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\AnimalEspecie_" & nomArquivo & ".csv"
                                                                       )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvEspecie.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvEspecie.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvEspecie.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvEspecie.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvEspecie.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvEspecie.Rows(i).Cells(x).Value.ToString())

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

    Private Sub TxbCodEspecie_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TxbCodEspecie.Text) Then
            TxbCodEspecie.Text = ""
        End If
    End Sub

    Private Sub DgvEspecie_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEspecie.CellClick
        Me.TxbCodEspecie.Text = DgvEspecie.CurrentRow.Cells(0).Value
        Me.TxbDesEspecie.Text = DgvEspecie.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.TxbDesEspecie.Select()
    End Sub
End Class
