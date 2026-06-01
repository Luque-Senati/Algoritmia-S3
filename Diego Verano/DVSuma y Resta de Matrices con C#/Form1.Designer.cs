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
            this.label1.Location = new System.Drawing.Point(189, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma y Resta de Matrices";
            // 
            // rbtndospor
            // 
            this.rbtndospor.AutoSize = true;
            this.rbtndospor.Checked = true;
            this.rbtndospor.Location = new System.Drawing.Point(125, 116);
            this.rbtndospor.Name = "rbtndospor";
            this.rbtndospor.Size = new System.Drawing.Size(48, 20);
            this.rbtndospor.TabIndex = 1;
            this.rbtndospor.TabStop = true;
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
            // 
            // lbloperacion
            // 
            this.lbloperacion.AutoSize = true;
            this.lbloperacion.Location = new System.Drawing.Point(178, 247);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(14, 16);
            this.lbloperacion.TabIndex = 2;
            this.lbloperacion.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // dGVdatouno
            // 
            this.dGVdatouno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dGVdatodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVdatodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVdatodos.ColumnHeadersVisible = false;
            this.dGVdatodos.Location = new System.Drawing.Point(198, 189);
            this.dGVdatodos.Name = "dGVdatodos";
            this.dGVdatodos.RowHeadersVisible = false;
            this.dGVdatodos.RowHeadersWidth = 51;
            this.dGVdatodos.RowTemplate.Height = 24;
            this.dGVdatodos.Size = new System.Drawing.Size(166, 142);
            this.dGVdatodos.TabIndex = 3;
            // 
            // dGVresultado
            // 
            this.dGVresultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVresultado.ColumnHeadersVisible = false;
            this.dGVresultado.Location = new System.Drawing.Point(390, 189);
            this.dGVresultado.Name = "dGVresultado";
            this.dGVresultado.RowHeadersVisible = false;
            this.dGVresultado.RowHeadersWidth = 51;
            this.dGVresultado.RowTemplate.Height = 24;
            this.dGVresultado.Size = new System.Drawing.Size(166, 142);
            this.dGVresultado.TabIndex = 3;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(137, 366);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(133, 43);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(283, 366);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(133, 43);
            this.btnresta.TabIndex = 4;
            this.btnresta.Text = "Restar";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 499);
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

