Public Class ClDespesa
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQL
    Dim ultimodespesa As Integer

    Private cod_despesa_ As Integer
    Public Property cod_despesa() As Integer
        Get
            Return cod_despesa_
        End Get
        Set(ByVal value As Integer)
            cod_despesa_ = value
        End Set
    End Property

    Private des_despesa_ As String
    Public Property des_despesa() As String
        Get
            Return des_despesa_
        End Get
        Set(ByVal value As String)
            des_despesa_ = value
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

    Private cod_pessoa_favorecido_ As Integer
    Public Property cod_pessoa_favorecido() As Integer
        Get
            Return cod_pessoa_favorecido_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_favorecido_ = value
        End Set
    End Property
    Private cod_tipo_despesa_ As Integer
    Public Property cod_tipo_despesa() As Integer
        Get
            Return cod_tipo_despesa_
        End Get
        Set(ByVal value As Integer)
            cod_tipo_despesa_ = value
        End Set
    End Property

    Private cod_pessoa_funcionario_ As Integer
    Public Property cod_pessoa_funcionario() As Integer
        Get
            Return cod_pessoa_funcionario_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_funcionario_ = value
        End Set
    End Property

    Private dta_despesa_ As Date
    Public Property dta_despesa() As Date
        Get
            Return dta_despesa_
        End Get
        Set(ByVal value As Date)
            dta_despesa_ = value
        End Set
    End Property

    Private des_observacao_ As String
    Public Property des_observacao() As String
        Get
            Return des_observacao_
        End Get
        Set(ByVal value As String)
            des_observacao_ = value
        End Set
    End Property

    Private val_despesa_ As String
    Public Property val_despesa() As String
        Get
            Return val_despesa_
        End Get
        Set(ByVal value As String)
            val_despesa_ = value
        End Set
    End Property

    Public Sub Cadastrardespesa()
        sql = "Insert Into tab_despesa( des_despesa,
                                        cod_evento,
                                       cod_pessoa_favorecido,
                                       cod_tipo_despesa, 
                                       cod_pessoa_funcionario,      
                                       dta_despesa,
                                       des_observacao, 
                                       val_despesa)
                       Values ('" & des_despesa & "',
                               " & cod_evento & ",
                               " & cod_pessoa_favorecido & " ,
                               " & cod_tipo_despesa & ",
                               " & cod_pessoa_funcionario & ",
                               '" & dta_despesa & "',
                               '" & des_observacao & "',
                               '" & val_despesa & "')"
        con.Operar(sql)
    End Sub

    Public Sub Atualizardespesa()
        sql = "Update tab_despesa Set des_despesa = '" & des_despesa & "' ,
                                      cod_evento = " & cod_evento & " ,
                                      cod_pessoa_favorecido = " & cod_pessoa_favorecido & " ,
                                      cod_tipo_despesa = " & cod_tipo_despesa & ",
                                      cod_pessoa_funcionario = " & cod_pessoa_funcionario & ",
                                      dta_despesa ='" & dta_despesa & "',
                                      des_observacao ='" & des_observacao & "',
                                      val_despesa ='" & val_despesa & "' 
                                      Where cod_despesa = " & cod_despesa & ""
        con.Operar(sql)
    End Sub

    Public Sub Excluirdespesa()
        sql = " Delete from tab_despesa Where cod_despesa =" & cod_despesa & ""
        con.Operar(sql)
    End Sub
    Public Function Consultardespesa()
        sql = "Select a.cod_despesa ,
                   a.des_despesa ,
            	   a.cod_evento ,
            	   b.nom_evento ,
            	   a.cod_pessoa_favorecido ,
            	   c.nom_pessoa , 
            	   a.cod_tipo_despesa ,
            	   d.des_tipo_despesa ,
                   a.cod_pessoa_funcionario,
                   e.nom_pessoa as nom_pessoa_funcionario,
            	   a.dta_despesa ,
            	   a.des_observacao ,
            	   a.val_despesa 
            From tab_despesa a
            join tab_evento b on (a.cod_evento = b.cod_evento )
            join tab_pessoa c on (c.COD_PESSOA = a.cod_pessoa_favorecido )
            join tab_tipo_despesa d on (a.cod_tipo_despesa = d.cod_tipo_despesa )
            join tab_pessoa e on (e.COD_PESSOA = a.cod_pessoa_funcionario)"

        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultardespesaPesquisa()
        sql = "Select a.cod_despesa ,
                   a.des_despesa ,
            	   a.cod_evento ,
            	   b.nom_evento ,
            	   a.cod_pessoa_favorecido ,
            	   c.nom_pessoa , 
            	   a.cod_tipo_despesa ,
            	   d.des_tipo_despesa ,
                   a.cod_pessoa_funcionario,
                   e.nom_pessoa as nom_pessoa_funcionario,
            	   a.dta_despesa ,
            	   a.des_observacao ,
            	   a.val_despesa 
            From tab_despesa a
            join tab_evento b on (a.cod_evento = b.cod_evento )
            join tab_pessoa c on (c.COD_PESSOA = a.cod_pessoa_favorecido )
            join tab_tipo_despesa d on (a.cod_tipo_despesa = d.cod_tipo_despesa )
            join tab_pessoa e on (e.COD_PESSOA = a.cod_pessoa_funcionario)
            where  ((a.cod_despesa = " & cod_despesa & ")or(" & cod_despesa & " = 0 ))
              and (( a.des_despesa like ('% " & des_despesa & "%'))or ('" & des_despesa & "'  = '" & "" & "' ))
              and  ((a.cod_evento = " & cod_evento & ")or(" & cod_evento & " = 0 ))
              and  ((a.cod_pessoa_favorecido = " & cod_pessoa_favorecido & ")or(" & cod_pessoa_favorecido & " = 0 ))
              and  ((a.cod_tipo_despesa = " & cod_tipo_despesa & ")or(" & cod_tipo_despesa & " = 0 ))
              and  ((a.cod_pessoa_funcionario = " & cod_pessoa_funcionario & ")or(" & cod_pessoa_funcionario & " = 0 ))
              and (( a.des_despesa like ('% " & des_observacao & "%'))or ('" & des_observacao & "' = '" & "" & "' ))
              and  ((a.val_despesa = " & val_despesa & ")or(" & val_despesa & " = 0 ))"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultaRelDespesa()
        sql = "Select a.des_despesa,
                      b.des_tipo_despesa,
                      c.NOM_PESSOA,
                      a.val_despesa
              From tab_despesa a
              Join tab_tipo_despesa b on (a.cod_tipo_despesa = b.cod_tipo_despesa)
              Join tab_pessoa c on (a.cod_pessoa_favorecido = c.COD_PESSOA )
              Where cod_evento =" & cod_evento & "
              Order By 3, 2"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultardespesaCodigo()
        sql = "Select * From tab_despesa Where cod_despesa =" & cod_despesa & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultardespesaVenda()
        sql = "Select cod_despesa,
                      des_despesa ,
                      cod_tipo_despesa, 
                      dta_despesa From tab_despesa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultardespesaPesquisa(busca As String)
        sql = "Select cod_despesa, 
                      des_despesa  
               From tab_despesa where des_despesa like ('%" & busca & "%')"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimodespesaCadastrado()
        sql = "Select cast( max(cod_despesa) as varchar(5)) 
                 From tab_despesa"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
