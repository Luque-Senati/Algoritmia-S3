namespace Calculo_de_descuento_en_tienda_de_zapatillas
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
            cboTipo = new ComboBox();
            lblPrecio = new Label();
            lblTipo = new Label();
            lblTalla = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            txtPrecio = new TextBox();
            txtTalla = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Running", "Montain", "Urban" });
            cboTipo.Location = new Point(90, 67);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(126, 23);
            cboTipo.TabIndex = 0;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(90, 136);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(114, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio de la zapatilla";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(106, 49);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(93, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de zapatilla";
            // 
            // lblTalla
            // 
            lblTalla.AutoSize = true;
            lblTalla.Location = new Point(134, 212);
            lblTalla.Name = "lblTalla";
            lblTalla.Size = new Size(31, 15);
            lblTalla.TabIndex = 3;
            lblTalla.Text = "Talla";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(337, 233);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(475, 233);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a pagar:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(90, 154);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(126, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(90, 230);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(126, 23);
            txtTalla.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(337, 153);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtTalla);
            Controls.Add(txtPrecio);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblTalla);
            Controls.Add(lblTipo);
            Controls.Add(lblPrecio);
            Controls.Add(cboTipo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipo;
        private Label lblPrecio;
        private Label lblTipo;
        private Label lblTalla;
        private Label lblDescuento;
        private Label lblTotal;
        private TextBox txtPrecio;
        private TextBox txtTalla;
        private Button btnCalcular;
    }
}
