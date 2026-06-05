namespace DescuentoZapatillasApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtDescuentoManual = new System.Windows.Forms.Label();
            this.btnCalcularSinDescuento = new System.Windows.Forms.Button();
            this.txtDescManual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio de la zapatilla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de zapatilla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Talla:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Running",
            "Montain",
            "Urban"});
            this.cmbTipo.Location = new System.Drawing.Point(208, 54);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(208, 104);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(200, 328);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular Descuento";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(17, 264);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Esperando datos...";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(208, 160);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(121, 20);
            this.txtTalla.TabIndex = 7;
            this.txtTalla.TextChanged += new System.EventHandler(this.txtTalla_TextChanged);
            // 
            // txtDescuentoManual
            // 
            this.txtDescuentoManual.AutoSize = true;
            this.txtDescuentoManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoManual.Location = new System.Drawing.Point(17, 222);
            this.txtDescuentoManual.Name = "txtDescuentoManual";
            this.txtDescuentoManual.Size = new System.Drawing.Size(166, 16);
            this.txtDescuentoManual.TabIndex = 8;
            this.txtDescuentoManual.Text = "Descuento Manual (%):";
            // 
            // btnCalcularSinDescuento
            // 
            this.btnCalcularSinDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSinDescuento.Location = new System.Drawing.Point(12, 329);
            this.btnCalcularSinDescuento.Name = "btnCalcularSinDescuento";
            this.btnCalcularSinDescuento.Size = new System.Drawing.Size(155, 23);
            this.btnCalcularSinDescuento.TabIndex = 9;
            this.btnCalcularSinDescuento.Text = "Calcular sin Descuento";
            this.btnCalcularSinDescuento.UseVisualStyleBackColor = true;
            this.btnCalcularSinDescuento.Click += new System.EventHandler(this.btnCalcularSinDescuento_Click);
            // 
            // txtDescManual
            // 
            this.txtDescManual.Location = new System.Drawing.Point(208, 218);
            this.txtDescManual.Name = "txtDescManual";
            this.txtDescManual.Size = new System.Drawing.Size(121, 20);
            this.txtDescManual.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "SISTEMA DE CONTROL DE DESCUENTOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescManual);
            this.Controls.Add(this.btnCalcularSinDescuento);
            this.Controls.Add(this.txtDescuentoManual);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label txtDescuentoManual;
        private System.Windows.Forms.Button btnCalcularSinDescuento;
        private System.Windows.Forms.TextBox txtDescManual;
        private System.Windows.Forms.Label label4;
    }
}

