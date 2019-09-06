Public Class ClItem
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQ
    Dim ultimoItem As Integer

    Private cod_item_ As Integer
    Public Property cod_item() As Integer
        Get
            Return cod_item_
        End Get
        Set(ByVal value As Integer)
            cod_item_ = value
        End Set
    End Property

    Private des_item_ As String
    Public Property des_item() As String
        Get
            Return des_item_
        End Get
        Set(ByVal value As String)
            des_item_ = value
        End Set
    End Property

    Private val_preco_venda_ As String
    Public Property val_preco_venda() As String

        Get
            Return val_preco_venda_
        End Get
        Set(ByVal value As String)
            val_preco_venda_ = value
        End Set
    End Property

    Private val_custo_ As String
    Public Property val_custo() As String
        Get
            Return val_custo_
        End Get
        Set(ByVal value As String)
            val_custo_ = value
        End Set
    End Property

    Private ind_ativo_ As String
    Public Property ind_ativo() As String
        Get
            Return ind_ativo_
        End Get
        Set(ByVal value As String)
            ind_ativo_ = value
        End Set
    End Property

    Private cod_evento_ As String
    Public Property cod_evento() As String
        Get
            Return cod_evento_
        End Get
        Set(ByVal value As String)
            cod_evento_ = value
        End Set
    End Property

    Public Sub CadastrarItem()
        sql = "Insert Into tab_item( des_item, val_preco_venda, val_custo, ind_ativo, cod_evento) Values ('" & des_item & "' , '" & val_preco_venda & "','" & val_custo & "','" & ind_ativo & "','" & cod_evento & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarItem()
        sql = "Update tab_item Set des_item = '" & des_item & "' ,val_preco_venda = " & val_preco_venda & ",val_custo =" & val_custo & ",ind_ativo ='" & ind_ativo & "',cod_evento =" & cod_evento & " Where cod_item = " & cod_item & ""
        con.Operar(sql)
    End Sub
    Public Sub AtualizarItemEvento()
        sql = "Update tab_item Set des_item = '" & des_item & "' ,val_preco_venda = " & val_preco_venda & ",val_custo =" & val_custo & ",ind_ativo ='" & ind_ativo & "',cod_evento =" & cod_evento & " Where cod_evento = " & cod_evento & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirItem()
        sql = " Delete from tab_item Where cod_item =" & cod_item & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarItem()
        sql = "Select * From tab_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarItemCodigo()
        sql = "Select * From tab_item Where cod_item =" & cod_item & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarItemVenda()
        sql = "Select cod_item, 
                      des_item ,
                      val_preco_venda, 
                      val_custo 
              From tab_item
              where ind_ativo = 'S'"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarItemPesquisa(busca As String)

        sql = "Select * 
              From tab_item
              where des_item like ('%" & busca & "%')
                and ind_ativo = 'S'
              order by des_item"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoItemCadastrado()
        sql = "Select cast( max(cod_item) as varchar(5)) From tab_item"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
