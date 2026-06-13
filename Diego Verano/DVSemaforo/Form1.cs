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
        int tiempoRestante = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PbSemaforo.Image = Properties.Resources.semafo;
            BtnDetener.Enabled = false;

            TiempoentreCambios.Interval = 1000;

            NuDVelocidadSemaforo.Value = 5;

        }

        private void TiempoentreCambios_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            LblCuentadeTiempo.Text = tiempoRestante.ToString();

            if (tiempoRestante > 0) return;
            switch (luces)
            {
                case 0:
                    PbSemaforo.Image = Properties.Resources.semaamrillo;
                    tiempoRestante = Convert.ToInt32(NuDVelocidadSemaforo.Value);
                    luces = 1;
                    LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Luz Amarilla Encendida");
                    break;

                case 1: 
                    PbSemaforo.Image = Properties.Resources.semarojo;
                    tiempoRestante = Convert.ToInt32(NuDVelocidadSemaforo.Value);
                    luces = 2;
                    LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Luz Roja Encendida");
                    break;

                case 2: 
                    PbSemaforo.Image = Properties.Resources.semaverde;
                    tiempoRestante = Convert.ToInt32(NuDVelocidadSemaforo.Value);
                    luces = 0;
                    LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Luz Verde Encendida");
                    break;
            }

            LblCuentadeTiempo.Text = tiempoRestante.ToString();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (BtnIniciar.Text == "Iniciar")
            {
                tiempoRestante = Convert.ToInt32(NuDVelocidadSemaforo.Value);
                LblCuentadeTiempo.Text = tiempoRestante.ToString();

                TiempoentreCambios.Start();
                PbSemaforo.Image = Properties.Resources.semaverde;
                luces = 0;

                LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Simulación Iniciada en Verde");

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
                BtnDetener.Text = "Continuar";
                LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Simulación Pausada");
            }
            else if (BtnDetener.Text == "Continuar")
            {
                TiempoentreCambios.Enabled = true;
                BtnDetener.Text = "Detener";
                LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Simulación Reanudada");
            }
        }
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            if (BtnApagar.Text == "Apagar")
            {
                TiempoentreCambios.Stop();
                PbSemaforo.Image = Properties.Resources.semafo;
                LblCuentadeTiempo.Text = "0";
                LbTiemposdeCambio.Items.Add(DateTime.Now.ToString("HH:mm:ss") + " - Sistema Apagado");

                BtnIniciar.Enabled = true;
                BtnDetener.Enabled = false;
                BtnDetener.Text = "Detener";
            }
        }

        private void NuDVelocidadSemaforo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LblCuentadeTiempo_Click(object sender, EventArgs e)
        {
            
        }

        private void LbTiemposdeCambio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
