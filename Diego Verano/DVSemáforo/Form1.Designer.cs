namespace DVSemáforo
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
            this.components = new System.ComponentModel.Container();
            this.PBSemaforo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTiempoParaelCambio = new System.Windows.Forms.Label();
            this.NuDAjustedeSemaforo = new System.Windows.Forms.NumericUpDown();
            this.LBRegistro = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaforo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuDAjustedeSemaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // PBSemaforo
            // 
            this.PBSemaforo.Location = new System.Drawing.Point(12, 12);
            this.PBSemaforo.Name = "PBSemaforo";
            this.PBSemaforo.Size = new System.Drawing.Size(128, 259);
            this.PBSemaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBSemaforo.TabIndex = 0;
            this.PBSemaforo.TabStop = false;
            this.PBSemaforo.Click += new System.EventHandler(this.PBSemaforo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(32, 277);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(80, 30);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(118, 277);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(80, 30);
            this.BtnApagar.TabIndex = 1;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(205, 277);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(80, 30);
            this.BtnDetener.TabIndex = 1;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NuDAjustedeSemaforo);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste del tiempo";
            // 
            // LblTiempoParaelCambio
            // 
            this.LblTiempoParaelCambio.AutoSize = true;
            this.LblTiempoParaelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiempoParaelCambio.Location = new System.Drawing.Point(201, 89);
            this.LblTiempoParaelCambio.Name = "LblTiempoParaelCambio";
            this.LblTiempoParaelCambio.Size = new System.Drawing.Size(65, 20);
            this.LblTiempoParaelCambio.TabIndex = 3;
            this.LblTiempoParaelCambio.Text = "Cuenta:";
            // 
            // NuDAjustedeSemaforo
            // 
            this.NuDAjustedeSemaforo.Location = new System.Drawing.Point(19, 19);
            this.NuDAjustedeSemaforo.Name = "NuDAjustedeSemaforo";
            this.NuDAjustedeSemaforo.Size = new System.Drawing.Size(120, 20);
            this.NuDAjustedeSemaforo.TabIndex = 0;
            // 
            // LBRegistro
            // 
            this.LBRegistro.FormattingEnabled = true;
            this.LBRegistro.Location = new System.Drawing.Point(150, 137);
            this.LBRegistro.Name = "LBRegistro";
            this.LBRegistro.Size = new System.Drawing.Size(165, 134);
            this.LBRegistro.TabIndex = 4;
            this.LBRegistro.SelectedIndexChanged += new System.EventHandler(this.LBRegistro_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 354);
            this.Controls.Add(this.LBRegistro);
            this.Controls.Add(this.LblTiempoParaelCambio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.PBSemaforo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaforo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NuDAjustedeSemaforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBSemaforo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NuDAjustedeSemaforo;
        private System.Windows.Forms.Label LblTiempoParaelCambio;
        private System.Windows.Forms.ListBox LBRegistro;
    }
}

