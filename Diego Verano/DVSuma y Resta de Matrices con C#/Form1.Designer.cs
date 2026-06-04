namespace Suma_y_Resta_de_Matrices_con_C_
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtndospor = new System.Windows.Forms.RadioButton();
            this.rbtntrespor = new System.Windows.Forms.RadioButton();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVdatouno = new System.Windows.Forms.DataGridView();
            this.dGVdatodos = new System.Windows.Forms.DataGridView();
            this.dGVresultado = new System.Windows.Forms.DataGridView();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdatouno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdatodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma y Resta de Matrices";
            // 
            // rbtndospor
            // 
            this.rbtndospor.AutoSize = true;
            this.rbtndospor.Location = new System.Drawing.Point(157, 116);
            this.rbtndospor.Name = "rbtndospor";
            this.rbtndospor.Size = new System.Drawing.Size(48, 20);
            this.rbtndospor.TabIndex = 1;
            this.rbtndospor.Text = "2x2";
            this.rbtndospor.UseVisualStyleBackColor = true;
            this.rbtndospor.CheckedChanged += new System.EventHandler(this.rbtndospor_CheckedChanged);
            // 
            // rbtntrespor
            // 
            this.rbtntrespor.AutoSize = true;
            this.rbtntrespor.Location = new System.Drawing.Point(368, 116);
            this.rbtntrespor.Name = "rbtntrespor";
            this.rbtntrespor.Size = new System.Drawing.Size(48, 20);
            this.rbtntrespor.TabIndex = 1;
            this.rbtntrespor.Text = "3x3";
            this.rbtntrespor.UseVisualStyleBackColor = true;
            this.rbtntrespor.CheckedChanged += new System.EventHandler(this.rbtntrespor_CheckedChanged);
            // 
            // lbloperacion
            // 
            this.lbloperacion.AutoSize = true;
            this.lbloperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.Location = new System.Drawing.Point(178, 247);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(27, 29);
            this.lbloperacion.TabIndex = 2;
            this.lbloperacion.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // dGVdatouno
            // 
            this.dGVdatouno.AllowUserToAddRows = false;
            this.dGVdatouno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVdatouno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVdatouno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdatouno.ColumnHeadersVisible = false;
            this.dGVdatouno.Location = new System.Drawing.Point(6, 189);
            this.dGVdatouno.Name = "dGVdatouno";
            this.dGVdatouno.RowHeadersVisible = false;
            this.dGVdatouno.RowHeadersWidth = 51;
            this.dGVdatouno.RowTemplate.Height = 24;
            this.dGVdatouno.Size = new System.Drawing.Size(166, 142);
            this.dGVdatouno.TabIndex = 3;
            // 
            // dGVdatodos
            // 
            this.dGVdatodos.AllowUserToAddRows = false;
            this.dGVdatodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVdatodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVdatodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdatodos.ColumnHeadersVisible = false;
            this.dGVdatodos.Location = new System.Drawing.Point(211, 189);
            this.dGVdatodos.Name = "dGVdatodos";
            this.dGVdatodos.RowHeadersVisible = false;
            this.dGVdatodos.RowHeadersWidth = 51;
            this.dGVdatodos.RowTemplate.Height = 24;
            this.dGVdatodos.Size = new System.Drawing.Size(166, 142);
            this.dGVdatodos.TabIndex = 3;
            // 
            // dGVresultado
            // 
            this.dGVresultado.AllowUserToAddRows = false;
            this.dGVresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVresultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVresultado.ColumnHeadersVisible = false;
            this.dGVresultado.Location = new System.Drawing.Point(416, 189);
            this.dGVresultado.Name = "dGVresultado";
            this.dGVresultado.RowHeadersVisible = false;
            this.dGVresultado.RowHeadersWidth = 51;
            this.dGVresultado.RowTemplate.Height = 24;
            this.dGVresultado.Size = new System.Drawing.Size(166, 142);
            this.dGVresultado.TabIndex = 3;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(118, 366);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(133, 43);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click_1);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(330, 366);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(133, 43);
            this.btnresta.TabIndex = 4;
            this.btnresta.Text = "Restar";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 499);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.dGVresultado);
            this.Controls.Add(this.dGVdatodos);
            this.Controls.Add(this.dGVdatouno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbloperacion);
            this.Controls.Add(this.rbtntrespor);
            this.Controls.Add(this.rbtndospor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Suma Y Resta de Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.dGVdatouno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVdatodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVresultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtndospor;
        private System.Windows.Forms.RadioButton rbtntrespor;
        private System.Windows.Forms.Label lbloperacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVdatouno;
        private System.Windows.Forms.DataGridView dGVdatodos;
        private System.Windows.Forms.DataGridView dGVresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
    }
}

