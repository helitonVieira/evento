<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmParametroSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmParametroSistema))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbIngresso = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbImgIngAltura = New Controles.TxbCodigo()
        Me.TxbImgIngLargura = New Controles.TxbCodigo()
        Me.TxbImgIngMargEsquerda = New Controles.TxbCodigo()
        Me.TxbImgIngMargCabecalho = New Controles.TxbCodigo()
        Me.txb_fontIngresso = New Controles.TxbCodigo()
        Me.txbFontProduto = New Controles.TxbCodigo()
        Me.BtnGravar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbIngresso.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(500, 301)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(500, 292)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Eventos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGravar)
        Me.GroupBox1.Controls.Add(Me.txbFontProduto)
        Me.GroupBox1.Controls.Add(Me.GbIngresso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alterar tamanho fonte Produtos:"
        '
        'GbIngresso
        '
        Me.GbIngresso.Controls.Add(Me.txb_fontIngresso)
        Me.GbIngresso.Controls.Add(Me.GroupBox3)
        Me.GbIngresso.Controls.Add(Me.Label2)
        Me.GbIngresso.Location = New System.Drawing.Point(6, 77)
        Me.GbIngresso.Name = "GbIngresso"
        Me.GbIngresso.Size = New System.Drawing.Size(476, 153)
        Me.GbIngresso.TabIndex = 11
        Me.GbIngresso.TabStop = False
        Me.GbIngresso.Text = "Ingresso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Alterar tamanho Fonte Ingressos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxbImgIngMargCabecalho)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngMargEsquerda)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngLargura)
        Me.GroupBox3.Controls.Add(Me.TxbImgIngAltura)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(276, 109)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Imagem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Margem Esquerda:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Margem Cabeçalho:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Largura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Altura:"
        '
        'TxbImgIngAltura
        '
        Me.TxbImgIngAltura.Location = New System.Drawing.Point(161, 13)
        Me.TxbImgIngAltura.Name = "TxbImgIngAltura"
        Me.TxbImgIngAltura.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngAltura.TabIndex = 23
        '
        'TxbImgIngLargura
        '
        Me.TxbImgIngLargura.Location = New System.Drawing.Point(161, 36)
        Me.TxbImgIngLargura.Name = "TxbImgIngLargura"
        Me.TxbImgIngLargura.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngLargura.TabIndex = 24
        '
        'TxbImgIngMargEsquerda
        '
        Me.TxbImgIngMargEsquerda.Location = New System.Drawing.Point(161, 59)
        Me.TxbImgIngMargEsquerda.Name = "TxbImgIngMargEsquerda"
        Me.TxbImgIngMargEsquerda.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngMargEsquerda.TabIndex = 25
        '
        'TxbImgIngMargCabecalho
        '
        Me.TxbImgIngMargCabecalho.Location = New System.Drawing.Point(161, 82)
        Me.TxbImgIngMargCabecalho.Name = "TxbImgIngMargCabecalho"
        Me.TxbImgIngMargCabecalho.Size = New System.Drawing.Size(100, 20)
        Me.TxbImgIngMargCabecalho.TabIndex = 26
        '
        'txb_fontIngresso
        '
        Me.txb_fontIngresso.Location = New System.Drawing.Point(172, 16)
        Me.txb_fontIngresso.Name = "txb_fontIngresso"
        Me.txb_fontIngresso.Size = New System.Drawing.Size(100, 20)
        Me.txb_fontIngresso.TabIndex = 22
        '
        'txbFontProduto
        '
        Me.txbFontProduto.Location = New System.Drawing.Point(172, 14)
        Me.txbFontProduto.Name = "txbFontProduto"
        Me.txbFontProduto.Size = New System.Drawing.Size(100, 20)
        Me.txbFontProduto.TabIndex = 12
        '
        'BtnGravar
        '
        Me.BtnGravar.Image = CType(resources.GetObject("BtnGravar.Image"), System.Drawing.Image)
        Me.BtnGravar.Location = New System.Drawing.Point(451, 9)
        Me.BtnGravar.Name = "BtnGravar"
        Me.BtnGravar.Size = New System.Drawing.Size(31, 31)
        Me.BtnGravar.TabIndex = 13
        Me.BtnGravar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(508, 318)
        Me.TabControl1.TabIndex = 1
        '
        'FrmParametroSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 332)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmParametroSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parametros Sistema"
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbIngresso.ResumeLayout(False)
        Me.GbIngresso.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Protected WithEvents BtnGravar As Button
    Friend WithEvents txbFontProduto As Controles.TxbCodigo
    Friend WithEvents GbIngresso As GroupBox
    Friend WithEvents txb_fontIngresso As Controles.TxbCodigo
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxbImgIngMargCabecalho As Controles.TxbCodigo
    Friend WithEvents TxbImgIngMargEsquerda As Controles.TxbCodigo
    Friend WithEvents TxbImgIngLargura As Controles.TxbCodigo
    Friend WithEvents TxbImgIngAltura As Controles.TxbCodigo
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
End Class
