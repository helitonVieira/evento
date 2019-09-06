<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLicencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLicencia))
        Me.TxtChave = New System.Windows.Forms.TextBox()
        Me.BtConfirma = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtChave
        '
        Me.TxtChave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtChave.Location = New System.Drawing.Point(6, 19)
        Me.TxtChave.MaxLength = 20
        Me.TxtChave.Name = "TxtChave"
        Me.TxtChave.Size = New System.Drawing.Size(188, 20)
        Me.TxtChave.TabIndex = 1
        '
        'BtConfirma
        '
        Me.BtConfirma.Image = CType(resources.GetObject("BtConfirma.Image"), System.Drawing.Image)
        Me.BtConfirma.Location = New System.Drawing.Point(2, 61)
        Me.BtConfirma.Name = "BtConfirma"
        Me.BtConfirma.Size = New System.Drawing.Size(93, 53)
        Me.BtConfirma.TabIndex = 2
        Me.BtConfirma.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Image = CType(resources.GetObject("BtCancelar.Image"), System.Drawing.Image)
        Me.BtCancelar.Location = New System.Drawing.Point(111, 61)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(93, 53)
        Me.BtCancelar.TabIndex = 3
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtChave)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 50)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Digite a chave"
        '
        'FrmLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 115)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtConfirma)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLicencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLicencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtChave As TextBox
    Friend WithEvents BtConfirma As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
