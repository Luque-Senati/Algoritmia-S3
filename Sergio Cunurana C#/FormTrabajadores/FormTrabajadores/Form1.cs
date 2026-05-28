namespace FormTrabajadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int HorasTrabajadas;
            double PagoPorHora, SalarioBruto, Descuento, SalarioNeto;

            HorasTrabajadas = Convert.ToInt32(TxtHorasTrabajadas.Text);
            PagoPorHora = Convert.ToDouble(TxtPagoPorHora.Text);

            SalarioBruto = HorasTrabajadas * PagoPorHora;
            Descuento = 0.2 * SalarioBruto;
            SalarioNeto = SalarioBruto - Descuento;

            TxtSalarioBruto.Text = Convert.ToString(SalarioBruto);
            TxtDescuento.Text = Convert.ToString(Descuento);
            TxtSalarioNeto.Text = Convert.ToString(SalarioNeto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtApellidosNombres.Text = "";
            TxtHorasTrabajadas.Text = "";
            TxtPagoPorHora.Text = "";
            TxtSalarioBruto.Text = "";
            TxtDescuento.Text = "";
            TxtSalarioNeto.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
