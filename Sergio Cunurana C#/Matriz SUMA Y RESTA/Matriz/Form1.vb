Public Class Form1

    Dim f, c As Integer

    ' RADIOBUTTON 2x2
    Private Sub rb2x2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2x2.CheckedChanged

        f = 2
        c = 2

        DataGridView1.ColumnCount = c
        DataGridView1.RowCount = f

        DataGridView2.ColumnCount = c
        DataGridView2.RowCount = f

        DataGridView3.ColumnCount = c
        DataGridView3.RowCount = f

    End Sub

    ' RADIOBUTTON 3x3
    Private Sub rb3x3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3x3.CheckedChanged

        f = 3
        c = 3

        DataGridView1.ColumnCount = c
        DataGridView1.RowCount = f

        DataGridView2.ColumnCount = c
        DataGridView2.RowCount = f

        DataGridView3.ColumnCount = c
        DataGridView3.RowCount = f

    End Sub

    ' BOTON SUMAR
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click

        Dim i, j As Integer
        Dim a, b, r As Integer

        For i = 0 To f - 1
            For j = 0 To c - 1

                a = Val(DataGridView1.Item(j, i).Value)
                b = Val(DataGridView2.Item(j, i).Value)

                r = a + b

                DataGridView3.Item(j, i).Value = r

            Next
        Next

    End Sub

    ' BOTON RESTAR
    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click

        Dim i, j As Integer
        Dim a, b, r As Integer

        For i = 0 To f - 1
            For j = 0 To c - 1

                a = Val(DataGridView1.Item(j, i).Value)
                b = Val(DataGridView2.Item(j, i).Value)

                r = a - b

                DataGridView3.Item(j, i).Value = r

            Next
        Next

    End Sub

End Class