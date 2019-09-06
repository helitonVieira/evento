<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDespesa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDespesa))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtCadPessoa = New System.Windows.Forms.Button()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.BtLimpar = New System.Windows.Forms.Button()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.BtExcluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtFuncionario = New System.Windows.Forms.Button()
        Me.TxbNomFuncionario = New System.Windows.Forms.TextBox()
        Me.TxbCodFuncionario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtEvento = New System.Windows.Forms.Button()
        Me.txbnomEvento = New System.Windows.Forms.TextBox()
        Me.DtpDtaDespesa = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtFavorecido = New System.Windows.Forms.Button()
        Me.TxbNomFavorecido = New System.Windows.Forms.TextBox()
        Me.TxbCodFavorecido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btTipoDespesa = New System.Windows.Forms.Button()
        Me.txbDesTipoDespesa = New System.Windows.Forms.TextBox()
        Me.txbCodTipoDespesa = New System.Windows.Forms.TextBox()
        Me.TxbCodEvento = New System.Windows.Forms.TextBox()
        Me.TxbValDespesa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbNomDespesa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbCodDespesa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDespesa = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtCadPessoa)
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.BtLimpar)
        Me.GroupBox2.Controls.Add(Me.BtSalvar)
        Me.GroupBox2.Controls.Add(Me.BtExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 65)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'BtCadPessoa
        '
        Me.BtCadPessoa.Image = CType(resources.GetObject("BtCadPessoa.Image"), System.Drawing.Image)
        Me.BtCadPessoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtCadPessoa.Location = New System.Drawing.Point(306, 11)
        Me.BtCadPessoa.Name = "BtCadPessoa"
        Me.BtCadPessoa.Size = New System.Drawing.Size(48, 50)
        Me.BtCadPessoa.TabIndex = 116
        Me.BtCadPessoa.UseVisualStyleBackColor = True
        '
        'BtPresquisa
        '
        Me.BtPresquisa.Image = CType(resources.GetObject("BtPresquisa.Image"), System.Drawing.Image)
        Me.BtPresquisa.Location = New System.Drawing.Point(116, 11)
        Me.BtPresquisa.Name = "BtPresquisa"
        Me.BtPresquisa.Size = New System.Drawing.Size(48, 50)
        Me.BtPresquisa.TabIndex = 0
        Me.BtPresquisa.UseVisualStyleBackColor = True
        '
        'BtLimpar
        '
        Me.BtLimpar.Image = CType(resources.GetObject("BtLimpar.Image"), System.Drawing.Image)
        Me.BtLimpar.Location = New System.Drawing.Point(170, 11)
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(48, 50)
        Me.BtLimpar.TabIndex = 7
        Me.BtLimpar.UseVisualStyleBackColor = True
        '
        'BtSalvar
        '
        Me.BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), System.Drawing.Image)
        Me.BtSalvar.Location = New System.Drawing.Point(8, 11)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(48, 50)
        Me.BtSalvar.TabIndex = 2
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'BtExcluir
        '
        Me.BtExcluir.Image = CType(resources.GetObject("BtExcluir.Image"), System.Drawing.Image)
        Me.BtExcluir.Location = New System.Drawing.Point(62, 11)
        Me.BtExcluir.Name = "BtExcluir"
        Me.BtExcluir.Size = New System.Drawing.Size(48, 50)
        Me.BtExcluir.TabIndex = 6
        Me.BtExcluir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtFuncionario)
        Me.GroupBox1.Controls.Add(Me.TxbNomFuncionario)
        Me.GroupBox1.Controls.Add(Me.TxbCodFuncionario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BtEvento)
        Me.GroupBox1.Controls.Add(Me.txbnomEvento)
        Me.GroupBox1.Controls.Add(Me.DtpDtaDespesa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtFavorecido)
        Me.GroupBox1.Controls.Add(Me.TxbNomFavorecido)
        Me.GroupBox1.Controls.Add(Me.TxbCodFavorecido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btTipoDespesa)
        Me.GroupBox1.Controls.Add(Me.txbDesTipoDespesa)
        Me.GroupBox1.Controls.Add(Me.txbCodTipoDespesa)
        Me.GroupBox1.Controls.Add(Me.TxbCodEvento)
        Me.GroupBox1.Controls.Add(Me.TxbValDespesa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxbObservacao)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxbNomDespesa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxbCodDespesa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 299)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Despesa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Funcionário"
        '
        'BtFuncionario
        '
        Me.BtFuncionario.Image = CType(resources.GetObject("BtFuncionario.Image"), System.Drawing.Image)
        Me.BtFuncionario.Location = New System.Drawing.Point(334, 189)
        Me.BtFuncionario.Name = "BtFuncionario"
        Me.BtFuncionario.Size = New System.Drawing.Size(25, 21)
        Me.BtFuncionario.TabIndex = 39
        Me.BtFuncionario.UseVisualStyleBackColor = True
        '
        'TxbNomFuncionario
        '
        Me.TxbNomFuncionario.Location = New System.Drawing.Point(67, 189)
        Me.TxbNomFuncionario.Name = "TxbNomFuncionario"
        Me.TxbNomFuncionario.Size = New System.Drawing.Size(263, 20)
        Me.TxbNomFuncionario.TabIndex = 38
        '
        'TxbCodFuncionario
        '
        Me.TxbCodFuncionario.Location = New System.Drawing.Point(6, 189)
        Me.TxbCodFuncionario.Name = "TxbCodFuncionario"
        Me.TxbCodFuncionario.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodFuncionario.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Evento"
        '
        'BtEvento
        '
        Me.BtEvento.Image = CType(resources.GetObject("BtEvento.Image"), System.Drawing.Image)
        Me.BtEvento.Location = New System.Drawing.Point(335, 73)
        Me.BtEvento.Name = "BtEvento"
        Me.BtEvento.Size = New System.Drawing.Size(25, 21)
        Me.BtEvento.TabIndex = 35
        Me.BtEvento.UseVisualStyleBackColor = True
        '
        'txbnomEvento
        '
        Me.txbnomEvento.Location = New System.Drawing.Point(68, 73)
        Me.txbnomEvento.Name = "txbnomEvento"
        Me.txbnomEvento.Size = New System.Drawing.Size(263, 20)
        Me.txbnomEvento.TabIndex = 34
        '
        'DtpDtaDespesa
        '
        Me.DtpDtaDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaDespesa.Location = New System.Drawing.Point(273, 10)
        Me.DtpDtaDespesa.Name = "DtpDtaDespesa"
        Me.DtpDtaDespesa.Size = New System.Drawing.Size(80, 20)
        Me.DtpDtaDespesa.TabIndex = 31
        Me.DtpDtaDespesa.Value = New Date(2019, 8, 26, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Favorecido"
        '
        'BtFavorecido
        '
        Me.BtFavorecido.Image = CType(resources.GetObject("BtFavorecido.Image"), System.Drawing.Image)
        Me.BtFavorecido.Location = New System.Drawing.Point(335, 150)
        Me.BtFavorecido.Name = "BtFavorecido"
        Me.BtFavorecido.Size = New System.Drawing.Size(25, 21)
        Me.BtFavorecido.TabIndex = 29
        Me.BtFavorecido.UseVisualStyleBackColor = True
        '
        'TxbNomFavorecido
        '
        Me.TxbNomFavorecido.Location = New System.Drawing.Point(68, 150)
        Me.TxbNomFavorecido.Name = "TxbNomFavorecido"
        Me.TxbNomFavorecido.Size = New System.Drawing.Size(263, 20)
        Me.TxbNomFavorecido.TabIndex = 28
        '
        'TxbCodFavorecido
        '
        Me.TxbCodFavorecido.Location = New System.Drawing.Point(7, 150)
        Me.TxbCodFavorecido.Name = "TxbCodFavorecido"
        Me.TxbCodFavorecido.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodFavorecido.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tipo Despesa"
        '
        'btTipoDespesa
        '
        Me.btTipoDespesa.Image = CType(resources.GetObject("btTipoDespesa.Image"), System.Drawing.Image)
        Me.btTipoDespesa.Location = New System.Drawing.Point(334, 111)
        Me.btTipoDespesa.Name = "btTipoDespesa"
        Me.btTipoDespesa.Size = New System.Drawing.Size(25, 21)
        Me.btTipoDespesa.TabIndex = 25
        Me.btTipoDespesa.UseVisualStyleBackColor = True
        '
        'txbDesTipoDespesa
        '
        Me.txbDesTipoDespesa.Location = New System.Drawing.Point(67, 111)
        Me.txbDesTipoDespesa.Name = "txbDesTipoDespesa"
        Me.txbDesTipoDespesa.Size = New System.Drawing.Size(263, 20)
        Me.txbDesTipoDespesa.TabIndex = 24
        '
        'txbCodTipoDespesa
        '
        Me.txbCodTipoDespesa.Location = New System.Drawing.Point(6, 111)
        Me.txbCodTipoDespesa.Name = "txbCodTipoDespesa"
        Me.txbCodTipoDespesa.Size = New System.Drawing.Size(55, 20)
        Me.txbCodTipoDespesa.TabIndex = 23
        '
        'TxbCodEvento
        '
        Me.TxbCodEvento.Location = New System.Drawing.Point(6, 73)
        Me.TxbCodEvento.Name = "TxbCodEvento"
        Me.TxbCodEvento.Size = New System.Drawing.Size(54, 20)
        Me.TxbCodEvento.TabIndex = 12
        '
        'TxbValDespesa
        '
        Me.TxbValDespesa.Location = New System.Drawing.Point(273, 273)
        Me.TxbValDespesa.Name = "TxbValDespesa"
        Me.TxbValDespesa.Size = New System.Drawing.Size(80, 20)
        Me.TxbValDespesa.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'TxbObservacao
        '
        Me.TxbObservacao.Location = New System.Drawing.Point(7, 232)
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(346, 20)
        Me.TxbObservacao.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Observação"
        '
        'TxbNomDespesa
        '
        Me.TxbNomDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomDespesa.Location = New System.Drawing.Point(67, 34)
        Me.TxbNomDespesa.Name = "TxbNomDespesa"
        Me.TxbNomDespesa.Size = New System.Drawing.Size(286, 20)
        Me.TxbNomDespesa.TabIndex = 6
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
        'TxbCodDespesa
        '
        Me.TxbCodDespesa.Location = New System.Drawing.Point(6, 34)
        Me.TxbCodDespesa.Name = "TxbCodDespesa"
        Me.TxbCodDespesa.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodDespesa.TabIndex = 4
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
        'DgvDespesa
        '
        Me.DgvDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDespesa.Location = New System.Drawing.Point(4, 385)
        Me.DgvDespesa.Name = "DgvDespesa"
        Me.DgvDespesa.Size = New System.Drawing.Size(361, 153)
        Me.DgvDespesa.TabIndex = 9
        '
        'FrmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvDespesa)
        Me.Name = "FrmDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDespesa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents BtLimpar As Button
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbCodEvento As TextBox
    Friend WithEvents TxbValDespesa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbObservacao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNomDespesa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbCodDespesa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvDespesa As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents BtFavorecido As Button
    Friend WithEvents TxbNomFavorecido As TextBox
    Friend WithEvents TxbCodFavorecido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btTipoDespesa As Button
    Friend WithEvents txbDesTipoDespesa As TextBox
    Friend WithEvents txbCodTipoDespesa As TextBox
    Friend WithEvents DtpDtaDespesa As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtEvento As Button
    Friend WithEvents txbnomEvento As TextBox
    Friend WithEvents BtCadPessoa As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtFuncionario As Button
    Friend WithEvents TxbNomFuncionario As TextBox
    Friend WithEvents TxbCodFuncionario As TextBox
End Class
