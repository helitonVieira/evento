﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItem1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItem1))
        Me.DgvItem = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxbCodItem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbDesSubCategoria = New System.Windows.Forms.TextBox()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.TxtCodEvento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecoCusto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbDesItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPresquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSubCategoria = New System.Windows.Forms.Button()
        Me.TxbCodSubCategoria = New Controles.TxbCodigo()
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvItem
        '
        Me.DgvItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItem.Location = New System.Drawing.Point(12, 226)
        Me.DgvItem.Name = "DgvItem"
        Me.DgvItem.Size = New System.Drawing.Size(441, 105)
        Me.DgvItem.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código"
        '
        'TxbCodItem
        '
        Me.TxbCodItem.Enabled = False
        Me.TxbCodItem.Location = New System.Drawing.Point(6, 34)
        Me.TxbCodItem.Name = "TxbCodItem"
        Me.TxbCodItem.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodItem.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnSubCategoria)
        Me.GroupBox1.Controls.Add(Me.txbDesSubCategoria)
        Me.GroupBox1.Controls.Add(Me.TxbCodSubCategoria)
        Me.GroupBox1.Controls.Add(Me.CkbAtivo)
        Me.GroupBox1.Controls.Add(Me.TxtCodEvento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtPrecoCusto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxbPrecoVenda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxbDesItem)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxbCodItem)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 153)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-7, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "SubCategoria:"
        '
        'txbDesSubCategoria
        '
        Me.txbDesSubCategoria.Location = New System.Drawing.Point(136, 107)
        Me.txbDesSubCategoria.Name = "txbDesSubCategoria"
        Me.txbDesSubCategoria.Size = New System.Drawing.Size(228, 20)
        Me.txbDesSubCategoria.TabIndex = 48
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(290, 74)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 15
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'TxtCodEvento
        '
        Me.TxtCodEvento.Enabled = False
        Me.TxtCodEvento.Location = New System.Drawing.Point(179, 72)
        Me.TxtCodEvento.Name = "TxtCodEvento"
        Me.TxtCodEvento.Size = New System.Drawing.Size(80, 20)
        Me.TxtCodEvento.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cód.Evento"
        '
        'TxtPrecoCusto
        '
        Me.TxtPrecoCusto.Location = New System.Drawing.Point(93, 72)
        Me.TxtPrecoCusto.Name = "TxtPrecoCusto"
        Me.TxtPrecoCusto.Size = New System.Drawing.Size(80, 20)
        Me.TxtPrecoCusto.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Preço Custo"
        '
        'TxbPrecoVenda
        '
        Me.TxbPrecoVenda.Location = New System.Drawing.Point(7, 72)
        Me.TxbPrecoVenda.Name = "TxbPrecoVenda"
        Me.TxbPrecoVenda.Size = New System.Drawing.Size(80, 20)
        Me.TxbPrecoVenda.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Preço Venda"
        '
        'TxbDesItem
        '
        Me.TxbDesItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesItem.Location = New System.Drawing.Point(67, 34)
        Me.TxbDesItem.Name = "TxbDesItem"
        Me.TxbDesItem.Size = New System.Drawing.Size(273, 20)
        Me.TxbDesItem.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descrição"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnPresquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 65)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'BtnPresquisa
        '
        Me.BtnPresquisa.Image = CType(resources.GetObject("BtnPresquisa.Image"), System.Drawing.Image)
        Me.BtnPresquisa.Location = New System.Drawing.Point(116, 11)
        Me.BtnPresquisa.Name = "BtnPresquisa"
        Me.BtnPresquisa.Size = New System.Drawing.Size(48, 50)
        Me.BtnPresquisa.TabIndex = 0
        Me.BtnPresquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(170, 11)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(48, 50)
        Me.BtnLimpar.TabIndex = 7
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(8, 11)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(48, 50)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(62, 11)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(48, 50)
        Me.BtnExcluir.TabIndex = 6
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnSubCategoria
        '
        Me.BtnSubCategoria.Image = CType(resources.GetObject("BtnSubCategoria.Image"), System.Drawing.Image)
        Me.BtnSubCategoria.Location = New System.Drawing.Point(368, 107)
        Me.BtnSubCategoria.Name = "BtnSubCategoria"
        Me.BtnSubCategoria.Size = New System.Drawing.Size(25, 21)
        Me.BtnSubCategoria.TabIndex = 49
        Me.BtnSubCategoria.UseVisualStyleBackColor = True
        '
        'TxbCodSubCategoria
        '
        Me.TxbCodSubCategoria.Location = New System.Drawing.Point(69, 107)
        Me.TxbCodSubCategoria.Name = "TxbCodSubCategoria"
        Me.TxbCodSubCategoria.Size = New System.Drawing.Size(61, 20)
        Me.TxbCodSubCategoria.TabIndex = 47
        '
        'FrmItem1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 338)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvItem)
        Me.Name = "FrmItem1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Cadasstro Item"
        CType(Me.DgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPresquisa As Button
    Friend WithEvents DgvItem As DataGridView
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxbCodItem As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbDesItem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodEvento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrecoCusto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbPrecoVenda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CkbAtivo As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSubCategoria As Button
    Friend WithEvents txbDesSubCategoria As TextBox
    Friend WithEvents TxbCodSubCategoria As Controles.TxbCodigo
End Class