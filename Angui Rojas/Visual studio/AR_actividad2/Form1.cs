namespace AR_actividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo, ¿Cómo están?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            resultado = num1 + num2;
            textBox3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            resultado = num1 - num2;
            textBox3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            resultado = num1 * num2;
            textBox3.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);
            resultado = num1 / num2;
            textBox3.Text = resultado.ToString();
        }
    }
}
