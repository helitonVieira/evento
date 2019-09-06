<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventarioRapido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventarioRapido))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtPresquisa = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbSeq = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustoTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustoUn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.btBuscaItem = New System.Windows.Forms.Button()
        Me.txtDesItem = New System.Windows.Forms.TextBox()
        Me.lbData = New System.Windows.Forms.Label()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Evento = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btMovimento = New System.Windows.Forms.Button()
        Me.txtDesTipoMovimento = New System.Windows.Forms.TextBox()
        Me.txtCodTipoMovimento = New System.Windows.Forms.TextBox()
        Me.btBuscaEvento = New System.Windows.Forms.Button()
        Me.txtDesEvento = New System.Windows.Forms.TextBox()
        Me.txtCodEvento = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Evento.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtPresquisa)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.BtSalvar)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 65)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'BtPresquisa
        '
        Me.BtPresquisa.Image = CType(resources.GetObject("BtPresquisa.Image"), System.Drawing.Image)
        Me.BtPresquisa.Location = New System.Drawing.Point(167, 9)
        Me.BtPresquisa.Name = "BtPresquisa"
        Me.BtPresquisa.Size = New System.Drawing.Size(48, 50)
        Me.BtPresquisa.TabIndex = 14
        Me.BtPresquisa.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(113, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtSalvar
        '
        Me.BtSalvar.Image = CType(resources.GetObject("BtSalvar.Image"), System.Drawing.Image)
        Me.BtSalvar.Location = New System.Drawing.Point(5, 9)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(48, 50)
        Me.BtSalvar.TabIndex = 11
        Me.BtSalvar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(59, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCodItem
        '
        Me.txtCodItem.Location = New System.Drawing.Point(6, 19)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.Size = New System.Drawing.Size(54, 20)
        Me.txtCodItem.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbSeq)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCustoTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCustoUn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtQtde)
        Me.GroupBox1.Controls.Add(Me.btBuscaItem)
        Me.GroupBox1.Controls.Add(Me.txtDesItem)
        Me.GroupBox1.Controls.Add(Me.txtCodItem)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 85)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'LbSeq
        '
        Me.LbSeq.AutoSize = True
        Me.LbSeq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSeq.Location = New System.Drawing.Point(282, 58)
        Me.LbSeq.Name = "LbSeq"
        Me.LbSeq.Size = New System.Drawing.Size(32, 13)
        Me.LbSeq.TabIndex = 14
        Me.LbSeq.Text = "Sequ"
        Me.LbSeq.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Custo Total"
        '
        'txtCustoTotal
        '
        Me.txtCustoTotal.Location = New System.Drawing.Point(190, 58)
        Me.txtCustoTotal.Name = "txtCustoTotal"
        Me.txtCustoTotal.Size = New System.Drawing.Size(86, 20)
        Me.txtCustoTotal.TabIndex = 11
        Me.txtCustoTotal.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Custo Un"
        '
        'txtCustoUn
        '
        Me.txtCustoUn.Location = New System.Drawing.Point(98, 58)
        Me.txtCustoUn.Name = "txtCustoUn"
        Me.txtCustoUn.Size = New System.Drawing.Size(86, 20)
        Me.txtCustoUn.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Qtde"
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(6, 58)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(86, 20)
        Me.txtQtde.TabIndex = 9
        '
        'btBuscaItem
        '
        Me.btBuscaItem.Image = CType(resources.GetObject("btBuscaItem.Image"), System.Drawing.Image)
        Me.btBuscaItem.Location = New System.Drawing.Point(343, 19)
        Me.btBuscaItem.Name = "btBuscaItem"
        Me.btBuscaItem.Size = New System.Drawing.Size(25, 21)
        Me.btBuscaItem.TabIndex = 8
        Me.btBuscaItem.UseVisualStyleBackColor = True
        '
        'txtDesItem
        '
        Me.txtDesItem.Location = New System.Drawing.Point(66, 19)
        Me.txtDesItem.Name = "txtDesItem"
        Me.txtDesItem.Size = New System.Drawing.Size(274, 20)
        Me.txtDesItem.TabIndex = 7
        '
        'lbData
        '
        Me.lbData.AutoSize = True
        Me.lbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbData.Location = New System.Drawing.Point(6, 246)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(30, 13)
        Me.lbData.TabIndex = 12
        Me.lbData.Text = "Data"
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(3, 262)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(374, 186)
        Me.dgvInventario.TabIndex = 12
        '
        'Evento
        '
        Me.Evento.Controls.Add(Me.Label5)
        Me.Evento.Controls.Add(Me.btMovimento)
        Me.Evento.Controls.Add(Me.txtDesTipoMovimento)
        Me.Evento.Controls.Add(Me.txtCodTipoMovimento)
        Me.Evento.Controls.Add(Me.btBuscaEvento)
        Me.Evento.Controls.Add(Me.txtDesEvento)
        Me.Evento.Controls.Add(Me.txtCodEvento)
        Me.Evento.Location = New System.Drawing.Point(3, 71)
        Me.Evento.Name = "Evento"
        Me.Evento.Size = New System.Drawing.Size(374, 84)
        Me.Evento.TabIndex = 13
        Me.Evento.TabStop = False
        Me.Evento.Text = "Evento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tipo Movimento"
        '
        'btMovimento
        '
        Me.btMovimento.Image = CType(resources.GetObject("btMovimento.Image"), System.Drawing.Image)
        Me.btMovimento.Location = New System.Drawing.Point(343, 57)
        Me.btMovimento.Name = "btMovimento"
        Me.btMovimento.Size = New System.Drawing.Size(25, 21)
        Me.btMovimento.TabIndex = 5
        Me.btMovimento.UseVisualStyleBackColor = True
        '
        'txtDesTipoMovimento
        '
        Me.txtDesTipoMovimento.Location = New System.Drawing.Point(66, 57)
        Me.txtDesTipoMovimento.Name = "txtDesTipoMovimento"
        Me.txtDesTipoMovimento.Size = New System.Drawing.Size(274, 20)
        Me.txtDesTipoMovimento.TabIndex = 4
        '
        'txtCodTipoMovimento
        '
        Me.txtCodTipoMovimento.Location = New System.Drawing.Point(6, 57)
        Me.txtCodTipoMovimento.Name = "txtCodTipoMovimento"
        Me.txtCodTipoMovimento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodTipoMovimento.TabIndex = 3
        '
        'btBuscaEvento
        '
        Me.btBuscaEvento.Image = CType(resources.GetObject("btBuscaEvento.Image"), System.Drawing.Image)
        Me.btBuscaEvento.Location = New System.Drawing.Point(343, 18)
        Me.btBuscaEvento.Name = "btBuscaEvento"
        Me.btBuscaEvento.Size = New System.Drawing.Size(25, 21)
        Me.btBuscaEvento.TabIndex = 2
        Me.btBuscaEvento.UseVisualStyleBackColor = True
        '
        'txtDesEvento
        '
        Me.txtDesEvento.Location = New System.Drawing.Point(66, 18)
        Me.txtDesEvento.Name = "txtDesEvento"
        Me.txtDesEvento.Size = New System.Drawing.Size(274, 20)
        Me.txtDesEvento.TabIndex = 1
        '
        'txtCodEvento
        '
        Me.txtCodEvento.Location = New System.Drawing.Point(6, 18)
        Me.txtCodEvento.Name = "txtCodEvento"
        Me.txtCodEvento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodEvento.TabIndex = 0
        '
        'FrmInventarioRapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 449)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.Evento)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmInventarioRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInventarioRapido"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Evento.ResumeLayout(False)
        Me.Evento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtPresquisa As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtSalvar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCodItem As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDesItem As TextBox
    Friend WithEvents lbData As Label
    Friend WithEvents btBuscaItem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustoTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustoUn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents Evento As GroupBox
    Friend WithEvents btBuscaEvento As Button
    Friend WithEvents txtDesEvento As TextBox
    Friend WithEvents txtCodEvento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btMovimento As Button
    Friend WithEvents txtDesTipoMovimento As TextBox
    Friend WithEvents txtCodTipoMovimento As TextBox
    Friend WithEvents LbSeq As Label
End Class
