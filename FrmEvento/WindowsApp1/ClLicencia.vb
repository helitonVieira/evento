Public Class ClLicencia
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQ
    ' Dim ultimoItem As Integer

    Private des_chave_ As String
    Public Property des_chave() As String
        Get
            Return des_chave_
        End Get
        Set(ByVal value As String)
            des_chave_ = value
        End Set
    End Property
    Public Sub Cadastrar()
        sql = "Insert Into tab_licencia( des_chave) Values ('" & des_chave & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizar()
        sql = "Update tab_licencia Set des_chave = '" & des_chave & "'"
        con.Operar(sql)
    End Sub
    Public Function buscaLicencia()
        sql = "Select des_chave From tab_licencia"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
