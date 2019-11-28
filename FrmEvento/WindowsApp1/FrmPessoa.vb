Public Class FrmPessoa
    Dim conectar As New ConexaoSQ
    Dim ds, dsDependente As New DataSet
    Dim pessoa, pessoa2 As New ClPessoa

    Dim pessoaDependente As New ClPessoaDependente
    Dim atualizar As Integer = 1
    Dim atualizarDependente As Integer = 1
    Dim i As Integer = 0
    Dim cod_pessoa_old, nom_pessoa_old, nom_fantasia_old, num_cnpj_cpf_old, num_ie_rg_old,
        dta_nascimento_old, des_logradouro_old, des_complemento_old, cod_cidade_old,
        nom_bairro_old, num_cep_old, num_telefone_1_old, num_telefone_2_old, num_telefone_3_old,
        des_observacao_old, dta_cadastro_old, ind_cliente_old, ind_fornecedor_old,
        ind_funcionario_old, ind_ativo_old, des_email_old, ind_pe_old As String
    Dim cod_dependente_old, nom_dependente_old, num_fone_depte_old, nom_apelido_old,
        dta_nascimento_depte_old, des_observacao_depte_old As String

    Private Sub BtnPesquisa_Click(sender As Object, e As EventArgs) Handles BtnPresquisa.Click
        verificarAuteracaoPessoa()

        If TxbCodPessoa.Text = "" Then
            cod_pessoa_old = 0
        Else
            cod_pessoa_old = TxbCodPessoa.Text
        End If
        nom_pessoa_old = TxbNomPessoa.Text
        atualizaDados()
        carregaFormulario()


    End Sub
    Public Sub atualizaDados()
        Try
            Dim tabela As DataTable
            If cod_pessoa_old = "" Then
                cod_pessoa_old = "0"
            End If
            ds = pessoa.ConsultarPessoaBusca(cod_pessoa_old, nom_pessoa_old, nom_fantasia_old, num_cnpj_cpf_old, num_ie_rg_old,
                                             des_logradouro_old, cod_cidade_old, nom_bairro_old, num_cep_old, num_telefone_1_old,
                                             num_telefone_2_old, num_telefone_3_old, des_observacao_old, ind_cliente_old,
                                            ind_fornecedor_old, ind_funcionario_old, ind_ativo_old, des_email_old, ind_pe_old)
            tabela = ds.Tables(0)

            If tabela.Rows.Count > 0 Then
                ' DgvPessoa.DataSource = Nothing
                DgvPessoa.DataSource = ds.Tables(0)
                'formatarGrid()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub atualizaDadosDependente()
        Try
            Dim tabela As DataTable
            dsDependente = pessoaDependente.ConsultarDependente(cod_pessoa_old)
            tabela = dsDependente.Tables(0)

            If tabela.Rows.Count > 0 Then
                DgvDependente.DataSource = Nothing
                DgvDependente.DataSource = dsDependente.Tables(0)
                formatarGridDependente()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnCsv_Click(sender As Object, e As EventArgs) Handles BtnCsv.Click
        If ds.Tables(0).Rows.Count < 1 Then
            Exit Sub
        End If

        'My.Computer.FileSystem.CreateDirectory("C:\\CashMonitor")
        Dim nomArquivo As String
        Dim dataAtual As String
        Dim nomPasta As String

        'localizar a pasta
        Dim pasta As New FolderBrowserDialog
        Dim dr As DialogResult = pasta.ShowDialog()
        If dr = System.Windows.Forms.DialogResult.OK Then
            nomPasta = pasta.SelectedPath
        End If

        Dim horaMin As String
        dataAtual = Format(Today, "ddmmyyyy")
        dataAtual = Replace(dataAtual, "00", "10")
        horaMin = Format(Now, "hhmm")



        nomArquivo = "Pessoa_" & dataAtual & "_" & horaMin

        Dim CSV As System.IO.StreamWriter = New System.IO.StreamWriter(nomPasta & "\Pessoa_" & nomArquivo & ".csv"
                                                                           )
        Dim i As Integer, x As Integer

        Dim QtdColunas As Integer = DgvPessoa.ColumnCount - 1

        For i = 0 To QtdColunas
            If DgvPessoa.Columns(i).HeaderText.Substring(0, 6) <> "Column" Then
                CSV.Write(DgvPessoa.Columns(i).HeaderText)

                If (i < QtdColunas) Then

                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            End If
        Next i

        ' CSV.Write(CSV.NewLine)

        Dim QtdRows As Integer = DgvPessoa.Rows.Count - 1

        For i = 0 To QtdRows

            For x = 0 To QtdColunas

                If (Not DgvPessoa.Rows(i).Cells(x).Value Is Nothing) Then
                    CSV.Write(DgvPessoa.Rows(i).Cells(x).Value.ToString())

                End If

                If (x < QtdColunas) Then
                    CSV.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                End If

            Next x
            CSV.Write(CSV.NewLine)
        Next i
        MsgBox("Arquivo criado com sucesso em   " & nomPasta & "\" & nomArquivo)

        CSV.Close()
    End Sub
    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        salvaRegistro()

    End Sub
    Public Sub salvaRegistro()
        Try

            If TxbNomPessoa.Text = "" Then
                MsgBox("INFORME NOME")
                TxbNomPessoa.Select()
                Exit Sub
            End If

            pessoa.nom_pessoa = TxbNomPessoa.Text
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

            nom_pessoa_old = TxbNomPessoa.Text

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
            ind_pe_old = "N"
            If atualizar = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = pessoa2.UltimaPessoaCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                pessoa.cod_pessoa = Convert.ToInt16(ult) + 1

                pessoa.CadastrarPessoa()
                MsgBox("Cadastrado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
                carregaFormulario()
            Else
                pessoa.cod_pessoa = TxbCodPessoa.Text
                pessoa.AtualizarPessoa()
                MsgBox("Alterado com Sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDados()
            End If

        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Private Sub FrmPessoa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim count As Integer
        For count = 1 To 100
            Beep()
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxbCodPessoa.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir:  " & vbCrLf & TxbNomPessoa.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pessoa.cod_pessoa = TxbCodPessoa.Text
                pessoa.ExcluirPessoa()
                MsgBox("Excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao tentar excluir Pessoa , " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        verificarAuteracaoPessoa()
        limpar()
        DgvPessoa.DataSource = Nothing
        TxbCodPessoa.Enabled = True
        TabControl1.SelectedIndex = 0
        BtnDependente.Visible = False

    End Sub

    Private Sub BtnLimpaDept_Click(sender As Object, e As EventArgs) Handles BtnLimpaDept.Click
        verificarAuteracaoDependente()
        limparDependente()
    End Sub

    Private Sub DgvDependente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDependente.CellClick
        carregaFormularioDepte()
    End Sub
    Public Sub carregaFormularioDepte()
        Try
            limparDependente()
            atualizarDependente = 2
            txbCodDepte.Text = DgvDependente.CurrentRow.Cells(0).Value
            txbNomDepte.Text = DgvDependente.CurrentRow.Cells(1).Value
            txbApelidoDepte.Text = DgvDependente.CurrentRow.Cells(3).Value
            txbFoneDepte.Text = DgvDependente.CurrentRow.Cells(4).Value
            DtpDtaNascDept.Value = DgvDependente.CurrentRow.Cells(5).Value
            txbObsDepte.Text = DgvDependente.CurrentRow.Cells(6).Value

            cod_dependente_old = txbCodDepte.Text
            nom_dependente_old = txbNomDepte.Text
            nom_apelido_old = txbApelidoDepte.Text
            num_fone_depte_old = txbFoneDepte.Text
            dta_nascimento_depte_old = DgvDependente.CurrentRow.Cells(5).Value
            des_observacao_depte_old = txbObsDepte.Text

            txbCodDepte.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Public Sub limparDependente()
        txbCodDepte.Text = ""
        txbNomDepte.Text = ""
        txbApelidoDepte.Text = ""
        txbFoneDepte.Text = ""
        txbObsDepte.Text = ""

        cod_dependente_old = ""
        nom_dependente_old = ""
        nom_apelido_old = ""
        num_fone_depte_old = ""
        dta_nascimento_depte_old = ""
        des_observacao_depte_old = ""

        txbCodDepte.Enabled = True
        atualizarDependente = 1
    End Sub
    Private Sub BtnExcluiDept_Click(sender As Object, e As EventArgs) Handles BtnExcluiDept.Click
        If txbCodDepte.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Deseja excluir o Dependente :" & vbCrLf & txbNomDepte.Text & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
            Try
                pessoaDependente.cod_dependente = txbCodDepte.Text
                pessoaDependente.ExcluirDependente()
                MsgBox("Dependente excluido com sucesso", MsgBoxStyle.Information, "Informação")
                atualizaDados()

            Catch ex As Exception
                MsgBox("Erro ao excluir Dependente, " & ex.Message & "!", MsgBoxStyle.Critical, "Erro")
            End Try
        End If
    End Sub

    Private Sub CkbFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles CkbFuncionario.CheckedChanged
        If CkbFuncionario.Checked = True Then
            BtnFuncionario.Visible = True
        Else
            BtnFuncionario.Visible = False
        End If
    End Sub

    Private Sub BtnSalvaDepte_Click(sender As Object, e As EventArgs) Handles BtnSalvaDepte.Click
        salvarDependente()
    End Sub
    Public Sub salvarDependente()
        Try
            If txbNomDepte.Text = "" Then
                MsgBox("INFORME NOME DO ITEM")
                txbNomDepte.Select()
                Exit Sub
            End If

            pessoaDependente.nom_dependente = txbNomDepte.Text
            pessoaDependente.cod_pessoa = TxbCodPessoa.Text
            pessoaDependente.nom_apelido = txbApelidoDepte.Text
            pessoaDependente.dta_nascimento = DtpDtaNascDept.Value.ToShortDateString
            pessoaDependente.des_observacao = txbObsDepte.Text
            pessoaDependente.num_telefone = txbFoneDepte.Text

            If atualizarDependente = 1 Then
                'pegar o ultimo registro
                Dim ultimo As New DataSet
                ultimo = pessoaDependente.UltimoDependenteCadastrado
                Dim ult As String = ultimo.Tables(0).Rows(0)("ultimo")
                pessoaDependente.cod_dependente = Convert.ToInt16(ult) + 1

                pessoaDependente.CadastrarDependente()
                ultimo.Clear()
                MsgBox("Dependente cadastrado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDadosDependente()
            Else
                pessoaDependente.cod_dependente = txbCodDepte.Text
                pessoaDependente.AtualizarDependente()
                MsgBox("Pelagem Alterado com sucesso", MsgBoxStyle.OkOnly, "Sucesso")
                atualizaDadosDependente()
            End If

            limparDependente()
        Catch ex As Exception
            MsgBox("Não foi possivel Salvar no banco" & ex.Message, MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub
    Public Sub limpar()
        TxbCodPessoa.Text = ""
        TxbNomPessoa.Text = ""
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
        CkbAtivo.Checked = True
        TxbEmail.Text = ""
        '       DgvPessoa.Rows.Clear()

        cod_pessoa_old = ""
        nom_pessoa_old = ""
        nom_fantasia_old = ""
        num_cnpj_cpf_old = ""
        num_ie_rg_old = ""
        des_complemento_old = ""
        dta_nascimento_old = ""
        des_logradouro_old = ""
        des_complemento_old = ""
        cod_cidade_old = ""
        nom_bairro_old = ""
        num_cep_old = ""
        num_telefone_1_old = ""
        num_telefone_2_old = ""
        num_telefone_3_old = ""
        des_observacao_old = ""
        ind_cliente_old = ""
        ind_fornecedor_old = ""
        ind_funcionario_old = ""
        ind_ativo_old = ""
        des_email_old = ""

        'DgvPessoa.DataSource = Nothing
        'DgvDependente.DataSource = Nothing

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

    Public Sub formatarGridDependente()
        With DgvDependente
            .Columns(0).HeaderText = "COD"
            .Columns(1).HeaderText = "DEPENDENTE"
            .Columns(2).HeaderText = "COD.CLIENTE"
            .Columns(3).HeaderText = "APELIDO"
            .Columns(4).HeaderText = "FONE"
            .Columns(5).HeaderText = "NASCIMENTO"
            .Columns(6).HeaderText = "OBSERVAÇÃO"
            .Columns(0).Width = 40
            .Columns(1).Width = 200
            .Columns(2).Width = 0
            .Columns(3).Width = 100
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 200
        End With
    End Sub


    Public Sub carregaFormulario()
        Try
            limpar()
            atualizar = 2
            BtnDependente.Visible = True
            TxbCodPessoa.Text = ds.Tables(0).Rows(i)("cod_pessoa").ToString
            TxbNomPessoa.Text = ds.Tables(0).Rows(i)("nom_pessoa").ToString
            TxbNomFantasia.Text = ds.Tables(0).Rows(i)("nom_fantasia").ToString
            TxbCnpjCpf.Text = ds.Tables(0).Rows(i)("num_cnpj_cpf").ToString
            TxbIeRg.Text = ds.Tables(0).Rows(i)("num_ie_rg").ToString
            DtpDtaNasc.Value = ds.Tables(0).Rows(i)("dta_nascimento").ToString
            TxbRua.Text = ds.Tables(0).Rows(i)("des_logradouro").ToString
            TxbComplemento.Text = ds.Tables(0).Rows(i)("des_complemento").ToString
            TxbCodCidade.Text = ds.Tables(0).Rows(i)("cod_cidade").ToString
            TxbNomCidade.Text = "UBERLANDIA"
            TxbBairro.Text = ds.Tables(0).Rows(i)("nom_bairro").ToString
            TxbCep.Text = ds.Tables(0).Rows(i)("num_cep").ToString
            TxbFone1.Text = ds.Tables(0).Rows(i)("num_telefone_1").ToString
            TxbFone2.Text = ds.Tables(0).Rows(i)("num_telefone_2").ToString
            TxbFone3.Text = ds.Tables(0).Rows(i)("num_telefone_3").ToString
            TxbObservacao.Text = ds.Tables(0).Rows(i)("des_observacao").ToString
            If ds.Tables(0).Rows(i)("ind_cliente").ToString = "S" Then
                CkbCliente.Checked = True
            Else
                CkbCliente.Checked = False
            End If
            If ds.Tables(0).Rows(i)("ind_fornecedor").ToString = "S" Then
                CkbFornecedor.Checked = True
            Else
                CkbFornecedor.Checked = False
            End If
            If ds.Tables(0).Rows(i)("ind_funcionario").ToString = "S" Then
                CkbFuncionario.Checked = True
            Else
                CkbFuncionario.Checked = False
            End If
            If ds.Tables(0).Rows(i)("ind_ativo").ToString = "S" Then
                CkbAtivo.Checked = True
            Else
                CkbAtivo.Checked = False
            End If
            TxbEmail.Text = ds.Tables(0).Rows(i)("des_email").ToString


            cod_pessoa_old = ds.Tables(0).Rows(i)("cod_pessoa").ToString
            nom_pessoa_old = ds.Tables(0).Rows(i)("nom_pessoa").ToString
            nom_fantasia_old = ds.Tables(0).Rows(i)("nom_fantasia").ToString
            num_cnpj_cpf_old = ds.Tables(0).Rows(i)("num_cnpj_cpf").ToString
            num_ie_rg_old = ds.Tables(0).Rows(i)("num_ie_rg").ToString
            dta_nascimento_old = ds.Tables(0).Rows(i)("dta_nascimento").ToString.Substring(0, 10)
            des_logradouro_old = ds.Tables(0).Rows(i)("des_logradouro").ToString
            des_complemento_old = ds.Tables(0).Rows(i)("des_complemento").ToString
            cod_cidade_old = ds.Tables(0).Rows(i)("cod_cidade").ToString
            nom_bairro_old = ds.Tables(0).Rows(i)("nom_bairro").ToString
            num_cep_old = ds.Tables(0).Rows(i)("num_cep").ToString
            num_telefone_1_old = ds.Tables(0).Rows(i)("num_telefone_1").ToString
            num_telefone_2_old = ds.Tables(0).Rows(i)("num_telefone_2").ToString
            num_telefone_3_old = ds.Tables(0).Rows(i)("num_telefone_3").ToString
            des_observacao_old = ds.Tables(0).Rows(i)("des_observacao").ToString
            ind_cliente_old = ds.Tables(0).Rows(i)("ind_cliente").ToString
            ind_fornecedor_old = ds.Tables(0).Rows(i)("ind_fornecedor").ToString
            ind_funcionario_old = ds.Tables(0).Rows(i)("ind_funcionario").ToString = "S"
            ind_ativo_old = ds.Tables(0).Rows(i)("ind_ativo").ToString
            des_email_old = ds.Tables(0).Rows(i)("des_email").ToString

            If TxbCodPessoa.Text <> "" Then
                BtnDependente.Enabled = True
            End If
            Ckb_pe.Checked = False
            TxbCodPessoa.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
        BtnPrincipal.Enabled = False
    End Sub

    Private Sub DgvPessoa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPessoa.CellClick
        carregaFormulario()
        TxbNomPessoa.Select()
    End Sub

    Private Sub TxbCodigo_TextChanged(sender As Object, e As EventArgs) Handles TxbCodPessoa.TextChanged
        If Not IsNumeric(TxbCodPessoa.Text) Then
            TxbCodPessoa.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnGrid.Click
        If TabControl1.SelectedIndex = 1 Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnDependente.Click
        TabControl1.SelectedIndex = 2
        GbNavegador.Enabled = False
        BtnDependente.Enabled = False
        BtnPrincipal.Enabled = True
        cod_pessoa_old = TxbCodPessoa.Text
        If CkbFuncionario.Checked = True Then
            BtnFuncionario.Enabled = True
        Else
            BtnFuncionario.Enabled = False
        End If
        atualizarDependente = 1
        limparDependente()
        atualizaDadosDependente()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles BtnFuncionario.Click
        If TabControl1.SelectedIndex = 2 Then
            verificarAuteracaoDependente()
        End If
        TabControl1.SelectedIndex = 3
        BtnFuncionario.Enabled = False
        BtnPrincipal.Enabled = True
        If TxbCodPessoa.Text <> "" Then
            BtnDependente.Enabled = True
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        verificarAuteracaoDependente()
        TabControl1.SelectedIndex = 0
        GbNavegador.Enabled = True
        BtnPrincipal.Enabled = False
        If TxbCodPessoa.Text <> "" Then
            BtnDependente.Enabled = True
            If CkbFuncionario.Checked = True Then
                BtnFuncionario.Enabled = True
            End If
        End If
    End Sub

    Private Sub DgvPessoa_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPessoa.CellContentClick
        TabControl1.SelectedIndex = 0
    End Sub
    Public Sub verificarAuteracaoPessoa()
        Dim msg As String = ""
        If TxbCodPessoa.Text = "" Then
            Exit Sub
        End If
        If nom_pessoa_old <> TxbNomPessoa.Text Then
            msg = "Nome" & vbCrLf & "Anterior: " & nom_pessoa_old & vbCrLf & " Nova : " & TxbNomPessoa.Text
        End If

        If nom_fantasia_old <> TxbNomFantasia.Text Then
            msg = msg & vbCrLf & "Nome Fantasia" & vbCrLf & "Anterior: " & nom_fantasia_old & vbCrLf & " Nova : " & TxbNomFantasia.Text
        End If
        If num_cnpj_cpf_old <> TxbCnpjCpf.Text Then
            msg = msg & vbCrLf & "CNPJ CPF" & vbCrLf & "Anterior: " & num_cnpj_cpf_old & vbCrLf & " Nova : " & TxbCnpjCpf.Text
        End If
        If num_ie_rg_old <> TxbIeRg.Text Then
            msg = msg & vbCrLf & "IE RG" & vbCrLf & "Anterior: " & num_ie_rg_old & vbCrLf & " Nova : " & TxbIeRg.Text
        End If
        If dta_nascimento_old <> DtpDtaNasc.Value.ToShortDateString Then
            msg = msg & vbCrLf & "Data Nascimento" & vbCrLf & "Anterior: " & dta_nascimento_old & vbCrLf & " Nova : " & DtpDtaNasc.Value.ToShortDateString
        End If


        If des_logradouro_old <> TxbRua.Text Then
            msg = msg & vbCrLf & "Rua" & vbCrLf & "Anterior: " & des_logradouro_old & vbCrLf & " Nova : " & TxbRua.Text
        End If
        If des_complemento_old <> TxbComplemento.Text Then
            msg = msg & vbCrLf & "Complemento" & vbCrLf & "Anterior: " & des_complemento_old & vbCrLf & " Nova : " & TxbComplemento.Text
        End If
        If cod_cidade_old <> TxbCodCidade.Text Then
            msg = msg & vbCrLf & "Cidade" & vbCrLf & "Anterior: " & cod_cidade_old & vbCrLf & " Nova : " & TxbCodCidade.Text
        End If
        If nom_bairro_old <> TxbBairro.Text Then
            msg = msg & vbCrLf & "Bairro" & vbCrLf & "Anterior: " & nom_bairro_old & vbCrLf & " Nova : " & TxbBairro.Text
        End If
        If num_cep_old <> TxbCep.Text Then
            msg = msg & vbCrLf & "Cep" & vbCrLf & "Anterior: " & num_cep_old & vbCrLf & " Nova : " & TxbCep.Text
        End If
        If num_telefone_1_old <> TxbFone1.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_1_old & vbCrLf & " Nova : " & TxbFone1.Text
        End If
        If num_telefone_2_old <> TxbFone2.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_2_old & vbCrLf & " Nova : " & TxbFone2.Text
        End If
        If num_telefone_3_old <> TxbFone3.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_telefone_3_old & vbCrLf & " Nova : " & TxbFone3.Text
        End If
        If des_observacao_old <> TxbObservacao.Text Then
            msg = msg & vbCrLf & "Observação" & vbCrLf & "Anterior: " & des_observacao_old & vbCrLf & " Nova : " & TxbObservacao.Text
        End If

        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvaRegistro()
            End If
        End If
    End Sub
    Public Sub verificarAuteracaoDependente()
        Dim msg As String = ""
        If txbCodDepte.Text = "" Then
            Exit Sub
        End If
        If nom_dependente_old <> txbNomDepte.Text Then
            msg = "Nome" & vbCrLf & "Anterior: " & nom_dependente_old & vbCrLf & " Nova : " & txbNomDepte.Text
        End If

        If nom_apelido_old <> txbApelidoDepte.Text Then
            msg = msg & vbCrLf & "Apelido" & vbCrLf & "Anterior: " & nom_apelido_old & vbCrLf & " Nova : " & txbApelidoDepte.Text
        End If
        If num_fone_depte_old <> txbFoneDepte.Text Then
            msg = msg & vbCrLf & "Fone" & vbCrLf & "Anterior: " & num_fone_depte_old & vbCrLf & " Nova : " & txbFoneDepte.Text
        End If
        If des_observacao_depte_old <> txbObsDepte.Text Then
            msg = msg & vbCrLf & "Observação" & vbCrLf & "Anterior: " & des_observacao_depte_old & vbCrLf & " Nova : " & txbObsDepte.Text
        End If
        If dta_nascimento_depte_old <> DtpDtaNascDept.Value.ToShortDateString Then
            msg = msg & vbCrLf & "Data Nascimento" & vbCrLf & "Anterior: " & dta_nascimento_depte_old & vbCrLf & " Nova : " & DtpDtaNascDept.Value.ToShortDateString
        End If

        If msg <> "" Then
            If MsgBox("Deseja salvar a alteraçã em:" & vbCrLf & msg & "?", MsgBoxStyle.YesNo, "Confirmação") = MsgBoxResult.Yes Then
                salvarDependente()
            End If
        End If
    End Sub

    Private Sub BtnPrimeiroReg_Click(sender As Object, e As EventArgs) Handles BtnPrimeiroReg.Click
        verificarAuteracaoPessoa()

        If ds.Tables(0).Rows.Count > 0 Then
            i = 0
            carregaFormulario()
        End If

    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        verificarAuteracaoPessoa()

        If ds.Tables(0).Rows.Count > 0 Then
            If i = 0 Then
                i = ds.Tables(0).Rows.Count - 1
            Else
                i = i - 1
            End If
        End If
        carregaFormulario()
    End Sub

    Private Sub BtnUltimoReg_Click(sender As Object, e As EventArgs) Handles BtnUltimoReg.Click
        verificarAuteracaoPessoa()

        If ds.Tables(0).Rows.Count > 0 Then
            i = ds.Tables(0).Rows.Count - 1
        End If
        carregaFormulario()
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        verificarAuteracaoPessoa()

        If ds.Tables(0).Rows.Count > 0 Then
            If i < ds.Tables(0).Rows.Count - 1 Then
                i = i + 1
            Else
                i = 0
            End If
        End If
        carregaFormulario()
    End Sub


End Class