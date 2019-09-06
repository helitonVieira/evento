<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumoVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelMargemDeLucroBrutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelResumoIngressosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelDespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenciaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioRapidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxbCodItem = New System.Windows.Forms.TextBox()
        Me.LbDescricaoItem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbQtde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbCodEvento = New System.Windows.Forms.Label()
        Me.LbNomEvento = New System.Windows.Forms.Label()
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.LbNomeUsuario = New System.Windows.Forms.Label()
        Me.LbPermissaoUsuario = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocRelResumoVenda = New System.Drawing.Printing.PrintDocument()
        Me.lbLicencia = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentDespesa = New System.Drawing.Printing.PrintDocument()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbValorUnitario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbValorTotal = New System.Windows.Forms.TextBox()
        Me.DgvVenda = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbTotalGeral = New System.Windows.Forms.TextBox()
        Me.btnRemoverLinha = New System.Windows.Forms.Button()
        Me.BtnImprimirFicha = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBuscaItem = New System.Windows.Forms.ComboBox()
        Me.txbBuscaDesItem = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvPagamento = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxbSaldoRestante = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbTotalGeralPg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LbDesFormaPagto = New System.Windows.Forms.Label()
        Me.TxbTroco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbValorPagto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbCodFormaPagto = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbBuscaPessoa = New System.Windows.Forms.ComboBox()
        Me.TxbBuscaNomPessoa = New System.Windows.Forms.TextBox()
        Me.DgvPessoa = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DgvFormaPagto = New System.Windows.Forms.DataGridView()
        Me.btItemVenda = New System.Windows.Forms.Button()
        Me.BtBuscaItem = New System.Windows.Forms.Button()
        Me.BtBuscaPessoa = New System.Windows.Forms.Button()
        Me.GbCabecalho = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LbCodCliente = New System.Windows.Forms.Label()
        Me.LbNomCliente = New System.Windows.Forms.Label()
        Me.GbBotaoAtalho = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtPagamento = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DgvFormaPagto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCabecalho.SuspendLayout()
        Me.GbBotaoAtalho.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Purple
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.LicenciaToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.AdministrativoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1094, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventoToolStripMenuItem
        '
        Me.EventoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem1, Me.ItemToolStripMenuItem1, Me.PessoaToolStripMenuItem})
        Me.EventoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EventoToolStripMenuItem.Name = "EventoToolStripMenuItem"
        Me.EventoToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.EventoToolStripMenuItem.Text = "Cadastro"
        '
        'EventoToolStripMenuItem1
        '
        Me.EventoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImToolStripMenuItem})
        Me.EventoToolStripMenuItem1.Name = "EventoToolStripMenuItem1"
        Me.EventoToolStripMenuItem1.Size = New System.Drawing.Size(127, 26)
        Me.EventoToolStripMenuItem1.Text = "Evento"
        '
        'ImToolStripMenuItem
        '
        Me.ImToolStripMenuItem.Name = "ImToolStripMenuItem"
        Me.ImToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ImToolStripMenuItem.Text = "Imprimir Ingresso"
        '
        'ItemToolStripMenuItem1
        '
        Me.ItemToolStripMenuItem1.Name = "ItemToolStripMenuItem1"
        Me.ItemToolStripMenuItem1.Size = New System.Drawing.Size(127, 26)
        Me.ItemToolStripMenuItem1.Text = "Item"
        '
        'PessoaToolStripMenuItem
        '
        Me.PessoaToolStripMenuItem.Name = "PessoaToolStripMenuItem"
        Me.PessoaToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.PessoaToolStripMenuItem.Text = "Pessoa"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarToolStripMenuItem})
        Me.VendasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VendasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'BarToolStripMenuItem
        '
        Me.BarToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.BarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BarToolStripMenuItem.Name = "BarToolStripMenuItem"
        Me.BarToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.BarToolStripMenuItem.Text = "PDV"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumoVendasToolStripMenuItem, Me.RelMargemDeLucroBrutoToolStripMenuItem, Me.RelResumoIngressosToolStripMenuItem, Me.RelDespesaToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ResumoVendasToolStripMenuItem
        '
        Me.ResumoVendasToolStripMenuItem.Name = "ResumoVendasToolStripMenuItem"
        Me.ResumoVendasToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.ResumoVendasToolStripMenuItem.Text = "Rel. Resumo Vendas"
        '
        'RelMargemDeLucroBrutoToolStripMenuItem
        '
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Name = "RelMargemDeLucroBrutoToolStripMenuItem"
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Text = "Rel. Margem de Lucro Bruto"
        '
        'RelResumoIngressosToolStripMenuItem
        '
        Me.RelResumoIngressosToolStripMenuItem.Name = "RelResumoIngressosToolStripMenuItem"
        Me.RelResumoIngressosToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.RelResumoIngressosToolStripMenuItem.Text = "Rel. Resumo Ingressos"
        '
        'RelDespesaToolStripMenuItem
        '
        Me.RelDespesaToolStripMenuItem.Name = "RelDespesaToolStripMenuItem"
        Me.RelDespesaToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.RelDespesaToolStripMenuItem.Text = "Rel. Despesa"
        '
        'LicenciaToolStripMenuItem
        '
        Me.LicenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LicenciaToolStripMenuItem1})
        Me.LicenciaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LicenciaToolStripMenuItem.Name = "LicenciaToolStripMenuItem"
        Me.LicenciaToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.LicenciaToolStripMenuItem.Text = "Licencia"
        '
        'LicenciaToolStripMenuItem1
        '
        Me.LicenciaToolStripMenuItem1.Name = "LicenciaToolStripMenuItem1"
        Me.LicenciaToolStripMenuItem1.Size = New System.Drawing.Size(135, 26)
        Me.LicenciaToolStripMenuItem1.Text = "Licencia"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(101, 25)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioRapidoToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'InventarioRapidoToolStripMenuItem
        '
        Me.InventarioRapidoToolStripMenuItem.Name = "InventarioRapidoToolStripMenuItem"
        Me.InventarioRapidoToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.InventarioRapidoToolStripMenuItem.Text = "Inventario Rapido"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DespesaToolStripMenuItem})
        Me.AdministrativoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.AdministrativoToolStripMenuItem.Text = "Administrativo"
        '
        'DespesaToolStripMenuItem
        '
        Me.DespesaToolStripMenuItem.Name = "DespesaToolStripMenuItem"
        Me.DespesaToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.DespesaToolStripMenuItem.Text = "Despesa"
        '
        'TxbCodItem
        '
        Me.TxbCodItem.BackColor = System.Drawing.Color.Purple
        Me.TxbCodItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCodItem.ForeColor = System.Drawing.Color.White
        Me.TxbCodItem.Location = New System.Drawing.Point(6, 39)
        Me.TxbCodItem.Name = "TxbCodItem"
        Me.TxbCodItem.Size = New System.Drawing.Size(319, 80)
        Me.TxbCodItem.TabIndex = 1
        Me.TxbCodItem.Tag = "0"
        '
        'LbDescricaoItem
        '
        Me.LbDescricaoItem.AutoSize = True
        Me.LbDescricaoItem.BackColor = System.Drawing.Color.Transparent
        Me.LbDescricaoItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricaoItem.ForeColor = System.Drawing.Color.White
        Me.LbDescricaoItem.Location = New System.Drawing.Point(119, 3)
        Me.LbDescricaoItem.Name = "LbDescricaoItem"
        Me.LbDescricaoItem.Size = New System.Drawing.Size(0, 33)
        Me.LbDescricaoItem.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código"
        '
        'TxbQtde
        '
        Me.TxbQtde.BackColor = System.Drawing.Color.Purple
        Me.TxbQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbQtde.ForeColor = System.Drawing.Color.White
        Me.TxbQtde.Location = New System.Drawing.Point(6, 158)
        Me.TxbQtde.Name = "TxbQtde"
        Me.TxbQtde.Size = New System.Drawing.Size(319, 80)
        Me.TxbQtde.TabIndex = 2
        Me.TxbQtde.Tag = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantidade"
        '
        'LbCodEvento
        '
        Me.LbCodEvento.AutoSize = True
        Me.LbCodEvento.BackColor = System.Drawing.Color.Transparent
        Me.LbCodEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodEvento.ForeColor = System.Drawing.Color.White
        Me.LbCodEvento.Location = New System.Drawing.Point(6, 14)
        Me.LbCodEvento.Name = "LbCodEvento"
        Me.LbCodEvento.Size = New System.Drawing.Size(31, 20)
        Me.LbCodEvento.TabIndex = 8
        Me.LbCodEvento.Text = "TE"
        '
        'LbNomEvento
        '
        Me.LbNomEvento.AutoSize = True
        Me.LbNomEvento.BackColor = System.Drawing.Color.Transparent
        Me.LbNomEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEvento.ForeColor = System.Drawing.Color.White
        Me.LbNomEvento.Location = New System.Drawing.Point(43, 14)
        Me.LbNomEvento.Name = "LbNomEvento"
        Me.LbNomEvento.Size = New System.Drawing.Size(31, 20)
        Me.LbNomEvento.TabIndex = 9
        Me.LbNomEvento.Text = "TE"
        '
        'DgvItem
        '
        Me.DgvItem.AllowUserToAddRows = False
        Me.DgvItem.AllowUserToDeleteRows = False
        Me.DgvItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvItem.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItem.Location = New System.Drawing.Point(9, 55)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.ReadOnly = True
        Me.DgvItem.Size = New System.Drawing.Size(692, 447)
        Me.DgvItem.StandardTab = True
        Me.DgvItem.TabIndex = 1000
        '
        'LbNomeUsuario
        '
        Me.LbNomeUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomeUsuario.AutoSize = True
        Me.LbNomeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LbNomeUsuario.ForeColor = System.Drawing.Color.White
        Me.LbNomeUsuario.Location = New System.Drawing.Point(1014, 16)
        Me.LbNomeUsuario.Name = "LbNomeUsuario"
        Me.LbNomeUsuario.Size = New System.Drawing.Size(72, 13)
        Me.LbNomeUsuario.TabIndex = 12
        Me.LbNomeUsuario.Text = "nome Usuario"
        '
        'LbPermissaoUsuario
        '
        Me.LbPermissaoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbPermissaoUsuario.AutoSize = True
        Me.LbPermissaoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LbPermissaoUsuario.ForeColor = System.Drawing.Color.White
        Me.LbPermissaoUsuario.Location = New System.Drawing.Point(1014, 36)
        Me.LbPermissaoUsuario.Name = "LbPermissaoUsuario"
        Me.LbPermissaoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.LbPermissaoUsuario.TabIndex = 13
        Me.LbPermissaoUsuario.Text = "Label6"
        '
        'PrintDocument1
        '
        '
        'PrintDocRelResumoVenda
        '
        '
        'lbLicencia
        '
        Me.lbLicencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLicencia.AutoSize = True
        Me.lbLicencia.BackColor = System.Drawing.Color.Transparent
        Me.lbLicencia.Location = New System.Drawing.Point(922, 591)
        Me.lbLicencia.Name = "lbLicencia"
        Me.lbLicencia.Size = New System.Drawing.Size(45, 13)
        Me.lbLicencia.TabIndex = 14
        Me.lbLicencia.Text = "Licença"
        '
        'PrintDocument2
        '
        '
        'PrintDocument3
        '
        '
        'PrintDocumentDespesa
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 33)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Preço Unitario"
        '
        'TxbValorUnitario
        '
        Me.TxbValorUnitario.BackColor = System.Drawing.Color.Purple
        Me.TxbValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorUnitario.ForeColor = System.Drawing.Color.White
        Me.TxbValorUnitario.Location = New System.Drawing.Point(6, 277)
        Me.TxbValorUnitario.Name = "TxbValorUnitario"
        Me.TxbValorUnitario.Size = New System.Drawing.Size(319, 80)
        Me.TxbValorUnitario.TabIndex = 15
        Me.TxbValorUnitario.Tag = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 33)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Preço Total"
        '
        'TxbValorTotal
        '
        Me.TxbValorTotal.BackColor = System.Drawing.Color.Purple
        Me.TxbValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorTotal.ForeColor = System.Drawing.Color.White
        Me.TxbValorTotal.Location = New System.Drawing.Point(6, 396)
        Me.TxbValorTotal.Name = "TxbValorTotal"
        Me.TxbValorTotal.Size = New System.Drawing.Size(319, 80)
        Me.TxbValorTotal.TabIndex = 17
        Me.TxbValorTotal.Tag = "1"
        '
        'DgvVenda
        '
        Me.DgvVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvVenda.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenda.GridColor = System.Drawing.Color.White
        Me.DgvVenda.Location = New System.Drawing.Point(331, 39)
        Me.DgvVenda.Name = "DgvVenda"
        Me.DgvVenda.Size = New System.Drawing.Size(370, 318)
        Me.DgvVenda.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(387, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 33)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Venda"
        '
        'TxbTotalGeral
        '
        Me.TxbTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbTotalGeral.BackColor = System.Drawing.Color.Purple
        Me.TxbTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbTotalGeral.ForeColor = System.Drawing.Color.White
        Me.TxbTotalGeral.Location = New System.Drawing.Point(387, 397)
        Me.TxbTotalGeral.Name = "TxbTotalGeral"
        Me.TxbTotalGeral.Size = New System.Drawing.Size(314, 80)
        Me.TxbTotalGeral.TabIndex = 20
        Me.TxbTotalGeral.Tag = "1"
        '
        'btnRemoverLinha
        '
        Me.btnRemoverLinha.BackColor = System.Drawing.Color.Purple
        Me.btnRemoverLinha.ForeColor = System.Drawing.Color.White
        Me.btnRemoverLinha.Location = New System.Drawing.Point(572, 360)
        Me.btnRemoverLinha.Name = "btnRemoverLinha"
        Me.btnRemoverLinha.Size = New System.Drawing.Size(129, 36)
        Me.btnRemoverLinha.TabIndex = 22
        Me.btnRemoverLinha.Text = "Excluir Linha - F8"
        Me.btnRemoverLinha.UseVisualStyleBackColor = False
        '
        'BtnImprimirFicha
        '
        Me.BtnImprimirFicha.BackColor = System.Drawing.Color.Purple
        Me.BtnImprimirFicha.Enabled = False
        Me.BtnImprimirFicha.ForeColor = System.Drawing.Color.White
        Me.BtnImprimirFicha.Location = New System.Drawing.Point(26, 237)
        Me.BtnImprimirFicha.Name = "BtnImprimirFicha"
        Me.BtnImprimirFicha.Size = New System.Drawing.Size(149, 44)
        Me.BtnImprimirFicha.TabIndex = 23
        Me.BtnImprimirFicha.Text = "Imprimir Fichas - F9"
        Me.BtnImprimirFicha.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(367, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(715, 543)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxbQtde)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxbCodItem)
        Me.TabPage1.Controls.Add(Me.TxbTotalGeral)
        Me.TabPage1.Controls.Add(Me.LbDescricaoItem)
        Me.TabPage1.Controls.Add(Me.TxbValorUnitario)
        Me.TabPage1.Controls.Add(Me.btnRemoverLinha)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DgvVenda)
        Me.TabPage1.Controls.Add(Me.TxbValorTotal)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(707, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "VendaItem"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 479)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 17)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "F5 - Finalizar Venda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(147, 479)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 17)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "F6 - Alterar Cliente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(279, 479)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(165, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "F10 - Alterar Quantidade"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(450, 479)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "F12 - Busca Item"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DgvItem)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(707, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BuscaItem"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbBuscaItem)
        Me.GroupBox1.Controls.Add(Me.txbBuscaDesItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 43)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'cbBuscaItem
        '
        Me.cbBuscaItem.FormattingEnabled = True
        Me.cbBuscaItem.Location = New System.Drawing.Point(6, 15)
        Me.cbBuscaItem.Name = "cbBuscaItem"
        Me.cbBuscaItem.Size = New System.Drawing.Size(88, 21)
        Me.cbBuscaItem.TabIndex = 1
        '
        'txbBuscaDesItem
        '
        Me.txbBuscaDesItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbBuscaDesItem.Location = New System.Drawing.Point(100, 16)
        Me.txbBuscaDesItem.Name = "txbBuscaDesItem"
        Me.txbBuscaDesItem.Size = New System.Drawing.Size(217, 20)
        Me.txbBuscaDesItem.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.DgvPagamento)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.TxbSaldoRestante)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.TxbTotalGeralPg)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.LbDesFormaPagto)
        Me.TabPage3.Controls.Add(Me.TxbTroco)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.TxbValorPagto)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.TxbCodFormaPagto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(707, 517)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pagamento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(369, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 24)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "F1 -  Tela Itens"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(368, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 24)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "F12 - Busca Forma Pagto"
        '
        'DgvPagamento
        '
        Me.DgvPagamento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPagamento.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPagamento.GridColor = System.Drawing.Color.White
        Me.DgvPagamento.Location = New System.Drawing.Point(372, 43)
        Me.DgvPagamento.Name = "DgvPagamento"
        Me.DgvPagamento.Size = New System.Drawing.Size(319, 179)
        Me.DgvPagamento.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(22, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 33)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Saldo Restante"
        '
        'TxbSaldoRestante
        '
        Me.TxbSaldoRestante.BackColor = System.Drawing.Color.Purple
        Me.TxbSaldoRestante.Enabled = False
        Me.TxbSaldoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbSaldoRestante.ForeColor = System.Drawing.Color.White
        Me.TxbSaldoRestante.Location = New System.Drawing.Point(22, 161)
        Me.TxbSaldoRestante.Name = "TxbSaldoRestante"
        Me.TxbSaldoRestante.Size = New System.Drawing.Size(314, 80)
        Me.TxbSaldoRestante.TabIndex = 32
        Me.TxbSaldoRestante.Tag = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(22, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 33)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Total Venda"
        '
        'TxbTotalGeralPg
        '
        Me.TxbTotalGeralPg.BackColor = System.Drawing.Color.Purple
        Me.TxbTotalGeralPg.Enabled = False
        Me.TxbTotalGeralPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbTotalGeralPg.ForeColor = System.Drawing.Color.White
        Me.TxbTotalGeralPg.Location = New System.Drawing.Point(22, 43)
        Me.TxbTotalGeralPg.Name = "TxbTotalGeralPg"
        Me.TxbTotalGeralPg.Size = New System.Drawing.Size(314, 80)
        Me.TxbTotalGeralPg.TabIndex = 30
        Me.TxbTotalGeralPg.Tag = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(373, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 33)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Troco"
        '
        'LbDesFormaPagto
        '
        Me.LbDesFormaPagto.AutoSize = True
        Me.LbDesFormaPagto.BackColor = System.Drawing.Color.Transparent
        Me.LbDesFormaPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDesFormaPagto.ForeColor = System.Drawing.Color.White
        Me.LbDesFormaPagto.Location = New System.Drawing.Point(118, 240)
        Me.LbDesFormaPagto.Name = "LbDesFormaPagto"
        Me.LbDesFormaPagto.Size = New System.Drawing.Size(0, 33)
        Me.LbDesFormaPagto.TabIndex = 29
        '
        'TxbTroco
        '
        Me.TxbTroco.BackColor = System.Drawing.Color.Purple
        Me.TxbTroco.Enabled = False
        Me.TxbTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbTroco.ForeColor = System.Drawing.Color.White
        Me.TxbTroco.Location = New System.Drawing.Point(372, 320)
        Me.TxbTroco.Name = "TxbTroco"
        Me.TxbTroco.Size = New System.Drawing.Size(319, 80)
        Me.TxbTroco.TabIndex = 28
        Me.TxbTroco.Tag = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(22, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 33)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Valor Pagamento"
        '
        'TxbValorPagto
        '
        Me.TxbValorPagto.BackColor = System.Drawing.Color.Purple
        Me.TxbValorPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbValorPagto.ForeColor = System.Drawing.Color.White
        Me.TxbValorPagto.Location = New System.Drawing.Point(22, 403)
        Me.TxbValorPagto.Name = "TxbValorPagto"
        Me.TxbValorPagto.Size = New System.Drawing.Size(319, 80)
        Me.TxbValorPagto.TabIndex = 2
        Me.TxbValorPagto.Tag = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 33)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cód. "
        '
        'TxbCodFormaPagto
        '
        Me.TxbCodFormaPagto.BackColor = System.Drawing.Color.Purple
        Me.TxbCodFormaPagto.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxbCodFormaPagto.ForeColor = System.Drawing.Color.White
        Me.TxbCodFormaPagto.Location = New System.Drawing.Point(23, 276)
        Me.TxbCodFormaPagto.Name = "TxbCodFormaPagto"
        Me.TxbCodFormaPagto.Size = New System.Drawing.Size(319, 80)
        Me.TxbCodFormaPagto.TabIndex = 1
        Me.TxbCodFormaPagto.Tag = "0"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.DgvPessoa)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(707, 517)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "BuscaPessoa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.CbBuscaPessoa)
        Me.GroupBox2.Controls.Add(Me.TxbBuscaNomPessoa)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(701, 43)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'CbBuscaPessoa
        '
        Me.CbBuscaPessoa.FormattingEnabled = True
        Me.CbBuscaPessoa.Location = New System.Drawing.Point(6, 15)
        Me.CbBuscaPessoa.Name = "CbBuscaPessoa"
        Me.CbBuscaPessoa.Size = New System.Drawing.Size(88, 24)
        Me.CbBuscaPessoa.TabIndex = 1
        '
        'TxbBuscaNomPessoa
        '
        Me.TxbBuscaNomPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbBuscaNomPessoa.Location = New System.Drawing.Point(100, 16)
        Me.TxbBuscaNomPessoa.Name = "TxbBuscaNomPessoa"
        Me.TxbBuscaNomPessoa.Size = New System.Drawing.Size(217, 22)
        Me.TxbBuscaNomPessoa.TabIndex = 0
        '
        'DgvPessoa
        '
        Me.DgvPessoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPessoa.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPessoa.GridColor = System.Drawing.Color.White
        Me.DgvPessoa.Location = New System.Drawing.Point(6, 55)
        Me.DgvPessoa.Name = "DgvPessoa"
        Me.DgvPessoa.Size = New System.Drawing.Size(695, 425)
        Me.DgvPessoa.TabIndex = 20
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.DgvFormaPagto)
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(707, 517)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "FormaPagto"
        '
        'DgvFormaPagto
        '
        Me.DgvFormaPagto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFormaPagto.BackgroundColor = System.Drawing.Color.Purple
        Me.DgvFormaPagto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvFormaPagto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvFormaPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFormaPagto.GridColor = System.Drawing.Color.White
        Me.DgvFormaPagto.Location = New System.Drawing.Point(3, 3)
        Me.DgvFormaPagto.Name = "DgvFormaPagto"
        Me.DgvFormaPagto.Size = New System.Drawing.Size(701, 483)
        Me.DgvFormaPagto.TabIndex = 26
        '
        'btItemVenda
        '
        Me.btItemVenda.BackColor = System.Drawing.Color.Purple
        Me.btItemVenda.Enabled = False
        Me.btItemVenda.ForeColor = System.Drawing.Color.White
        Me.btItemVenda.Location = New System.Drawing.Point(26, 30)
        Me.btItemVenda.Name = "btItemVenda"
        Me.btItemVenda.Size = New System.Drawing.Size(149, 44)
        Me.btItemVenda.TabIndex = 24
        Me.btItemVenda.Text = "Item Venda - F1"
        Me.btItemVenda.UseVisualStyleBackColor = False
        '
        'BtBuscaItem
        '
        Me.BtBuscaItem.BackColor = System.Drawing.Color.Purple
        Me.BtBuscaItem.Enabled = False
        Me.BtBuscaItem.ForeColor = System.Drawing.Color.White
        Me.BtBuscaItem.Location = New System.Drawing.Point(26, 111)
        Me.BtBuscaItem.Name = "BtBuscaItem"
        Me.BtBuscaItem.Size = New System.Drawing.Size(149, 44)
        Me.BtBuscaItem.TabIndex = 25
        Me.BtBuscaItem.Text = "Pesquisa - F12"
        Me.BtBuscaItem.UseVisualStyleBackColor = False
        '
        'BtBuscaPessoa
        '
        Me.BtBuscaPessoa.BackColor = System.Drawing.Color.Purple
        Me.BtBuscaPessoa.Enabled = False
        Me.BtBuscaPessoa.ForeColor = System.Drawing.Color.White
        Me.BtBuscaPessoa.Location = New System.Drawing.Point(26, 153)
        Me.BtBuscaPessoa.Name = "BtBuscaPessoa"
        Me.BtBuscaPessoa.Size = New System.Drawing.Size(149, 44)
        Me.BtBuscaPessoa.TabIndex = 26
        Me.BtBuscaPessoa.Text = "Pesquisa Cliente - F6"
        Me.BtBuscaPessoa.UseVisualStyleBackColor = False
        '
        'GbCabecalho
        '
        Me.GbCabecalho.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbCabecalho.BackColor = System.Drawing.Color.Purple
        Me.GbCabecalho.Controls.Add(Me.Label18)
        Me.GbCabecalho.Controls.Add(Me.LbCodCliente)
        Me.GbCabecalho.Controls.Add(Me.LbNomCliente)
        Me.GbCabecalho.Controls.Add(Me.LbCodEvento)
        Me.GbCabecalho.Controls.Add(Me.LbNomEvento)
        Me.GbCabecalho.Controls.Add(Me.LbPermissaoUsuario)
        Me.GbCabecalho.Controls.Add(Me.LbNomeUsuario)
        Me.GbCabecalho.Location = New System.Drawing.Point(0, 32)
        Me.GbCabecalho.Name = "GbCabecalho"
        Me.GbCabecalho.Size = New System.Drawing.Size(1094, 36)
        Me.GbCabecalho.TabIndex = 27
        Me.GbCabecalho.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(365, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Cliente:"
        '
        'LbCodCliente
        '
        Me.LbCodCliente.AutoSize = True
        Me.LbCodCliente.BackColor = System.Drawing.Color.Transparent
        Me.LbCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodCliente.ForeColor = System.Drawing.Color.White
        Me.LbCodCliente.Location = New System.Drawing.Point(443, 16)
        Me.LbCodCliente.Name = "LbCodCliente"
        Me.LbCodCliente.Size = New System.Drawing.Size(29, 20)
        Me.LbCodCliente.TabIndex = 14
        Me.LbCodCliente.Text = "Cli"
        '
        'LbNomCliente
        '
        Me.LbNomCliente.AutoSize = True
        Me.LbNomCliente.BackColor = System.Drawing.Color.Transparent
        Me.LbNomCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomCliente.ForeColor = System.Drawing.Color.White
        Me.LbNomCliente.Location = New System.Drawing.Point(491, 16)
        Me.LbNomCliente.Name = "LbNomCliente"
        Me.LbNomCliente.Size = New System.Drawing.Size(63, 20)
        Me.LbNomCliente.TabIndex = 15
        Me.LbNomCliente.Text = "nomCli"
        '
        'GbBotaoAtalho
        '
        Me.GbBotaoAtalho.Controls.Add(Me.PictureBox1)
        Me.GbBotaoAtalho.Controls.Add(Me.Button1)
        Me.GbBotaoAtalho.Controls.Add(Me.BtPagamento)
        Me.GbBotaoAtalho.Controls.Add(Me.btItemVenda)
        Me.GbBotaoAtalho.Controls.Add(Me.BtBuscaItem)
        Me.GbBotaoAtalho.Controls.Add(Me.BtBuscaPessoa)
        Me.GbBotaoAtalho.Controls.Add(Me.BtnImprimirFicha)
        Me.GbBotaoAtalho.Location = New System.Drawing.Point(0, 106)
        Me.GbBotaoAtalho.Name = "GbBotaoAtalho"
        Me.GbBotaoAtalho.Size = New System.Drawing.Size(361, 480)
        Me.GbBotaoAtalho.TabIndex = 16
        Me.GbBotaoAtalho.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(26, 287)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 193)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(26, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Quantidade - F10"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtPagamento
        '
        Me.BtPagamento.BackColor = System.Drawing.Color.Purple
        Me.BtPagamento.Enabled = False
        Me.BtPagamento.ForeColor = System.Drawing.Color.White
        Me.BtPagamento.Location = New System.Drawing.Point(26, 195)
        Me.BtPagamento.Name = "BtPagamento"
        Me.BtPagamento.Size = New System.Drawing.Size(149, 44)
        Me.BtPagamento.TabIndex = 27
        Me.BtPagamento.Text = "Pagamento - F5"
        Me.BtPagamento.UseVisualStyleBackColor = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.GbBotaoAtalho)
        Me.Controls.Add(Me.GbCabecalho)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbLicencia)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos System              Heliton(034)996451318"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DgvPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DgvFormaPagto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCabecalho.ResumeLayout(False)
        Me.GbCabecalho.PerformLayout()
        Me.GbBotaoAtalho.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TxbCodItem As TextBox
    Friend WithEvents LbDescricaoItem As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbQtde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EventoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbCodEvento As Label
    Friend WithEvents LbNomEvento As Label
    Friend WithEvents LbNomeUsuario As Label
    Friend WithEvents LbPermissaoUsuario As Label
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DgvItem As DataGridView
    Friend WithEvents ResumoVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocRelResumoVenda As Printing.PrintDocument
    Friend WithEvents LicenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenciaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lbLicencia As Label
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioRapidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelMargemDeLucroBrutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents RelResumoIngressosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PessoaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DespesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelDespesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocumentDespesa As Printing.PrintDocument
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbValorUnitario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbValorTotal As TextBox
    Friend WithEvents DgvVenda As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbTotalGeral As TextBox
    Friend WithEvents btnRemoverLinha As Button
    Friend WithEvents BtnImprimirFicha As Button
    Friend WithEvents ImToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btItemVenda As Button
    Friend WithEvents BtBuscaItem As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvFormaPagto As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbCodFormaPagto As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DgvPessoa As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbBuscaItem As ComboBox
    Friend WithEvents txbBuscaDesItem As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbBuscaPessoa As ComboBox
    Friend WithEvents TxbBuscaNomPessoa As TextBox
    Friend WithEvents BtBuscaPessoa As Button
    Friend WithEvents GbCabecalho As GroupBox
    Friend WithEvents LbCodCliente As Label
    Friend WithEvents LbNomCliente As Label
    Friend WithEvents GbBotaoAtalho As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbValorPagto As TextBox
    Friend WithEvents BtPagamento As Button
    Friend WithEvents LbDesFormaPagto As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbTroco As TextBox
    Friend WithEvents DgvPagamento As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents TxbSaldoRestante As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbTotalGeralPg As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
