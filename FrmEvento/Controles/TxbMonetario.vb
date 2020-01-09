Imports System.Windows.Forms
Public Class TxbMonetario
    Inherits TextBox

    Public Sub ClTxbMonetario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = CChar(ChrW(Asc(","))) Then
            e.Handled = False
        ElseIf e.KeyChar = CChar(ChrW(Asc("."))) Then
            e.Handled = True
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub ClTxbMonetario_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Me.Text <> "" Then
            If IsNumeric(Me.Text) = False Then
                MessageBox.Show("Formato incorreto de número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Text = "0,00"
                Me.Select()
            Else
                Me.Text = FormatNumber(Convert.ToDouble(Me.Text), 2)
            End If
        Else
            Me.Text = "0,00"
        End If
    End Sub
    Private Sub TxbMonetario_val(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Text = "" Then
            Me.Text = "0,00"
        End If
        Me.Text = FormatNumber(Convert.ToDouble(Me.Text), 2)
    End Sub
End Class
