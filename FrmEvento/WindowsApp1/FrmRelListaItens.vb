Public Class FrmRelListaItens
    Private Sub FrmRelListaItens_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim reportFont As Font = New Drawing.Font("Time New Roman", 14)
        Dim reportFont1 As Font = New Drawing.Font("Time New Roman", 26)
        e.Graphics.DrawString("teste Relatorio", reportFont, Brushes.Chocolate, 100, 100)
        e.Graphics.DrawString(" ", reportFont, Brushes.Chocolate, 100, 100)
        e.Graphics.DrawString(" ", reportFont, Brushes.Chocolate, 100, 100)
        e.Graphics.DrawString("        GRUPO BOLOLO", reportFont1, Brushes.CornflowerBlue, 100, 160)
    End Sub
End Class