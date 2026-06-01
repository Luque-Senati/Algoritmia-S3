Imports System.Runtime.Intrinsics.X86

Public Class Menudeopciones
    Private Sub OtraPestañaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtraPestañaToolStripMenuItem.Click
        Calculadora.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaToolStripMenuItem.Click
        Factura.Show()
    End Sub
End Class
