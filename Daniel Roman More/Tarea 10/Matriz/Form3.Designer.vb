<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.lbldevolucion = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblcodigo = New System.Windows.Forms.Label()
        Me.lblprecio = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dgvfactura = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnvender = New System.Windows.Forms.Button()
        Me.label14 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.dgvfactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.cboproducto)
        Me.panel1.Controls.Add(Me.btneliminar)
        Me.panel1.Controls.Add(Me.btnagregar)
        Me.panel1.Controls.Add(Me.txtefectivo)
        Me.panel1.Controls.Add(Me.txtcantidad)
        Me.panel1.Controls.Add(Me.lbldevolucion)
        Me.panel1.Controls.Add(Me.label12)
        Me.panel1.Controls.Add(Me.label11)
        Me.panel1.Controls.Add(Me.lbltotal)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.lblnombre)
        Me.panel1.Controls.Add(Me.lblcodigo)
        Me.panel1.Controls.Add(Me.lblprecio)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.dgvfactura)
        Me.panel1.Location = New System.Drawing.Point(23, 68)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(419, 462)
        Me.panel1.TabIndex = 1
        '
        'cboproducto
        '
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(145, 25)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(121, 21)
        Me.cboproducto.TabIndex = 19
        '
        'btneliminar
        '
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.Location = New System.Drawing.Point(286, 119)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(109, 48)
        Me.btneliminar.TabIndex = 18
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnagregar
        '
        Me.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnagregar.Location = New System.Drawing.Point(286, 57)
        Me.btnagregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(109, 48)
        Me.btnagregar.TabIndex = 17
        Me.btnagregar.Text = "AGREGAR"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(175, 399)
        Me.txtefectivo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(76, 20)
        Me.txtefectivo.TabIndex = 16
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(144, 150)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtcantidad.TabIndex = 15
        '
        'lbldevolucion
        '
        Me.lbldevolucion.AutoSize = True
        Me.lbldevolucion.Location = New System.Drawing.Point(323, 399)
        Me.lbldevolucion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldevolucion.Name = "lbldevolucion"
        Me.lbldevolucion.Size = New System.Drawing.Size(10, 13)
        Me.lbldevolucion.TabIndex = 13
        Me.lbldevolucion.Text = "-"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(292, 369)
        Me.label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(91, 13)
        Me.label12.TabIndex = 12
        Me.label12.Text = "DEVOLUCIÓN:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(180, 369)
        Me.label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(71, 13)
        Me.label11.TabIndex = 11
        Me.label11.Text = "EFECTIVO:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(92, 399)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(10, 13)
        Me.lbltotal.TabIndex = 10
        Me.lbltotal.Text = "-"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(58, 369)
        Me.label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(109, 13)
        Me.label9.TabIndex = 9
        Me.label9.Text = "TOTAL A PAGAR:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(58, 151)
        Me.label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(74, 13)
        Me.label8.TabIndex = 8
        Me.label8.Text = "CANTIDAD:"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(142, 92)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(10, 13)
        Me.lblnombre.TabIndex = 7
        Me.lblnombre.Text = "-"
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(142, 62)
        Me.lblcodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(10, 13)
        Me.lblcodigo.TabIndex = 6
        Me.lblcodigo.Text = "-"
        '
        'lblprecio
        '
        Me.lblprecio.AutoSize = True
        Me.lblprecio.Location = New System.Drawing.Point(142, 121)
        Me.lblprecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblprecio.Name = "lblprecio"
        Me.lblprecio.Size = New System.Drawing.Size(10, 13)
        Me.lblprecio.TabIndex = 5
        Me.lblprecio.Text = "-"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(58, 119)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 13)
        Me.label4.TabIndex = 4
        Me.label4.Text = "PRECIO:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(58, 87)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(64, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "NOMBRE:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(58, 59)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "CODIGO:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(58, 28)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "PRODUCTO:"
        '
        'dgvfactura
        '
        Me.dgvfactura.AllowUserToAddRows = False
        Me.dgvfactura.AllowUserToDeleteRows = False
        Me.dgvfactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvfactura.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvfactura.Location = New System.Drawing.Point(9, 185)
        Me.dgvfactura.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvfactura.Name = "dgvfactura"
        Me.dgvfactura.ReadOnly = True
        Me.dgvfactura.RowHeadersVisible = False
        Me.dgvfactura.RowHeadersWidth = 51
        Me.dgvfactura.RowTemplate.Height = 24
        Me.dgvfactura.Size = New System.Drawing.Size(386, 151)
        Me.dgvfactura.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODIGO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCTO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRECIO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CANTIDAD"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnvender
        '
        Me.btnvender.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnvender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvender.Location = New System.Drawing.Point(160, 536)
        Me.btnvender.Margin = New System.Windows.Forms.Padding(2)
        Me.btnvender.Name = "btnvender"
        Me.btnvender.Size = New System.Drawing.Size(163, 52)
        Me.btnvender.TabIndex = 2
        Me.btnvender.Text = "VENDER"
        Me.btnvender.UseVisualStyleBackColor = False
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.Color.White
        Me.label14.Location = New System.Drawing.Point(113, 23)
        Me.label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(251, 30)
        Me.label14.TabIndex = 3
        Me.label14.Text = "FACTURA TIENDA"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(470, 599)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.btnvender)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dgvfactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents btneliminar As Button
    Private WithEvents btnagregar As Button
    Private WithEvents txtefectivo As TextBox
    Private WithEvents txtcantidad As TextBox
    Private WithEvents lbldevolucion As Label
    Private WithEvents label12 As Label
    Private WithEvents label11 As Label
    Private WithEvents lbltotal As Label
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents lblnombre As Label
    Private WithEvents lblcodigo As Label
    Private WithEvents lblprecio As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents dgvfactura As DataGridView
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents btnvender As Button
    Private WithEvents label14 As Label
    Friend WithEvents cboproducto As ComboBox
End Class
