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
        Me.DgvDespesa = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.BtCadPessoa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 206)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Despesa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Funcionário"
        '
        'BtFuncionario
        '
        Me.BtFuncionario.Image = CType(resources.GetObject("BtFuncionario.Image"), System.Drawing.Image)
        Me.BtFuncionario.Location = New System.Drawing.Point(420, 143)
        Me.BtFuncionario.Name = "BtFuncionario"
        Me.BtFuncionario.Size = New System.Drawing.Size(25, 21)
        Me.BtFuncionario.TabIndex = 39
        Me.BtFuncionario.UseVisualStyleBackColor = True
        '
        'TxbNomFuncionario
        '
        Me.TxbNomFuncionario.Location = New System.Drawing.Point(153, 143)
        Me.TxbNomFuncionario.Name = "TxbNomFuncionario"
        Me.TxbNomFuncionario.Size = New System.Drawing.Size(263, 20)
        Me.TxbNomFuncionario.TabIndex = 38
        '
        'TxbCodFuncionario
        '
        Me.TxbCodFuncionario.Location = New System.Drawing.Point(90, 143)
        Me.TxbCodFuncionario.Name = "TxbCodFuncionario"
        Me.TxbCodFuncionario.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodFuncionario.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Evento"
        '
        'BtEvento
        '
        Me.BtEvento.Image = CType(resources.GetObject("BtEvento.Image"), System.Drawing.Image)
        Me.BtEvento.Location = New System.Drawing.Point(420, 65)
        Me.BtEvento.Name = "BtEvento"
        Me.BtEvento.Size = New System.Drawing.Size(25, 21)
        Me.BtEvento.TabIndex = 35
        Me.BtEvento.UseVisualStyleBackColor = True
        '
        'txbnomEvento
        '
        Me.txbnomEvento.Location = New System.Drawing.Point(153, 65)
        Me.txbnomEvento.Name = "txbnomEvento"
        Me.txbnomEvento.Size = New System.Drawing.Size(263, 20)
        Me.txbnomEvento.TabIndex = 34
        '
        'DtpDtaDespesa
        '
        Me.DtpDtaDespesa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaDespesa.Location = New System.Drawing.Point(237, 12)
        Me.DtpDtaDespesa.Name = "DtpDtaDespesa"
        Me.DtpDtaDespesa.Size = New System.Drawing.Size(80, 20)
        Me.DtpDtaDespesa.TabIndex = 31
        Me.DtpDtaDespesa.Value = New Date(2019, 8, 26, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Favorecido"
        '
        'BtFavorecido
        '
        Me.BtFavorecido.Image = CType(resources.GetObject("BtFavorecido.Image"), System.Drawing.Image)
        Me.BtFavorecido.Location = New System.Drawing.Point(420, 117)
        Me.BtFavorecido.Name = "BtFavorecido"
        Me.BtFavorecido.Size = New System.Drawing.Size(25, 21)
        Me.BtFavorecido.TabIndex = 29
        Me.BtFavorecido.UseVisualStyleBackColor = True
        '
        'TxbNomFavorecido
        '
        Me.TxbNomFavorecido.Location = New System.Drawing.Point(153, 117)
        Me.TxbNomFavorecido.Name = "TxbNomFavorecido"
        Me.TxbNomFavorecido.Size = New System.Drawing.Size(263, 20)
        Me.TxbNomFavorecido.TabIndex = 28
        '
        'TxbCodFavorecido
        '
        Me.TxbCodFavorecido.Location = New System.Drawing.Point(90, 117)
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
        Me.btTipoDespesa.Location = New System.Drawing.Point(420, 91)
        Me.btTipoDespesa.Name = "btTipoDespesa"
        Me.btTipoDespesa.Size = New System.Drawing.Size(25, 21)
        Me.btTipoDespesa.TabIndex = 25
        Me.btTipoDespesa.UseVisualStyleBackColor = True
        '
        'txbDesTipoDespesa
        '
        Me.txbDesTipoDespesa.Location = New System.Drawing.Point(153, 91)
        Me.txbDesTipoDespesa.Name = "txbDesTipoDespesa"
        Me.txbDesTipoDespesa.Size = New System.Drawing.Size(263, 20)
        Me.txbDesTipoDespesa.TabIndex = 24
        '
        'txbCodTipoDespesa
        '
        Me.txbCodTipoDespesa.Location = New System.Drawing.Point(90, 91)
        Me.txbCodTipoDespesa.Name = "txbCodTipoDespesa"
        Me.txbCodTipoDespesa.Size = New System.Drawing.Size(55, 20)
        Me.txbCodTipoDespesa.TabIndex = 23
        '
        'TxbCodEvento
        '
        Me.TxbCodEvento.Location = New System.Drawing.Point(90, 65)
        Me.TxbCodEvento.Name = "TxbCodEvento"
        Me.TxbCodEvento.Size = New System.Drawing.Size(54, 20)
        Me.TxbCodEvento.TabIndex = 12
        '
        'TxbValDespesa
        '
        Me.TxbValDespesa.Location = New System.Drawing.Point(364, 12)
        Me.TxbValDespesa.Name = "TxbValDespesa"
        Me.TxbValDespesa.Size = New System.Drawing.Size(80, 20)
        Me.TxbValDespesa.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Valor"
        '
        'TxbObservacao
        '
        Me.TxbObservacao.Location = New System.Drawing.Point(90, 169)
        Me.TxbObservacao.Multiline = True
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(355, 20)
        Me.TxbObservacao.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Observação"
        '
        'TxbNomDespesa
        '
        Me.TxbNomDespesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomDespesa.Location = New System.Drawing.Point(153, 39)
        Me.TxbNomDespesa.Name = "TxbNomDespesa"
        Me.TxbNomDespesa.Size = New System.Drawing.Size(293, 20)
        Me.TxbNomDespesa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sequencia:"
        '
        'TxbCodDespesa
        '
        Me.TxbCodDespesa.Location = New System.Drawing.Point(90, 39)
        Me.TxbCodDespesa.Name = "TxbCodDespesa"
        Me.TxbCodDespesa.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodDespesa.TabIndex = 4
        '
        'DgvDespesa
        '
        Me.DgvDespesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDespesa.Location = New System.Drawing.Point(4, 280)
        Me.DgvDespesa.Name = "DgvDespesa"
        Me.DgvDespesa.Size = New System.Drawing.Size(459, 153)
        Me.DgvDespesa.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BtnCsv)
        Me.GroupBox2.Controls.Add(Me.BtnUltimoReg)
        Me.GroupBox2.Controls.Add(Me.BtnAnterior)
        Me.GroupBox2.Controls.Add(Me.BtnProximo)
        Me.GroupBox2.Controls.Add(Me.BtnPrimeiroReg)
        Me.GroupBox2.Controls.Add(Me.BtnGrid)
        Me.GroupBox2.Controls.Add(Me.BtnPesquisa)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 46)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        '
        'BtnCsv
        '
        Me.BtnCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCsv.Location = New System.Drawing.Point(176, 10)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.Size = New System.Drawing.Size(31, 31)
        Me.BtnCsv.TabIndex = 7
        Me.BtnCsv.Text = "CSV"
        Me.BtnCsv.UseVisualStyleBackColor = True
        '
        'BtnUltimoReg
        '
        Me.BtnUltimoReg.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnUltimoReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnUltimoReg.Image = CType(resources.GetObject("BtnUltimoReg.Image"), System.Drawing.Image)
        Me.BtnUltimoReg.Location = New System.Drawing.Point(312, 10)
        Me.BtnUltimoReg.Name = "BtnUltimoReg"
        Me.BtnUltimoReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnUltimoReg.TabIndex = 11
        Me.BtnUltimoReg.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(244, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(31, 31)
        Me.BtnAnterior.TabIndex = 9
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnProximo
        '
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(278, 10)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(31, 31)
        Me.BtnProximo.TabIndex = 10
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnPrimeiroReg
        '
        Me.BtnPrimeiroReg.Image = CType(resources.GetObject("BtnPrimeiroReg.Image"), System.Drawing.Image)
        Me.BtnPrimeiroReg.Location = New System.Drawing.Point(210, 10)
        Me.BtnPrimeiroReg.Name = "BtnPrimeiroReg"
        Me.BtnPrimeiroReg.Size = New System.Drawing.Size(31, 31)
        Me.BtnPrimeiroReg.TabIndex = 8
        Me.BtnPrimeiroReg.UseVisualStyleBackColor = True
        '
        'BtnGrid
        '
        Me.BtnGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGrid.Image = CType(resources.GetObject("BtnGrid.Image"), System.Drawing.Image)
        Me.BtnGrid.Location = New System.Drawing.Point(142, 10)
        Me.BtnGrid.Name = "BtnGrid"
        Me.BtnGrid.Size = New System.Drawing.Size(31, 31)
        Me.BtnGrid.TabIndex = 6
        Me.BtnGrid.UseVisualStyleBackColor = True
        '
        'BtnPesquisa
        '
        Me.BtnPesquisa.Image = CType(resources.GetObject("BtnPesquisa.Image"), System.Drawing.Image)
        Me.BtnPesquisa.Location = New System.Drawing.Point(74, 10)
        Me.BtnPesquisa.Name = "BtnPesquisa"
        Me.BtnPesquisa.Size = New System.Drawing.Size(31, 31)
        Me.BtnPesquisa.TabIndex = 4
        Me.BtnPesquisa.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(108, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(31, 31)
        Me.BtnLimpar.TabIndex = 5
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(6, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(31, 31)
        Me.BtnSalvar.TabIndex = 2
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(40, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(31, 31)
        Me.BtnExcluir.TabIndex = 3
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtCadPessoa
        '
        Me.BtCadPessoa.Image = CType(resources.GetObject("BtCadPessoa.Image"), System.Drawing.Image)
        Me.BtCadPessoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtCadPessoa.Location = New System.Drawing.Point(431, 13)
        Me.BtCadPessoa.Name = "BtCadPessoa"
        Me.BtCadPessoa.Size = New System.Drawing.Size(35, 31)
        Me.BtCadPessoa.TabIndex = 116
        Me.BtCadPessoa.UseVisualStyleBackColor = True
        '
        'FrmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtCadPessoa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvDespesa)
        Me.Name = "FrmDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDespesa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbCodEvento As TextBox
    Friend WithEvents TxbValDespesa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbObservacao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNomDespesa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbCodDespesa As TextBox
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
    Protected WithEvents GroupBox2 As GroupBox
    Protected WithEvents BtnCsv As Button
    Protected WithEvents BtnUltimoReg As Button
    Protected WithEvents BtnAnterior As Button
    Protected WithEvents BtnProximo As Button
    Protected WithEvents BtnPrimeiroReg As Button
    Protected WithEvents BtnGrid As Button
    Protected WithEvents BtnPesquisa As Button
    Protected WithEvents BtnLimpar As Button
    Protected WithEvents BtnSalvar As Button
    Protected WithEvents BtnExcluir As Button
End Class
