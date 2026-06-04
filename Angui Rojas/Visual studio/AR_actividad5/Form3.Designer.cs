namespace AR_actividad5
{
    partial class Form3
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
            panel1 = new Panel();
            button1 = new Button();
            txtEfectivo = new TextBox();
            lblDevolucion = new Label();
            lblTotalPagar = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtEfectivo);
            panel1.Controls.Add(lblDevolucion);
            panel1.Controls.Add(lblTotalPagar);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(cmbProducto);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel1.Location = new Point(23, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 432);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(360, 112);
            button1.Name = "button1";
            button1.Size = new Size(93, 46);
            button1.TabIndex = 19;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEfectivo
            // 
            txtEfectivo.BorderStyle = BorderStyle.FixedSingle;
            txtEfectivo.Cursor = Cursors.IBeam;
            txtEfectivo.Location = new Point(212, 368);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(100, 23);
            txtEfectivo.TabIndex = 18;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // lblDevolucion
            // 
            lblDevolucion.AutoSize = true;
            lblDevolucion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDevolucion.Location = new Point(385, 364);
            lblDevolucion.Name = "lblDevolucion";
            lblDevolucion.Size = new Size(19, 25);
            lblDevolucion.TabIndex = 17;
            lblDevolucion.Text = "-";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalPagar.Location = new Point(57, 364);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(19, 25);
            lblTotalPagar.TabIndex = 16;
            lblTotalPagar.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 339);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 15;
            label9.Text = "DEVOLUCIÓN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(233, 339);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 14;
            label8.Text = "EFECTIVO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(55, 340);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 13;
            label7.Text = "TOTAL A PAGAR:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(360, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(93, 46);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = Color.Green;
            dataGridView1.Location = new Point(20, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(453, 134);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "CÓDIGO";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "PRODUCTO";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "PRECIO";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "CANTIDAD";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "TOTAL";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Items.AddRange(new object[] { "Champú", "Papel Higiénico", "Galleta", "Gaseosa", "Fideo", "Detergente" });
            cmbProducto.Location = new Point(151, 31);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 9;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(151, 149);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(151, 123);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(12, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "-";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(151, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(12, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "-";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(151, 60);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(12, 15);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(57, 152);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "CANTIDAD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(57, 123);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 3;
            label5.Text = "PRECIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(57, 91);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 2;
            label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(57, 60);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "CÓDIGO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(57, 34);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "PRODUCTO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(332, 28);
            label1.TabIndex = 1;
            label1.Text = "FACTURA TIENDA \"DON MIGUEL\"";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(219, 488);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 2;
            button3.Text = "VENDER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(534, 564);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblCodigo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private Label lblPrecio;
        private Label lblNombre;
        private TextBox txtEfectivo;
        private Label lblDevolucion;
        private Label lblTotalPagar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnVender;
        private Button button1;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}