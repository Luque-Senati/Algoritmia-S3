namespace AR_actividad5
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
            menuStrip1 = new MenuStrip();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            climaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            fondoToolStripMenuItem = new ToolStripMenuItem();
            validadorDeCaracteresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleGreen;
            menuStrip1.Items.AddRange(new ToolStripItem[] { formatoToolStripMenuItem, acercaDeToolStripMenuItem, fondoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(702, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, facturaToolStripMenuItem });
            formatoToolStripMenuItem.ForeColor = SystemColors.ControlText;
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(64, 20);
            formatoToolStripMenuItem.Text = "Formato";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(137, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(137, 22);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { climaToolStripMenuItem, validadorDeCaracteresToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(83, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // climaToolStripMenuItem
            // 
            climaToolStripMenuItem.Name = "climaToolStripMenuItem";
            climaToolStripMenuItem.Size = new Size(105, 22);
            climaToolStripMenuItem.Text = "Clima";
            climaToolStripMenuItem.Click += climaToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(141, 99);
            label1.Name = "label1";
            label1.Size = new Size(395, 27);
            label1.TabIndex = 1;
            label1.Text = "Programación Orientada a Objetos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(141, 141);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 2;
            label2.Text = "Angui Rojas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(141, 185);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 3;
            label3.Text = "SENATI";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.ForestGreen;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            dateTimePicker1.Location = new Point(141, 258);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(141, 300);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 5;
            button1.Text = "Fecha";
            button1.UseVisualStyleBackColor = false;
            // 
            // fondoToolStripMenuItem
            // 
            fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
            fondoToolStripMenuItem.Size = new Size(53, 20);
            fondoToolStripMenuItem.Text = "Fondo";
            // 
            // validadorDeCaracteresToolStripMenuItem
            // 
            validadorDeCaracteresToolStripMenuItem.Name = "validadorDeCaracteresToolStripMenuItem";
            validadorDeCaracteresToolStripMenuItem.Size = new Size(197, 22);
            validadorDeCaracteresToolStripMenuItem.Text = "Validador de Caracteres";
            validadorDeCaracteresToolStripMenuItem.Click += validadorDeCaracteresToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(702, 450);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ToolStripMenuItem climaToolStripMenuItem;
        private ToolStripMenuItem validadorDeCaracteresToolStripMenuItem;
        private ToolStripMenuItem fondoToolStripMenuItem;
    }
}
