Public Class FrmPessoa
    Dim conectar As New ConexaoSQ
    Dim ds As New DataSet
    Dim pessoa As New ClPessoa
    Dim atualizar As Integer = 1

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtPresquisa.Click
            atualizaDados()
            limpar()
        End Sub
        Public Sub atualizaDados()
            '  conectar.Conectar()
            Dim tabela As DataTable
        ds = pessoa.ConsultarPessoa()
        tabela = ds.Tables(0)


            If tabela.Rows.Count > 0 Then
            DgvPessoa.DataSource = ds.Tables(0)
            formatarGrid()
            End If
        '   limpar()

    End Sub

        Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
            Try
                Dim ultimo As DataSet
            ultimo = pessoa.ConsultarPessoaVenda
            '  Label7.Text = ultimo.Tables(0).Rows.Item(1).ToString
            If TxbNome.Text = "" Then
                MsgBox("INFORME NOME")
                TxbNome.Select()
                Exit Sub
            End If

            pessoa.nom_pessoa = TxbNome.Text
            pessoa.nom_fantasia = TxbNomFantasia.Text
            pessoa.num_cnpj_cpf = TxbCnpjCpf.Text
            pessoa.num_ie_rg = TxbIeRg.Text
            pessoa.dta_nascimento = DtpDtaNasc.Value.ToShortDateString
            pessoa.des_logradouro = TxbRua.Text
            pessoa.des_complemento = TxbComplemento.Text
            pessoa.cod_cidade = "5002"
            pessoa.nom_bairro = TxbBairro.Text
            pessoa.num_cep = TxbCep.Text
            pessoa.num_fone_1 = TxbFone1.Text
            pessoa.num_fone_2 = TxbFone2.Text
            pessoa.num_fone_3 = TxbFone3.Text
            pessoa.des_observacao = TxbObservacao.Text
            pessoa.dta_cadastro = Now

            If CkbCliente.Checked = True Then
                pessoa.ind_cliente = "S"
            Else
                pessoa.ind_cliente = "N"
            End If

            If CkbFornecedor.Checked = True Then
                pessoa.ind_fornecedor = "S"
            Else
                pessoa.ind_fornecedor = "N"
            End If

            If CkbFuncionario.Checked = True Then
                pessoa.ind_funcionario = "S"
            Else
                pessoa.ind_funcionario = "N"
            End If


            If CkbAtivo.Checked = True Or atualizar = 1 Then
                pessoa.ind_ativo = "S"
            Else
                pessoa.ind_ativo = "N"
            End If
            pessoa.des_email = TxbEmail.Text
            If atualizar = 1 Then
                pessoa.CadastrarPessoa()
                MsgBox("Cadastrado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
                Else
                pessoa.cod_pessoa = TxbCodigo.Text
                pessoa.AtualizarPessoa()
                MsgBox("Alterado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
                End If


            Catch ex As Exception
                MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
            End Try
        End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox("Deseja excluir " & TxbNome.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pessoa.cod_pessoa = TxbCodigo.Text
                pessoa.ExcluirPessoa()
                MsgBox("Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Item, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            limpar()

        End Sub
        Public Sub limpar()
        TxbCodigo.Text = ""
        TxbNome.Text = ""
        TxbNomFantasia.Text = ""
        TxbCnpjCpf.Text = ""
        TxbIeRg.Text = ""
        '  DtpDtaNasc.Value.ToShortDateString() = "today"
        TxbRua.Text = ""
        TxbComplemento.Text = ""
        TxbCodCidade.Text = ""
        TxbNomCidade.Text = ""
        TxbBairro.Text = ""
        TxbCep.Text = ""
        TxbFone1.Text = ""
        TxbFone2.Text = ""
        TxbFone3.Text = ""
        TxbObservacao.Text = ""
        CkbCliente.Checked = False
        CkbFornecedor.Checked = False
        CkbFuncionario.Checked = False
        CkbAtivo.Checked = False
        TxbEmail.Text = ""

        atualizar = 1

        End Sub
        Public Sub formatarGrid()
        With DgvPessoa
            .Columns(0).HeaderText = "COD"
            .Columns(1).HeaderText = "NOME"
            .Columns(2).HeaderText = "NOME.FANTASIA"
            .Columns(3).HeaderText = "CNPJ/CPF"
            .Columns(4).HeaderText = "IE/RG"
            .Columns(5).HeaderText = "NASCIMENTO"
            .Columns(6).HeaderText = "LOGRADOURO"
            .Columns(7).HeaderText = "COMPLEMENTO"
            .Columns(8).HeaderText = "COD.CIDADE"
            .Columns(9).HeaderText = "BAIRRO"
            .Columns(10).HeaderText = "CEP"
            .Columns(11).HeaderText = "TELEFONE_1"
            .Columns(12).HeaderText = "TELEFONE_2"
            .Columns(13).HeaderText = "TELEFONE_3"
            .Columns(14).HeaderText = "OBSERVACAO"
            .Columns(15).HeaderText = "DTA.CADASTRO"
            .Columns(16).HeaderText = "CLIENTE"
            .Columns(17).HeaderText = "FORNECEDOR"
            .Columns(18).HeaderText = "FUNCIONARIO"
            .Columns(19).HeaderText = "ATIVO"
            .Columns(20).HeaderText = "EMAIL"
            .Columns(0).Width = 40
            .Columns(1).Width = 200
            .Columns(2).Width = 60
            .Columns(3).Width = 60
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 60
            .Columns(7).Width = 60
            .Columns(8).Width = 60
            .Columns(9).Width = 60
            .Columns(10).Width = 60
            .Columns(11).Width = 60
            .Columns(12).Width = 60
            .Columns(13).Width = 60
            .Columns(14).Width = 60
            .Columns(15).Width = 60
            .Columns(16).Width = 60
            .Columns(17).Width = 60
            .Columns(18).Width = 60
            .Columns(19).Width = 60
            .Columns(20).Width = 60
        End With
    End Sub


        Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            TxbCodigo.Text = DgvPessoa.CurrentRow.Cells(0).Value
            TxbNome.Text = DgvPessoa.CurrentRow.Cells(1).Value
            TxbNomFantasia.Text = DgvPessoa.CurrentRow.Cells(2).Value
            TxbCnpjCpf.Text = DgvPessoa.CurrentRow.Cells(3).Value
            TxbIeRg.Text = DgvPessoa.CurrentRow.Cells(4).Value
            DtpDtaNasc.Value = DgvPessoa.CurrentRow.Cells(5).Value
            TxbRua.Text = DgvPessoa.CurrentRow.Cells(6).Value
            TxbComplemento.Text = DgvPessoa.CurrentRow.Cells(7).Value
            TxbCodCidade.Text = DgvPessoa.CurrentRow.Cells(8).Value
            TxbNomCidade.Text = "UBERLANDIA"
            TxbBairro.Text = DgvPessoa.CurrentRow.Cells(9).Value
            TxbCep.Text = DgvPessoa.CurrentRow.Cells(10).Value
            TxbFone1.Text = DgvPessoa.CurrentRow.Cells(11).Value
            TxbFone2.Text = DgvPessoa.CurrentRow.Cells(12).Value
            TxbFone3.Text = DgvPessoa.CurrentRow.Cells(13).Value
            TxbObservacao.Text = DgvPessoa.CurrentRow.Cells(14).Value
            If DgvPessoa.CurrentRow.Cells(16).Value = "S" Then
                CkbCliente.Checked = True
            Else
                CkbCliente.Checked = False
            End If
            If DgvPessoa.CurrentRow.Cells(17).Value = "S" Then
                CkbFornecedor.Checked = True
            Else
                CkbFornecedor.Checked = False
            End If
            If DgvPessoa.CurrentRow.Cells(18).Value = "S" Then
                CkbFuncionario.Checked = True
            Else
                CkbFuncionario.Checked = False
            End If
            If DgvPessoa.CurrentRow.Cells(19).Value = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            TxbEmail.Text = DgvPessoa.CurrentRow.Cells(20).Value
        Catch ex As Exception

        End Try
        End Sub

    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            limpar()
        End Sub

    Private Sub DgvPessoa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPessoa.CellClick
        carregaFormulario()
        TxbNome.Select()
    End Sub

    Private Sub TxbCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxbCodigo.TextChanged
        If Not IsNumeric(TxbCodigo.Text) Then
            TxbCodigo.Text = ""
        End If
    End Sub
End Class