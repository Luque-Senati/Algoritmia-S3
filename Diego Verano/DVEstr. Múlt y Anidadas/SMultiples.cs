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
    public partial class SMultiples : Form
    {
        public SMultiples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txtcaracter.Text.Length == 0)
            {
                Lbldicta.Text = "Ingrese un caracter";
                return;
            }
            
            char c = Txtcaracter.Text[0];

            if (c >= 'a' && c <= 'z')
            {
                Lbldicta.Text = "Es una letra minuscula";
            }

            else if (c >= 'A' && c <= 'Z')
            {
                Lbldicta.Text = "Es una letra mayúscula";
            }

            else if (c >= '0' && c <= '9')
            {
                Lbldicta.Text = "Es un numero";
            }

            else
            {
                Lbldicta.Text = "No es un caracter alfanumérica";
            }

        }

        private void SMultiples_Load(object sender, EventArgs e)
        {

        }
    }
}
