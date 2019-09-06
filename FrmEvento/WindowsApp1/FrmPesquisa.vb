Public Class FrmPesquisa
    Dim conectar As New ConexaoSQ
    Dim ds As New DataSet
    Dim item As New ClItem
    Dim inventario As New FrmInventarioRapido
    Dim clTipoMovto As New ClTipoMovimento
    Dim clTipoDespesa As New ClTipoDespesa
    Dim pessoa As New ClPessoa
    Dim ingressoImpresso As New ClIngressoImpresso
    Dim evento As New ClEvento

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
            If tabela = "tab_item" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Codigo")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                ds = item.ConsultarItemPesquisa(busca)
                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(0).Width = 60
                        .Columns(1).Width = 200
                    End With
                End If
            End If

            If tabela = "tab_tipo_despesa" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Codigo")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                ds = clTipoDespesa.ConsultarTipoDespesa(busca)
                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(0).Width = 60
                        .Columns(1).Width = 200
                    End With
                End If
            End If

            If tabela = "tab_tipo_movimento" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Codigo")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                ds = clTipoMovto.ConsultarTipoMovtoPesquisa(busca)
                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(0).Width = 60
                        .Columns(1).Width = 200
                    End With
                End If
            End If

            If tabela = "tab_pessoa" Or tabela = "tab_pessoa_despesa" Or tabela = "funcionarioDespesa" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Codigo")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                If tabela = "funcionarioDespesa" Then
                    ds = pessoa.ConsultarPessoaFuncionario(busca)
                Else
                    ds = pessoa.ConsultarPessoa(busca)
                End If
                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(0).Width = 60
                        .Columns(1).Width = 200
                    End With
                End If
            End If

            If tabela = "tab_ingresso_impresso" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Codigo")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                ingressoImpresso.cod_evento = cod_evento
                ds = ingressoImpresso.ConsultarIngressoImpressoAberto()
                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(0).Width = 60
                        .Columns(1).Width = 200
                    End With
                End If
            End If

            If tabela = "tab_evento" Or tabela = "tab_evento_despesa" Or tabela = "tab_evento_principal" Then
                cbBusca.Items.Clear()
                cbBusca.Items.Add("Data")
                cbBusca.Items.Add("Descricao")
                Dim tab As DataTable
                If tabela = "tab_evento" Then
                    ds = evento.ConsultarEventoAberto()
                Else
                    ds = evento.ConsultarEvento()
                End If

                tab = ds.Tables(0)
                If tab.Rows.Count > 0 Then
                    dgvBusca.DataSource = ds.Tables(0)
                    With dgvBusca
                        .Columns(0).HeaderText = "Código"
                        .Columns(1).HeaderText = "Descrição"
                        .Columns(2).HeaderText = "Descrição"
                        .Columns(3).HeaderText = "Descrição"
                        .Columns(4).HeaderText = "Data"
                        .Columns(0).Width = 40
                        .Columns(1).Width = 100
                        .Columns(0).Width = 100
                        .Columns(1).Width = 100
                    End With
                End If
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
            FrmDespesa.TxbCodFavorecido.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesa.TxbNomFavorecido.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "funcionarioDespesa" Then
            FrmDespesa.TxbCodFuncionario.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesa.TxbNomFuncionario.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_evento_despesa" Then
            FrmDespesa.TxbCodEvento.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesa.txbnomEvento.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_tipo_despesa" Then
            FrmDespesa.txbCodTipoDespesa.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmDespesa.txbDesTipoDespesa.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If

        If tabela = "tab_tipo_movimento" Then
            FrmInventarioRapido.txtCodTipoMovimento.Text = dgvBusca.CurrentRow.Cells(0).Value
            FrmInventarioRapido.txtDesTipoMovimento.Text = dgvBusca.CurrentRow.Cells(1).Value
        End If
        Me.Close()
    End Sub
End Class