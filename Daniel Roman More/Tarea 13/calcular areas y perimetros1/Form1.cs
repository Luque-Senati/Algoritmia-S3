namespace calcular_areas_y_perimetros1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboFigura.Items.Add("Cuadrado");
            cboFigura.Items.Add("Rectangulo");
            cboFigura.Items.Add("Triangulo");
            cboFigura.Items.Add("Circulo");
        }
        public abstract class Figura
        {
            public abstract double CalcularArea();
            public abstract double CalcularPerimetro();
        }
        public class Cuadrado : Figura
        {
            private double lado;

            public Cuadrado(double lado)
            {
                this.lado = lado;
            }

            public override double CalcularArea()
            {
                return lado * lado;
            }

            public override double CalcularPerimetro()
            {
                return lado * 4;
            }
        }
        public class Rectangulo : Figura
        {
            private double ancho;
            private double alto;

            public Rectangulo(double ancho, double alto)
            {
                this.ancho = ancho;
                this.alto = alto;
            }

            public override double CalcularArea()
            {
                return ancho * alto;
            }

            public override double CalcularPerimetro()
            {
                return 2 * (ancho + alto);
            }
        }
        public class Triangulo : Figura
        {
            private double lado1;
            private double lado2;
            private double lado3;
            private double altura;

            public Triangulo(double lado1,
                             double lado2,
                             double lado3,
                             double altura)
            {
                this.lado1 = lado1;
                this.lado2 = lado2;
                this.lado3 = lado3;
                this.altura = altura;
            }

            public override double CalcularArea()
            {
                return (lado1 * altura) / 2;
            }

            public override double CalcularPerimetro()
            {
                return lado1 + lado2 + lado3;
            }
        }
        public class Circulo : Figura
        {
            private double radio;

            public Circulo(double radio)
            {
                this.radio = radio;
            }

            public override double CalcularArea()
            {
                return Math.PI * radio * radio;
            }

            public override double CalcularPerimetro()
            {
                return 2 * Math.PI * radio;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Figura? figura = null;

            if (cboFigura.Text == "Cuadrado")
            {
                double lado = Convert.ToDouble(txtMedida1.Text);

                figura = new Cuadrado(lado);
            }

            else if (cboFigura.Text == "Rectangulo")
            {
                double ancho = Convert.ToDouble(txtMedida1.Text);
                double alto = Convert.ToDouble(txtMedida2.Text);

                figura = new Rectangulo(ancho, alto);
            }

            else if (cboFigura.Text == "Triangulo")
            {
                double lado1 = Convert.ToDouble(txtMedida1.Text);
                double lado2 = Convert.ToDouble(txtMedida2.Text);
                double lado3 = Convert.ToDouble(txtMedida3.Text);
                double altura = Convert.ToDouble(txtMedida2.Text);

                figura = new Triangulo(lado1, lado2, lado3, altura);
            }

            else if (cboFigura.Text == "Circulo")
            {
                double radio = Convert.ToDouble(txtMedida1.Text);

                figura = new Circulo(radio);
            }
            if (figura == null)
            {
                MessageBox.Show("Seleccione una figura válida.");
                return;
            }

            lblResultado.Text =
                "Área = " + figura.CalcularArea().ToString("0.00")
                + "\nPerímetro = " +
                figura.CalcularPerimetro().ToString("0.00");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMedida1.Clear();
            txtMedida2.Clear();
            txtMedida3.Clear();

            lblResultado.Text = "";

            cboFigura.SelectedIndex = -1;

            txtMedida1.Focus();
        }
    }
}
