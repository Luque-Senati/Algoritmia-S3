using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVSemáforo
{
    public partial class Form1 : Form
    {
        private enum EstadoSemaforo
        {
            Verde,
            Amarillo,
            Rojo
        }

        private EstadoSemaforo EstadoActual;
        private EstadoSemaforo EstadoAnterior;
        private int TiempoRestante;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentesEspeciales();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarEstado(EstadoSemaforo.Rojo);
            timer1.Interval = 1000; 
            timer1.Start();
        }

        private void PBSemaforo_Click(object sender, EventArgs e)
        {

        }

        private void LBRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {

        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {

        }
    }
}
