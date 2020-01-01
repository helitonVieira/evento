Public Class FrmItem1
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim item As New ClItem1
    Dim atualizar As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPresquisa.Click
        atualizaDados()
        limpar()
    End Sub
    Public Sub atualizaDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = item.ConsultarItem()
        tabela = ds.Tables(0)


        If tabela.Rows.Count > 0 Then
            DgvItem.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        limpar()

    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try
            'Dim ultimo As DataSet
            ' ultimo = item.ConsultarItemVenda
            '  Label7.Text = ultimo.Tables(0).Rows.Item(1).ToString
            If TxbDesItem.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                TxbDesItem.Select()
                Exit Sub
            End If

            item.des_item = TxbDesItem.Text
            If TxbPrecoVenda.Text = "" Then
                TxbPrecoVenda.Text = "0"
            End If

            item.val_preco_venda = TxbPrecoVenda.Text.Replace(",", ".")
            If TxtPrecoCusto.Text = "" Then
                TxtPrecoCusto.Text = "0"
            End If
            item.val_custo = TxtPrecoCusto.Text.Replace(",", ".")
            If TxtCodEvento.Text = "" Then
                TxtCodEvento.Text = "0"
            End If
            item.cod_evento = TxtCodEvento.Text
            If CkbAtivo.Checked = False Then
                item.ind_ativo = "N"
            Else
                item.ind_ativo = "S"
            End If

            If atualizar = 1 Then
                item.CadastrarItem()
                MsgBox("Item cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                item.cod_item = TxbCodItem.Text
                item.AtualizarItem()
                MsgBox("Item Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If


        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir o item" & TxbDesItem.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                item.cod_item = TxbCodItem.Text
                item.ExcluirItem()
                MsgBox("Item excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()
                limpar()
            Catch ex As Exception
                MsgBox("Erro ao excluir Item, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        limpar()

    End Sub
    Public Sub limpar()
        TxbCodItem.Text = ""
        TxbDesItem.Text = ""
        TxtPrecoCusto.Text = ""
        TxbPrecoVenda.Text = ""
        TxtCodEvento.Text = ""
        CkbAtivo.Checked = False

        atualizar = 1

    End Sub
    Public Sub formatarGrid()
        With DgvItem
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Descrição"
            .Columns(2).HeaderText = "Val.Venda"
            .Columns(3).HeaderText = "Val.Custo"
            .Columns(4).HeaderText = "Ativo"
            .Columns(5).HeaderText = "Cód.Evento"
            .Columns(0).Width = 60
            .Columns(1).Width = 200
            .Columns(2).Width = 60
            .Columns(3).Width = 60
            .Columns(4).Width = 60
            .Columns(5).Width = 60

        End With
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            TxbCodItem.Text = DgvItem.CurrentRow.Cells(0).Value
            TxbDesItem.Text = DgvItem.CurrentRow.Cells(1).Value
            TxbPrecoVenda.Text = DgvItem.CurrentRow.Cells(2).Value
            TxtPrecoCusto.Text = DgvItem.CurrentRow.Cells(3).Value
            TxtCodEvento.Text = DgvItem.CurrentRow.Cells(5).Value


            If DgvItem.CurrentRow.Cells(4).Value = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            Dim tabela As DataTable
            ds = item.UltimoItemCadastrado()
            tabela = ds.Tables(0)
            '   CbIndAtivo.DataSource = ds.Tables(0)
            '   MsgBox(CbIndAtivo.DisplayMember)


        Catch ex As Exception

        End Try

    End Sub
    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
    End Sub

    Private Sub DgvItem_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvItem.CellEnter
        carregaFormulario()

    End Sub

    Private Sub TxtCodItem_TextChanged(sender As Object, e As EventArgs) Handles TxbCodItem.TextChanged
        If Not IsNumeric(TxbCodItem.Text) Then
            TxbCodItem.Text = ""
        End If
    End Sub

    Private Sub TxtPrecoVenda_TextChanged(sender As Object, e As EventArgs) Handles TxbPrecoVenda.TextChanged
        If Not IsNumeric(TxbPrecoVenda.Text) Then
            TxbPrecoVenda.Text = ""
        End If
    End Sub

    Private Sub TxtPrecoCusto_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecoCusto.TextChanged
        If Not IsNumeric(TxtPrecoCusto.Text) Then
            TxtPrecoCusto.Text = ""
        End If
    End Sub

    Private Sub TxtCodEvento_TextChanged(sender As Object, e As EventArgs) Handles TxtCodEvento.TextChanged
        If Not IsNumeric(TxtCodEvento.Text) Then
            TxtCodEvento.Text = ""
        End If
    End Sub

    Private Sub BtnSubCategoria_Click(sender As Object, e As EventArgs) Handles BtnSubCategoria.Click
        FrmPesquisa.tabela = "tab_subcategoria_item"
        FrmPesquisa.ShowDialog()
    End Sub
End Class
