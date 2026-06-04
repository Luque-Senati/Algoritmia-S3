using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AR_actividad5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte temperatura;
            string clima;

            temperatura = Convert.ToByte(textBox1.Text);

            if (temperatura < 10)
            {
                clima = "Frío";
            }
            else if (temperatura >= 10 && temperatura <= 20)
            {
                clima = "Nublado";
            }
            else if (temperatura > 20 && temperatura <= 30)
            {
                clima = "Calor";
            }
            else
            {
                clima = "Tropical";
            }

            textBox2.Text = clima;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
