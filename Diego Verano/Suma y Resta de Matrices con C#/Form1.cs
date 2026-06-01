using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_y_Resta_de_Matrices_con_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operacion = "2x2";

        private void ConfigurarMatrices(int tamaño)
        {
            dGVdatouno.ColumnRemoved();
            dGVdatodos.ColumnRemoved();
            dGVresultado.ColumnRemoved();
        }

        private void rbtndospor_CheckedChanged(object sender, EventArgs e)
        {
            dGVdatouno.Column.Add("Column");
        }
    }
}
