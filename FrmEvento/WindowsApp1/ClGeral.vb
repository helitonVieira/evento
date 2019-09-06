Public Class ClGeral
    Public Sub somenteNumero(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    Public Function somar(x As Double, y As Double)
        Dim s As Double
        s = x + y
        Return (s)
    End Function
    Public Function mutiplicar(x As Double, y As Double)
        Dim s As Double
        s = x * y
        Return (s)
    End Function
End Class
