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
            this.btnprueba = new System.Windows.Forms.Button();
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
            this.btncalculo = new System.Windows.Forms.Button();
            this.btnmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprueba
            // 
            this.btnprueba.Location = new System.Drawing.Point(209, 463);
            this.btnprueba.Margin = new System.Windows.Forms.Padding(4);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(204, 95);
            this.btnprueba.TabIndex = 0;
            this.btnprueba.Text = "Prueba";
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(304, 55);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(189, 59);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 16);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txttallapolo
            // 
            this.txttallapolo.Location = new System.Drawing.Point(304, 155);
            this.txttallapolo.Margin = new System.Windows.Forms.Padding(4);
            this.txttallapolo.Name = "txttallapolo";
            this.txttallapolo.Size = new System.Drawing.Size(132, 22);
            this.txttallapolo.TabIndex = 1;
            // 
            // lbltalladepolo
            // 
            this.lbltalladepolo.AutoSize = true;
            this.lbltalladepolo.Location = new System.Drawing.Point(189, 159);
            this.lbltalladepolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltalladepolo.Name = "lbltalladepolo";
            this.lbltalladepolo.Size = new System.Drawing.Size(88, 16);
            this.lbltalladepolo.TabIndex = 2;
            this.lbltalladepolo.Text = "Talla de Polo";
            // 
            // txtinicial
            // 
            this.txtinicial.Location = new System.Drawing.Point(304, 107);
            this.txtinicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtinicial.Name = "txtinicial";
            this.txtinicial.Size = new System.Drawing.Size(132, 22);
            this.txtinicial.TabIndex = 1;
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Location = new System.Drawing.Point(189, 111);
            this.lblinicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(41, 16);
            this.lblinicial.TabIndex = 2;
            this.lblinicial.Text = "Inicial";
            // 
            // txttallacamisa
            // 
            this.txttallacamisa.Location = new System.Drawing.Point(304, 207);
            this.txttallacamisa.Margin = new System.Windows.Forms.Padding(4);
            this.txttallacamisa.Name = "txttallacamisa";
            this.txttallacamisa.Size = new System.Drawing.Size(132, 22);
            this.txttallacamisa.TabIndex = 1;
            // 
            // lbltalladecamisa
            // 
            this.lbltalladecamisa.AutoSize = true;
            this.lbltalladecamisa.Location = new System.Drawing.Point(189, 210);
            this.lbltalladecamisa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltalladecamisa.Name = "lbltalladecamisa";
            this.lbltalladecamisa.Size = new System.Drawing.Size(106, 16);
            this.lbltalladecamisa.TabIndex = 2;
            this.lbltalladecamisa.Text = "Talla de Camisa";
            // 
            // txtonline
            // 
            this.txtonline.Location = new System.Drawing.Point(304, 255);
            this.txtonline.Margin = new System.Windows.Forms.Padding(4);
            this.txtonline.Name = "txtonline";
            this.txtonline.Size = new System.Drawing.Size(132, 22);
            this.txtonline.TabIndex = 1;
            // 
            // lblonline
            // 
            this.lblonline.AutoSize = true;
            this.lblonline.Location = new System.Drawing.Point(189, 258);
            this.lblonline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblonline.Name = "lblonline";
            this.lblonline.Size = new System.Drawing.Size(45, 16);
            this.lblonline.TabIndex = 2;
            this.lblonline.Text = "Online";
            // 
            // btncalculo
            // 
            this.btncalculo.Location = new System.Drawing.Point(47, 345);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(197, 86);
            this.btncalculo.TabIndex = 3;
            this.btncalculo.Text = "Calculos";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click_1);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(323, 341);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(225, 89);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 587);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.btncalculo);
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
            this.Controls.Add(this.btnprueba);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprueba;
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
        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.Button btnmenu;
    }
}

