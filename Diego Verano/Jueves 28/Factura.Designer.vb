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
        Me.cantidad = New TextBox()
        cantidad = New TextBox()
        Label7 = New Label()
        Me.codigo = New Label()
        Me.nombre = New Label()
        Me.precio = New Label()
        devolucion = New Label()
        pagar = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Me.label = New Label()
        año = New Label()
        Me.DGproducto = New DataGridView()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(Me.DGproducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Beliminar)
        Panel1.Controls.Add(Bagregar)
        Panel1.Controls.Add(Me.cproducto)
        Panel1.Controls.Add(Me.cantidad)
        Panel1.Controls.Add(cantidad)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Me.codigo)
        Panel1.Controls.Add(Me.nombre)
        Panel1.Controls.Add(Me.precio)
        Panel1.Controls.Add(devolucion)
        Panel1.Controls.Add(pagar)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Me.label)
        Panel1.Controls.Add(año)
        Panel1.Controls.Add(Me.DGproducto)
        Panel1.Location = New Point(12, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 453)
        Panel1.TabIndex = 0
        ' 
        ' Beliminar
        ' 
        Beliminar.Location = New Point(349, 97)
        Beliminar.Name = "Beliminar"
        Beliminar.Size = New Size(105, 34)
        Beliminar.TabIndex = 4
        Beliminar.Text = "Eliminar"
        Beliminar.UseVisualStyleBackColor = True
        ' 
        ' Bagregar
        ' 
        Bagregar.Location = New Point(349, 57)
        Bagregar.Name = "Bagregar"
        Bagregar.Size = New Size(105, 34)
        Bagregar.TabIndex = 4
        Bagregar.Text = "Agregar"
        Bagregar.UseVisualStyleBackColor = True
        ' 
        ' cproducto
        ' 
        Me.cproducto.FormattingEnabled = True
        Me.cproducto.Location = New Point(217, 27)
        Me.cproducto.Name = "cproducto"
        Me.cproducto.Size = New Size(121, 23)
        Me.cproducto.TabIndex = 3
        ' 
        ' cantidad
        ' 
        Me.cantidad.Location = New Point(217, 137)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New Size(100, 23)
        Me.cantidad.TabIndex = 2
        ' 
        ' cantidad
        ' 
        cantidad.Location = New Point(186, 397)
        cantidad.Name = "TextBox1"
        cantidad.Size = New Size(100, 23)
        cantidad.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(50, 88)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 1
        Label7.Text = "Nombre"
        ' 
        ' codigo
        ' 
        Me.codigo.AutoSize = True
        Me.codigo.Location = New Point(217, 61)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New Size(12, 15)
        Me.codigo.TabIndex = 1
        Me.codigo.Text = "-"
        ' 
        ' nombre
        ' 
        Me.nombre.AutoSize = True
        Me.nombre.Location = New Point(217, 88)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New Size(12, 15)
        Me.nombre.TabIndex = 1
        Me.nombre.Text = "-"
        ' 
        ' precio
        ' 
        Me.precio.AutoSize = True
        Me.precio.Location = New Point(217, 115)
        Me.precio.Name = "precio"
        Me.precio.Size = New Size(12, 15)
        Me.precio.TabIndex = 1
        Me.precio.Text = "-"
        ' 
        ' devolucion
        ' 
        devolucion.AutoSize = True
        devolucion.Location = New Point(369, 405)
        devolucion.Name = "devolucion"
        devolucion.Size = New Size(12, 15)
        devolucion.TabIndex = 1
        devolucion.Text = "-"
        ' 
        ' pagar
        ' 
        pagar.AutoSize = True
        pagar.Location = New Point(94, 405)
        pagar.Name = "pagar"
        pagar.Size = New Size(12, 15)
        pagar.TabIndex = 1
        pagar.Text = "-"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(72, 361)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 15)
        Label11.TabIndex = 1
        Label11.Text = "Total A Pagar"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(349, 361)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 15)
        Label10.TabIndex = 1
        Label10.Text = "Devolución"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(203, 361)
        Label9.Name = "Label9"
        Label9.Size = New Size(49, 15)
        Label9.TabIndex = 1
        Label9.Text = "Efectivo"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(50, 140)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 1
        Label8.Text = "Cantidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 15)
        Label4.TabIndex = 1
        Label4.Text = "Precio"
        ' 
        ' label
        ' 
        Me.label.AutoSize = True
        Me.label.Location = New Point(50, 61)
        Me.label.Name = "label"
        Me.label.Size = New Size(46, 15)
        Me.label.TabIndex = 1
        Me.label.Text = "Codigo"
        ' 
        ' año
        ' 
        año.AutoSize = True
        año.Location = New Point(44, 30)
        año.Name = "año"
        año.Size = New Size(56, 15)
        año.TabIndex = 1
        año.Text = "Producto"
        ' 
        ' DGproducto
        ' 
        Me.DGproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGproducto.Location = New Point(24, 166)
        Me.DGproducto.Name = "DGproducto"
        Me.DGproducto.Size = New Size(430, 179)
        Me.DGproducto.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(56, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 32)
        Label1.TabIndex = 1
        Label1.Text = "Factura Tienda San Maritinio"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 571)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tienda San Maritinio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Me.DGproducto, ComponentModel.ISupportInitialize).EndInit()
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
End Class
