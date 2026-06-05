using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuentoZapatillasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtDescManual.Text, out decimal porcentajeIntroducido) || porcentajeIntroducido < 0 || porcentajeIntroducido > 100)
            {
                MessageBox.Show("Por favor, ingrese un porcentaje de descuento válido (entre 0 y 100).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal porcentajeDescuento = porcentajeIntroducido / 100m;

            decimal descuento = precio * porcentajeDescuento;
            decimal total = precio - descuento;

            lblResultado.Text = $"Monto comprado: {precio:C}\n" +
                                $"Descuento aplicado: {descuento:C} ({porcentajeDescuento:P})\n" +
                                $"Total a pagar: {total:C}";
        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularSinDescuento_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblResultado.Text = $"Monto comprado: {precio:C}\n" +
                                $"Descuento aplicado: {0:C} (0%)\n" +
                                $"Total a pagar: {precio:C}";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
