Public Class ClTipoParcelamento
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQL
    Dim ultimo As Integer

    Private cod_tipo_ As Integer
    Public Property cod_tipo() As Integer
        Get
            Return cod_tipo_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_ = value
        End Set
    End Property

    Private des_tipo_ As String
    Public Property des_tipo() As String
        Get
            Return des_tipo_
        End Get
        Set(ByVal value As String)
            des_tipo_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_tipo_parcelamento( cod_tipo ,des_tipo) Values (" & cod_tipo & ",'" & des_tipo & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_tipo_parcelamento Set des_tipo = '" & des_tipo & "'  Where cod_tipo = " & cod_tipo & ""
        con.Operar(sql)
    End Sub
    Public Sub Excluir()
        sql = " Delete from tab_tipo_parcelamento Where cod_tipo =" & cod_tipo & ""
        con.Operar(sql)
    End Sub

    Public Function Consultar(cod As Integer, desc As String)
        sql = "Select cod_tipo,
                      des_tipo
               From tab_tipo_parcelamento
               where ((des_tipo like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_tipo = " & cod & " )or (0 = " & cod & "))
              order by des_tipo"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarCodigo()
        sql = "Select * From tab_tipo_parcelamento Where cod_tipo =" & cod_tipo & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPesquisa(busca As String)
        sql = "Select * 
              From tab_tipo_parcelamento
              where des_tipo like ('%" & busca & "%')               
              order by des_tipo"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoCadastrado()
        sql = "Select coalesce(cast( max(cod_tipo) as varchar(5)),0)as ultimo From tab_tipo_parcelamento"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
