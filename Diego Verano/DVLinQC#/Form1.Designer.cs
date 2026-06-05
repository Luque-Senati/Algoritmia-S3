namespace DVLinQC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lstResultado = new ListBox();
            BtnPostres = new Button();
            LstPostres = new ListBox();
            IResultado = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 55);
            button1.Name = "button1";
            button1.Size = new Size(151, 105);
            button1.TabIndex = 0;
            button1.Text = "Numeros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(256, 51);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(138, 109);
            lstResultado.TabIndex = 1;
            // 
            // BtnPostres
            // 
            BtnPostres.Location = new Point(39, 244);
            BtnPostres.Name = "BtnPostres";
            BtnPostres.Size = new Size(151, 105);
            BtnPostres.TabIndex = 2;
            BtnPostres.Text = "Postres\r\n¡AQUI!";
            BtnPostres.UseVisualStyleBackColor = true;
            BtnPostres.Click += BtnPostres_Click;
            // 
            // LstPostres
            // 
            LstPostres.FormattingEnabled = true;
            LstPostres.Location = new Point(256, 240);
            LstPostres.Name = "LstPostres";
            LstPostres.Size = new Size(138, 109);
            LstPostres.TabIndex = 3;
            // 
            // IResultado
            // 
            IResultado.FormattingEnabled = true;
            IResultado.Location = new Point(431, 51);
            IResultado.Name = "IResultado";
            IResultado.Size = new Size(138, 109);
            IResultado.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
            Controls.Add(LstPostres);
            Controls.Add(BtnPostres);
            Controls.Add(IResultado);
            Controls.Add(lstResultado);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lstResultado;
        private Button BtnPostres;
        private ListBox LstPostres;
        private ListBox IResultado;
    }
}
