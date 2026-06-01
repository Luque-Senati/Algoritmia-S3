<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Panel1 = New Panel()
        Beliminar = New Button()
        Bagregar = New Button()
        cproducto = New ComboBox()
        efectivo = New TextBox()
        cantidad = New TextBox()
        Label7 = New Label()
        codigo = New Label()
        nombre = New Label()
        precio = New Label()
        devolucion = New Label()
        pagar = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        label = New Label()
        año = New Label()
        DGproducto = New DataGridView()
        Label1 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DGproducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Beliminar)
        Panel1.Controls.Add(Bagregar)
        Panel1.Controls.Add(cproducto)
        Panel1.Controls.Add(efectivo)
        Panel1.Controls.Add(cantidad)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(codigo)
        Panel1.Controls.Add(nombre)
        Panel1.Controls.Add(precio)
        Panel1.Controls.Add(devolucion)
        Panel1.Controls.Add(pagar)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(label)
        Panel1.Controls.Add(año)
        Panel1.Controls.Add(DGproducto)
        Panel1.Location = New Point(14, 79)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(547, 604)
        Panel1.TabIndex = 0
        ' 
        ' Beliminar
        ' 
        Beliminar.Location = New Point(399, 129)
        Beliminar.Margin = New Padding(3, 4, 3, 4)
        Beliminar.Name = "Beliminar"
        Beliminar.Size = New Size(120, 45)
        Beliminar.TabIndex = 4
        Beliminar.Text = "Eliminar"
        Beliminar.UseVisualStyleBackColor = True
        ' 
        ' Bagregar
        ' 
        Bagregar.Location = New Point(399, 76)
        Bagregar.Margin = New Padding(3, 4, 3, 4)
        Bagregar.Name = "Bagregar"
        Bagregar.Size = New Size(120, 45)
        Bagregar.TabIndex = 4
        Bagregar.Text = "Agregar"
        Bagregar.UseVisualStyleBackColor = True
        ' 
        ' cproducto
        ' 
        cproducto.AutoCompleteCustomSource.AddRange(New String() {"Manzana", "Naranja", "Mandarina", "Chocolate", "Pera", "Platano"})
        cproducto.FormattingEnabled = True
        cproducto.Location = New Point(248, 36)
        cproducto.Margin = New Padding(3, 4, 3, 4)
        cproducto.Name = "cproducto"
        cproducto.Size = New Size(152, 28)
        cproducto.TabIndex = 3
        ' 
        ' efectivo
        ' 
        efectivo.Location = New Point(216, 533)
        efectivo.Margin = New Padding(3, 4, 3, 4)
        efectivo.Name = "efectivo"
        efectivo.Size = New Size(114, 27)
        efectivo.TabIndex = 2
        ' 
        ' cantidad
        ' 
        cantidad.Location = New Point(248, 187)
        cantidad.Margin = New Padding(3, 4, 3, 4)
        cantidad.Name = "cantidad"
        cantidad.Size = New Size(114, 27)
        cantidad.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(57, 117)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 20)
        Label7.TabIndex = 1
        Label7.Text = "Nombre"
        ' 
        ' codigo
        ' 
        codigo.AutoSize = True
        codigo.Location = New Point(248, 81)
        codigo.Name = "codigo"
        codigo.Size = New Size(15, 20)
        codigo.TabIndex = 1
        codigo.Text = "-"
        ' 
        ' nombre
        ' 
        nombre.AutoSize = True
        nombre.Location = New Point(248, 117)
        nombre.Name = "nombre"
        nombre.Size = New Size(15, 20)
        nombre.TabIndex = 1
        nombre.Text = "-"
        ' 
        ' precio
        ' 
        precio.AutoSize = True
        precio.Location = New Point(248, 153)
        precio.Name = "precio"
        precio.Size = New Size(15, 20)
        precio.TabIndex = 1
        precio.Text = "-"
        ' 
        ' devolucion
        ' 
        devolucion.AutoSize = True
        devolucion.Location = New Point(422, 540)
        devolucion.Name = "devolucion"
        devolucion.Size = New Size(15, 20)
        devolucion.TabIndex = 1
        devolucion.Text = "-"
        ' 
        ' pagar
        ' 
        pagar.AutoSize = True
        pagar.Location = New Point(107, 540)
        pagar.Name = "pagar"
        pagar.Size = New Size(15, 20)
        pagar.TabIndex = 1
        pagar.Text = "-"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(82, 481)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 20)
        Label11.TabIndex = 1
        Label11.Text = "Total A Pagar"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(399, 481)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 20)
        Label10.TabIndex = 1
        Label10.Text = "Devolución"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(232, 481)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 20)
        Label9.TabIndex = 1
        Label9.Text = "Efectivo"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(57, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 1
        Label8.Text = "Cantidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 1
        Label4.Text = "Precio"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(57, 81)
        label.Name = "label"
        label.Size = New Size(58, 20)
        label.TabIndex = 1
        label.Text = "Codigo"
        ' 
        ' año
        ' 
        año.AutoSize = True
        año.Location = New Point(50, 40)
        año.Name = "año"
        año.Size = New Size(69, 20)
        año.TabIndex = 1
        año.Text = "Producto"
        ' 
        ' DGproducto
        ' 
        DGproducto.AllowUserToAddRows = False
        DGproducto.AllowUserToDeleteRows = False
        DGproducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGproducto.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DGproducto.Location = New Point(27, 221)
        DGproducto.Margin = New Padding(3, 4, 3, 4)
        DGproducto.Name = "DGproducto"
        DGproducto.ReadOnly = True
        DGproducto.RowHeadersVisible = False
        DGproducto.RowHeadersWidth = 51
        DGproducto.Size = New Size(492, 239)
        DGproducto.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(54, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(478, 40)
        Label1.TabIndex = 1
        Label1.Text = "Factura Tienda San Maritinio"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Codigo"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Producto"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Precio"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Cantidad"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' factura
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 761)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tienda San Maritinio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DGproducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents codigo As Label
    Friend WithEvents cpro As Label
    Friend WithEvents label As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents año As Label
    Friend WithEvents DGproducto As DataGridView
    Friend WithEvents nombre As Label
    Friend WithEvents cproducto As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Beliminar As Button
    Friend WithEvents Bagregar As Button
    Friend WithEvents devolucion As Label
    Friend WithEvents pagar As Label
    Friend WithEvents precio As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents efectivo As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
