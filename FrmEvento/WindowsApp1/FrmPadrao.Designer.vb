<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPadrao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPadrao))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BtSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 67)
        Me.GroupBox2.TabIndex = 12
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
        'FrmPadrao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "FrmPadrao"
        Me.Text = "FrmPadrao"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtnExcluir As Button
End Class
