namespace AR_actividad3
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingreso de Datos: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(105, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 124);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "Pago por hora S/.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 82);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Horas trabajadas: ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Apellidos y nombres: ";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(43, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 175);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida de Datos: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(190, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(190, 85);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 27);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 130);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 2;
            label6.Text = "Salario Neto S/.";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 88);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 1;
            label5.Text = "Descuento S/.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 45);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 0;
            label4.Text = "Salario Bruto S/.";
            // 
            // button1
            // 
            button1.Location = new Point(520, 231);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(520, 295);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 3;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(520, 352);
            button3.Name = "button3";
            button3.Size = new Size(121, 45);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 422);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cálculo del salario neto (Angui Rojas)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
