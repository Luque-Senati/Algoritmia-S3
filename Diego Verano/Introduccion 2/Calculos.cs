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
            double num1, num2, resultado, caja1, caja2, resu;
            
            //En caso de hace una división y querer los numeros completos con decimales
            //Cambiarlos a double los num y el resultado o tmb a float

            num1 = 20;
            num2 = 43;

            resultado = num1 + num2;
            //Tambien se puede convertir aquí a double o floar [Convert.ToDouble(num1)]
            //Abreviatura de la operación resultado*=2 unidireccional eg resultado+=10 
            resultado += 10;

            MessageBox.Show("Nuestro resultado es: " + resultado);
            MessageBox.Show(resultado.ToString());
          
            caja1 = Convert.ToDouble(txtbox1.Text);
            caja2 = Convert.ToDouble(txtbox2.Text);

            resu = caja1 + caja2;

            MessageBox.Show(resu.ToString());


        }

        private void btnexpon_Click(object sender, EventArgs e)
        {
            //Exponente
            int unonum, dosnum;
            double resultado;

            unonum = Convert.ToInt16(txtbox1.Text);
            dosnum = Convert.ToInt16(txtbox2.Text);
             
            resultado = Math.Pow(unonum,dosnum);
            //La clase Math se ve que va a ser importante para multiples operaciones de diferentes tipos
            MessageBox.Show(resultado.ToString());
        }
    }
}
