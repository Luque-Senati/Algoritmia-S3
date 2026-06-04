using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AR_actividad5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double valor1 = 0;
        double valor2 = 0;
        string operacion = "";

        private void button2_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            textBox1.Text += boton.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operacion = boton.Text;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operacion = boton.Text;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operacion = boton.Text;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operacion = boton.Text;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);
            double resultado = 0;
            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break;
                case "-": resultado = valor1 - valor2; break;
                case "*": resultado = valor1 * valor2; break;
                case "/":
                    if (valor2 != 0) resultado = valor1 / valor2;
                    else MessageBox.Show("No se puede dividir entre cero"); break;
            }
            textBox1.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
