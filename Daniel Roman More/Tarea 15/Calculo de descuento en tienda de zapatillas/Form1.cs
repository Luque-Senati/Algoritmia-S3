namespace Calculo_de_descuento_en_tienda_de_zapatillas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Running");
            cboTipo.Items.Add("Montain");
            cboTipo.Items.Add("Urban");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precio, descuento = 0, total;
            int talla;
            string tipo;

            precio = Convert.ToDecimal(txtPrecio.Text);
            talla = Convert.ToInt32(txtTalla.Text);
            tipo = cboTipo.Text;

            // If anidados
            if (tipo == "Running")
            {
                if (talla <= 40)
                {
                    descuento = precio * 0.05m;
                }
            }
            else
            {
                if (tipo == "Montain")
                {
                    if (talla <= 40)
                    {
                        descuento = precio * 0.10m;
                    }
                }
                else
                {
                    if (tipo == "Urban")
                    {
                        if (talla <= 40)
                        {
                            descuento = precio * 0.15m;
                        }
                    }
                }
            }

            total = precio - descuento;

            lblDescuento.Text = "Descuento: S/ " + descuento.ToString("0.00");
            lblTotal.Text = "Total a pagar: S/ " + total.ToString("0.00");
        }

    }
}
