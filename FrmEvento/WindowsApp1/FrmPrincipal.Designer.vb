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
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespesaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoReceitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceitaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PessoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunçãoFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmoxarifadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioRapidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDV1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirIngressoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumoVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelMargemDeLucroBrutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelResumoIngressosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelDespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspécieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaçaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelagemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacinaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParasitaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirIngressoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicençaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecíeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecíeCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BancoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParcelamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoParcelamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocRelResumoVenda = New System.Drawing.Printing.PrintDocument()
        Me.lbLicencia = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocumentDespesa = New System.Drawing.Printing.PrintDocument()
        Me.LbNomeUsuario = New System.Windows.Forms.Label()
        Me.LbPermissaoUsuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Purple
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrativoToolStripMenuItem, Me.EventoToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.PetToolStripMenuItem, Me.EventosToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.FinanceiroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1094, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DespesaToolStripMenuItem, Me.ReceitaToolStripMenuItem})
        Me.AdministrativoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.AdministrativoToolStripMenuItem.Text = "Administrativo"
        '
        'DespesaToolStripMenuItem
        '
        Me.DespesaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDespesaToolStripMenuItem, Me.DespesaToolStripMenuItem1})
        Me.DespesaToolStripMenuItem.Name = "DespesaToolStripMenuItem"
        Me.DespesaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DespesaToolStripMenuItem.Text = "Despesa"
        '
        'TipoDespesaToolStripMenuItem
        '
        Me.TipoDespesaToolStripMenuItem.Name = "TipoDespesaToolStripMenuItem"
        Me.TipoDespesaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoDespesaToolStripMenuItem.Text = "Tipo Despesa"
        '
        'DespesaToolStripMenuItem1
        '
        Me.DespesaToolStripMenuItem1.Name = "DespesaToolStripMenuItem1"
        Me.DespesaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DespesaToolStripMenuItem1.Text = "Despesa"
        '
        'ReceitaToolStripMenuItem
        '
        Me.ReceitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoReceitaToolStripMenuItem, Me.ReceitaToolStripMenuItem1})
        Me.ReceitaToolStripMenuItem.Name = "ReceitaToolStripMenuItem"
        Me.ReceitaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReceitaToolStripMenuItem.Text = "Receita"
        '
        'TipoReceitaToolStripMenuItem
        '
        Me.TipoReceitaToolStripMenuItem.Name = "TipoReceitaToolStripMenuItem"
        Me.TipoReceitaToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.TipoReceitaToolStripMenuItem.Text = "Tipo Receita"
        '
        'ReceitaToolStripMenuItem1
        '
        Me.ReceitaToolStripMenuItem1.Name = "ReceitaToolStripMenuItem1"
        Me.ReceitaToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.ReceitaToolStripMenuItem1.Text = "Receita"
        '
        'EventoToolStripMenuItem
        '
        Me.EventoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PessoaToolStripMenuItem, Me.FuncionárioToolStripMenuItem})
        Me.EventoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EventoToolStripMenuItem.Name = "EventoToolStripMenuItem"
        Me.EventoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EventoToolStripMenuItem.Text = "Pessoa"
        '
        'PessoaToolStripMenuItem
        '
        Me.PessoaToolStripMenuItem.Name = "PessoaToolStripMenuItem"
        Me.PessoaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PessoaToolStripMenuItem.Text = "Pessoa"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunçãoFuncionárioToolStripMenuItem})
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FuncionárioToolStripMenuItem.Text = "Funcionário"
        '
        'FunçãoFuncionárioToolStripMenuItem
        '
        Me.FunçãoFuncionárioToolStripMenuItem.Name = "FunçãoFuncionárioToolStripMenuItem"
        Me.FunçãoFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FunçãoFuncionárioToolStripMenuItem.Text = "Função Funcionário"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem, Me.InventarioRapidoToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmoxarifadoToolStripMenuItem1, Me.SeçãoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.SubCategoriaToolStripMenuItem, Me.ItemToolStripMenuItem1, Me.ToolStripMenuItem2, Me.UnidadeToolStripMenuItem, Me.MarcaToolStripMenuItem})
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'AlmoxarifadoToolStripMenuItem1
        '
        Me.AlmoxarifadoToolStripMenuItem1.Name = "AlmoxarifadoToolStripMenuItem1"
        Me.AlmoxarifadoToolStripMenuItem1.Size = New System.Drawing.Size(270, 22)
        Me.AlmoxarifadoToolStripMenuItem1.Text = "Almoxarifado"
        '
        'SeçãoToolStripMenuItem
        '
        Me.SeçãoToolStripMenuItem.Name = "SeçãoToolStripMenuItem"
        Me.SeçãoToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.SeçãoToolStripMenuItem.Text = "Seção"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'SubCategoriaToolStripMenuItem
        '
        Me.SubCategoriaToolStripMenuItem.Name = "SubCategoriaToolStripMenuItem"
        Me.SubCategoriaToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.SubCategoriaToolStripMenuItem.Text = "SubCategoria"
        '
        'ItemToolStripMenuItem1
        '
        Me.ItemToolStripMenuItem1.Name = "ItemToolStripMenuItem1"
        Me.ItemToolStripMenuItem1.Size = New System.Drawing.Size(270, 22)
        Me.ItemToolStripMenuItem1.Text = "Item"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(270, 22)
        Me.ToolStripMenuItem2.Text = "-------------------------------------------------"
        '
        'UnidadeToolStripMenuItem
        '
        Me.UnidadeToolStripMenuItem.Name = "UnidadeToolStripMenuItem"
        Me.UnidadeToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.UnidadeToolStripMenuItem.Text = "Unidade"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'InventarioRapidoToolStripMenuItem
        '
        Me.InventarioRapidoToolStripMenuItem.Name = "InventarioRapidoToolStripMenuItem"
        Me.InventarioRapidoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.InventarioRapidoToolStripMenuItem.Text = "Inventario Rapido"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarToolStripMenuItem, Me.ImprimirIngressoToolStripMenuItem})
        Me.VendasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VendasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'BarToolStripMenuItem
        '
        Me.BarToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.BarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDV1ToolStripMenuItem})
        Me.BarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BarToolStripMenuItem.Name = "BarToolStripMenuItem"
        Me.BarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.BarToolStripMenuItem.Text = "PDV"
        '
        'PDV1ToolStripMenuItem
        '
        Me.PDV1ToolStripMenuItem.Name = "PDV1ToolStripMenuItem"
        Me.PDV1ToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.PDV1ToolStripMenuItem.Text = "PDV 1"
        '
        'ImprimirIngressoToolStripMenuItem
        '
        Me.ImprimirIngressoToolStripMenuItem.Name = "ImprimirIngressoToolStripMenuItem"
        Me.ImprimirIngressoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ImprimirIngressoToolStripMenuItem.Text = "Imprimir Ingresso"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumoVendasToolStripMenuItem, Me.RelMargemDeLucroBrutoToolStripMenuItem, Me.RelResumoIngressosToolStripMenuItem, Me.RelDespesaToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'ResumoVendasToolStripMenuItem
        '
        Me.ResumoVendasToolStripMenuItem.Name = "ResumoVendasToolStripMenuItem"
        Me.ResumoVendasToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ResumoVendasToolStripMenuItem.Text = "Rel. Resumo Vendas"
        '
        'RelMargemDeLucroBrutoToolStripMenuItem
        '
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Name = "RelMargemDeLucroBrutoToolStripMenuItem"
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RelMargemDeLucroBrutoToolStripMenuItem.Text = "Rel. Margem de Lucro Bruto"
        '
        'RelResumoIngressosToolStripMenuItem
        '
        Me.RelResumoIngressosToolStripMenuItem.Name = "RelResumoIngressosToolStripMenuItem"
        Me.RelResumoIngressosToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RelResumoIngressosToolStripMenuItem.Text = "Rel. Resumo Ingressos"
        '
        'RelDespesaToolStripMenuItem
        '
        Me.RelDespesaToolStripMenuItem.Name = "RelDespesaToolStripMenuItem"
        Me.RelDespesaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.RelDespesaToolStripMenuItem.Text = "Rel. Despesa"
        '
        'PetToolStripMenuItem
        '
        Me.PetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnimalToolStripMenuItem, Me.VacinaToolStripMenuItem1, Me.ParasitaToolStripMenuItem1})
        Me.PetToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PetToolStripMenuItem.Name = "PetToolStripMenuItem"
        Me.PetToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.PetToolStripMenuItem.Text = "Pet"
        '
        'AnimalToolStripMenuItem
        '
        Me.AnimalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspécieToolStripMenuItem, Me.RaçaToolStripMenuItem, Me.PelagemToolStripMenuItem})
        Me.AnimalToolStripMenuItem.Name = "AnimalToolStripMenuItem"
        Me.AnimalToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AnimalToolStripMenuItem.Text = "Animal"
        '
        'EspécieToolStripMenuItem
        '
        Me.EspécieToolStripMenuItem.Name = "EspécieToolStripMenuItem"
        Me.EspécieToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EspécieToolStripMenuItem.Text = "Espécie"
        '
        'RaçaToolStripMenuItem
        '
        Me.RaçaToolStripMenuItem.Name = "RaçaToolStripMenuItem"
        Me.RaçaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RaçaToolStripMenuItem.Text = "Raça"
        '
        'PelagemToolStripMenuItem
        '
        Me.PelagemToolStripMenuItem.Name = "PelagemToolStripMenuItem"
        Me.PelagemToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.PelagemToolStripMenuItem.Text = "Pelagem"
        '
        'VacinaToolStripMenuItem1
        '
        Me.VacinaToolStripMenuItem1.Name = "VacinaToolStripMenuItem1"
        Me.VacinaToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.VacinaToolStripMenuItem1.Text = "Controle Vacina"
        '
        'ParasitaToolStripMenuItem1
        '
        Me.ParasitaToolStripMenuItem1.Name = "ParasitaToolStripMenuItem1"
        Me.ParasitaToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ParasitaToolStripMenuItem1.Text = "Controle Parasita"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem2})
        Me.EventosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.EventosToolStripMenuItem.Text = "Eventos"
        '
        'EventoToolStripMenuItem2
        '
        Me.EventoToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem1, Me.ImprimirIngressoToolStripMenuItem1})
        Me.EventoToolStripMenuItem2.Name = "EventoToolStripMenuItem2"
        Me.EventoToolStripMenuItem2.Size = New System.Drawing.Size(109, 22)
        Me.EventoToolStripMenuItem2.Text = "Evento"
        '
        'EventoToolStripMenuItem1
        '
        Me.EventoToolStripMenuItem1.Name = "EventoToolStripMenuItem1"
        Me.EventoToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.EventoToolStripMenuItem1.Text = "Evento"
        '
        'ImprimirIngressoToolStripMenuItem1
        '
        Me.ImprimirIngressoToolStripMenuItem1.Name = "ImprimirIngressoToolStripMenuItem1"
        Me.ImprimirIngressoToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ImprimirIngressoToolStripMenuItem1.Text = "Imprimir Ingresso"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosSistemaToolStripMenuItem, Me.LicençaToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ParametrosToolStripMenuItem.Text = "Sistema"
        '
        'ParametrosSistemaToolStripMenuItem
        '
        Me.ParametrosSistemaToolStripMenuItem.Name = "ParametrosSistemaToolStripMenuItem"
        Me.ParametrosSistemaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ParametrosSistemaToolStripMenuItem.Text = "Parametros Sistema"
        '
        'LicençaToolStripMenuItem
        '
        Me.LicençaToolStripMenuItem.Name = "LicençaToolStripMenuItem"
        Me.LicençaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LicençaToolStripMenuItem.Text = "Licença"
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspecíeToolStripMenuItem, Me.BancoToolStripMenuItem, Me.ParcelamentoToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FinanceiroToolStripMenuItem.Text = "Financeiro"
        '
        'EspecíeToolStripMenuItem
        '
        Me.EspecíeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EspecíeCaixaToolStripMenuItem})
        Me.EspecíeToolStripMenuItem.Name = "EspecíeToolStripMenuItem"
        Me.EspecíeToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EspecíeToolStripMenuItem.Text = "Especíe"
        '
        'EspecíeCaixaToolStripMenuItem
        '
        Me.EspecíeCaixaToolStripMenuItem.Name = "EspecíeCaixaToolStripMenuItem"
        Me.EspecíeCaixaToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.EspecíeCaixaToolStripMenuItem.Text = "Especíe Caixa"
        '
        'BancoToolStripMenuItem
        '
        Me.BancoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BancoToolStripMenuItem1})
        Me.BancoToolStripMenuItem.Name = "BancoToolStripMenuItem"
        Me.BancoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BancoToolStripMenuItem.Text = "Banco"
        '
        'BancoToolStripMenuItem1
        '
        Me.BancoToolStripMenuItem1.Name = "BancoToolStripMenuItem1"
        Me.BancoToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.BancoToolStripMenuItem1.Text = "Bancos"
        '
        'ParcelamentoToolStripMenuItem
        '
        Me.ParcelamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoParcelamentoToolStripMenuItem})
        Me.ParcelamentoToolStripMenuItem.Name = "ParcelamentoToolStripMenuItem"
        Me.ParcelamentoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ParcelamentoToolStripMenuItem.Text = "Pagar/Receber"
        '
        'TipoParcelamentoToolStripMenuItem
        '
        Me.TipoParcelamentoToolStripMenuItem.Name = "TipoParcelamentoToolStripMenuItem"
        Me.TipoParcelamentoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TipoParcelamentoToolStripMenuItem.Text = "Tipo Parcelamento"
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
        'PrintDocumentDespesa
        '
        '
        'LbNomeUsuario
        '
        Me.LbNomeUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbNomeUsuario.AutoSize = True
        Me.LbNomeUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LbNomeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbNomeUsuario.ForeColor = System.Drawing.Color.White
        Me.LbNomeUsuario.Location = New System.Drawing.Point(937, 9)
        Me.LbNomeUsuario.Name = "LbNomeUsuario"
        Me.LbNomeUsuario.Size = New System.Drawing.Size(72, 13)
        Me.LbNomeUsuario.TabIndex = 29
        Me.LbNomeUsuario.Text = "nome Usuario"
        '
        'LbPermissaoUsuario
        '
        Me.LbPermissaoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbPermissaoUsuario.AutoSize = True
        Me.LbPermissaoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LbPermissaoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbPermissaoUsuario.ForeColor = System.Drawing.Color.White
        Me.LbPermissaoUsuario.Location = New System.Drawing.Point(846, 9)
        Me.LbPermissaoUsuario.Name = "LbPermissaoUsuario"
        Me.LbPermissaoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.LbPermissaoUsuario.TabIndex = 30
        Me.LbPermissaoUsuario.Text = "Label6"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.LogoVSystem2
        Me.PictureBox2.Location = New System.Drawing.Point(523, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(571, 522)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.LbPermissaoUsuario)
        Me.Controls.Add(Me.LbNomeUsuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbLicencia)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos System              Heliton(034)996451318"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EventoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ResumoVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDocRelResumoVenda As Printing.PrintDocument
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
    Friend WithEvents ImprimirIngressoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PDV1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspécieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaçaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelagemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ImprimirIngressoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParametrosSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicençaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmoxarifadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SeçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LbNomeUsuario As Label
    Friend WithEvents LbPermissaoUsuario As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UnidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VacinaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParasitaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecíeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecíeCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDespesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DespesaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReceitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoReceitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceitaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunçãoFuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BancoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ParcelamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoParcelamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventoToolStripMenuItem1 As ToolStripMenuItem
End Class
