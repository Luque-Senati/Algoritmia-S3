using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVMenu_Strip
{
    public partial class SAnidadas : Form
    {
        public SAnidadas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte temperatura;
            string clima;

            temperatura = Convert.ToByte(Txttemp.Text);

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

            Txtclima.Text = clima;
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtclima.Clear();
            Txttemp.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
