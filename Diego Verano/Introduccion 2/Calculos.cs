using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion_2
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = 20;
            num2 = 43;

            resultado = num1 + num2;

            MessageBox.Show("Nuestro resultado es: " + resultado.ToString()); 

            

        }
    }
}
