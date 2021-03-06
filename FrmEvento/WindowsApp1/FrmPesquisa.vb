﻿Public Class FrmPesquisa
    Dim conectar As New ConexaoSQL
    Dim ds As New DataSet
    Dim item As New ClItem1
    Dim inventario As New FrmInventarioRapido
    Dim clTipoMovto As New ClTipoMovimento
    Dim clTipoDespesa As New ClTipoDespesa
    Dim clAlmoxarifado As New ClAlmoxarifado
    Dim clSecao As New ClSecaoItem
    Dim clCategoria As New ClCategoriaItem
    Dim clSubCategoria As New ClSubCategoriaItem
    Dim clFuncao As New ClFuncaoFuncionario
    Dim clAnimalVacina As PetSystem.ClVacina
    Dim clAnimaControleParasita As PetSystem.ClControleParasita
    Dim clAnimalraca As PetSystem.ClRaca
    Dim clAnimalPelagem As PetSystem.ClPelagem
    Dim clAnimalEspecie As PetSystem.ClEspecie
    Dim pessoa As New ClPessoa
    Dim ingressoImpresso As New ClIngressoImpresso
    Dim evento As New ClEvento
    Dim clFuncao_func As New ClFuncaoFuncionario
    Dim clUnidade As New ClUnidade
    Dim clMarca As New ClMarca
    Dim clCidade As New ClCidade
    Dim clEspecieCaixa As New ClEspecieCaixa
    Dim clBanco As New ClBanco
    Dim clTipoParcelamento As New ClTipoParcelamento

    Private cod_evento_ As Integer
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property

    Private tabela_ As String
    Public Property tabela() As String
        Get
            Return tabela_
        End Get
        Set(ByVal value As String)
            tabela_ = value
        End Set
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega(tabela, "")
    End Sub
    Public Sub carrega(tabela As String, busca As String)
        Try
            ds.Clear()
            cbBusca.Items.Clear()
            cbBusca.Items.Add("Codigo")
            cbBusca.Items.Add("Descricao")
            Dim tab As DataTable
            If tabela = "tab_item" Then
                ds = item.ConsultarItemPesquisa(busca)
            ElseIf tabela = "tab_tipo_despesa" Then
                ds = clTipoDespesa.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_tipo_movimento" Then
                ds = clTipoMovto.ConsultarTipoMovtoPesquisa(busca)
            ElseIf tabela = "tab_pessoa" Or tabela = "tab_pessoa_despesa" Then
                ds = pessoa.ConsultarPessoa(busca)
            ElseIf tabela = "funcionarioDespesa" Then
                ds = pessoa.ConsultarPessoaFuncionario(busca)
            ElseIf tabela = "tab_ingresso_impresso" Then
                ingressoImpresso.cod_evento = cod_evento
                ds = ingressoImpresso.ConsultarIngressoImpressoAberto()
            ElseIf tabela = "tab_evento_despesa" Or tabela = "tab_evento_principal" Then
                ds = evento.ConsultarEvento()
            ElseIf tabela = "tab_evento" Then
                ds = evento.ConsultarEventoAberto()
            ElseIf tabela = "tab_almoxarifado_secao" Then
                ds = clAlmoxarifado.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_secao_categoria" Then
                ds = clSecao.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_categoria_subcategoria" Then
                ds = clCategoria.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_subcategoria_item" Then
                ds = clSubCategoria.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_fornecedor_item" Then
                ds = pessoa.ConsultarPessoaFornecedor(busca)
            ElseIf tabela = "tab_funcao_func_pessoa" Then
                ds = clFuncao_func.ConsultarFuncaoFuncionarioPesquisa(busca)
            ElseIf tabela = "tab_unidade_item" Then
                ds = clUnidade.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_unidade_item_barra" Then
                ds = ClUnidade.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_marca_item" Then
                ds = clMarca.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_cidade_pessoa" Then
                ds = clCidade.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_pessoa_despesa" Then
                ds = pessoa.ConsultarPessoa(busca)
            ElseIf tabela = "tab_especie_pagamento" Then
                ds = clEspecieCaixa.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_banco_pagamento" Then
                ds = clBanco.ConsultarPesquisa(busca)
            ElseIf tabela = "tab_tipo_parcelamento_pagamento" Then
                ds = ClTipoParcelamento.ConsultarPesquisa(busca)
            End If
            tab = ds.Tables(0)
            If tab.Rows.Count > 0 Then
                dgvBusca.DataSource = ds.Tables(0)
                With dgvBusca
                    .Columns(0).HeaderText = "Código"
                    .Columns(1).HeaderText = "Descrição"
                    .Columns(0).Width = 60
                    .Columns(1).Width = 240
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txbBusca.TextChanged
        carrega(tabela, txbBusca.Text)
    End Sub

    Private Sub dgvBusca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusca.CellClick
        If tabela = "tab_item" Then
            FrmInventarioRapido.txtCodItem.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmInventarioRapido.txtDesItem.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_pessoa" Then
            FrmEvento.TxbCodPessoaIP.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmEvento.TxbNomPessoaIP.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_ingresso_impresso" Then
            FrmEvento.TxbCodImpressaoIP.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmEvento.TxbDesImpressaoIP.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_evento" Then
            FrmInventarioRapido.txtCodEvento.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmInventarioRapido.txtDesEvento.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_evento_principal" Then
            FrmPrincipal.codEvento = dgvBusca.CurrentRow.Cells(0).Value
            FrmPrincipal.nomEvento = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_pessoa_despesa" Then
            FrmDespesas.TxbCodFavorecido.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesas.TxbNomFavorecido.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_tipo_despesa" Then
            FrmDespesas.TxbCodTipo.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesas.TxbDesTipo.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_tipo_movimento" Then
            FrmInventarioRapido.txtCodTipoMovimento.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmInventarioRapido.txtDesTipoMovimento.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_almoxarifado_secao" Then
            FrmSecao.TxbCodAlmoxarifado.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmSecao.txbDesAlmoxarifado.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_secao_categoria" Then
            FrmCategoria.TxbCodSecao.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmCategoria.txbDesSecao.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_categoria_subcategoria" Then
            FrmSubCategoria.TxbCodCategoria.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmSubCategoria.txbDesCategoria.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_subcategoria_item" Then
            FrmItem.txbCodSubcategoria.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmItem.TxbDesSubcategoria.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_unidade_item" Then
            FrmItem.TxbCodUnidade.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmItem.TxbDesUnidade.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_marca_item" Then
            FrmItem.TxbCodMarca.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmItem.TxbDesMarca.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_funcao_func_pessoa" Then
            FrmPessoa.TxbCodFuncaoFunc.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmPessoa.txbDesFuncaoFunc.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_cidade_pessoa" Then
            FrmPessoa.TxbCodCidade.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmPessoa.TxbNomCidade.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_fornecedor_item" Then
            FrmItem.TxbCodFornecedor.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmItem.TxbNomFornecedor.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If tabela = "tab_unidade_item_barra" Then
            FrmItem.TxbUnidadeBarra.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmItem.TxbDesUnidadeBarra.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        If ((tabela = "tab_especie_pagamento") Or (tabela = "tab_banco_pagamento") Or (tabela = "tab_tipo_parcelamento_pagamento")) Then
            ModVariavelGlobal.pesquisaCodigo = dgvBusca.CurrentRow.Cells(0).Value
            ModVariavelGlobal.pesquisaNome = dgvBusca.CurrentRow.Cells(1).Value
        End If

        Me.Close()
    End Sub
End Class