Public Class ClAnimalPelagem
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQ
    Dim ultimoPelagem As Integer

    Private cod_pelagem_ As Integer
    Public Property cod_pelagem() As Integer
        Get
            Return cod_pelagem_
        End Get
        Set(ByVal value As Integer)
            cod_pelagem_ = value
        End Set
    End Property

    Private des_pelagem_ As String
    Public Property des_pelagem() As String
        Get
            Return des_pelagem_
        End Get
        Set(ByVal value As String)
            des_pelagem_ = value
        End Set
    End Property
    Public Sub CadastrarPelagem()
        sql = "Insert Into tab_animal_pelagem( cod_pelagem ,des_pelagem) Values (" & cod_pelagem & ",'" & des_pelagem & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarPelagem()
        sql = "Update tab_animal_pelagem Set des_pelagem = '" & des_pelagem & "'  Where cod_pelagem = " & cod_pelagem & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirPelagem()
        sql = " Delete from tab_animal_pelagem Where cod_pelagem =" & cod_pelagem & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarPelagem(cod As Integer, desc As String)
        sql = "Select cod_pelagem,
                      des_pelagem
               From tab_animal_pelagem
               where ((des_pelagem like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_pelagem = " & cod & " )or (0 = " & cod & "))
              order by des_pelagem"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPelagemCodigo()
        sql = "Select * From tab_animal_pelagem Where cod_pelagem =" & cod_pelagem & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPelagemPesquisa(busca As String)
        sql = "Select * 
              From tab_animal_pelagem
              where des_pelagem like ('%" & busca & "%')               
              order by des_pelagem"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoPelagemCadastrado()
        sql = "Select coalesce(cast( max(cod_pelagem) as varchar(5)),0)as ultimo From tab_animal_pelagem"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
