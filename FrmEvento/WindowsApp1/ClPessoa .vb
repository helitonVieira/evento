Public Class ClPessoa
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New ConexaoSQ
    Dim ultimoItem As Integer

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private nom_pessoa_ As String
    Public Property nom_pessoa() As String
        Get
            Return nom_pessoa_
        End Get
        Set(ByVal value As String)
            nom_pessoa_ = value
        End Set
    End Property

    Private nom_fantasia_ As String
    Public Property nom_fantasia() As String

        Get
            Return nom_fantasia_
        End Get
        Set(ByVal value As String)
            nom_fantasia_ = value
        End Set
    End Property

    Private num_cnpj_cpf_ As String
    Public Property num_cnpj_cpf() As String
        Get
            Return num_cnpj_cpf_
        End Get
        Set(ByVal value As String)
            num_cnpj_cpf_ = value
        End Set
    End Property

    Private num_ie_rg_ As String
    Public Property num_ie_rg() As String
        Get
            Return num_ie_rg_
        End Get
        Set(ByVal value As String)
            num_ie_rg_ = value
        End Set
    End Property

    Private dta_nascimento_ As Date
    Public Property dta_nascimento() As Date
        Get
            Return dta_nascimento_
        End Get
        Set(ByVal value As Date)
            dta_nascimento_ = value
        End Set
    End Property

    Private des_logradouro_ As String
    Public Property des_logradouro() As String
        Get
            Return des_logradouro_
        End Get
        Set(ByVal value As String)
            des_logradouro_ = value
        End Set
    End Property

    Private des_complemento_ As String
    Public Property des_complemento() As String

        Get
            Return des_complemento_
        End Get
        Set(ByVal value As String)
            des_complemento_ = value
        End Set
    End Property

    Private cod_cidade_ As Integer
    Public Property cod_cidade() As Integer
        Get
            Return cod_cidade_
        End Get
        Set(ByVal value As Integer)
            cod_cidade_ = value
        End Set
    End Property

    Private nom_bairro_ As String
    Public Property nom_bairro() As String
        Get
            Return nom_bairro_
        End Get
        Set(ByVal value As String)
            nom_bairro_ = value
        End Set
    End Property

    Private num_cep_ As String
    Public Property num_cep() As String
        Get
            Return num_cep_
        End Get
        Set(ByVal value As String)
            num_cep_ = value
        End Set
    End Property
    Private num_fone_1_ As String
    Public Property num_fone_1() As String
        Get
            Return num_fone_1_
        End Get
        Set(ByVal value As String)
            num_fone_1_ = value
        End Set
    End Property

    Private num_fone_2_ As String
    Public Property num_fone_2() As String
        Get
            Return num_fone_2_
        End Get
        Set(ByVal value As String)
            num_fone_2_ = value
        End Set
    End Property

    Private num_fone_3_ As String
    Public Property num_fone_3() As String
        Get
            Return num_fone_3_
        End Get
        Set(ByVal value As String)
            num_fone_3_ = value
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

    Private dta_cadastro_ As Date
    Public Property dta_cadastro() As Date
        Get
            Return dta_cadastro_
        End Get
        Set(ByVal value As Date)
            dta_cadastro_ = value
        End Set
    End Property

    Private ind_cliente_ As String
    Public Property ind_cliente() As String
        Get
            Return ind_cliente_
        End Get
        Set(ByVal value As String)
            ind_cliente_ = value
        End Set
    End Property

    Private ind_fornecedor_ As String
    Public Property ind_fornecedor() As String
        Get
            Return ind_fornecedor_
        End Get
        Set(ByVal value As String)
            ind_fornecedor_ = value
        End Set
    End Property

    Private ind_funcionario_ As String
    Public Property ind_funcionario() As String
        Get
            Return ind_funcionario_
        End Get
        Set(ByVal value As String)
            ind_funcionario_ = value
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

    Private des_email_ As String
    Public Property des_email() As String
        Get
            Return des_email_
        End Get
        Set(ByVal value As String)
            des_email_ = value
        End Set
    End Property


    Public Sub CadastrarPessoa()
        sql = "Insert Into tab_pessoa(      
                               NOM_PESSOA                  ,    
                               NOM_FANTASIA                ,    
                               NUM_CNPJ_CPF                ,    
                               NUM_IE_RG                   ,    
                               DTA_NASCIMENTO              ,    
                               DES_LOGRADOURO              ,    
                               DES_COMPLEMENTO             ,    
                               COD_CIDADE                  ,    
                               NOM_BAIRRO                  ,    
                               NUM_CEP                     ,    
                               NUM_TELEFONE_1              ,    
                               NUM_TELEFONE_2              ,    
                               NUM_TELEFONE_3              ,    
                               DES_OBSERVACAO              ,    
                               DTA_CADASTRO                ,    
                               IND_CLIENTE                 ,    
                               IND_FORNECEDOR              ,    
                               IND_FUNCIONARIO             ,    
                               IND_ATIVO                   ,
                               DES_EMAIL )
                 Values ('" & nom_pessoa & "' , '" & nom_fantasia & "','" & num_cnpj_cpf & "','" & num_ie_rg & "','" & dta_nascimento & "'
                         , '" & des_logradouro & "','" & des_complemento & "','" & cod_cidade & "','" & nom_bairro & "'
                         , '" & num_cep & "','" & num_fone_1 & "','" & num_fone_2 & "','" & num_fone_3 & "' 
                         , '" & des_observacao & "','" & dta_cadastro & "','" & ind_cliente & "','" & ind_fornecedor & "'
                         , '" & ind_funcionario & "','" & ind_ativo & "','" & des_email & "')"
        con.Operar(sql)
    End Sub

    Public Sub AtualizarPessoa()
        sql = "Update tab_pessoa Set  NOM_PESSOA    ='" & nom_pessoa & "' ,
                                    NOM_FANTASIA    ='" & nom_fantasia & "',
                                    NUM_CNPJ_CPF    ='" & num_cnpj_cpf & "',
                                    NUM_IE_RG       ='" & num_ie_rg & "',
                                    DTA_NASCIMENTO  ='" & dta_nascimento & "' ,
                                    DES_LOGRADOURO  ='" & des_logradouro & "',
                                    DES_COMPLEMENTO ='" & des_complemento & "',                                   
                                    NOM_BAIRRO      ='" & nom_bairro & "' ,
                                    NUM_CEP         ='" & num_cep & "',
                                    NUM_TELEFONE_1  ='" & num_fone_1 & "',
                                    NUM_TELEFONE_2  ='" & num_fone_2 & "',
                                    NUM_TELEFONE_3  ='" & num_fone_3 & "' ,
                                    DES_OBSERVACAO  ='" & des_observacao & "',
                                    IND_CLIENTE     ='" & ind_cliente & "',
                                    IND_FORNECEDOR  ='" & ind_fornecedor & "' ,
                                    IND_FUNCIONARIO ='" & ind_funcionario & "',
                                    IND_ATIVO       ='" & ind_ativo & "',
                                    DES_EMAIL       ='" & des_email & "'
                                  
                                   Where cod_pessoa   =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Sub ExcluirPessoa()
        sql = " Delete from tab_pessoa Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarPessoa(busca As String)
        sql = "Select * From tab_pessoa 
               where nom_pessoa like ('%" & busca & "%')
                 and ind_ativo = 'S'
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultarPessoa()
        sql = "Select * From tab_pessoa
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaFuncionario(busca As String)
        sql = "Select * From tab_pessoa
                where ind_funcionario = 'S' 
                  and ind_ativo = 'S'
                  and nom_pessoa like ('%" & busca & "%')
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaCliente(busca As String)
        sql = "Select cod_pessoa,nom_pessoa From tab_pessoa
                where ind_cliente = 'S' 
                   and ind_ativo = 'S'
                  and nom_pessoa like ('%" & busca & "%')
               order by nom_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaCodigo()
        sql = "Select * From tab_pessoa Where cod_cod_pessoa =" & cod_pessoa & ""
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function ConsultarPessoaVenda()
        sql = "Select cod_pessoa, nom_pessoa From tab_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function

    Public Function UltimaPessoaCadastrado()
        sql = "Select cast( max(cod_pessoa) as varchar(5)) From tab_pessoa"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
