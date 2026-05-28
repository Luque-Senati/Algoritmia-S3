using System;
using System.Data;
using System.Windows.Forms;

namespace Programa
{
    public partial class calculadora : Form
    {
        string pantallaCompleta = "";

        public calculadora()
        {
            InitializeComponent();
        }

        // NUMEROS
        private void button0_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "0";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "1";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "2";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "3";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "4";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "5";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "6";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "7";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "8";
            txtPantalla.Text = pantallaCompleta;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantallaCompleta += "9";
            txtPantalla.Text = pantallaCompleta;
        }

        // PUNTO
        private void button_punto_Click(object sender, EventArgs e)
        {
            pantallaCompleta += ".";
            txtPantalla.Text = pantallaCompleta;
        }

        // OPERACIONES
        private void buttonSUM_Click(object sender, EventArgs e)
        {
            pantallaCompleta += " + ";
            txtPantalla.Text = pantallaCompleta;
        }

        private void buttonRES_Click(object sender, EventArgs e)
        {
            pantallaCompleta += " - ";
            txtPantalla.Text = pantallaCompleta;
        }

        private void buttonmMUL_Click(object sender, EventArgs e)
        {
            pantallaCompleta += " * ";
            txtPantalla.Text = pantallaCompleta;
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            pantallaCompleta += " / ";
            txtPantalla.Text = pantallaCompleta;
        }

        // IGUAL
        private void buttonIGU_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = new DataTable().Compute(pantallaCompleta, null);
                txtPantalla.Text = resultado.ToString();
                pantallaCompleta = resultado.ToString();
            }
            catch
            {
                txtPantalla.Text = "Error";
                pantallaCompleta = "";
            }
        }

        // LIMPIAR
        private void buttonC_Click(object sender, EventArgs e)
        {
            pantallaCompleta = "";
            txtPantalla.Clear();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            pantallaCompleta = "";
            txtPantalla.Clear();
        }
    }
}