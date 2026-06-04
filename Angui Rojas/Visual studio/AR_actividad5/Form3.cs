using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AR_actividad5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblTotalPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "impresora virtual";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            this.Close();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod;
            string nom;
            float precio;

            cod = cmbProducto.SelectedIndex;
            nom = cmbProducto.SelectedItem.ToString();
            precio = cmbProducto.SelectedIndex;

            switch (cod)
            {
                case 0: lblCodigo.Text = "0011"; break;
                case 1: lblCodigo.Text = "0022"; break;
                case 2: lblCodigo.Text = "0033"; break;
                case 3: lblCodigo.Text = "0044"; break;
                case 4: lblCodigo.Text = "0055"; break;
                default: lblCodigo.Text = "0033"; break;
            }

            switch (nom)
            {
                case "Champú": lblNombre.Text = "Champú"; break;
                case "Papel Higiénico": lblNombre.Text = "Papel Higiénico"; break;
                case "Galleta": lblNombre.Text = "Galleta"; break;
                case "Gaseosa": lblNombre.Text = "Gaseosa"; break;
                case "Fideo": lblNombre.Text = "Fideo"; break;
                default: lblNombre.Text = "Detergente"; break;

            }

            switch (precio)
            {
                case 0: lblPrecio.Text = "35"; break;
                case 1: lblPrecio.Text = "30"; break;
                case 2: lblPrecio.Text = "5"; break;
                case 3: lblPrecio.Text = "8"; break;
                case 4: lblPrecio.Text = "4"; break;
                default: lblPrecio.Text = "25"; break;

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dataGridView1);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            dataGridView1.Rows.Add(file);

            lblCodigo.Text = lblNombre.Text = lblPrecio.Text = txtCantidad.Text = "";

            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costos = 0;
            int contador = 0;

            contador = dataGridView1.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costos += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            lblTotalPagar.Text = costos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar este producto?",
                    "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotalPagar.Text)).ToString();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
