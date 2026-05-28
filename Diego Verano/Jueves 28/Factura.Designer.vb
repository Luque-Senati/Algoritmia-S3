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
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        año = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        pagar = New Label()
        devolucion = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(devolucion)
        Panel1.Controls.Add(pagar)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(año)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(12, 59)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(479, 453)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(217, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(217, 137)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(186, 397)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(217, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(12, 15)
        Label6.TabIndex = 1
        Label6.Text = "-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(217, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(12, 15)
        Label5.TabIndex = 1
        Label5.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(217, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(12, 15)
        Label2.TabIndex = 1
        Label2.Text = "-"
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 1
        Label3.Text = "Edad"
        ' 
        ' año
        ' 
        año.AutoSize = True
        año.Location = New Point(44, 30)
        año.Name = "año"
        año.Size = New Size(116, 15)
        año.TabIndex = 1
        año.Text = "Nombre del criminal"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(430, 179)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(357, 32)
        Label1.TabIndex = 1
        Label1.Text = "Criminales más buscados"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(349, 57)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 34)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(349, 97)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 34)
        Button2.TabIndex = 4
        Button2.Text = "Button1"
        Button2.UseVisualStyleBackColor = True
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
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(349, 361)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 15)
        Label10.TabIndex = 1
        Label10.Text = "Devolución"
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
        ' pagar
        ' 
        pagar.AutoSize = True
        pagar.Location = New Point(94, 405)
        pagar.Name = "pagar"
        pagar.Size = New Size(12, 15)
        pagar.TabIndex = 1
        pagar.Text = "-"
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
        ' Factura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 571)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Criminales buscados por la INTERPOL"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents año As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents devolucion As Label
    Friend WithEvents pagar As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
