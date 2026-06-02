using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
        
        private void ConfigurarMatrices(int tamaño)
        {
            dGVdatouno.Columns.Clear();
            dGVdatodos.Columns.Clear();
            dGVresultado.Columns.Clear();

            for (int i = 0; i < tamaño; i++)
            {
                dGVdatouno.Columns.Add("Col" + i, "");
                dGVdatodos.Columns.Add("Col" + i, "");
                dGVresultado.Columns.Add("Col" + i, "");
            }

            dGVdatouno.Rows.Add(tamaño);
            dGVdatodos.Rows.Add(tamaño);
            dGVresultado.Rows.Add(tamaño);
        }

        string operacion = "2x2";

        private void rbtndospor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtndospor.Checked)
            {
                operacion = "2x2";
                ConfigurarMatrices(2);
            }
        }

        private void rbtntrespor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtntrespor.Checked)
            {
                operacion = "3x3";
                ConfigurarMatrices(3);

            }
        }

        private bool Validar(int limite)
        {
            for (int i = 0; i < limite; i++)
            {
                for (int j = 0; j < limite; j++)
                {
                    if (dGVdatouno[i, j].Value == null || dGVdatodos[i, j].Value == null || 
                        dGVdatouno[i, j].Value.ToString() == "" || dGVdatodos[i,j].Value.ToString() == "")
                    {
                MessageBox.Show("No celdas vacias. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                    }
                }
            }
            return true;
        }

        private void btnsuma_Click_1(object sender, EventArgs e)
        {
            int limite = operacion == "2x2" ? 2 : 3;
            if (Validar(limite))
            {
                lbloperacion.Text = "+";

                for (int i = 0; i < limite; i++)
                {
                    for (int j = 0; j < limite; j++)
                    {
                        double valor1 = Convert.ToDouble(dGVdatouno[j, i].Value);
                        double valor2 = Convert.ToDouble(dGVdatodos[j, i].Value);
                        double resultado = valor1 + valor2;
                        dGVresultado[j, i].Value = resultado;
                    }
                }
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            int limite = operacion == "2x2" ? 2 : 3;
            if (Validar(limite))
            {
                lbloperacion.Text = "-";

                for (int i = 0; i < limite; i++)
                {
                    for (int j = 0; j < limite; j++)
                    {
                        double valor1 = Convert.ToDouble(dGVdatouno[j, i].Value);
                        double valor2 = Convert.ToDouble(dGVdatodos[j, i].Value);
                        double resultado = valor1 - valor2;
                        dGVresultado[j, i].Value = resultado;
                    }
                }
            }
        }
    }
}
