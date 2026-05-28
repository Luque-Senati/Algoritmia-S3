namespace Programa
{
    partial class calculadora
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtPantalla = new TextBox();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonSUM = new Button();
            buttonRES = new Button();
            buttonmMUL = new Button();
            buttonDIV = new Button();
            buttonIGU = new Button();
            buttonC = new Button();
            buttonCE = new Button();
            button_punto = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(33, 60);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(300, 39);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // button0
            // 
            button0.Location = new Point(33, 257);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 146);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 146);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(193, 146);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 186);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(113, 186);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(193, 186);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(33, 226);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(113, 226);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(193, 226);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.Click += button9_Click;
            // 
            // buttonSUM
            // 
            buttonSUM.Location = new Point(274, 146);
            buttonSUM.Name = "buttonSUM";
            buttonSUM.Size = new Size(75, 23);
            buttonSUM.TabIndex = 12;
            buttonSUM.Text = "+";
            buttonSUM.Click += buttonSUM_Click;
            // 
            // buttonRES
            // 
            buttonRES.Location = new Point(274, 186);
            buttonRES.Name = "buttonRES";
            buttonRES.Size = new Size(75, 23);
            buttonRES.TabIndex = 13;
            buttonRES.Text = "-";
            buttonRES.Click += buttonRES_Click;
            // 
            // buttonmMUL
            // 
            buttonmMUL.Location = new Point(274, 226);
            buttonmMUL.Name = "buttonmMUL";
            buttonmMUL.Size = new Size(75, 23);
            buttonmMUL.TabIndex = 14;
            buttonmMUL.Text = "*";
            buttonmMUL.Click += buttonmMUL_Click;
            // 
            // buttonDIV
            // 
            buttonDIV.Location = new Point(274, 117);
            buttonDIV.Name = "buttonDIV";
            buttonDIV.Size = new Size(75, 23);
            buttonDIV.TabIndex = 15;
            buttonDIV.Text = "/";
            buttonDIV.Click += buttonDIV_Click;
            // 
            // buttonIGU
            // 
            buttonIGU.Location = new Point(274, 255);
            buttonIGU.Name = "buttonIGU";
            buttonIGU.Size = new Size(75, 23);
            buttonIGU.TabIndex = 16;
            buttonIGU.Text = "=";
            buttonIGU.Click += buttonIGU_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(33, 117);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(75, 23);
            buttonC.TabIndex = 17;
            buttonC.Text = "C";
            buttonC.Click += buttonC_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(192, 117);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(75, 23);
            buttonCE.TabIndex = 18;
            buttonCE.Text = "CE";
            buttonCE.Click += buttonCE_Click;
            // 
            // button_punto
            // 
            button_punto.Location = new Point(192, 257);
            button_punto.Name = "button_punto";
            button_punto.Size = new Size(75, 23);
            button_punto.TabIndex = 19;
            button_punto.Text = ".";
            button_punto.Click += button_punto_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 1;
            label1.Text = "Calculadora";
            // 
            // calculadora
            // 
            ClientSize = new Size(371, 320);
            Controls.Add(txtPantalla);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button0);
            Controls.Add(buttonSUM);
            Controls.Add(buttonRES);
            Controls.Add(buttonmMUL);
            Controls.Add(buttonDIV);
            Controls.Add(buttonIGU);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(button_punto);
            Name = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button button0, button1, button2, button3, button4, button5, button6, button7, button8, button9;
        private Button buttonSUM, buttonRES, buttonmMUL, buttonDIV, buttonIGU;
        private Button buttonC, buttonCE, button_punto;
        private Label label1;
    }
}