namespace Programa
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
            label14 = new Label();
            btnVender = new Button();
            panel1 = new Panel();
            btnEliminar = new Button();
            btnAgregar = new Button();
            txtEfectivo = new TextBox();
            txtCantidad = new TextBox();
            cmbProducto = new ComboBox();
            lblDevolucion = new Label();
            label12 = new Label();
            label11 = new Label();
            lblTotatlPagar = new Label();
            label9 = new Label();
            label8 = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            lblPrecio = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvLista = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.IndianRed;
            label14.Location = new Point(47, 22);
            label14.Name = "label14";
            label14.Size = new Size(400, 30);
            label14.TabIndex = 5;
            label14.Text = "FACTURA TIENDA DON PEPE";
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(128, 255, 128);
            btnVender.Cursor = Cursors.Hand;
            btnVender.Location = new Point(170, 620);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(190, 60);
            btnVender.TabIndex = 4;
            btnVender.Text = "VENDER";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtEfectivo);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cmbProducto);
            panel1.Controls.Add(lblDevolucion);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblTotatlPagar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvLista);
            panel1.Location = new Point(15, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 534);
            panel1.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(333, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 55);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Location = new Point(333, 66);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 55);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(204, 460);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(88, 23);
            txtEfectivo.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(168, 172);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(88, 23);
            txtCantidad.TabIndex = 15;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Items.AddRange(new object[] { "Polo", "Gorra", "Camisa" });
            cmbProducto.Location = new Point(160, 33);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(165, 23);
            cmbProducto.TabIndex = 14;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.Location = new Point(377, 460);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(12, 15);
            lblDevolucion.TabIndex = 13;
            lblDevolucion.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(341, 426);
            label12.Name = "label12";
            label12.Size = new Size(91, 13);
            label12.TabIndex = 12;
            label12.Text = "DEVOLUCIÓN:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(210, 426);
            label11.Name = "label11";
            label11.Size = new Size(71, 13);
            label11.TabIndex = 11;
            label11.Text = "EFECTIVO:";
            // 
            // lblTotatlPagar
            // 
            lblTotatlPagar.AutoSize = true;
            lblTotatlPagar.Location = new Point(107, 460);
            lblTotatlPagar.Name = "lblTotatlPagar";
            lblTotatlPagar.Size = new Size(12, 15);
            lblTotatlPagar.TabIndex = 10;
            lblTotatlPagar.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(67, 426);
            label9.Name = "label9";
            label9.Size = new Size(109, 13);
            label9.TabIndex = 9;
            label9.Text = "TOTAL A PAGAR:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(67, 174);
            label8.Name = "label8";
            label8.Size = new Size(74, 13);
            label8.TabIndex = 8;
            label8.Text = "CANTIDAD:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(165, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(12, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "-";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(165, 71);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(12, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "-";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(165, 140);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(12, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 137);
            label4.Name = "label4";
            label4.Size = new Size(57, 13);
            label4.TabIndex = 4;
            label4.Text = "PRECIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 100);
            label3.Name = "label3";
            label3.Size = new Size(64, 13);
            label3.TabIndex = 3;
            label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 13);
            label2.TabIndex = 2;
            label2.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 13);
            label1.TabIndex = 1;
            label1.Text = "PRODUCTO:";
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.BackgroundColor = SystemColors.ControlLight;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvLista.Location = new Point(23, 219);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersVisible = false;
            dgvLista.RowHeadersWidth = 51;
            dgvLista.RowTemplate.Height = 24;
            dgvLista.Size = new Size(451, 174);
            dgvLista.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "CODIGO";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "PRODUCTO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "CANTIDAD";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "TOTAL";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 699);
            Controls.Add(label14);
            Controls.Add(btnVender);
            Controls.Add(panel1);
            Name = "Factura";
            Text = "Factura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Button btnVender;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox txtEfectivo;
        private TextBox txtCantidad;
        private ComboBox cmbProducto;
        private Label lblDevolucion;
        private Label label12;
        private Label label11;
        private Label lblTotatlPagar;
        private Label label9;
        private Label label8;
        private Label lblNombre;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvLista;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}