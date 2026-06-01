Public Class Calculadora
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bcero_Click(sender As Object, e As EventArgs) Handles Bcero.Click
        resolucion.Text = resolucion.Text & "0"
    End Sub

    Private Sub Buno_Click(sender As Object, e As EventArgs) Handles Buno.Click
        resolucion.Text = resolucion.Text & "1"
    End Sub

    Private Sub Bdos_Click(sender As Object, e As EventArgs) Handles Bdos.Click
        resolucion.Text = resolucion.Text & "2"
    End Sub

    Private Sub Btres_Click(sender As Object, e As EventArgs) Handles Btres.Click
        resolucion.Text = resolucion.Text & "3"
    End Sub

    Private Sub Bcuatro_Click(sender As Object, e As EventArgs) Handles Bcuatro.Click
        resolucion.Text = resolucion.Text & "4"
    End Sub

    Private Sub Bcinco_Click(sender As Object, e As EventArgs) Handles Bcinco.Click
        resolucion.Text = resolucion.Text & "5"
    End Sub

    Private Sub Bseis_Click(sender As Object, e As EventArgs) Handles Bseis.Click
        resolucion.Text = resolucion.Text & "6"
    End Sub

    Private Sub Bsiete_Click(sender As Object, e As EventArgs) Handles Bsiete.Click
        resolucion.Text = resolucion.Text & "7"
    End Sub

    Private Sub Bocho_Click(sender As Object, e As EventArgs) Handles Bocho.Click
        resolucion.Text = resolucion.Text & "8"
    End Sub

    Private Sub Bnueve_Click(sender As Object, e As EventArgs) Handles Bnueve.Click
        resolucion.Text = resolucion.Text & "9"
    End Sub

    Private Sub Bmas_Click(sender As Object, e As EventArgs) Handles Bmas.Click
        Try
            If resolucion.Text <> "" Then
                memoria1 = Val(resolucion.Text)
                signo = "+"
                resolucion.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bmenos_Click(sender As Object, e As EventArgs) Handles Bmenos.Click
        Try
            If resolucion.Text <> "" Then
                memoria1 = Val(resolucion.Text)
                signo = "-"
                resolucion.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bmult_Click(sender As Object, e As EventArgs) Handles Bmult.Click
        Try
            If resolucion.Text <> "" Then
                memoria1 = Val(resolucion.Text)
                signo = "*"
                resolucion.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bdiv_Click(sender As Object, e As EventArgs) Handles Bdiv.Click
        Try
            If resolucion.Text <> "" Then
                memoria1 = Val(resolucion.Text)
                signo = "/"
                resolucion.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        resolucion.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub Bresultado_Click(sender As Object, e As EventArgs) Handles Bresultado.Click
        Try
            If resolucion.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = resolucion.Text
                calculadora()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub calculadora()
        Select Case signo
            Case "+"
                resolucion.Text = memoria1 + memoria2
            Case "-"
                resolucion.Text = memoria1 - memoria2
            Case "*"
                resolucion.Text = memoria1 * memoria2
            Case "/"
                resolucion.Text = memoria1 / memoria2
            Case Else
                MessageBox.Show("Operación no válida")
        End Select
    End Sub
End Class
