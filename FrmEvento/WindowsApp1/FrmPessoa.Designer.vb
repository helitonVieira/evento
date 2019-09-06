<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPessoa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPessoa))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxbEmail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxbObservacao = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxbFone3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxbFone2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxbFone1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxbCep = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxbBairro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbNomCidade = New System.Windows.Forms.TextBox()
        Me.TxbCodCidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxbComplemento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpDtaNasc = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxbNomFantasia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbRua = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbIeRg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbCnpjCpf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvPessoa = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CkbAtivo = New System.Windows.Forms.CheckBox()
        Me.CkbFuncionario = New System.Windows.Forms.CheckBox()
        Me.CkbFornecedor = New System.Windows.Forms.CheckBox()
        Me.CkbCliente = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BtSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 67)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
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
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(170, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
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
        'BtnExcluir
        '
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(62, 11)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(48, 50)
        Me.BtnExcluir.TabIndex = 6
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxbEmail)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxbObservacao)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxbFone3)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxbFone2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxbFone1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxbCep)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxbBairro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxbNomCidade)
        Me.GroupBox1.Controls.Add(Me.TxbCodCidade)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxbComplemento)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtpDtaNasc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxbNomFantasia)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxbRua)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxbIeRg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxbCnpjCpf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxbNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxbCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 329)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'TxbEmail
        '
        Me.TxbEmail.Location = New System.Drawing.Point(6, 305)
        Me.TxbEmail.Name = "TxbEmail"
        Me.TxbEmail.Size = New System.Drawing.Size(340, 20)
        Me.TxbEmail.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Email"
        '
        'TxbObservacao
        '
        Me.TxbObservacao.Location = New System.Drawing.Point(6, 266)
        Me.TxbObservacao.Name = "TxbObservacao"
        Me.TxbObservacao.Size = New System.Drawing.Size(340, 20)
        Me.TxbObservacao.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Observação"
        '
        'TxbFone3
        '
        Me.TxbFone3.Location = New System.Drawing.Point(6, 111)
        Me.TxbFone3.Name = "TxbFone3"
        Me.TxbFone3.Size = New System.Drawing.Size(80, 20)
        Me.TxbFone3.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Fone3"
        '
        'TxbFone2
        '
        Me.TxbFone2.Location = New System.Drawing.Point(266, 71)
        Me.TxbFone2.Name = "TxbFone2"
        Me.TxbFone2.Size = New System.Drawing.Size(80, 20)
        Me.TxbFone2.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(263, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Fone2"
        '
        'TxbFone1
        '
        Me.TxbFone1.Location = New System.Drawing.Point(180, 71)
        Me.TxbFone1.Name = "TxbFone1"
        Me.TxbFone1.Size = New System.Drawing.Size(80, 20)
        Me.TxbFone1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Fone1"
        '
        'TxbCep
        '
        Me.TxbCep.Location = New System.Drawing.Point(264, 187)
        Me.TxbCep.Name = "TxbCep"
        Me.TxbCep.Size = New System.Drawing.Size(80, 20)
        Me.TxbCep.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(261, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Cep"
        '
        'TxbBairro
        '
        Me.TxbBairro.Location = New System.Drawing.Point(6, 187)
        Me.TxbBairro.Name = "TxbBairro"
        Me.TxbBairro.Size = New System.Drawing.Size(252, 20)
        Me.TxbBairro.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Bairro"
        '
        'TxbNomCidade
        '
        Me.TxbNomCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomCidade.Location = New System.Drawing.Point(67, 227)
        Me.TxbNomCidade.Name = "TxbNomCidade"
        Me.TxbNomCidade.Size = New System.Drawing.Size(279, 20)
        Me.TxbNomCidade.TabIndex = 24
        '
        'TxbCodCidade
        '
        Me.TxbCodCidade.Location = New System.Drawing.Point(6, 227)
        Me.TxbCodCidade.Name = "TxbCodCidade"
        Me.TxbCodCidade.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodCidade.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Cidade"
        '
        'TxbComplemento
        '
        Me.TxbComplemento.Location = New System.Drawing.Point(266, 149)
        Me.TxbComplemento.Name = "TxbComplemento"
        Me.TxbComplemento.Size = New System.Drawing.Size(80, 20)
        Me.TxbComplemento.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Complemento"
        '
        'DtpDtaNasc
        '
        Me.DtpDtaNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaNasc.Location = New System.Drawing.Point(266, 111)
        Me.DtpDtaNasc.Name = "DtpDtaNasc"
        Me.DtpDtaNasc.Size = New System.Drawing.Size(80, 20)
        Me.DtpDtaNasc.TabIndex = 17
        Me.DtpDtaNasc.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(263, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Dta.Nasc"
        '
        'TxbNomFantasia
        '
        Me.TxbNomFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNomFantasia.Location = New System.Drawing.Point(6, 71)
        Me.TxbNomFantasia.Name = "TxbNomFantasia"
        Me.TxbNomFantasia.Size = New System.Drawing.Size(167, 20)
        Me.TxbNomFantasia.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nome Fantasia"
        '
        'TxbRua
        '
        Me.TxbRua.Location = New System.Drawing.Point(6, 149)
        Me.TxbRua.Name = "TxbRua"
        Me.TxbRua.Size = New System.Drawing.Size(252, 20)
        Me.TxbRua.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Rua"
        '
        'TxbIeRg
        '
        Me.TxbIeRg.Location = New System.Drawing.Point(180, 111)
        Me.TxbIeRg.Name = "TxbIeRg"
        Me.TxbIeRg.Size = New System.Drawing.Size(80, 20)
        Me.TxbIeRg.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(177, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IE/RG"
        '
        'TxbCnpjCpf
        '
        Me.TxbCnpjCpf.Location = New System.Drawing.Point(94, 111)
        Me.TxbCnpjCpf.Name = "TxbCnpjCpf"
        Me.TxbCnpjCpf.Size = New System.Drawing.Size(80, 20)
        Me.TxbCnpjCpf.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CNPJ/CPF"
        '
        'TxbNome
        '
        Me.TxbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxbNome.Location = New System.Drawing.Point(67, 34)
        Me.TxbNome.Name = "TxbNome"
        Me.TxbNome.Size = New System.Drawing.Size(279, 20)
        Me.TxbNome.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nome"
        '
        'TxbCodigo
        '
        Me.TxbCodigo.Enabled = False
        Me.TxbCodigo.Location = New System.Drawing.Point(6, 34)
        Me.TxbCodigo.Name = "TxbCodigo"
        Me.TxbCodigo.Size = New System.Drawing.Size(55, 20)
        Me.TxbCodigo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código"
        '
        'DgvPessoa
        '
        Me.DgvPessoa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPessoa.Location = New System.Drawing.Point(3, 3)
        Me.DgvPessoa.Name = "DgvPessoa"
        Me.DgvPessoa.Size = New System.Drawing.Size(370, 388)
        Me.DgvPessoa.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 423)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CkbAtivo)
        Me.GroupBox3.Controls.Add(Me.CkbFuncionario)
        Me.GroupBox3.Controls.Add(Me.CkbFornecedor)
        Me.GroupBox3.Controls.Add(Me.CkbCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 341)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 44)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'CkbAtivo
        '
        Me.CkbAtivo.AutoSize = True
        Me.CkbAtivo.Location = New System.Drawing.Point(304, 19)
        Me.CkbAtivo.Name = "CkbAtivo"
        Me.CkbAtivo.Size = New System.Drawing.Size(50, 17)
        Me.CkbAtivo.TabIndex = 3
        Me.CkbAtivo.Text = "Ativo"
        Me.CkbAtivo.UseVisualStyleBackColor = True
        '
        'CkbFuncionario
        '
        Me.CkbFuncionario.AutoSize = True
        Me.CkbFuncionario.Location = New System.Drawing.Point(153, 19)
        Me.CkbFuncionario.Name = "CkbFuncionario"
        Me.CkbFuncionario.Size = New System.Drawing.Size(81, 17)
        Me.CkbFuncionario.TabIndex = 2
        Me.CkbFuncionario.Text = "Funcionario"
        Me.CkbFuncionario.UseVisualStyleBackColor = True
        '
        'CkbFornecedor
        '
        Me.CkbFornecedor.AutoSize = True
        Me.CkbFornecedor.Location = New System.Drawing.Point(67, 19)
        Me.CkbFornecedor.Name = "CkbFornecedor"
        Me.CkbFornecedor.Size = New System.Drawing.Size(80, 17)
        Me.CkbFornecedor.TabIndex = 1
        Me.CkbFornecedor.Text = "Fornecedor"
        Me.CkbFornecedor.UseVisualStyleBackColor = True
        '
        'CkbCliente
        '
        Me.CkbCliente.AutoSize = True
        Me.CkbCliente.Location = New System.Drawing.Point(8, 19)
        Me.CkbCliente.Name = "CkbCliente"
        Me.CkbCliente.Size = New System.Drawing.Size(58, 17)
        Me.CkbCliente.TabIndex = 0
        Me.CkbCliente.Text = "Cliente"
        Me.CkbCliente.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvPessoa)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FrmPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 496)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmPessoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPessoa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvPessoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxbRua As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbIeRg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbCnpjCpf As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvPessoa As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxbNomFantasia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbEmail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxbObservacao As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxbFone3 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxbFone2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxbFone1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxbCep As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxbBairro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbNomCidade As TextBox
    Friend WithEvents TxbCodCidade As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxbComplemento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpDtaNasc As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CkbAtivo As CheckBox
    Friend WithEvents CkbFuncionario As CheckBox
    Friend WithEvents CkbFornecedor As CheckBox
    Friend WithEvents CkbCliente As CheckBox
End Class
