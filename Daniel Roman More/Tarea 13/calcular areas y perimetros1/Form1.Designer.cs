namespace calcular_areas_y_perimetros1
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
            cboFigura = new ComboBox();
            lblFigura = new Label();
            lblMedida1 = new Label();
            lblMedida2 = new Label();
            lblMedida3 = new Label();
            lblResultado = new Label();
            txtMedida1 = new TextBox();
            txtMedida2 = new TextBox();
            txtMedida3 = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // cboFigura
            // 
            cboFigura.FormattingEnabled = true;
            cboFigura.Items.AddRange(new object[] { "Cuadrado", "", "Rectangulo", "", "Triangulo", "", "Circulo" });
            cboFigura.Location = new Point(181, 74);
            cboFigura.Name = "cboFigura";
            cboFigura.Size = new Size(121, 23);
            cboFigura.TabIndex = 0;
            // 
            // lblFigura
            // 
            lblFigura.AutoSize = true;
            lblFigura.Location = new Point(181, 56);
            lblFigura.Name = "lblFigura";
            lblFigura.Size = new Size(120, 15);
            lblFigura.TabIndex = 1;
            lblFigura.Text = "Seleccione una figura";
            lblFigura.Click += label1_Click;
            // 
            // lblMedida1
            // 
            lblMedida1.AutoSize = true;
            lblMedida1.Location = new Point(617, 56);
            lblMedida1.Name = "lblMedida1";
            lblMedida1.Size = new Size(56, 15);
            lblMedida1.TabIndex = 2;
            lblMedida1.Text = "Medida 1";
            // 
            // lblMedida2
            // 
            lblMedida2.AutoSize = true;
            lblMedida2.Location = new Point(617, 134);
            lblMedida2.Name = "lblMedida2";
            lblMedida2.Size = new Size(56, 15);
            lblMedida2.TabIndex = 3;
            lblMedida2.Text = "Medida 2";
            // 
            // lblMedida3
            // 
            lblMedida3.AutoSize = true;
            lblMedida3.Location = new Point(617, 219);
            lblMedida3.Name = "lblMedida3";
            lblMedida3.Size = new Size(56, 15);
            lblMedida3.TabIndex = 4;
            lblMedida3.Text = "Medida 3";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(181, 192);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // txtMedida1
            // 
            txtMedida1.Location = new Point(599, 74);
            txtMedida1.Name = "txtMedida1";
            txtMedida1.Size = new Size(100, 23);
            txtMedida1.TabIndex = 6;
            // 
            // txtMedida2
            // 
            txtMedida2.Location = new Point(599, 152);
            txtMedida2.Name = "txtMedida2";
            txtMedida2.Size = new Size(100, 23);
            txtMedida2.TabIndex = 7;
            // 
            // txtMedida3
            // 
            txtMedida3.Location = new Point(599, 237);
            txtMedida3.Name = "txtMedida3";
            txtMedida3.Size = new Size(100, 23);
            txtMedida3.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(181, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(262, 126);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtMedida3);
            Controls.Add(txtMedida2);
            Controls.Add(txtMedida1);
            Controls.Add(lblResultado);
            Controls.Add(lblMedida3);
            Controls.Add(lblMedida2);
            Controls.Add(lblMedida1);
            Controls.Add(lblFigura);
            Controls.Add(cboFigura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFigura;
        private Label lblFigura;
        private Label lblMedida1;
        private Label lblMedida2;
        private Label lblMedida3;
        private Label lblResultado;
        private TextBox txtMedida1;
        private TextBox txtMedida2;
        private TextBox txtMedida3;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
