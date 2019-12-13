Public Class ClUsuario
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL

    Private cod_usuario_ As Integer
    Public Property cod_usuario() As Integer
        Get
            Return cod_usuario_
        End Get
        Set(ByVal value As Integer)
            cod_usuario_ = value
        End Set
    End Property
    Private nom_usuario_ As String
    Public Property nom_usuario() As String
        Get
            Return nom_usuario_
        End Get
        Set(ByVal value As String)
            nom_usuario_ = value
        End Set
    End Property
    Private des_senha_ As String
    Public Property des_senha() As String
        Get
            Return des_senha_
        End Get
        Set(ByVal value As String)
            des_senha_ = value
        End Set
    End Property
    Private des_permissao_usuario_ As String
    Public Property des_permissao_usuario() As String
        Get
            Return des_permissao_usuario_
        End Get
        Set(ByVal value As String)
            des_permissao_usuario_ = value
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

    Public Sub CadastrarUsuario()
        sql = "Insert Into tab_usuario(nom_usuario, des_senha, des_permissao_usuario, ind_ativo) Values ('" & nom_usuario & "' , '" & des_senha & "','" & des_permissao_usuario & "','" & ind_ativo & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarUsuario()
        sql = "Update tab_usuario Set nom_usuario = '" & nom_usuario & "' ,des_senha = '" & des_senha & "',des_permissao_usuario ='" & des_permissao_usuario & "',ind_ativo ='" & ind_ativo & "'  Where cod_usuario = " & cod_usuario & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirUsuario()
        sql = " Delete from tab_usuario Where cod_usuario =" & cod_usuario & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarUsuario()
        sql = "Select * From tab_usuario"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarUsuarioExpecifico1()
        sql = "Select * From tab_usuario Where nom_usuario ='" & nom_usuario & "' and des_senha = '" & des_senha & "'"
        ds = con.Listar(sql)
        Return ds
    End Function

End Class
