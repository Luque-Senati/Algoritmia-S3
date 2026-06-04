using System;
using System.Linq;
using System.Windows.Forms;

namespace Consulta_de_datos_con_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            string[] postres =
            {
                "Pay de manzana",
                "Pastel de tres leches",
                "Pastel de chocolate",
                "Pastel de choclo",
                "Manzana caramelizada",
                "Fresas con crema"
            };

            string palabra = txtBuscar.Text.Trim().ToLower();

            var consulta =
                from p in postres
                where p.ToLower().Contains(palabra)
                orderby p
                select p;

            lstResultados.Items.Add("=== RESULTADOS DE LA BÚSQUEDA ===");
            lstResultados.Items.Add("");

            if (consulta.Any())
            {
                foreach (var item in consulta)
                {
                    lstResultados.Items.Add(item);
                }
            }
            else
            {
                lstResultados.Items.Add("No se encontraron resultados.");
            }

            lstResultados.Items.Add("");
            lstResultados.Items.Add("=== INFORMACIÓN DEL RESULTADO ===");

            MostrarInformacion(consulta);
        }

        private void MostrarInformacion(object resultado)
        {
            Type tipo = resultado.GetType();

            lstResultados.Items.Add("Tipo generado por LINQ:");
            lstResultados.Items.Add(tipo.FullName ?? "Nombre no disponible");

            lstResultados.Items.Add("");

            lstResultados.Items.Add("Ensamblado:");
            lstResultados.Items.Add(tipo.Assembly.FullName ?? "Ensamblado no disponible");
        }
    }
}