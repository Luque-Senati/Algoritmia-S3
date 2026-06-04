namespace Consulta_de_datos_con_LINQ
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
            btnPostres = new Button();
            lstResultados = new ListBox();
            label1 = new Label();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            SuspendLayout();
            // 
            // btnPostres
            // 
            btnPostres.Location = new Point(52, 60);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(75, 23);
            btnPostres.TabIndex = 0;
            btnPostres.Text = "Postres";
            btnPostres.UseVisualStyleBackColor = true;
            btnPostres.Click += btnPostres_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(52, 118);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(366, 289);
            lstResultados.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(151, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 2;
            label1.Text = "Listado de postres";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(201, 64);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(252, 61);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(label1);
            Controls.Add(lstResultados);
            Controls.Add(btnPostres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPostres;
        private ListBox lstResultados;
        private Label label1;
        private Label lblBuscar;
        private TextBox txtBuscar;
    }
}
