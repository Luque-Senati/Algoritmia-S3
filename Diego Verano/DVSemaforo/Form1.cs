using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVSemaforo
{
    public partial class Form1 : Form
    {
        int luces = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PbSemaforo.Image = Properties.Resources.semafo;
            BtnDetener.Enabled = false;
        }

        private void TiempoentreCambios_Tick(object sender, EventArgs e)
        {
            switch (luces)
            {
                case 0:
                    PbSemaforo.Image = Properties.Resources.semaverde;
                    TiempoentreCambios.Interval = 2000;
                    luces = 1;
                    break;
                case 1:
                    PbSemaforo.Image = Properties.Resources.semaamrillo;
                    TiempoentreCambios.Interval = 1000;
                    luces = 2;
                    break; 
                case 2:
                    PbSemaforo.Image = Properties.Resources.semarojo;
                    TiempoentreCambios.Interval = 2000;
                    luces = 0;
                    break;
            }    
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (BtnIniciar.Text == "Iniciar")
            {
                BtnIniciar.Text = "Iniciar";
                TiempoentreCambios.Start();
                PbSemaforo.Image = Properties.Resources.semaverde;
                BtnIniciar.Enabled = false;
                BtnDetener.Enabled = true;
                BtnApagar.Text = "Apagar";
            }
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            if (BtnDetener.Text == "Detener")
            {
                TiempoentreCambios.Enabled = false;
                BtnDetener.Text = "Continuar    ";
            }
            else
                if (BtnDetener.Text == "Continuar")
                {
                    TiempoentreCambios.Enabled = true;
                    BtnDetener.Text = "Detener";
                }
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (BtnApagar.Text == "Apagar")
            {
                BtnApagar.Text = "Apagar";
                Close();
            }
            else
            {
                TiempoentreCambios.Stop();
                PbSemaforo.Image = Properties.Resources.semafo;
                BtnIniciar.Enabled = true;
                BtnDetener.Enabled = false;
                BtnApagar.Enabled = true;
                BtnApagar.Text = "Apagar";
                BtnDetener.Text = "Detener";
            }
        }

        private void NuDVelocidadSemaforo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblCuentadeTiempo_Click(object sender, EventArgs e)
        {
            LblCuentadeTiempo.Show(TiempoentreCambios);
        }

        private void LbTiemposdeCambio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
