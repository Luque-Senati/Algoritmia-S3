using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AR_actividad5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[0];

            if (c >= 'a' && c <= 'z')
            {
                label2.Text = "Es una letra minúscula";
            }
            else if (c >= 'A' && c <= 'Z')
            {
                label2.Text = "Es una letra mayúscula";
            }
            else if (c >= '0' && c <= '9')
            {
                label2.Text = "Es un número";
            }
            else
            {
                label2.Text = "No es un carácter alfanumérico";
            }


            if (textBox1.Text.Length == 0)
            {
                label2.Text = "Ingrese un carácter";
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
