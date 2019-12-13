Public Class FrmInventarioRapido
    Dim conectar As New ConexaoSQL
    Dim clGeral As New ClGeral
    Dim atualizar As Integer = 1
    Dim inventario As New ClInventarioRapido
    Dim clEvento As New ClEvento
    Dim clItem As New ClItem
    Dim clTipoMovimento As New ClTipoMovimento
    Dim ds As New DataSet
    Public desItem As String

    Private codItem_ As String
    Public Property codItem() As String
        Get
            Return codItem_
        End Get
        Set(ByVal value As String)
            codItem_ = value
        End Set
    End Property
    Private Sub FrmInventarioRapido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbData.Text = Today
        limpar()
    End Sub

    Private Sub BtPesquisa_Click(sender As Object, e As EventArgs) Handles btBuscaItem.Click
        FrmPesquisa.tabela = "tab_item"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btBuscaEvento.Click
        FrmPesquisa.tabela = "tab_evento"
        FrmPesquisa.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtPresquisa_Click(sender As Object, e As EventArgs) Handles BtPresquisa.Click
        atualizaDados()
    End Sub
    Public Sub atualizaDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = inventario.ConsultarInventario()
        tabela = ds.Tables(0)


        If tabela.Rows.Count > 0 Then
            dgvInventario.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        limpar()
    End Sub
    Public Sub limpar()
        ' txbCodEvento.Text = ""
        ' txbDesEvento.Text = ""
        txtCodItem.Text = ""
        txtDesItem.Text = ""
        txtQtde.Text = ""
        txtCustoUn.Text = ""
        txtCustoTotal.Text = ""
        atualizar = 1
    End Sub
    Public Sub formatarGrid()
        With dgvInventario
            .Columns(0).HeaderText = "Sequencia"
            .Columns(1).HeaderText = "Cód.Evento"
            .Columns(2).HeaderText = "Cód.TipoMovimento"
            .Columns(3).HeaderText = "CódItem"
            .Columns(4).HeaderText = "Qtde"
            .Columns(5).HeaderText = "Val.Custo.Un"
            .Columns(6).HeaderText = "Val.Custo.Tot"
            .Columns(7).HeaderText = "Data"
            .Columns(0).Width = 40
            .Columns(1).Width = 40
            .Columns(1).Width = 40
            .Columns(2).Width = 40
            .Columns(3).Width = 40
            .Columns(4).Width = 40
            .Columns(5).Width = 40
            .Columns(6).Width = 40
            .Columns(7).Width = 40

        End With
    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        Try
            ' Dim ultimo As DataSet
            'ultimo = inventario.ConsultarItemVenda
            '  Label7.Text = ultimo.Tables(0).Rows.Item(1).ToString
            If txtCodEvento.Text = "" Then
                MsgBox("INFORME O EVENTO")
                txtCodEvento.Select()
                Exit Sub
            End If
            inventario.cod_evento = txtCodEvento.Text

            If txtCodTipoMovimento.Text = "" Then
                MsgBox("INFORME O MOVIMENTO")
                txtCodTipoMovimento.Select()
                Exit Sub
            End If
            inventario.cod_tipo_movimento = txtCodTipoMovimento.Text

            If txtCodItem.Text = "" Then
                MsgBox("INFORME O ITEM")
                txtCodItem.Select()
                Exit Sub
            End If
            inventario.cod_item = txtCodItem.Text

            If txtQtde.Text = "" Then
                MsgBox("INFORME O QUANTIDADE")
                txtQtde.Select()
                Exit Sub
            End If
            inventario.qtd_item = txtQtde.Text.Replace(",", ".")

            If txtCustoUn.Text = "" Then
                MsgBox("INFORME O VALOR CUSTO UNITARIO")
                txtCustoUn.Select()
                Exit Sub
            End If
            inventario.val_custo_unitario = txtCustoUn.Text.Replace(",", ".")

            If txtCustoTotal.Text = "" Then
                txtCustoTotal.Text = "0"
            End If
            inventario.val_custo_total = txtCustoTotal.Text.Replace(",", ".")
            inventario.dta_inventario = Today

            If atualizar = 1 Then
                inventario.CadastrarInventario()
                MsgBox("Inventario cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            Else
                inventario.AtualizarInventario()
                MsgBox("Inventario Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If


        Catch ex As Exception
            MsgBox("Não foi possivel Salvar Registo no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Function StrToFloat(v As String) As String
        Throw New NotImplementedException()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Deseja excluir o item Inventario" & txtDesItem.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                inventario.seq_inventario = LbSeq.Text
                inventario.ExcluirInventario()
                MsgBox("Item Inventario excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Item Inventario, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpar()
    End Sub

    Private Sub txtCustoUn_Validated(sender As Object, e As EventArgs) Handles txtCustoUn.Validated
        If txtQtde.Text = "" Or txtCustoUn.Text = "" Then
            Exit Sub
        End If
        txtCustoTotal.Text = clGeral.mutiplicar(txtQtde.Text.Replace(".", ","), txtCustoUn.Text.Replace(".", ","))
    End Sub

    Private Sub txbCodEvento_TextChanged(sender As Object, e As EventArgs) Handles txtCodEvento.TextChanged
        If Not IsNumeric(txtCodEvento.Text) Then
            txtCodEvento.Text = ""
        End If
        Try
            clEvento.cod_evento = txtCodEvento.Text
            Dim ds1 As New DataSet
            ds1 = clEvento.ConsultarEvento
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            txtDesEvento.Text = linha.Item(1).ToString
        Catch ex As Exception
            txtDesEvento.Text = ""
        End Try


    End Sub

    Private Sub txbCodItem_TextChanged(sender As Object, e As EventArgs) Handles txtCodItem.TextChanged
        If Not IsNumeric(txtCodItem.Text) Then
            txtCodItem.Text = ""
        End If
        Try
            clItem.cod_item = txtCodItem.Text
            Dim ds1 As New DataSet
            ds1 = clItem.ConsultarItemCodigo
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            txtDesItem.Text = linha.Item(1).ToString
        Catch ex As Exception
            txtDesItem.Text = ""
        End Try
    End Sub
    Private Sub btMovimento_Click(sender As Object, e As EventArgs) Handles btMovimento.Click
        FrmPesquisa.tabela = "tab_tipo_movimento"
        FrmPesquisa.ShowDialog()
    End Sub
    Private Sub txtCodTipoMovimento_TextChanged(sender As Object, e As EventArgs) Handles txtCodTipoMovimento.TextChanged
        If Not IsNumeric(txtCodTipoMovimento.Text) Then
            txtCodTipoMovimento.Text = ""
        End If
        Try
            clTipoMovimento.cod_tipo_movimento = txtCodTipoMovimento.Text
            Dim ds1 As New DataSet
            ds1 = clTipoMovimento.ConsultarTipoMovimentoCodigo
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            txtDesTipoMovimento.Text = linha.Item(1).ToString
        Catch ex As Exception
            txtDesTipoMovimento.Text = ""
        End Try
    End Sub

    Private Sub txtCodEvento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodEvento.KeyPress
        clGeral.somenteNumero(e)
    End Sub

    Private Sub txtCodTipoMovimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodTipoMovimento.KeyPress
        clGeral.somenteNumero(e)
    End Sub

    Private Sub txtCodItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodItem.KeyPress
        clGeral.somenteNumero(e)
    End Sub

    Private Sub dgvInventario_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellEnter
        Try
            limpar()
            txtCodTipoMovimento.Text = ""
            txtDesTipoMovimento.Text = ""
            txtCodEvento.Text = ""
            txtDesEvento.Text = ""
            atualizar = 2
            inventario.seq_inventario = dgvInventario.CurrentRow.Cells(0).Value
            txtCodEvento.Text = dgvInventario.CurrentRow.Cells(1).Value
            txtCodTipoMovimento.Text = dgvInventario.CurrentRow.Cells(2).Value
            txtCodItem.Text = dgvInventario.CurrentRow.Cells(3).Value
            txtQtde.Text = dgvInventario.CurrentRow.Cells(4).Value
            txtCustoUn.Text = dgvInventario.CurrentRow.Cells(5).Value
            txtCustoTotal.Text = dgvInventario.CurrentRow.Cells(6).Value
            lbData.Text = dgvInventario.CurrentRow.Cells(7).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtQtde_TextChanged(sender As Object, e As EventArgs) Handles txtQtde.TextChanged
        If Not IsNumeric(txtQtde.Text) Then
            txtQtde.Text = ""
        End If
    End Sub

    Private Sub txtCustoUn_TextChanged(sender As Object, e As EventArgs) Handles txtCustoUn.TextChanged
        If Not IsNumeric(txtCustoUn.Text) Then
            txtCustoUn.Text = ""
        End If
    End Sub

    Private Sub txtCustoTotal_TextChanged(sender As Object, e As EventArgs) Handles txtCustoTotal.TextChanged
        If Not IsNumeric(txtCustoTotal.Text) Then
            txtCustoTotal.Text = ""
        End If
    End Sub
End Class