<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmImprimirIngressos
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
        Me.DgvEvento = New System.Windows.Forms.DataGridView()
        Me.GroupBoxVendas = New System.Windows.Forms.GroupBox()
        Me.TxtCodItem = New System.Windows.Forms.TextBox()
        Me.LbDescricao = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtQtde = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVendas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEvento
        '
        Me.DgvEvento.AllowUserToAddRows = False
        Me.DgvEvento.AllowUserToDeleteRows = False
        Me.DgvEvento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEvento.Location = New System.Drawing.Point(6, 91)
        Me.DgvEvento.Name = "DgvEvento"
        Me.DgvEvento.ReadOnly = True
        Me.DgvEvento.Size = New System.Drawing.Size(547, 196)
        Me.DgvEvento.TabIndex = 0
        '
        'GroupBoxVendas
        '
        Me.GroupBoxVendas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxVendas.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBoxVendas.Controls.Add(Me.TxtCodItem)
        Me.GroupBoxVendas.Controls.Add(Me.DgvEvento)
        Me.GroupBoxVendas.Controls.Add(Me.LbDescricao)
        Me.GroupBoxVendas.Controls.Add(Me.Label2)
        Me.GroupBoxVendas.Controls.Add(Me.Label1)
        Me.GroupBoxVendas.Controls.Add(Me.TxtQtde)
        Me.GroupBoxVendas.Location = New System.Drawing.Point(2, 0)
        Me.GroupBoxVendas.Name = "GroupBoxVendas"
        Me.GroupBoxVendas.Size = New System.Drawing.Size(559, 293)
        Me.GroupBoxVendas.TabIndex = 12
        Me.GroupBoxVendas.TabStop = False
        '
        'TxtCodItem
        '
        Me.TxtCodItem.Location = New System.Drawing.Point(76, 16)
        Me.TxtCodItem.Name = "TxtCodItem"
        Me.TxtCodItem.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodItem.TabIndex = 1
        Me.TxtCodItem.Tag = "0"
        '
        'LbDescricao
        '
        Me.LbDescricao.AutoSize = True
        Me.LbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDescricao.Location = New System.Drawing.Point(182, 14)
        Me.LbDescricao.Name = "LbDescricao"
        Me.LbDescricao.Size = New System.Drawing.Size(0, 25)
        Me.LbDescricao.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Qtde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Item:"
        '
        'TxtQtde
        '
        Me.TxtQtde.Location = New System.Drawing.Point(76, 65)
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.Size = New System.Drawing.Size(100, 20)
        Me.TxtQtde.TabIndex = 2
        Me.TxtQtde.Tag = "1"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "///"
        '
        'FrmImprimirIngressos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 294)
        Me.Controls.Add(Me.GroupBoxVendas)
        Me.Name = "FrmImprimirIngressos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmImprimirIngressos"
        CType(Me.DgvEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVendas.ResumeLayout(False)
        Me.GroupBoxVendas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEvento As DataGridView
    Friend WithEvents GroupBoxVendas As GroupBox
    Friend WithEvents TxtCodItem As TextBox
    Friend WithEvents LbDescricao As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtQtde As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
