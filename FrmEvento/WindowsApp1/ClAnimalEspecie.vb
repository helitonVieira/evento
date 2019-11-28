Public Class ClAnimalEspecie
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQ
    Dim ultimoEspecie As Integer

    Private cod_especie_ As Integer
    Public Property cod_especie() As Integer
        Get
            Return cod_especie_
        End Get
        Set(ByVal value As Integer)
            cod_especie_ = value
        End Set
    End Property

    Private des_especie_ As String
    Public Property des_especie() As String
        Get
            Return des_especie_
        End Get
        Set(ByVal value As String)
            des_especie_ = value
        End Set
    End Property
    Public Sub CadastrarEspecie()
        sql = "Insert Into tab_animal_especie( cod_especie ,des_especie) Values (" & cod_especie & ",'" & des_especie & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarEspecie()
        sql = "Update tab_animal_especie Set des_especie = '" & des_especie & "'  Where cod_especie = " & cod_especie & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirEspecie()
        sql = " Delete from tab_animal_especie Where cod_especie =" & cod_especie & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarEspecie(cod As Integer, desc As String)
        sql = "Select cod_especie,
                      des_especie
               From tab_animal_especie
               where ((des_especie like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_especie = " & cod & " )or (0 = " & cod & "))
              order by des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarEspecieCodigo()
        sql = "Select * From tab_animal_especie Where cod_especie =" & cod_especie & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarEspeciePesquisa(busca As String)
        sql = "Select * 
              From tab_animal_especie
              where des_especie like ('%" & busca & "%')               
              order by des_especie"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoEspecieCadastrado()
        sql = "Select coalesce(cast( max(cod_especie) as varchar(5)),0)as ultimo From tab_animal_especie"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
