Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Public Class ConexaoSQL
    Private con As SqlConnection
    Private adpt As SqlDataAdapter
    Public ds As New DataSet
    Public cmd As SqlCommand
    Public caminhoBanco As String
    Public strCon As String
    ' Private strCon As String = "Data Source=localhost\SQLEXPRESS01;Initial catalog=evento;User Id =sa;Password=851213"
    ' Private strCon As String = "Data Source=DESKTOP-GMITBN3\SQLEXPRESS;Initial catalog=evento;User Id =sa;Password=851213"
    Public Sub pegarCaminhoArqTexto()
        Using sr As New StreamReader("c:\evento\caminhoBancoDados.txt")
            caminhoBanco = sr.ReadLine
            strCon = caminhoBanco
        End Using
    End Sub
    Public Sub Conectar()
        Try
            pegarCaminhoArqTexto()
            con = New SqlConnection(strCon)
            con.Open()
            MsgBox("Sucesso")
        Catch ex As Exception
            MsgBox("Erro ao tentar conectar", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub
    Public Sub Operar(ByVal sql As String)
        pegarCaminhoArqTexto()
        con = New SqlConnection(strCon)

        Try
            con.Open()
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Gravar SQL" & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
    End Sub

    Public Function Listar(ByVal sql As String)
        pegarCaminhoArqTexto()
        con = New SqlConnection(strCon)
        Try
            con.Open()
            adpt = New SqlDataAdapter(sql, con)
            ds.Clear()
            adpt.Fill(ds)

        Catch ex As Exception
            MsgBox("Erro ao listar busca SQL" & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return ds
    End Function
End Class
