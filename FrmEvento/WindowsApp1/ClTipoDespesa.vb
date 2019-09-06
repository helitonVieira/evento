Public Class ClTipoDespesa
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQ

    Private cod_tipo_despesa_ As Integer
    Public Property cod_tipo_despesa() As Integer
        Get
            Return cod_tipo_despesa_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_despesa_ = value
        End Set
    End Property
    Private des_tipo_despesa_ As String
    Public Property des_tipo_despesa() As String
        Get
            Return des_tipo_despesa_
        End Get
        Set(ByVal value As String)
            des_tipo_despesa_ = value
        End Set
    End Property
    Private ind_entrada_ As String
    Public Property ind_entrada() As String
        Get
            Return ind_entrada_
        End Get
        Set(ByVal value As String)
            ind_entrada_ = value
        End Set
    End Property
    Public Sub CadastrarTipoDespesa()
        sql = "Insert Into tab_tipo_despesa(cod_tipo_despesa,	des_tipo_despesa) Values ('" & cod_tipo_despesa & "' , '" & des_tipo_despesa & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarTipoDespesa()
        sql = "Update tab_tipo_despesa Set des_tipo_despesa = '" & des_tipo_despesa & "'  Where cod_tipo_despesa = " & cod_tipo_despesa & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirTipoDespesa()
        sql = " Delete from tab_tipo_despesa Where cod_tipo_despesa =" & cod_tipo_despesa & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarTipoDespesa(busca As String)
        sql = "Select * From tab_tipo_despesa
                where des_tipo_despesa like ('%" & busca & "%')
                 order by des_tipo_despesa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarTipoDespesaCodigo()
        sql = "Select * From tab_tipo_despesa Where cod_tipo_despesa =" & cod_tipo_despesa & ""
        ds = con.Listar(sql)
        Return ds
    End Function


End Class
