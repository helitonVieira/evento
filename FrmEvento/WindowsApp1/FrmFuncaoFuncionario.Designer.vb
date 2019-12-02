<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFuncaoFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuncaoFuncionario))
        Me.GbNavegador = New System.Windows.Forms.GroupBox()
        Me.BtnCsv = New System.Windows.Forms.Button()
        Me.BtnUltimoReg = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnPrimeiroReg = New System.Windows.Forms.Button()
        Me.BtnGrid = New System.Windows.Forms.Button()
        Me.BtnPesquisa = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxbDesFuncao = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxbCodFuncao = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvFuncao = New System.Windows.Forms.DataGridView()
        Me.GbNavegador.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvFuncao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbNavegador
        '
        Me.GbNavegador.Controls.Add(Me.BtnCsv)
        Me.GbNavegador.Controls.Add(Me.BtnUltimoReg)
        Me.GbNavegador.Controls.Add(Me.BtnAnterior)
        Me.GbNavegador.Controls.Add(Me.BtnProximo)
        Me.GbNavegador.Controls.Add(Me.BtnPrimeiroReg)
        Me.GbNavegador.Controls.Add(Me.BtnGrid)
        Me.GbNavegador.Controls.Add(Me.BtnPesquisa)
        Me.GbNavegador.Controls.Add(Me.BtnLimpar)
        Me.GbNavegador.Controls.Add(Me.BtnSalvar)
        Me.GbNavegador.Controls.Add(Me.BtnExcluir)
        Me.GbNavegador.Location = New System.Drawing.Point(8, 5)
        Me.GbNavegador.Name = "GbNavegador"
        Me.GbNavegador.Size = New System.Drawing.Size(422, 46)
        Me.GbNavegador.TabIndex = 12
        Me.GbNavegador.TabStop = False
        '
        'BtnCsv
        '
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.Location = New System.Drawing.Point(200, 10)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(32, 31)
        Me.BtnCsv.TabIndex = 26
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = True
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(355, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(32, 31)
        Me.BtnUltimoReg.TabIndex = 30
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(287, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(32, 31)
        Me.BtnAnterior.TabIndex = 28
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnProximo
        '
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(321, 10)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(32, 31)
        Me.BtnProximo.TabIndex = 29
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnPrimeiroReg
        '
        Me.BtnPrimeiroReg.Image = CType(resources.GetObject("BtnPrimeiroReg.Image"), System.Drawing.Image)
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(253, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(32, 31)
        Me.BtnPrimeiroReg.TabIndex = 27
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(150, 10)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(32, 31)
        Me.BtnGrid.TabIndex = 25
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Image = CType(resources.GetObject("BtnPesquisa.Image"), System.Drawing.Image)
        Me.BtnPesquisa.Location = New System.Drawing.Point(78, 10)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(32, 31)
        Me.BtnPesquisa.TabIndex = 23
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(114, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(32, 31)
        Me.BtnLimpar.TabIndex = 24
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(32, 31)
        Me.BtnSalvar.TabIndex = 21
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(42, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(32, 31)
        Me.BtnExcluir.TabIndex = 22
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 22)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 256)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(416, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbDesFuncao)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TxbCodFuncao)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(403, 54)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Função Funcionario"
        '
        'TxbDesFuncao
        '
        Me.TxbDesFuncao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxbDesFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbDesFuncao.Location = New System.Drawing.Point(131, 21)
        Me.TxbDesFuncao.Name = "TxbDesFuncao"
        Me.TxbDesFuncao.Size = New System.Drawing.Size(265, 20)
        Me.TxbDesFuncao.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Descrição:"
        '
        'TxbCodFuncao
        '
        Me.TxbCodFuncao.Location = New System.Drawing.Point(65, 21)
        Me.TxbCodFuncao.Name = "TxbCodFuncao"
        Me.TxbCodFuncao.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodFuncao.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvFuncao)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(416, 230)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvFuncao
        '
        Me.DgvFuncao.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFuncao.Location = New System.Drawing.Point(0, 13)
        Me.DgvFuncao.Name = "DgvFuncao"
        Me.DgvFuncao.Size = New System.Drawing.Size(414, 221)
        Me.DgvFuncao.TabIndex = 14
        '
        'FrmFuncaoFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 285)
        Me.Controls.Add(Me.GbNavegador)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmFuncaoFuncionario"
        Me.Text = "FrmFuncaoFuncionario"
        Me.GbNavegador.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvFuncao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbNavegador As GroupBox
    Friend WithEvents BtnCsv As Button
    Friend WithEvents BtnUltimoReg As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnPrimeiroReg As Button
    Friend WithEvents BtnGrid As Button
    Friend WithEvents BtnPesquisa As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxbDesFuncao As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxbCodFuncao As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DgvFuncao As DataGridView
End Class
