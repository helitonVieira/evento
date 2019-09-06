﻿Public Class FrmImprimirIngressos
    Dim conectar As New ConexaoSQ
    Dim ds As New DataSet
    Dim evento As New ClEvento
    Dim Ingresso As New ClIngresso
    Dim IngressoImpresso As New ClIngressoImpresso
    Dim paramSistem As New ClParametroSistema
    Dim emp As New ClEmpresa
    Dim valTotalItem, valCustoTotal As String
    Dim nome1, nome2, nome3, dtaEvento, obs1, obs2, lote As String
    Dim posicaoNome As Integer = 0
    Dim numIngresso As Integer


    Public Sub atribuirNome()

        nome1 = DgvEvento.CurrentRow.Cells(2).Value
        nome2 = DgvEvento.CurrentRow.Cells(3).Value
        nome3 = DgvEvento.CurrentRow.Cells(4).Value

        If nome1 = "Null" Then
            nome1 = ""
        End If
        If nome2 = "Null" Then
            nome2 = ""
        End If
        If nome3 = "Null" Then
            nome3 = ""
        End If


    End Sub
    Public Sub atualizarDados()
        '  conectar.Conectar()
        Dim tabela As DataTable
        ds = Ingresso.ConsultarIngressoEventoAberto()
        tabela = ds.Tables(0)

        If tabela.Rows.Count > 0 Then
            DgvEvento.DataSource = ds.Tables(0)
            formatarGrid()
        End If
        limpar()

    End Sub
    Public Sub formatarGrid()
        With DgvEvento
            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Código"
            .Columns(2).HeaderText = "Nome1"
            .Columns(3).HeaderText = "Nome2"
            .Columns(4).HeaderText = "Nome3"
            .Columns(5).HeaderText = "Valor"
            .Columns(6).HeaderText = "Data"
            .Columns(7).HeaderText = "Lote"
            .Columns(8).HeaderText = "Aberto"
            .Columns(9).HeaderText = "Observação1"
            .Columns(10).HeaderText = "Observação2"

            .Columns(0).Width = 60
            .Columns(1).Width = 80
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 60
            .Columns(7).Width = 60
            .Columns(8).Width = 60
            .Columns(9).Width = 60
            .Columns(10).Width = 60
        End With
    End Sub

    Private Sub TxtQtde_LostFocus(sender As Object, e As EventArgs) Handles TxtQtde.LostFocus
        If TxtQtde.Text = "" Then
            TxtQtde.Select()
            Exit Sub
        End If

        If LbDescricao.Text = "" Then
            TxtCodItem.Select()
            Exit Sub
        End If
        If TxtCodItem.Text = "" Or LbDescricao.Text = "" Then
            MsgBox("ITEM INVALIDO")
            TxtCodItem.Select()
            Exit Sub
        End If

        salvar()
        TxtCodItem.Select()
    End Sub

    Private Sub DgvEvento_CellContentClic(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEvento.CellContentClick
        Try
            TxtCodItem.Text = DgvEvento.CurrentRow.Cells(0).Value
            LbDescricao.Text = DgvEvento.CurrentRow.Cells(2).Value
            TxtQtde.Enabled = True
            TxtQtde.Select()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub FrmImprimirIngresso_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TECLA ENTER
        InsereEnter(Me)
    End Sub

    Public Sub salvar()

        '   TxtCodItem.Select()
        Try
            IngressoImpresso.cod_evento = TxtCodItem.Text
            IngressoImpresso.seq_ingresso = TxtCodItem.Text
            'verificar qtd
            If TxtQtde.Text = "" Then
                IngressoImpresso.qtd_impressa = "1"
            Else
                IngressoImpresso.qtd_impressa = TxtQtde.Text.Replace(",", ".")
            End If
            'verificar valor custo
            If valCustoTotal = "" Then
                valCustoTotal = "0"
            Else
                valCustoTotal = valCustoTotal.Replace(",", ".")
            End If
            'verificar valor venda
            If valTotalItem = "" Then
                valTotalItem = "0"
            Else
                valTotalItem = valTotalItem.Replace(",", ".")
            End If
            IngressoImpresso.val_total_impresso = valTotalItem * IngressoImpresso.qtd_impressa
            IngressoImpresso.InserirIngressoImpresso()

            Dim qtdImpressa As Integer = numIngresso
            For index As Integer = 1 To TxtQtde.Text
                numIngresso = qtdImpressa + index
                imprimirLayout()

            Next
            limpar()
            TxtCodItem.Select()
        Catch ex As Exception
            MsgBox("ERRO AO SALVAR EVENTO" & ex.Message, MsgBoxStyle.Critical, "Erro")
            TxtCodItem.Select()
        End Try
        TxtCodItem.Select()
    End Sub

    Public Sub limpar()
        TxtQtde.Text = ""
        LbDescricao.Text = ""
        TxtQtde.Enabled = False
        TxtCodItem.Text = ""
        nome1 = ""
        nome2 = ""
        nome3 = ""
        valTotalItem = ""
        TxtCodItem.Select()
    End Sub

    Private Sub TxtQtde_TextChanged(sender As Object, e As EventArgs) Handles TxtQtde.TextChanged
        If Not IsNumeric(TxtQtde.Text) Then
            TxtQtde.Text = ""
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpar()
        atualizarDados()

    End Sub

    Private Sub GroupBoxVendas_Enter(sender As Object, e As EventArgs) Handles GroupBoxVendas.Enter

    End Sub

    Private Sub TxtQtde_Focus(sender As Object, e As EventArgs) Handles TxtQtde.GotFocus
        If TxtCodItem.Text = "" Then
            TxtQtde.Enabled = False
            TxtCodItem.Select()
        End If
    End Sub

    Private Sub TxtCodItem_LostFocus(sender As Object, e As EventArgs) Handles TxtCodItem.LostFocus
        If TxtCodItem.Text = "" Then
            TxtCodItem.Select()
            Exit Sub
        End If
        TxtQtde.Enabled = True
        If TxtCodItem.Text = "" Then
            LbDescricao.Text = ""
        End If
        TxtQtde.Select()
    End Sub

    Private Sub TxtCodItem_TextChanged(sender As Object, e As EventArgs) Handles TxtCodItem.TextChanged
        If Not IsNumeric(TxtCodItem.Text) Then
            TxtCodItem.Text = ""
        End If
        Try

            For Each row In DgvEvento.Rows
                If TxtCodItem.Text = row.Cells(0).Value.ToString Then
                    LbDescricao.Text = row.Cells(2).Value.ToString
                    dtaEvento = row.Cells(6).Value.ToString
                    valTotalItem = row.Cells(5).Value.ToString
                    valCustoTotal = "0"
                    lote = row.Cells(7).Value.ToString
                    obs1 = row.Cells(9).Value.ToString
                    obs2 = row.Cells(10).Value.ToString
                    numIngresso = row.Cells(12).Value.ToString
                    atribuirNome()
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub imprimirLayout()
        Try
            PrintDocument1.Print()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim tabela As DataRow
            ds = paramSistem.consultarParametro()
            tabela = ds.Tables(0).Rows(0)
            Dim diminFontIngresso As Integer = tabela.Item(1)

            Dim ds1 As New DataSet
            ds1 = emp.ConsultarEmpresa
            Dim linha As DataRow
            linha = ds1.Tables(0).Rows(0)
            Dim nomEmpresa As String = linha.Item(1).ToString

            diminFontIngresso = 20 - (diminFontIngresso)

            Dim reportFont4 As Font = New Drawing.Font("Time New Roman", 4)
            Dim reportFont6 As Font = New Drawing.Font("Time New Roman", 6)
            Dim reportFont14 As Font = New Drawing.Font("Time New Roman", 14)
            Dim reportFont20 As Font = New Drawing.Font("Time New Roman", diminFontIngresso)
            Dim reportFont8 As Font = New Drawing.Font("Time New Roman", 8)
            Dim numero As Int16 = 99
            Dim newImageEmpresa As Image
            Try
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.png")

            Catch ex As Exception
                newImageEmpresa = Image.FromFile("C:\evento\imagem\logoEmpresa.jpg")

            End Try
            Dim x1 As Integer = 96
            Dim y1 As Integer = 0
            Dim width1 As Integer = 110
            Dim height1 As Integer = 110
            ' Draw image to screen.
            e.Graphics.DrawImage(newImageEmpresa, x1, y1, width1, height1)
            e.Graphics.DrawString(numIngresso, reportFont14, Brushes.Black, 230, 0)

            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 0)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 10)


            e.Graphics.DrawString(nome1, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome1.Count), 85)
            e.Graphics.DrawString(nome2, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome2.Count), 115)
            e.Graphics.DrawString(nome3, reportFont20, Brushes.Black, paramSistem.posicaoTamanho20(nome3.Count), 145)
            e.Graphics.DrawString(lote, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(lote.Count), 195)
            Dim totalIngresso As String = ""
            totalIngresso = "R$ " & valTotalItem & ".00"
            e.Graphics.DrawString(totalIngresso, reportFont14, Brushes.Black, paramSistem.posicaoTamanho14(totalIngresso.Count) + 10, 225)
            e.Graphics.DrawString(obs1, reportFont8, Brushes.Black, 5, 255)
            e.Graphics.DrawString(obs2, reportFont8, Brushes.Black, 5, 275)
            e.Graphics.DrawString("Válido apenas para dia:" & dtaEvento, reportFont8, Brushes.Black, 20, 305)
            Dim newImage As Image = Image.FromFile("C:\evento\imagem\CODBARRA.png")

            ' Create coordinates for upper-left corner

            ' of image and for size of image.
            Dim x As Integer = 40
            Dim y As Integer = 325
            Dim width As Integer = 200
            Dim height As Integer = 50

            ' Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y, width, height)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 385)
            e.Graphics.DrawString(nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa & " " & nomEmpresa, reportFont6, Brushes.Black, 0, 395)

            ' e.Graphics.DrawString(" ", reportFont1, Brushes.Black, 100, 160)
        Catch ex As Exception

        End Try
    End Sub

End Class