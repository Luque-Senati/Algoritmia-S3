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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calcu = new Calculadora();
            calcu.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factu = new Factura();
            factu.Show();
        }

        private void múltiplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAnidadas anida = new SAnidadas();
            anida.Show();
        }

        private void anidadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SMultiples multi = new SMultiples();
            multi.Show();
        }
    }
}
