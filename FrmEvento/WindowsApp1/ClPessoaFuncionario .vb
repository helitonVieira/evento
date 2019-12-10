Public Class ClPessoaFuncionario
    Dim sql As String
    Dim ds, dsUltimo As New DataSet

    Dim con As New ConexaoSQ
    Dim ultimoFuncionario As Integer

    Private cod_pessoa_ As Integer
    Public Property cod_pessoa() As Integer
        Get
            Return cod_pessoa_
        End Get
        Set(ByVal value As Integer)
            cod_pessoa_ = value
        End Set
    End Property

    Private cod_funcao_funcionario_ As Integer
    Public Property cod_funcao_funcionario() As Integer
        Get
            Return cod_funcao_funcionario_
        End Get
        Set(ByVal value As Integer)
            cod_funcao_funcionario_ = value
        End Set
    End Property


    Private val_salario_ As String
    Public Property val_salario() As String
        Get
            Return val_salario_
        End Get
        Set(ByVal value As String)
            val_salario_ = value
        End Set
    End Property

    Private Val_custo_hora_ As String
    Public Property Val_custo_hora() As String
        Get
            Return Val_custo_hora_
        End Get
        Set(ByVal value As String)
            Val_custo_hora_ = value
        End Set
    End Property

    Private ind_tipo_salario_ As String
    Public Property ind_tipo_salario() As String
        Get
            Return ind_tipo_salario_
        End Get
        Set(ByVal value As String)
            ind_tipo_salario_ = value
        End Set
    End Property

    Private dta_admissao_ As String
    Public Property dta_admissao() As String
        Get
            Return dta_admissao_
        End Get
        Set(ByVal value As String)
            dta_admissao_ = value
        End Set
    End Property

    Private dta_demissao_ As String
    Public Property dta_demissao() As String
        Get
            Return dta_demissao_
        End Get
        Set(ByVal value As String)
            dta_demissao_ = value
        End Set
    End Property

    Private dta_ultimo_reajuste_ As String
    Public Property dta_ultimo_reajuste() As String
        Get
            Return dta_ultimo_reajuste_
        End Get
        Set(ByVal value As String)
            dta_ultimo_reajuste_ = value
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

    Public Sub CadastrarFuncionario()
        If val_salario = "" Then
            val_salario = "0"
        Else
            val_salario = Replace(val_salario, ".", "")
            val_salario = Replace(val_salario, ",", "")
        End If
        If Val_custo_hora = "" Then
            Val_custo_hora = "0"
        Else
            Val_custo_hora = Replace(Val_custo_hora, ".", "")
            Val_custo_hora = Replace(Val_custo_hora, ",", "")
        End If
        If dta_admissao = "Null" Then
            String.IsNullOrEmpty(dta_admissao)
        End If
        If dta_demissao = "Null" Then
            String.IsNullOrEmpty(dta_demissao)
        End If
        If dta_ultimo_reajuste = "Null" Then
            String.IsNullOrEmpty(dta_ultimo_reajuste)
        End If
        sql = "Insert Into tab_pessoa_funcionario( cod_pessoa ,
                                                  cod_funcao_funcionario, 
                                                  val_salario,
                                                  val_custo_hora,
                                                  ind_tipo_salario,
                                                  dta_admissao,
                                                  dta_demissao,
                                                  dta_ultimo_reajuste,
                                                  des_observacao) 
                                        Values (" & cod_pessoa & ",
                                                " & cod_funcao_funcionario & ",
                                                '" & val_salario & "',
                                                '" & Val_custo_hora & "', 
                                                '" & ind_tipo_salario & "',
                                                '" & dta_admissao & "',
                                                '" & dta_demissao & "', 
                                                '" & dta_ultimo_reajuste & "',
                                                '" & des_observacao & "')"
        con.Operar(sql)
    End Sub

    Private Function IsDBNull() As String
        Throw New NotImplementedException()
    End Function

    Public Sub AtualizarFuncionario()
        sql = "Update tab_pessoa_funcionario Set  
                                      cod_funcao_funcionario ='" & cod_funcao_funcionario & "',
                                      val_salario ='" & val_salario & "' ,
                                      val_custo_hora ='" & Val_custo_hora & "',
                                      ind_tipo_salario ='" & ind_tipo_salario & "', 
                                      dta_admissao ='" & dta_admissao & "' ,
                                      dta_demissao ='" & dta_demissao & "' ,
                                      dta_ultimo_reajuste ='" & dta_ultimo_reajuste & "' ,
                                      des_observacao ='" & des_observacao & "'
                                Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub
    Public Sub ExcluirFuncionario()
        sql = " Delete from tab_pessoa_funcionario Where cod_pessoa =" & cod_pessoa & ""
        con.Operar(sql)
    End Sub

    Public Function ConsultarFuncionario(cod As Integer)
        sql = "SELECT *
               FROM tab_pessoa_funcionario 
               WHERE cod_pessoa = " & cod
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function UltimoFuncionarioCadastrado()
        sql = "Select coalesce(cast( max(cod_pessoa) as varchar(5)),0)as ultimo From tab_pessoa_funcionario"
        dsUltimo = con.Listar(sql)
        Return dsUltimo
    End Function
End Class
