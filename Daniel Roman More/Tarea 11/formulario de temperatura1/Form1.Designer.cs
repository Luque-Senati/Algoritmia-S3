namespace formulario_de_temperatura1
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
            btnSalir = new Button();
            label1 = new Label();
            btnNuevo = new Button();
            txtTemperatura = new TextBox();
            btnCalcular = new Button();
            groupBox2 = new GroupBox();
            txtClima = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(txtTemperatura);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Location = new Point(33, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(661, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Temperatura";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(510, 134);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(510, 91);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(49, 91);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(100, 23);
            txtTemperatura.TabIndex = 2;
            txtTemperatura.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(510, 48);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtClima);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(33, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(661, 123);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // txtClima
            // 
            txtClima.Location = new Point(49, 71);
            txtClima.Name = "txtClima";
            txtClima.Size = new Size(100, 23);
            txtClima.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 53);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de clima:";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
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
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtClima;
        private TextBox txtTemperatura;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnCalcular;
    }
}
