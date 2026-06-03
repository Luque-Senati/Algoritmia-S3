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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }


        //Variables para la calculadora
        string operacion = "";
        double num1 = 0;
        double num2 = 0;


        private void Btnuno_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "1";
        }

        private void Btndos_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "2";
        }

        private void Btntres_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "3";
        }

        private void Btncuatro_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "4";
        }

        private void Btncinco_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "5";
        }

        private void Btnseis_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "6";
        }

        private void Btnsiete_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "7";
        }

        private void Btnocho_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "8";
        }

        private void Btnnueve_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox.Text + "9";
        }

        private void Btncero_Click(object sender, EventArgs e)
        {
            Txtbox.Text = Txtbox + "0";
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Txtbox.Text);
            Txtbox.Text = "";

        }

        private void Btnmenos_Click(object sender, EventArgs e)
        {

        }

        private void Btnmulti_Click(object sender, EventArgs e)
        {

        }

        private void Btndivision_Click_1(object sender, EventArgs e)
        {

        }

        private void Btnigual_Click(object sender, EventArgs e)
        {

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtbox.Text = "";
            num1 = 0;
            num2 = 0;
            operacion = "";
        }
    }
}
