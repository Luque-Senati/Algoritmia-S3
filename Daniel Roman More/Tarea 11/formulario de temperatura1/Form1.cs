namespace formulario_de_temperatura1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double temperatura;

            temperatura = Convert.ToDouble(txtTemperatura.Text);

            if (temperatura < 10)
            {
                txtClima.Text = "Frío";
            }
            else if (temperatura >= 10 && temperatura <= 20)
            {
                txtClima.Text = "Nublado";
            }
            else if (temperatura >= 21 && temperatura <= 30)
            {
                txtClima.Text = "Calor";
            }
            else
            {
                txtClima.Text = "Tropical";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTemperatura.Clear();
            txtClima.Clear();
            txtTemperatura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
