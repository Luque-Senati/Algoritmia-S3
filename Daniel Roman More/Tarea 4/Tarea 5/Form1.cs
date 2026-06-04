namespace Tarea_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void CmdAceptar_Click(object sender, EventArgs e)
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

        private void CmdLimpiar_Click(object sender, EventArgs e)
        {
            TxtApellidosNombres.Text = "";
            TxtHorasTrabajadas.Text = "";
            TxtPagoPorHora.Text = "";
            TxtSalarioBruto.Text = "";
            TxtDescuento.Text = "";
            TxtSalarioNeto.Text = "";
        }

        private void CmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}