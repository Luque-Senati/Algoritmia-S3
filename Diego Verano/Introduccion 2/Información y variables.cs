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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprueba_Click(object sender, EventArgs e)
        {

            string nombre = "Diego"; //Almacena texto || requiere comillas dobles
            char inicial = '@'; //Almacenan caracteres únicos || requiere comillas simples
            int tallaPolo = 16; //Almacenan números enteros o negativos || requier 4 bytes
            long numeroLargo = 1234567890; //Almacenan números enteros o negativos muy grandes || requier 8 bytes
            float tallaCamisa = 15.5f; //Almacenan números decimales, se debe agregar la letra "f" al final del número || requier 4 bytes
            double tallazapato = 47.2; //Almacenan números decimales || requiere 8 bytes
            bool online = false; //Almacena valores verdaderos o falsos || requiere 1 byte
            var variable = "Hola"; //Almacena cualquier tipo de dato, pero no es recomendable usarlo || requiere 16 bytes
                      
            MessageBox.Show("Hola " + txtnombre.Text + " Bienvenido" + "\n" + "Tienes una talla de camisa de " + tallaCamisa.ToString());
            //MessageBox.Show("Esta es mi propia introducción a C#");
            //MessageBox.Show("Esta introducción traerá una destrucción caótica a mi propia paz");
            //MessageBox.Show("Pero no me importa, porque el conocimiento es poder");

            nombre= txtnombre.Text;
            inicial = Convert.ToChar(txtinicial.Text);
            tallaPolo = Convert.ToInt32(txttallapolo.Text);
            online = Convert.ToBoolean(txtonline.Text);

            //Si no se tiene alguno de estos requerimientos al darle al botón este dará error
            
            MessageBox.Show(txtnombre.Text + "\n" + "Tu inicial es " + txtinicial.Text + "\n " + "Tu talla de polo es" 
                + txttallapolo.Text + "\n " + "Y tu estado online es " + txtonline.Text);


        }

        private void btncalculo_Click_1(object sender, EventArgs e)
        {
            Calculos pestcalculo = new Calculos();


            pestcalculo.Show/*Dialog*/();
            //El Dialog sirve para "bloquear" la ventana que se ha abierto haciendo que no se pueda clickear en otro lado


        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            Menú pestmenu = new Menú();

            pestmenu.Show();
        }
    }
}
