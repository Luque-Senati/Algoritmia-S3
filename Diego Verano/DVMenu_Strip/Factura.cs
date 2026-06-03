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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            float precio;

            codigo = Cbproducto.SelectedIndex;
            nombre = Cbproducto.SelectedItem.ToString();
            precio = Cbproducto.SelectedIndex;

            //Productos Camisa || Manzana || Fideos || Harina || Arroz || Zapato

            switch (codigo)
            {
                case 0: Lblcodigo.Text = "001"; break;
                case 1: Lblcodigo.Text = "002"; break;
                case 2: Lblcodigo.Text = "003"; break;
                case 3: Lblcodigo.Text = "004"; break;
                case 4: Lblcodigo.Text = "005"; break;
                case 5: Lblcodigo.Text = "006"; break;
                //case default: Lblcodigo.Text = "-"; break;
            }

            switch(nombre)
            {
                case "Camisa": Lblnombre.Text = "Polo"; break;
                case "Manzana": Lblnombre.Text = "Manzana"; break;
                case "Fideos": Lblnombre.Text = "Fideos"; break;
                case "Harina": Lblnombre.Text = "Harina"; break;
                case "Arroz": Lblnombre.Text = "Arroz"; break;
                case "Zapato": Lblnombre.Text = "Zapato"; break;
            }

            switch(precio)
            {
                case 0: Lblprecio.Text = "60"; break;
                case 1: Lblprecio.Text = "4"; break;
                case 2: Lblprecio.Text = "7"; break;
                case 3: Lblprecio.Text = "4"; break;
                case 4: Lblprecio.Text = "34"; break;
                case 5: Lblprecio.Text = "80"; break;
                
            }
        }

        //Codigo || Nombre || Precio || Cantidad || Total
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(DgvTabla);

            file.Cells[0].Value = Lblcodigo.Text;
            file.Cells[1].Value = Lblnombre.Text;
            file.Cells[2].Value = Lblprecio.Text;
            file.Cells[3].Value = Txtcantidad.Text;
            file.Cells[4].Value = (float.Parse(Lblprecio.Text) * float.Parse(Txtcantidad.Text)).ToString();
            // problemas con esta linea 
            DgvTabla.Rows.Add(file);

            Lblcodigo.Text = Lblnombre.Text = Lblprecio.Text = Txtcantidad.Text = "";

        }

        public void obtencionTotal()
        {
            float costototal = 0;
            int contador = 0;

            contador = DgvTabla.RowCount;

            for (int i = 0; i < contador;  i++)
           { 
                costototal += float.Parse(DgvTabla.Rows[i].Cells[4].Value.ToString());
            }

            Lblpagar.Text = costototal.ToString();
        }


        private void Lblpagar_Click(object sender, EventArgs e)
        {

        }
    }
}
