using System;
using System.Windows.Forms;

namespace Programa
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculadora ventana = new calculadora();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Factura ventana = new Factura();
            ventana.Show();
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}