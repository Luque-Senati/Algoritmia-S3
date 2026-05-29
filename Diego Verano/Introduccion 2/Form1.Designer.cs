namespace Introduccion_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txttallapolo = new System.Windows.Forms.TextBox();
            this.lbltalladepolo = new System.Windows.Forms.Label();
            this.txtinicial = new System.Windows.Forms.TextBox();
            this.lblinicial = new System.Windows.Forms.Label();
            this.txttallacamisa = new System.Windows.Forms.TextBox();
            this.lbltalladecamisa = new System.Windows.Forms.Label();
            this.txtonline = new System.Windows.Forms.TextBox();
            this.lblonline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(228, 45);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(142, 48);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txttallapolo
            // 
            this.txttallapolo.Location = new System.Drawing.Point(228, 126);
            this.txttallapolo.Name = "txttallapolo";
            this.txttallapolo.Size = new System.Drawing.Size(100, 20);
            this.txttallapolo.TabIndex = 1;
            // 
            // lbltalladepolo
            // 
            this.lbltalladepolo.AutoSize = true;
            this.lbltalladepolo.Location = new System.Drawing.Point(142, 129);
            this.lbltalladepolo.Name = "lbltalladepolo";
            this.lbltalladepolo.Size = new System.Drawing.Size(69, 13);
            this.lbltalladepolo.TabIndex = 2;
            this.lbltalladepolo.Text = "Talla de Polo";
            // 
            // txtinicial
            // 
            this.txtinicial.Location = new System.Drawing.Point(228, 87);
            this.txtinicial.Name = "txtinicial";
            this.txtinicial.Size = new System.Drawing.Size(100, 20);
            this.txtinicial.TabIndex = 1;
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Location = new System.Drawing.Point(142, 90);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(34, 13);
            this.lblinicial.TabIndex = 2;
            this.lblinicial.Text = "Inicial";
            // 
            // txttallacamisa
            // 
            this.txttallacamisa.Location = new System.Drawing.Point(228, 168);
            this.txttallacamisa.Name = "txttallacamisa";
            this.txttallacamisa.Size = new System.Drawing.Size(100, 20);
            this.txttallacamisa.TabIndex = 1;
            // 
            // lbltalladecamisa
            // 
            this.lbltalladecamisa.AutoSize = true;
            this.lbltalladecamisa.Location = new System.Drawing.Point(142, 171);
            this.lbltalladecamisa.Name = "lbltalladecamisa";
            this.lbltalladecamisa.Size = new System.Drawing.Size(82, 13);
            this.lbltalladecamisa.TabIndex = 2;
            this.lbltalladecamisa.Text = "Talla de Camisa";
            // 
            // txtonline
            // 
            this.txtonline.Location = new System.Drawing.Point(228, 207);
            this.txtonline.Name = "txtonline";
            this.txtonline.Size = new System.Drawing.Size(100, 20);
            this.txtonline.TabIndex = 1;
            // 
            // lblonline
            // 
            this.lblonline.AutoSize = true;
            this.lblonline.Location = new System.Drawing.Point(142, 210);
            this.lblonline.Name = "lblonline";
            this.lblonline.Size = new System.Drawing.Size(37, 13);
            this.lblonline.TabIndex = 2;
            this.lblonline.Text = "Online";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 477);
            this.Controls.Add(this.lblonline);
            this.Controls.Add(this.txtonline);
            this.Controls.Add(this.lbltalladecamisa);
            this.Controls.Add(this.txttallacamisa);
            this.Controls.Add(this.lblinicial);
            this.Controls.Add(this.txtinicial);
            this.Controls.Add(this.lbltalladepolo);
            this.Controls.Add(this.txttallapolo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txttallapolo;
        private System.Windows.Forms.Label lbltalladepolo;
        private System.Windows.Forms.TextBox txtinicial;
        private System.Windows.Forms.Label lblinicial;
        private System.Windows.Forms.TextBox txttallacamisa;
        private System.Windows.Forms.Label lbltalladecamisa;
        private System.Windows.Forms.TextBox txtonline;
        private System.Windows.Forms.Label lblonline;
    }
}

