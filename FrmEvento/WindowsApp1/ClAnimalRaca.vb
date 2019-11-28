Public Class ClAnimalRaca
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQ
    Dim ultimoRaca As Integer

    Private cod_raca_ As Integer
    Public Property cod_raca() As Integer
        Get
            Return cod_raca_
        End Get
        Set(ByVal value As Integer)
            cod_raca_ = value
        End Set
    End Property

    Private des_raca_ As String
    Public Property des_raca() As String
        Get
            Return des_raca_
        End Get
        Set(ByVal value As String)
            des_raca_ = value
        End Set
    End Property
    Public Sub CadastrarRaca()
        sql = "Insert Into tab_animal_raca( cod_raca ,des_raca) Values (" & cod_raca & ",'" & des_raca & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarRaca()
        sql = "Update tab_animal_raca Set des_raca = '" & des_raca & "'  Where cod_raca = " & cod_raca & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirRaca()
        sql = " Delete from tab_animal_raca Where cod_raca =" & cod_raca & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarRaca(cod As Integer, desc As String)
        sql = "Select cod_raca,
                      des_raca
               From tab_animal_raca
               where ((des_raca like ('%" & desc & "%') )or ('' = '" & desc & "' ))  
                 and ((cod_raca = " & cod & " )or (0 = " & cod & "))
              order by des_raca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarRacaCodigo()
        sql = "Select * From tab_animal_raca Where cod_raca =" & cod_raca & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarRacaPesquisa(busca As String)
        sql = "Select * 
              From tab_animal_raca
              where des_raca like ('%" & busca & "%')               
              order by des_raca"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoRacaCadastrado()
        sql = "Select coalesce(cast( max(cod_raca) as varchar(5)),0)as ultimo From tab_animal_raca"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
