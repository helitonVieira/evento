Imports System.Security
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class FrmFuncaoFuncionario
    Dim conectar As New ConexaoSQ
    Dim ds, dsUltimo As New DataSet
    Dim funcao, funcao2 As New ClFuncaoFuncionario
    Dim atualizar As Integer = 1
    Dim cod As Integer
    Dim desc As String
    Dim i As Integer = 0

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPesquisa.Click
        verificarAutefuncaoo()

        If TxbCodFuncao.Text = "" Then
            cod = 0
        Else
            cod = TxbCodFuncao.Text
        End If
        desc = TxbDesFuncao.Text
        atualizaDados()

    End Sub
    Public Sub atualizaDados()
        Dim tabela As DataTable
        ds = funcao.ConsultarFuncaoFuncionario(cod, desc)
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvFuncao.DataSource = Nothing
            DgvFuncao.DataSource = ds.Tables(0)
            formatarGrid()
        End If
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try
            If TxbDesFuncao.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesFuncao.Select()
                Exit Sub
            End If

            funcao.des_funcao_funcionario = TxbDesFuncao.Text
            desc = TxbDesFuncao.Text

            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = funcao2.UltimoFuncaoFuncionarioCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                funcao.cod_funcao_funcionario = Convert.ToInt16(ult) + 1

                funcao.CadastrarFuncaoFuncionario()
                ultimo.Clear()
                MsgBox("Função Funcionario cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                funcao.cod_funcao_funcionario = TxbCodFuncao.Text
                funcao.AtualizarFuncaoFuncionario()
                MsgBox("Função Funcionario Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodFuncao.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir a Função Funcionario:   " & TxbDesFuncao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                funcao.cod_funcao_funcionario = TxbCodFuncao.Text
                funcao.ExcluirFuncaoFuncionario()
                MsgBox("Função Funcionario excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()

            Catch ex As Exception
                MsgBox("Erro ao excluir Função Funcionario, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAutefuncaoo()
        limpar()
        DgvFuncao.DataSource = Nothing
        TxbCodFuncao.Enabled = True
        TabControl1.SelectedIndex = 0

    End Sub
    Public Sub limpar()
        TxbCodFuncao.Text = ""
        TxbDesFuncao.Text = ""
        atualizar = 1


    End Sub
    Public Sub formatarGrid()
        Try
            With DgvFuncao
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
            TxbCodFuncao.Text = ds.Tables(0).Rows(i)("cod_funcao_funcionario").ToString
            TxbDesFuncao.Text = ds.Tables(0).Rows(i)("des_funcao_funcionario").ToString
            desc = TxbDesFuncao.Text
            TxbCodFuncao.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub verificarAutefuncaoo()
        If TxbCodFuncao.Text = "" Then
            Exit Sub
        End If
        If desc <> TxbDesFuncao.Text Then
            If MsgBox("Descrição foi alterada deseja salvar alteração?       Anterior: " & desc & "     Nova Descrição: " & TxbDesFuncao.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub

    Private Sub FrmFuncaoFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvFuncao_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncao.CellEnter
        i = DgvFuncao.CurrentRow.Index
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
        verificarAutefuncaoo()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAutefuncaoo()

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
        verificarAutefuncaoo()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAutefuncaoo()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub

    Private Sub TxbCodFuncao_TextChanged_1(sender As Object, e As EventArgs) Handles TxbCodFuncao.TextChanged
        If Not IsNumeric(TxbCodFuncao.Text) Then
            TxbCodFuncao.Text = ""
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



        nomArquivo = "FuncaoFuncionario_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\FuncaoFuncionario_" & nomArquivo & ".csv"
                                                                               )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvFuncao.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvFuncao.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvFuncao.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvFuncao.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvFuncao.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvFuncao.Rows(i).Cells(x).Value.ToString())

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

    Private Sub TxbCodFuncao_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TxbCodFuncao.Text) Then
            TxbCodFuncao.Text = ""
        End If
    End Sub

    Private Sub DgvFuncao_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFuncao.CellClick
        Me.TxbCodFuncao.Text = DgvFuncao.CurrentRow.Cells(0).Value
        Me.TxbDesFuncao.Text = DgvFuncao.CurrentRow.Cells(1).Value
        TabControl1.SelectedIndex = 0
        Me.TxbDesFuncao.Select()
    End Sub
End Class
