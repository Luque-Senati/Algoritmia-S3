namespace DVMenu_Strip
{
    partial class SMultiples
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
            this.button1 = new System.Windows.Forms.Button();
            this.Txtcaracter = new System.Windows.Forms.TextBox();
            this.Lbldicta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un solo caracter:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtcaracter
            // 
            this.Txtcaracter.Location = new System.Drawing.Point(56, 58);
            this.Txtcaracter.Name = "Txtcaracter";
            this.Txtcaracter.Size = new System.Drawing.Size(150, 22);
            this.Txtcaracter.TabIndex = 2;
            // 
            // Lbldicta
            // 
            this.Lbldicta.AutoSize = true;
            this.Lbldicta.Location = new System.Drawing.Point(72, 132);
            this.Lbldicta.Name = "Lbldicta";
            this.Lbldicta.Size = new System.Drawing.Size(0, 16);
            this.Lbldicta.TabIndex = 3;
            // 
            // SMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 212);
            this.Controls.Add(this.Lbldicta);
            this.Controls.Add(this.Txtcaracter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SMultiples";
            this.Text = "SMultiples";
            this.Load += new System.EventHandler(this.SMultiples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txtcaracter;
        private System.Windows.Forms.Label Lbldicta;
    }
}