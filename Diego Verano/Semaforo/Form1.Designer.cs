namespace Semaforo
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
            this.PBSemaAbajo = new System.Windows.Forms.PictureBox();
            this.PCSemaMedio = new System.Windows.Forms.PictureBox();
            this.PBSemaArriba = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCSemaMedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PBSemaAbajo
            // 
            this.PBSemaAbajo.Image = global::Semaforo.Properties.Resources.semaofb;
            this.PBSemaAbajo.Location = new System.Drawing.Point(125, 153);
            this.PBSemaAbajo.Margin = new System.Windows.Forms.Padding(0);
            this.PBSemaAbajo.Name = "PBSemaAbajo";
            this.PBSemaAbajo.Size = new System.Drawing.Size(87, 102);
            this.PBSemaAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSemaAbajo.TabIndex = 0;
            this.PBSemaAbajo.TabStop = false;
            // 
            // PCSemaMedio
            // 
            this.PCSemaMedio.Image = global::Semaforo.Properties.Resources.semaof;
            this.PCSemaMedio.Location = new System.Drawing.Point(125, 105);
            this.PCSemaMedio.Margin = new System.Windows.Forms.Padding(0);
            this.PCSemaMedio.Name = "PCSemaMedio";
            this.PCSemaMedio.Size = new System.Drawing.Size(87, 53);
            this.PCSemaMedio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCSemaMedio.TabIndex = 0;
            this.PCSemaMedio.TabStop = false;
            // 
            // PBSemaArriba
            // 
            this.PBSemaArriba.Image = global::Semaforo.Properties.Resources.semaof;
            this.PBSemaArriba.Location = new System.Drawing.Point(125, 52);
            this.PBSemaArriba.Margin = new System.Windows.Forms.Padding(0);
            this.PBSemaArriba.Name = "PBSemaArriba";
            this.PBSemaArriba.Size = new System.Drawing.Size(87, 53);
            this.PBSemaArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSemaArriba.TabIndex = 0;
            this.PBSemaArriba.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBSemaAbajo);
            this.Controls.Add(this.PCSemaMedio);
            this.Controls.Add(this.PBSemaArriba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCSemaMedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSemaArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBSemaArriba;
        private System.Windows.Forms.PictureBox PCSemaMedio;
        private System.Windows.Forms.PictureBox PBSemaAbajo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

