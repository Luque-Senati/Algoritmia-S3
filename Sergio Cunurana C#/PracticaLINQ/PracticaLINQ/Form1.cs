using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            string palabraBuscada = txtBuscador.Text.Trim();

            string[] postres = new string[]
            {
                "Pay de manzana",
                "Pastel de tres leches",
                "Pastel de chocolate",
                "Pastel de choclo",
                "Manzana caramelizada",
                "Fresas con crema",
                "Mazamorra morada",
                "Arroz con leche",
                "Suspiro a la limeña",
                "Crema volteada",
                "Pie de limón",
                "Tarta de fresa",
                "Mousse de maracuyá",
                "Flan de vainilla",
                "Alfajores de manjarblanco",
                "Brownie con helado",
                "Cheesecake de frambuesa",
                "Picarones con miel",
                "Budín de pan",
                "Gelatina de fresa"
            };

            var consulta = from p in postres
                           where string.IsNullOrEmpty(palabraBuscada) || p.ToLower().Contains(palabraBuscada.ToLower())
                           orderby p ascending
                           select p;

            if (!string.IsNullOrEmpty(palabraBuscada))
            {
                listBoxResultados.Items.Add($"--- POSTRES CON LA PALABRA '{palabraBuscada.ToUpper()}' ---");
            }
            else
            {
                listBoxResultados.Items.Add("--- TODOS LOS POSTRES DISPONIBLES ---");
            }

            foreach (var postre in consulta)
            {
                listBoxResultados.Items.Add(postre);
            }

            listBoxResultados.Items.Add("");
            listBoxResultados.Items.Add("--- METADATA DE LA CONSULTA ---");

            MostrarInformacionConsulta(consulta);
        }
        private void MostrarInformacionConsulta(object objetoLINQ)
        {
            Type tipo = objetoLINQ.GetType();
            string nombreEnsamblado = tipo.Assembly.GetName().Name;

            string fechaHoraActual = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            listBoxResultados.Items.Add("==========================================");
            listBoxResultados.Items.Add($" [REPORTE DE CONSULTA]");
            listBoxResultados.Items.Add($" Fecha y Hora:    {fechaHoraActual}");
            listBoxResultados.Items.Add($" Componente C#:   {nombreEnsamblado}.dll");
            listBoxResultados.Items.Add($" Tipo Interno:    {tipo.Name} (Colección Ordenada)");
            listBoxResultados.Items.Add("==========================================");
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                e.SuppressKeyPress = true;
                btnPostres_Click(this, new EventArgs());
            }
        }
    }
}
