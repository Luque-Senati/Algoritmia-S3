namespace Tarea_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            TxtApellidosNombres = new Label();
            TxtHorasTrabajadas = new Label();
            TxtPagoPorHora = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            TxtSalarioNeto = new Label();
            TxtDescuento = new Label();
            TxtSalarioBruto = new Label();
            Aceptar = new Button();
            Limpiar = new Button();
            Salir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(TxtApellidosNombres);
            groupBox1.Controls.Add(TxtHorasTrabajadas);
            groupBox1.Controls.Add(TxtPagoPorHora);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de datos:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "10.00";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "48";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Castillo Peralta, Carlos";
            // 
            // TxtApellidosNombres
            // 
            TxtApellidosNombres.AutoSize = true;
            TxtApellidosNombres.Location = new Point(45, 36);
            TxtApellidosNombres.Name = "TxtApellidosNombres";
            TxtApellidosNombres.Size = new Size(118, 15);
            TxtApellidosNombres.TabIndex = 0;
            TxtApellidosNombres.Text = "Apellidos y nombres:";
            TxtApellidosNombres.Click += label1_Click;
            // 
            // TxtHorasTrabajadas
            // 
            TxtHorasTrabajadas.AutoSize = true;
            TxtHorasTrabajadas.Location = new Point(45, 72);
            TxtHorasTrabajadas.Name = "TxtHorasTrabajadas";
            TxtHorasTrabajadas.Size = new Size(98, 15);
            TxtHorasTrabajadas.TabIndex = 1;
            TxtHorasTrabajadas.Text = "Horas trabajadas:";
            TxtHorasTrabajadas.Click += label2_Click;
            // 
            // TxtPagoPorHora
            // 
            TxtPagoPorHora.AutoSize = true;
            TxtPagoPorHora.Location = new Point(45, 106);
            TxtPagoPorHora.Name = "TxtPagoPorHora";
            TxtPagoPorHora.Size = new Size(99, 15);
            TxtPagoPorHora.TabIndex = 2;
            TxtPagoPorHora.Text = "Pago por hora S/.";
            TxtPagoPorHora.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(TxtSalarioNeto);
            groupBox2.Controls.Add(TxtDescuento);
            groupBox2.Controls.Add(TxtSalarioBruto);
            groupBox2.Location = new Point(12, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 144);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida de datos:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(262, 28);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "480.00";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 65);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            textBox5.Text = "96.00";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(262, 113);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 7;
            textBox6.Text = "384.00";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // TxtSalarioNeto
            // 
            TxtSalarioNeto.AutoSize = true;
            TxtSalarioNeto.Location = new Point(45, 113);
            TxtSalarioNeto.Name = "TxtSalarioNeto";
            TxtSalarioNeto.Size = new Size(86, 15);
            TxtSalarioNeto.TabIndex = 5;
            TxtSalarioNeto.Text = "Salario neto S/.";
            // 
            // TxtDescuento
            // 
            TxtDescuento.AutoSize = true;
            TxtDescuento.Location = new Point(45, 73);
            TxtDescuento.Name = "TxtDescuento";
            TxtDescuento.Size = new Size(80, 15);
            TxtDescuento.TabIndex = 4;
            TxtDescuento.Text = "Descuento S/.";
            TxtDescuento.Click += label5_Click;
            // 
            // TxtSalarioBruto
            // 
            TxtSalarioBruto.AutoSize = true;
            TxtSalarioBruto.Location = new Point(45, 36);
            TxtSalarioBruto.Name = "TxtSalarioBruto";
            TxtSalarioBruto.Size = new Size(91, 15);
            TxtSalarioBruto.TabIndex = 3;
            TxtSalarioBruto.Text = "Salario bruto S/.";
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(470, 214);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 2;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += CmdAceptar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(470, 256);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 3;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += CmdLimpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(470, 299);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 4;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += CmdSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 340);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Aceptar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label TxtApellidosNombres;
        private Label TxtSalarioNeto;
        private Label TxtDescuento;
        private Label TxtSalarioBruto;
        private Label TxtPagoPorHora;
        private Label TxtHorasTrabajadas;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button Aceptar;
        private Button Limpiar;
        private Button Salir;
    }
}
