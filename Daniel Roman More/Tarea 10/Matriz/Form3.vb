Public Class Form3

    'VARIABLE TOTAL
    Dim totalgeneral As Double = 0

    'LISTA DE PRODUCTOS
    Dim codigo(2) As String
    Dim nombre(2) As String
    Dim precio(2) As Double

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PRODUCTOS
        codigo(0) = "001"
        nombre(0) = "ARROZ"
        precio(0) = 25

        codigo(1) = "002"
        nombre(1) = "AZUCAR"
        precio(1) = 30

        codigo(2) = "003"
        nombre(2) = "ACEITE"
        precio(2) = 50

        'CARGAR COMBOBOX
        cboproducto.Items.Add(nombre(0))
        cboproducto.Items.Add(nombre(1))
        cboproducto.Items.Add(nombre(2))

    End Sub

    'MOSTRAR DATOS DEL PRODUCTO
    Private Sub cboproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboproducto.SelectedIndexChanged

        Dim i As Integer
        i = cboproducto.SelectedIndex

        lblcodigo.Text = codigo(i)
        lblnombre.Text = nombre(i)
        lblprecio.Text = precio(i)

    End Sub

    'AGREGAR PRODUCTO
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        If txtcantidad.Text = "" Then
            MessageBox.Show("Ingrese cantidad")
            Exit Sub
        End If

        Dim cantidad As Integer
        Dim subtotal As Double

        cantidad = Val(txtcantidad.Text)
        subtotal = cantidad * Val(lblprecio.Text)

        dgvfactura.Rows.Add(
            lblcodigo.Text,
            lblnombre.Text,
            lblprecio.Text,
            cantidad,
            subtotal
        )

        totalgeneral += subtotal

        lbltotal.Text = totalgeneral.ToString("0.00")

        txtcantidad.Clear()

    End Sub

    'ELIMINAR FILA
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        If dgvfactura.CurrentRow IsNot Nothing Then

            totalgeneral -= Val(dgvfactura.CurrentRow.Cells(4).Value)

            lbltotal.Text = totalgeneral.ToString("0.00")

            dgvfactura.Rows.Remove(dgvfactura.CurrentRow)

        End If

    End Sub

    'CALCULAR DEVOLUCION
    Private Sub txtefectivo_TextChanged(sender As Object, e As EventArgs) Handles txtefectivo.TextChanged

        If txtefectivo.Text <> "" Then

            Dim efectivo As Double
            Dim devolucion As Double

            efectivo = Val(txtefectivo.Text)

            devolucion = efectivo - totalgeneral

            lbldevolucion.Text = devolucion.ToString("0.00")

        End If

    End Sub

    'VENDER
    Private Sub btnvender_Click(sender As Object, e As EventArgs) Handles btnvender.Click

        MessageBox.Show("VENTA REALIZADA")

        dgvfactura.Rows.Clear()

        lblcodigo.Text = "-"
        lblnombre.Text = "-"
        lblprecio.Text = "-"
        lbltotal.Text = "-"
        lbldevolucion.Text = "-"

        txtcantidad.Clear()
        txtefectivo.Clear()

        totalgeneral = 0

    End Sub

End Class