using System;
using System.Collections.Generic;
using System.Linq;

namespace DVLinQC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ejemplo de Sintaxis de contenido");

            int[] numeros = { 1, 2, 3, 4, 5, 6 };
            var numerosPares = from numero in numeros
                               where numero % 2 == 0
                               select numero;
            foreach (var numero in numerosPares)
            {
                System.Diagnostics.Debug.WriteLine(numero);
            }

            System.Diagnostics.Debug.WriteLine("=========================================");

            System.Diagnostics.Debug.WriteLine("Ejemplo de Sintaxis de métodos");

            int[] nums = { 1, 2, 3, 4, 5, 6, };
            var numPares = nums.Where(num => num % 2 == 0);

            foreach (var num in numPares)
            {
                System.Diagnostics.Debug.WriteLine(num);
            }

            System.Diagnostics.Debug.WriteLine("=========================================");

            System.Diagnostics.Debug.WriteLine("Selección de un rango de numeros e imprimir");

            int[] nume = { 1, 5, 7, 3, 5, 9, 8 };
            var valores = from n in nume
                          where n > 3 && n < 8
                          select n;

            lstResultado.Items.Clear();

            foreach (var numer in valores)
            {
                lstResultado.Items.Add(numer);
                IResultado.Items.Add(valores);
            }

            System.Diagnostics.Debug.WriteLine("=========================================");

            System.Diagnostics.Debug.WriteLine("Consulta de Datos con LINQ en C#");
        }

        private void BtnPostres_Click(object sender, EventArgs e)
        {
            var postre = new List<Postres> 
            {
                new Postres { Nombre = "Pay de manzana"},
                new Postres { Nombre = "Pastes de tres leches"},
                new Postres { Nombre = "Pastel de chocolate"},
                new Postres { Nombre = "Pastel de choclo"},
                new Postres { Nombre = "Manzana caramelizada"},
                new Postres { Nombre = "Fresas con crema"},
            };

            var ordenPostre = postre.OrderBy()

            LstPostres.Items.Clear();

            LstPostres.Items.Add(postre);
        }
    }
}
