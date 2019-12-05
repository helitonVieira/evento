<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecao
    Inherits WindowsApp1.FrmCadPadrao

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSecao))
        Me.TxbCodAlmoxarifado = New Controles.TxbCodigo()
        Me.BtAlmoxarifado = New System.Windows.Forms.Button()
        Me.txbDesAlmoxarifado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExcluir
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtAlmoxarifado)
        Me.GroupBox4.Controls.Add(Me.txbDesAlmoxarifado)
        Me.GroupBox4.Controls.Add(Me.TxbCodAlmoxarifado)
        Me.GroupBox4.Size = New System.Drawing.Size(404, 77)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbDesAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtAlmoxarifado, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        '
        'BtnCsv
        '
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        '
        'BtnAnterior
        '
        '
        'BtnProximo
        '
        '
        'BtnPrimeiroReg
        '
        '
        'BtnGrid
        '
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        '
        'BtnLimpar
        '
        '
        'BtnPesquisa
        '
        '
        'BtnSalvar
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 118)
        Me.GroupBox1.Size = New System.Drawing.Size(407, 108)
        '
        'TxbCodAlmoxarifado
        '
        Me.TxbCodAlmoxarifado.Location = New System.Drawing.Point(64, 45)
        Me.TxbCodAlmoxarifado.Name = "TxbCodAlmoxarifado"
        Me.TxbCodAlmoxarifado.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodAlmoxarifado.TabIndex = 35
        '
        'BtAlmoxarifado
        '
        Me.BtAlmoxarifado.Image = CType(resources.GetObject("BtAlmoxarifado.Image"), System.Drawing.Image)
        Me.BtAlmoxarifado.Location = New System.Drawing.Point(375, 45)
        Me.BtAlmoxarifado.Name = "BtAlmoxarifado"
        Me.BtAlmoxarifado.Size = New System.Drawing.Size(25, 21)
        Me.BtAlmoxarifado.TabIndex = 37
        Me.BtAlmoxarifado.UseVisualStyleBackColor = True
        '
        'txbDesAlmoxarifado
        '
        Me.txbDesAlmoxarifado.Location = New System.Drawing.Point(131, 45)
        Me.txbDesAlmoxarifado.Name = "txbDesAlmoxarifado"
        Me.txbDesAlmoxarifado.Size = New System.Drawing.Size(240, 20)
        Me.txbDesAlmoxarifado.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almoxarif:"
        '
        'FrmSecao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmSecao"
        Me.Text = "FrmSecao"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxbCodAlmoxarifado As Controles.TxbCodigo
    Friend WithEvents Label1 As Label
    Friend WithEvents BtAlmoxarifado As Button
    Friend WithEvents txbDesAlmoxarifado As TextBox
End Class
