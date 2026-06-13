namespace DVSemaforo
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
            this.TiempoentreCambios = new System.Windows.Forms.Timer(this.components);
            this.PbSemaforo = new System.Windows.Forms.PictureBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.GbdelNumeralUpandDown = new System.Windows.Forms.GroupBox();
            this.NuDVelocidadSemaforo = new System.Windows.Forms.NumericUpDown();
            this.LblCuentadeTiempo = new System.Windows.Forms.Label();
            this.LbTiemposdeCambio = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSemaforo)).BeginInit();
            this.GbdelNumeralUpandDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NuDVelocidadSemaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // TiempoentreCambios
            // 
            this.TiempoentreCambios.Tick += new System.EventHandler(this.TiempoentreCambios_Tick);
            // 
            // PbSemaforo
            // 
            this.PbSemaforo.Image = global::DVSemaforo.Properties.Resources.semafo;
            this.PbSemaforo.Location = new System.Drawing.Point(16, 15);
            this.PbSemaforo.Margin = new System.Windows.Forms.Padding(4);
            this.PbSemaforo.Name = "PbSemaforo";
            this.PbSemaforo.Size = new System.Drawing.Size(191, 290);
            this.PbSemaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbSemaforo.TabIndex = 0;
            this.PbSemaforo.TabStop = false;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(33, 340);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(121, 46);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(163, 340);
            this.BtnDetener.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(121, 46);
            this.BtnDetener.TabIndex = 1;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.Location = new System.Drawing.Point(292, 340);
            this.BtnApagar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(121, 46);
            this.BtnApagar.TabIndex = 1;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // GbdelNumeralUpandDown
            // 
            this.GbdelNumeralUpandDown.Controls.Add(this.NuDVelocidadSemaforo);
            this.GbdelNumeralUpandDown.Location = new System.Drawing.Point(215, 20);
            this.GbdelNumeralUpandDown.Margin = new System.Windows.Forms.Padding(4);
            this.GbdelNumeralUpandDown.Name = "GbdelNumeralUpandDown";
            this.GbdelNumeralUpandDown.Padding = new System.Windows.Forms.Padding(4);
            this.GbdelNumeralUpandDown.Size = new System.Drawing.Size(208, 66);
            this.GbdelNumeralUpandDown.TabIndex = 2;
            this.GbdelNumeralUpandDown.TabStop = false;
            this.GbdelNumeralUpandDown.Text = "Ajuste del Tiempo";
            // 
            // NuDVelocidadSemaforo
            // 
            this.NuDVelocidadSemaforo.Location = new System.Drawing.Point(19, 23);
            this.NuDVelocidadSemaforo.Margin = new System.Windows.Forms.Padding(4);
            this.NuDVelocidadSemaforo.Name = "NuDVelocidadSemaforo";
            this.NuDVelocidadSemaforo.Size = new System.Drawing.Size(177, 22);
            this.NuDVelocidadSemaforo.TabIndex = 0;
            this.NuDVelocidadSemaforo.ValueChanged += new System.EventHandler(this.NuDVelocidadSemaforo_ValueChanged);
            // 
            // LblCuentadeTiempo
            // 
            this.LblCuentadeTiempo.AutoSize = true;
            this.LblCuentadeTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCuentadeTiempo.Location = new System.Drawing.Point(302, 90);
            this.LblCuentadeTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCuentadeTiempo.Name = "LblCuentadeTiempo";
            this.LblCuentadeTiempo.Size = new System.Drawing.Size(23, 31);
            this.LblCuentadeTiempo.TabIndex = 3;
            this.LblCuentadeTiempo.Text = "-";
            this.LblCuentadeTiempo.Click += new System.EventHandler(this.LblCuentadeTiempo_Click);
            // 
            // LbTiemposdeCambio
            // 
            this.LbTiemposdeCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbTiemposdeCambio.FormattingEnabled = true;
            this.LbTiemposdeCambio.HorizontalExtent = 300;
            this.LbTiemposdeCambio.HorizontalScrollbar = true;
            this.LbTiemposdeCambio.ItemHeight = 16;
            this.LbTiemposdeCambio.Location = new System.Drawing.Point(225, 125);
            this.LbTiemposdeCambio.Margin = new System.Windows.Forms.Padding(4);
            this.LbTiemposdeCambio.MultiColumn = true;
            this.LbTiemposdeCambio.Name = "LbTiemposdeCambio";
            this.LbTiemposdeCambio.Size = new System.Drawing.Size(203, 178);
            this.LbTiemposdeCambio.TabIndex = 4;
            this.LbTiemposdeCambio.SelectedIndexChanged += new System.EventHandler(this.LbTiemposdeCambio_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 416);
            this.Controls.Add(this.LbTiemposdeCambio);
            this.Controls.Add(this.LblCuentadeTiempo);
            this.Controls.Add(this.GbdelNumeralUpandDown);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.PbSemaforo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSemaforo)).EndInit();
            this.GbdelNumeralUpandDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NuDVelocidadSemaforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TiempoentreCambios;
        private System.Windows.Forms.PictureBox PbSemaforo;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.GroupBox GbdelNumeralUpandDown;
        private System.Windows.Forms.NumericUpDown NuDVelocidadSemaforo;
        private System.Windows.Forms.Label LblCuentadeTiempo;
        private System.Windows.Forms.ListBox LbTiemposdeCambio;
    }
}

