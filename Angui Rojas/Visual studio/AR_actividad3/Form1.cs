namespace AR_actividad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int HorasTrabajadas;
            double PagoPorHora, SalarioBruto, Descuento, SalarioNeto;
            HorasTrabajadas = Convert.ToInt32(textBox2.Text);
            PagoPorHora = Convert.ToDouble(textBox3.Text);
            SalarioBruto = HorasTrabajadas * PagoPorHora;
            Descuento = 0.2 * SalarioBruto;
            SalarioNeto = SalarioBruto - Descuento;
            textBox4.Text = Convert.ToString(SalarioBruto);
            textBox5.Text = Convert.ToString(Descuento);
            textBox6.Text = Convert.ToString(SalarioNeto);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
