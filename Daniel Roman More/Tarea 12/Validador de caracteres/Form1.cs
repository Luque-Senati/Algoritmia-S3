namespace Validador_de_caracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                label1.Text = "Ingrese un carácter";
                return;
            }

            char c = textBox1.Text[0];

            if (c >= 'a' && c <= 'z')
            {
                label1.Text = "Es una letra minúscula";
            }
            else if (c >= 'A' && c <= 'Z')
            {
                label1.Text = "Es una letra mayúscula";
            }
            else if (c >= '0' && c <= '9')
            {
                label1.Text = "Es un número";
            }
            else
            {
                label1.Text = "No es un carácter alfanumérico";
            }
        }
    }
}
