﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoria
    Inherits Controles.FrmCad1Padrao

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtSecao = New System.Windows.Forms.Button()
        Me.txbDesSecao = New System.Windows.Forms.TextBox()
        Me.TxbCodSecao = New Controles.TxbCodigo()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BtnPesquisa
        '
        '
        'BtnLimpar
        '
        '
        'BtnSalvar
        '
        '
        'BtnExcluir
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 116)
        Me.GroupBox1.Size = New System.Drawing.Size(407, 110)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.BtSecao)
        Me.GroupBox4.Controls.Add(Me.txbDesSecao)
        Me.GroupBox4.Controls.Add(Me.TxbCodSecao)
        Me.GroupBox4.Size = New System.Drawing.Size(404, 73)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodigo, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label18, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbDescricao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.TxbCodSecao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txbDesSecao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.BtSecao, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label1, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Seção:"
        '
        'BtSecao
        '
        Me.BtSecao.Image = CType(resources.GetObject("BtSecao.Image"), System.Drawing.Image)
        Me.BtSecao.Location = New System.Drawing.Point(372, 44)
        Me.BtSecao.Name = "BtSecao"
        Me.BtSecao.Size = New System.Drawing.Size(25, 22)
        Me.BtSecao.TabIndex = 41
        Me.BtSecao.UseVisualStyleBackColor = True
        '
        'txbDesSecao
        '
        Me.txbDesSecao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbDesSecao.Location = New System.Drawing.Point(131, 45)
        Me.txbDesSecao.Name = "txbDesSecao"
        Me.txbDesSecao.Size = New System.Drawing.Size(240, 20)
        Me.txbDesSecao.TabIndex = 40
        '
        'TxbCodSecao
        '
        Me.TxbCodSecao.Location = New System.Drawing.Point(65, 45)
        Me.TxbCodSecao.Name = "TxbCodSecao"
        Me.TxbCodSecao.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodSecao.TabIndex = 39
        '
        'Dgv
        '
        Me.Dgv.AllowUserToOrderColumns = True
        Me.Dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Location = New System.Drawing.Point(-1, 4)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.Size = New System.Drawing.Size(412, 218)
        Me.Dgv.TabIndex = 1
        Me.Dgv.VirtualMode = True
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(439, 283)
        Me.Name = "FrmCategoria"
        Me.Text = "FrmCategoria"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtSecao As Button
    Friend WithEvents txbDesSecao As TextBox
    Friend WithEvents TxbCodSecao As Controles.TxbCodigo
    Public WithEvents Dgv As DataGridView
End Class
