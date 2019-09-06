<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesquisa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBusca = New System.Windows.Forms.ComboBox()
        Me.txbBusca = New System.Windows.Forms.TextBox()
        Me.dgvBusca = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBusca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cbBusca)
        Me.GroupBox1.Controls.Add(Me.txbBusca)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbBusca
        '
        Me.cbBusca.FormattingEnabled = True
        Me.cbBusca.Location = New System.Drawing.Point(6, 15)
        Me.cbBusca.Name = "cbBusca"
        Me.cbBusca.Size = New System.Drawing.Size(88, 21)
        Me.cbBusca.TabIndex = 1
        '
        'txbBusca
        '
        Me.txbBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbBusca.Location = New System.Drawing.Point(100, 16)
        Me.txbBusca.Name = "txbBusca"
        Me.txbBusca.Size = New System.Drawing.Size(234, 20)
        Me.txbBusca.TabIndex = 0
        '
        'dgvBusca
        '
        Me.dgvBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusca.Location = New System.Drawing.Point(2, 52)
        Me.dgvBusca.Name = "dgvBusca"
        Me.dgvBusca.Size = New System.Drawing.Size(340, 168)
        Me.dgvBusca.TabIndex = 1
        '
        'FrmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 232)
        Me.Controls.Add(Me.dgvBusca)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBusca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbBusca As ComboBox
    Friend WithEvents txbBusca As TextBox
    Friend WithEvents dgvBusca As DataGridView
End Class
