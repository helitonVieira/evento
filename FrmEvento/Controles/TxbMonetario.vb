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
                Me.Select()
            Else
                Me.Text = FormatNumber(Convert.ToDouble(Me.Text), 2)
            End If


        End If
    End Sub
End Class
