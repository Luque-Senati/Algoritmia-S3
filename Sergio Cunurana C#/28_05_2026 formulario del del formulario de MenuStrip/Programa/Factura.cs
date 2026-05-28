using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Programa
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();

            // Asignamos manualmente los eventos del diseño a las funciones lógicas
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
        }

        // 1. EVENTO AL SELECCIONAR UN PRODUCTO
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1) return;

            int indice = cmbProducto.SelectedIndex;
            string nom = cmbProducto.SelectedItem.ToString();

            // Asignación de Códigos según la selección
            switch (indice)
            {
                case 0: lblCodigo.Text = "0011"; break; // Polo
                case 1: lblCodigo.Text = "0022"; break; // Gorra
                default: lblCodigo.Text = "0033"; break; // Camisa
            }

            // Asignación de Nombres
            lblNombre.Text = nom;

            // Asignación de Precios
            switch (indice)
            {
                case 0: lblPrecio.Text = "150"; break;
                case 1: lblPrecio.Text = "120"; break;
                default: lblPrecio.Text = "140"; break;
            }
        }

        // 2. BOTÓN AGREGAR PRODUCTO A LA LISTA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que se haya elegido un producto y colocado cantidad válida
            if (string.IsNullOrEmpty(lblCodigo.Text) || lblCodigo.Text == "-" || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto e ingrese una cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvLista);

                fila.Cells[0].Value = lblCodigo.Text;
                fila.Cells[1].Value = lblNombre.Text;
                fila.Cells[2].Value = lblPrecio.Text;
                fila.Cells[3].Value = txtCantidad.Text;

                // Calculamos el subtotal de la fila
                float precio = float.Parse(lblPrecio.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                fila.Cells[4].Value = (precio * cantidad).ToString();

                dgvLista.Rows.Add(fila);

                // Limpiamos los campos para una nueva selección
                lblCodigo.Text = "-";
                lblNombre.Text = "-";
                lblPrecio.Text = "-";
                txtCantidad.Text = "";

                obtenerTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. FUNCIÓN PARA CALCULAR EL TOTAL A PAGAR
        public void obtenerTotal()
        {
            float costoTotal = 0;

            // Recorremos de manera segura las filas para evitar desbordamientos
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    costoTotal += float.Parse(row.Cells[4].Value.ToString());
                }
            }

            lblTotatlPagar.Text = costoTotal.ToString();

            // Forzar actualización automática del vuelto
            txtEfectivo_TextChanged(null, null);
        }

        // 4. BOTÓN ELIMINAR PRODUCTO SELECCIONADO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este producto de la lista?",
                "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                dgvLista.Rows.Remove(dgvLista.CurrentRow);
                obtenerTotal();
            }
        }

        // 5. CÁLCULO EN TIEMPO REAL DEL CAMBIO/DEVOLUCIÓN
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEfectivo.Text) || string.IsNullOrEmpty(lblTotatlPagar.Text) || lblTotatlPagar.Text == "-")
            {
                lblDevolucion.Text = "-";
                return;
            }

            try
            {
                float efectivo = float.Parse(txtEfectivo.Text);
                float total = float.Parse(lblTotatlPagar.Text);
                lblDevolucion.Text = (efectivo - total).ToString();
            }
            catch
            {
                lblDevolucion.Text = "-";
            }
        }

        // 6. BOTÓN VENDER (PROCESAR E IMPRIMIR TICKET)
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos agregados en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MessageBox.Show("Venta completada de manera exitosa en Tienda Don Pepe.", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiamos la tabla para la siguiente venta
                dgvLista.Rows.Clear();
                lblTotatlPagar.Text = "-";
                txtEfectivo.Text = "";
                lblDevolucion.Text = "-";

                this.Close(); // Cierra la pestaña de la factura
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}