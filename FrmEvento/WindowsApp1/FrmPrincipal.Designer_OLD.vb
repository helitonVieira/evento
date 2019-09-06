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
        Me.DgvItemVenda = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngressosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbDescricao = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtQtde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbCodEvento = New System.Windows.Forms.Label()
        Me.LbNomEvento = New System.Windows.Forms.Label()
        Me.GroupBoxVendas = New System.Windows.Forms.GroupBox()
        Me.LbNomeUsuario = New System.Windows.Forms.Label()
        Me.LbPermissaoUsuario = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TxtCodItem = New System.Windows.Forms.TextBox()
        CType(Me.DgvItemVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxVendas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvItemVenda
        '
        Me.DgvItemVenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItemVenda.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvItemVenda.Location = New System.Drawing.Point(54, 105)
        Me.DgvItemVenda.Name = "DgvItemVenda"
        Me.DgvItemVenda.ReadOnly = True
        Me.DgvItemVenda.Size = New System.Drawing.Size(552, 226)
        Me.DgvItemVenda.TabIndex = 20
        Me.DgvItemVenda.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EventoToolStripMenuItem
        '
        Me.EventoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventoToolStripMenuItem1, Me.ItemToolStripMenuItem1})
        Me.EventoToolStripMenuItem.Name = "EventoToolStripMenuItem"
        Me.EventoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.EventoToolStripMenuItem.Text = "Cadastro"
        '
        'EventoToolStripMenuItem1
        '
        Me.EventoToolStripMenuItem1.Name = "EventoToolStripMenuItem1"
        Me.EventoToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.EventoToolStripMenuItem1.Text = "Evento"
        '
        'ItemToolStripMenuItem1
        '
        Me.ItemToolStripMenuItem1.Name = "ItemToolStripMenuItem1"
        Me.ItemToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.ItemToolStripMenuItem1.Text = "Item"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarToolStripMenuItem, Me.IngressosToolStripMenuItem})
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'BarToolStripMenuItem
        '
        Me.BarToolStripMenuItem.Name = "BarToolStripMenuItem"
        Me.BarToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.BarToolStripMenuItem.Text = "Bar"
        '
        'IngressosToolStripMenuItem
        '
        Me.IngressosToolStripMenuItem.Name = "IngressosToolStripMenuItem"
        Me.IngressosToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.IngressosToolStripMenuItem.Text = "Ingressos"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'LbDescricao
        '
        Me.LbDescricao.AutoSize = True
        Me.LbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricao.Location = New System.Drawing.Point(230, 29)
        Me.LbDescricao.Name = "LbDescricao"
        Me.LbDescricao.Size = New System.Drawing.Size(0, 25)
        Me.LbDescricao.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Item:"
        '
        'TxtQtde
        '
        Me.TxtQtde.Location = New System.Drawing.Point(124, 65)
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.Size = New System.Drawing.Size(100, 20)
        Me.TxtQtde.TabIndex = 2
        Me.TxtQtde.Tag = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Qtde:"
        '
        'LbCodEvento
        '
        Me.LbCodEvento.AutoSize = True
        Me.LbCodEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCodEvento.Location = New System.Drawing.Point(91, 39)
        Me.LbCodEvento.Name = "LbCodEvento"
        Me.LbCodEvento.Size = New System.Drawing.Size(0, 20)
        Me.LbCodEvento.TabIndex = 8
        '
        'LbNomEvento
        '
        Me.LbNomEvento.AutoSize = True
        Me.LbNomEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNomEvento.Location = New System.Drawing.Point(187, 39)
        Me.LbNomEvento.Name = "LbNomEvento"
        Me.LbNomEvento.Size = New System.Drawing.Size(0, 20)
        Me.LbNomEvento.TabIndex = 9
        '
        'GroupBoxVendas
        '
        Me.GroupBoxVendas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxVendas.Controls.Add(Me.TxtCodItem)
        Me.GroupBoxVendas.Controls.Add(Me.DgvItemVenda)
        Me.GroupBoxVendas.Controls.Add(Me.LbDescricao)
        Me.GroupBoxVendas.Controls.Add(Me.Label2)
        Me.GroupBoxVendas.Controls.Add(Me.Label1)
        Me.GroupBoxVendas.Controls.Add(Me.TxtQtde)
        Me.GroupBoxVendas.Location = New System.Drawing.Point(24, 101)
        Me.GroupBoxVendas.Name = "GroupBoxVendas"
        Me.GroupBoxVendas.Size = New System.Drawing.Size(733, 337)
        Me.GroupBoxVendas.TabIndex = 11
        Me.GroupBoxVendas.TabStop = False
        Me.GroupBoxVendas.Text = "Vendas"
        Me.GroupBoxVendas.Visible = False
        '
        'LbNomeUsuario
        '
        Me.LbNomeUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbNomeUsuario.AutoSize = True
        Me.LbNomeUsuario.Location = New System.Drawing.Point(145, 435)
        Me.LbNomeUsuario.Name = "LbNomeUsuario"
        Me.LbNomeUsuario.Size = New System.Drawing.Size(72, 13)
        Me.LbNomeUsuario.TabIndex = 12
        Me.LbNomeUsuario.Text = "nome Usuario"
        '
        'LbPermissaoUsuario
        '
        Me.LbPermissaoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LbPermissaoUsuario.AutoSize = True
        Me.LbPermissaoUsuario.Location = New System.Drawing.Point(23, 435)
        Me.LbPermissaoUsuario.Name = "LbPermissaoUsuario"
        Me.LbPermissaoUsuario.Size = New System.Drawing.Size(39, 13)
        Me.LbPermissaoUsuario.TabIndex = 13
        Me.LbPermissaoUsuario.Text = "Label6"
        '
        'PrintDocument1
        '
        '
        'TxtCodItem
        '
        Me.TxtCodItem.Location = New System.Drawing.Point(124, 35)
        Me.TxtCodItem.Name = "TxtCodItem"
        Me.TxtCodItem.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodItem.TabIndex = 21
        Me.TxtCodItem.Tag = "1"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LbPermissaoUsuario)
        Me.Controls.Add(Me.LbNomeUsuario)
        Me.Controls.Add(Me.GroupBoxVendas)
        Me.Controls.Add(Me.LbNomEvento)
        Me.Controls.Add(Me.LbCodEvento)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos System              Heliton(034)996451318"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvItemVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxVendas.ResumeLayout(False)
        Me.GroupBoxVendas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvItemVenda As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LbDescricao As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtQtde As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EventoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbCodEvento As Label
    Friend WithEvents LbNomEvento As Label
    Friend WithEvents GroupBoxVendas As GroupBox
    Friend WithEvents LbNomeUsuario As Label
    Friend WithEvents LbPermissaoUsuario As Label
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngressosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TxtCodItem As TextBox
End Class
