<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menudeopciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menudeopciones))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        OtraPestañaToolStripMenuItem = New ToolStripMenuItem()
        FacturaToolStripMenuItem = New ToolStripMenuItem()
        FondoToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(132, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(443, 45)
        Label1.TabIndex = 0
        Label1.Text = "Programacion Orientada a Objetos"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(80, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 29)
        Label2.TabIndex = 0
        Label2.Text = "Diego Verano Laverian"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(80, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 29)
        Label3.TabIndex = 0
        Label3.Text = "SENATI"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FormatoToolStripMenuItem, FondoToolStripMenuItem, AcercaDeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(706, 30)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OtraPestañaToolStripMenuItem, FacturaToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(79, 24)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' OtraPestañaToolStripMenuItem
        ' 
        OtraPestañaToolStripMenuItem.Name = "OtraPestañaToolStripMenuItem"
        OtraPestañaToolStripMenuItem.Size = New Size(224, 26)
        OtraPestañaToolStripMenuItem.Text = "Calculadora"
        ' 
        ' FacturaToolStripMenuItem
        ' 
        FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        FacturaToolStripMenuItem.Size = New Size(224, 26)
        FacturaToolStripMenuItem.Text = "Factura"
        ' 
        ' FondoToolStripMenuItem
        ' 
        FondoToolStripMenuItem.Name = "FondoToolStripMenuItem"
        FondoToolStripMenuItem.Size = New Size(65, 24)
        FondoToolStripMenuItem.Text = "Fondo"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(98, 24)
        AcercaDeToolStripMenuItem.Text = "Acerca de..."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label4.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(309, 427)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 40)
        Label4.TabIndex = 2
        Label4.Text = "Fecha"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(243, 375)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(267, 27)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Menudeopciones
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 624)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Menudeopciones"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtraPestañaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents FacturaToolStripMenuItem As ToolStripMenuItem

End Class
