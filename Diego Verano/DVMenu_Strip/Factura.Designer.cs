namespace DVMenu_Strip
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.Lblnombre = new System.Windows.Forms.Label();
            this.Lblcodigo = new System.Windows.Forms.Label();
            this.Lblprecio = new System.Windows.Forms.Label();
            this.Cbproducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lblpagar = new System.Windows.Forms.Label();
            this.Lbldevolucion = new System.Windows.Forms.Label();
            this.Txtefectivo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tienda Don Jackson";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txtefectivo);
            this.panel1.Controls.Add(this.Lbldevolucion);
            this.panel1.Controls.Add(this.Lblpagar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Cbproducto);
            this.panel1.Controls.Add(this.Lblprecio);
            this.panel1.Controls.Add(this.Lblcodigo);
            this.panel1.Controls.Add(this.Lblnombre);
            this.panel1.Controls.Add(this.Txtcantidad);
            this.panel1.Controls.Add(this.Btneliminar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DgvTabla);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 502);
            this.panel1.TabIndex = 1;
            // 
            // DgvTabla
            // 
            this.DgvTabla.AllowUserToAddRows = false;
            this.DgvTabla.AllowUserToDeleteRows = false;
            this.DgvTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvTabla.Location = new System.Drawing.Point(16, 219);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.ReadOnly = true;
            this.DgvTabla.RowHeadersVisible = false;
            this.DgvTabla.RowHeadersWidth = 51;
            this.DgvTabla.RowTemplate.Height = 24;
            this.DgvTabla.Size = new System.Drawing.Size(426, 170);
            this.DgvTabla.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(325, 105);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(117, 44);
            this.Btneliminar.TabIndex = 2;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.Location = new System.Drawing.Point(157, 174);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(116, 22);
            this.Txtcantidad.TabIndex = 3;
            // 
            // Lblnombre
            // 
            this.Lblnombre.AutoSize = true;
            this.Lblnombre.Location = new System.Drawing.Point(168, 105);
            this.Lblnombre.Name = "Lblnombre";
            this.Lblnombre.Size = new System.Drawing.Size(11, 16);
            this.Lblnombre.TabIndex = 4;
            this.Lblnombre.Text = "-";
            // 
            // Lblcodigo
            // 
            this.Lblcodigo.AutoSize = true;
            this.Lblcodigo.Location = new System.Drawing.Point(168, 74);
            this.Lblcodigo.Name = "Lblcodigo";
            this.Lblcodigo.Size = new System.Drawing.Size(11, 16);
            this.Lblcodigo.TabIndex = 4;
            this.Lblcodigo.Text = "-";
            // 
            // Lblprecio
            // 
            this.Lblprecio.AutoSize = true;
            this.Lblprecio.Location = new System.Drawing.Point(168, 133);
            this.Lblprecio.Name = "Lblprecio";
            this.Lblprecio.Size = new System.Drawing.Size(11, 16);
            this.Lblprecio.TabIndex = 4;
            this.Lblprecio.Text = "-";
            // 
            // Cbproducto
            // 
            this.Cbproducto.FormattingEnabled = true;
            this.Cbproducto.Items.AddRange(new object[] {
            "Camisa",
            "Manzana",
            "Fideos",
            "Harina",
            "Arroz",
            "Zapato"});
            this.Cbproducto.Location = new System.Drawing.Point(147, 39);
            this.Cbproducto.Name = "Cbproducto";
            this.Cbproducto.Size = new System.Drawing.Size(172, 24);
            this.Cbproducto.TabIndex = 5;
            this.Cbproducto.SelectedIndexChanged += new System.EventHandler(this.Cbproducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Efectivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Devolución";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total a Pagar";
            // 
            // Lblpagar
            // 
            this.Lblpagar.AutoSize = true;
            this.Lblpagar.Location = new System.Drawing.Point(95, 454);
            this.Lblpagar.Name = "Lblpagar";
            this.Lblpagar.Size = new System.Drawing.Size(11, 16);
            this.Lblpagar.TabIndex = 7;
            this.Lblpagar.Text = "-";
            this.Lblpagar.Click += new System.EventHandler(this.Lblpagar_Click);
            // 
            // Lbldevolucion
            // 
            this.Lbldevolucion.AutoSize = true;
            this.Lbldevolucion.Location = new System.Drawing.Point(351, 456);
            this.Lbldevolucion.Name = "Lbldevolucion";
            this.Lbldevolucion.Size = new System.Drawing.Size(11, 16);
            this.Lbldevolucion.TabIndex = 7;
            this.Lbldevolucion.Text = "-";
            // 
            // Txtefectivo
            // 
            this.Txtefectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtefectivo.Location = new System.Drawing.Point(180, 454);
            this.Txtefectivo.Name = "Txtefectivo";
            this.Txtefectivo.Size = new System.Drawing.Size(103, 22);
            this.Txtefectivo.TabIndex = 8;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Factura";
            this.Text = "Tienda Don Jackson";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtefectivo;
        private System.Windows.Forms.Label Lbldevolucion;
        private System.Windows.Forms.Label Lblpagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cbproducto;
        private System.Windows.Forms.Label Lblprecio;
        private System.Windows.Forms.Label Lblcodigo;
        private System.Windows.Forms.Label Lblnombre;
        private System.Windows.Forms.TextBox Txtcantidad;
    }
}