Public Class ClInventarioRapido
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL

    Private seq_inventario_ As Integer
    Public Property seq_inventario() As Integer
        Get
            Return seq_inventario_
        End Get
        Set(ByVal value As Integer)
            seq_inventario_ = value
        End Set
    End Property
    Private cod_evento_ As Integer
    Public Property cod_evento() As Integer
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As Integer)
            cod_evento_ = value
        End Set
    End Property
    Private cod_tipo_movimento_ As Integer
    Public Property cod_tipo_movimento() As Integer
        Get
            Return cod_tipo_movimento_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_movimento_ = value
        End Set
    End Property
    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property
    Private qtd_item_ As String
    Public Property qtd_item() As String
        Get
            Return qtd_item_
        End Get
        Set(ByVal value As String)
            qtd_item_ = value
        End Set
    End Property
    Private val_custo_unitario_ As String
    Public Property val_custo_unitario() As String
        Get
            Return val_custo_unitario_
        End Get
        Set(ByVal value As String)
            val_custo_unitario_ = value
        End Set
    End Property
    Private val_custo_total_ As String
    Public Property val_custo_total() As String
        Get
            Return val_custo_total_
        End Get
        Set(ByVal value As String)
            val_custo_total_ = value
        End Set
    End Property
    Private dta_inventario_ As Date
    Public Property dta_inventario() As Date
        Get
            Return dta_inventario_
        End Get
        Set(ByVal value As Date)
            dta_inventario_ = value
        End Set
    End Property
    Public Sub CadastrarInventario()
        sql = "Insert Into tab_inventario_rapido(cod_evento, cod_tipo_movimento,cod_item,qtd_item, val_custo_unitario, val_custo_total,dta_inventario) Values ('" & cod_evento & "' , '" & cod_tipo_movimento & "','" & cod_item & "','" & qtd_item & "','" & val_custo_unitario & "','" & val_custo_total & "','" & dta_inventario & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarInventario()
        sql = "Update tab_inventario_rapido Set cod_evento = " & cod_evento & " ,cod_tipo_movimento = " & cod_tipo_movimento & ",cod_item =" & cod_item & ",qtd_item =" & qtd_item & ",val_custo_unitario =" & val_custo_unitario & ",val_custo_total =" & val_custo_total & ",dta_inventario ='" & dta_inventario & "' Where seq_inventario = " & seq_inventario & ""
        con.Operar(sql)
    End Sub

    Public Sub ExcluirInventario()
        sql = " Delete from tab_inventario_rapido Where seq_inventario =" & seq_inventario & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarInventario()
        sql = "Select * From tab_inventario_rapido"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
