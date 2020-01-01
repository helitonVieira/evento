<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbMonetario1 = New Controles.TxbMonetario()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtSecao = New System.Windows.Forms.Button()
        Me.txbDesSecao = New System.Windows.Forms.TextBox()
        Me.TxbCodSecao = New Controles.TxbCodigo()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxbCodigo1 = New Controles.TxbCodigo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxbMonetario2 = New Controles.TxbMonetario()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxbDtaNasc = New Controles.TxbData()
        Me.DtpDtaNasc = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TxbMonetario3 = New Controles.TxbMonetario()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbMonetario4 = New Controles.TxbMonetario()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnLimparParasita = New System.Windows.Forms.Button()
        Me.BtnSalvaParasita = New System.Windows.Forms.Button()
        Me.BtnExcluirParasita = New System.Windows.Forms.Button()
        Me.DgvContParasitario = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxbMonetario5 = New Controles.TxbMonetario()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxbCodigo2 = New Controles.TxbCodigo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxbCodigo3 = New Controles.TxbCodigo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvContParasitario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxbMonetario1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtSecao)
        Me.GroupBox1.Controls.Add(Me.txbDesSecao)
        Me.GroupBox1.Controls.Add(Me.TxbCodSecao)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caixa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Valor:"
        '
        'TxbMonetario1
        '
        Me.TxbMonetario1.Location = New System.Drawing.Point(438, 16)
        Me.TxbMonetario1.Name = "TxbMonetario1"
        Me.TxbMonetario1.Size = New System.Drawing.Size(100, 20)
        Me.TxbMonetario1.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Espécie:"
        '
        'BtSecao
        '
        Me.BtSecao.Image = CType(resources.GetObject("BtSecao.Image"), System.Drawing.Image)
        Me.BtSecao.Location = New System.Drawing.Point(371, 16)
        Me.BtSecao.Name = "BtSecao"
        Me.BtSecao.Size = New System.Drawing.Size(25, 21)
        Me.BtSecao.TabIndex = 45
        Me.BtSecao.UseVisualStyleBackColor = True
        '
        'txbDesSecao
        '
        Me.txbDesSecao.Location = New System.Drawing.Point(141, 16)
        Me.txbDesSecao.Name = "txbDesSecao"
        Me.txbDesSecao.Size = New System.Drawing.Size(229, 20)
        Me.txbDesSecao.TabIndex = 44
        '
        'TxbCodSecao
        '
        Me.TxbCodSecao.Location = New System.Drawing.Point(75, 16)
        Me.TxbCodSecao.Name = "TxbCodSecao"
        Me.TxbCodSecao.Size = New System.Drawing.Size(60, 20)
        Me.TxbCodSecao.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TxbMonetario2)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TxbCodigo1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Banco"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.BtnLimparParasita)
        Me.GroupBox3.Controls.Add(Me.BtnSalvaParasita)
        Me.GroupBox3.Controls.Add(Me.BtnExcluirParasita)
        Me.GroupBox3.Controls.Add(Me.DgvContParasitario)
        Me.GroupBox3.Controls.Add(Me.TxbMonetario4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TxbMonetario3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxbDtaNasc)
        Me.GroupBox3.Controls.Add(Me.DtpDtaNasc)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 232)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parcelado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Mnemônico:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(217, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 21)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 20)
        Me.TextBox1.TabIndex = 48
        '
        'TxbCodigo1
        '
        Me.TxbCodigo1.Location = New System.Drawing.Point(75, 16)
        Me.TxbCodigo1.Name = "TxbCodigo1"
        Me.TxbCodigo1.Size = New System.Drawing.Size(43, 20)
        Me.TxbCodigo1.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Agencia:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(254, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(284, 20)
        Me.TextBox2.TabIndex = 51
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(136, 20)
        Me.TextBox3.TabIndex = 52
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(254, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(89, 20)
        Me.TextBox4.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Conta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Valor:"
        '
        'TxbMonetario2
        '
        Me.TxbMonetario2.Location = New System.Drawing.Point(438, 39)
        Me.TxbMonetario2.Name = "TxbMonetario2"
        Me.TxbMonetario2.Size = New System.Drawing.Size(100, 20)
        Me.TxbMonetario2.TabIndex = 55
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(542, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 21)
        Me.Button2.TabIndex = 48
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(542, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 21)
        Me.Button3.TabIndex = 49
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TxbDtaNasc
        '
        Me.TxbDtaNasc.Location = New System.Drawing.Point(69, 16)
        Me.TxbDtaNasc.MaxLength = 10
        Me.TxbDtaNasc.Name = "TxbDtaNasc"
        Me.TxbDtaNasc.Size = New System.Drawing.Size(66, 20)
        Me.TxbDtaNasc.TabIndex = 19
        '
        'DtpDtaNasc
        '
        Me.DtpDtaNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaNasc.Location = New System.Drawing.Point(137, 16)
        Me.DtpDtaNasc.Name = "DtpDtaNasc"
        Me.DtpDtaNasc.Size = New System.Drawing.Size(14, 20)
        Me.DtpDtaNasc.TabIndex = 20
        Me.DtpDtaNasc.Value = New Date(2018, 8, 31, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Vencimento:"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(336, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 21)
        Me.Button4.TabIndex = 51
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TxbMonetario3
        '
        Me.TxbMonetario3.Location = New System.Drawing.Point(232, 17)
        Me.TxbMonetario3.Name = "TxbMonetario3"
        Me.TxbMonetario3.Size = New System.Drawing.Size(100, 20)
        Me.TxbMonetario3.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Valor:"
        '
        'TxbMonetario4
        '
        Me.TxbMonetario4.Location = New System.Drawing.Point(438, 16)
        Me.TxbMonetario4.Name = "TxbMonetario4"
        Me.TxbMonetario4.Size = New System.Drawing.Size(100, 20)
        Me.TxbMonetario4.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Juros:"
        '
        'BtnLimparParasita
        '
        Me.BtnLimparParasita.Image = CType(resources.GetObject("BtnLimparParasita.Image"), System.Drawing.Image)
        Me.BtnLimparParasita.Location = New System.Drawing.Point(460, 178)
        Me.BtnLimparParasita.Name = "BtnLimparParasita"
        Me.BtnLimparParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnLimparParasita.TabIndex = 56
        Me.BtnLimparParasita.UseVisualStyleBackColor = True
        '
        'BtnSalvaParasita
        '
        Me.BtnSalvaParasita.Image = CType(resources.GetObject("BtnSalvaParasita.Image"), System.Drawing.Image)
        Me.BtnSalvaParasita.Location = New System.Drawing.Point(460, 104)
        Me.BtnSalvaParasita.Name = "BtnSalvaParasita"
        Me.BtnSalvaParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnSalvaParasita.TabIndex = 54
        Me.BtnSalvaParasita.UseVisualStyleBackColor = True
        '
        'BtnExcluirParasita
        '
        Me.BtnExcluirParasita.Image = CType(resources.GetObject("BtnExcluirParasita.Image"), System.Drawing.Image)
        Me.BtnExcluirParasita.Location = New System.Drawing.Point(460, 141)
        Me.BtnExcluirParasita.Name = "BtnExcluirParasita"
        Me.BtnExcluirParasita.Size = New System.Drawing.Size(30, 31)
        Me.BtnExcluirParasita.TabIndex = 55
        Me.BtnExcluirParasita.UseVisualStyleBackColor = True
        '
        'DgvContParasitario
        '
        Me.DgvContParasitario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContParasitario.Location = New System.Drawing.Point(7, 104)
        Me.DgvContParasitario.Name = "DgvContParasitario"
        Me.DgvContParasitario.Size = New System.Drawing.Size(448, 118)
        Me.DgvContParasitario.TabIndex = 57
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxbCodigo2)
        Me.GroupBox4.Controls.Add(Me.TxbCodigo3)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TxbMonetario5)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 55)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gerar Parcelas Automaticas"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Dia Fixo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxbMonetario5
        '
        Me.TxbMonetario5.Location = New System.Drawing.Point(301, 26)
        Me.TxbMonetario5.Name = "TxbMonetario5"
        Me.TxbMonetario5.Size = New System.Drawing.Size(100, 20)
        Me.TxbMonetario5.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(263, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Juros"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Parcela"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(418, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Qtde:"
        '
        'TxbCodigo2
        '
        Me.TxbCodigo2.Location = New System.Drawing.Point(449, 26)
        Me.TxbCodigo2.Name = "TxbCodigo2"
        Me.TxbCodigo2.Size = New System.Drawing.Size(100, 20)
        Me.TxbCodigo2.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Intervalo"
        '
        'TxbCodigo3
        '
        Me.TxbCodigo3.Location = New System.Drawing.Point(145, 22)
        Me.TxbCodigo3.Name = "TxbCodigo3"
        Me.TxbCodigo3.Size = New System.Drawing.Size(100, 20)
        Me.TxbCodigo3.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Vencimento"
        '
        'FrmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 381)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPagamento"
        Me.Text = "FrmPagamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvContParasitario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbMonetario1 As Controles.TxbMonetario
    Friend WithEvents Label1 As Label
    Friend WithEvents BtSecao As Button
    Friend WithEvents txbDesSecao As TextBox
    Friend WithEvents TxbCodSecao As Controles.TxbCodigo
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxbMonetario2 As Controles.TxbMonetario
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxbCodigo1 As Controles.TxbCodigo
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbMonetario4 As Controles.TxbMonetario
    Friend WithEvents Label9 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TxbMonetario3 As Controles.TxbMonetario
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbDtaNasc As Controles.TxbData
    Friend WithEvents DtpDtaNasc As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxbCodigo3 As Controles.TxbCodigo
    Friend WithEvents Label12 As Label
    Friend WithEvents TxbCodigo2 As Controles.TxbCodigo
    Friend WithEvents Label11 As Label
    Friend WithEvents TxbMonetario5 As Controles.TxbMonetario
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnLimparParasita As Button
    Friend WithEvents BtnSalvaParasita As Button
    Friend WithEvents BtnExcluirParasita As Button
    Friend WithEvents DgvContParasitario As DataGridView
End Class
