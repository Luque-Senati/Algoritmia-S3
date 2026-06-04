Public Class Form2

    Dim numero1 As Double
    Dim operacion As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPantalla.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPantalla.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPantalla.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPantalla.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPantalla.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPantalla.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPantalla.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPantalla.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPantalla.Text &= "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text &= "0"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        numero1 = Val(txtPantalla.Text)
        operacion = "+"
        txtPantalla.Clear()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        numero1 = Val(txtPantalla.Text)
        operacion = "-"
        txtPantalla.Clear()
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        numero1 = Val(txtPantalla.Text)
        operacion = "*"
        txtPantalla.Clear()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        numero1 = Val(txtPantalla.Text)
        operacion = "/"
        txtPantalla.Clear()
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

        Dim numero2 As Double
        Dim resultado As Double

        numero2 = Val(txtPantalla.Text)

        Select Case operacion

            Case "+"
                resultado = numero1 + numero2

            Case "-"
                resultado = numero1 - numero2

            Case "*"
                resultado = numero1 * numero2

            Case "/"
                resultado = numero1 / numero2

        End Select

        txtPantalla.Text = resultado

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtPantalla.Clear()
    End Sub

End Class