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
        FondoToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        FacturaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(146, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 34)
        Label1.TabIndex = 0
        Label1.Text = "Programacion Orientada a Objetos"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(70, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(221, 22)
        Label2.TabIndex = 0
        Label2.Text = "Diego Verano Laverian"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(70, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 22)
        Label3.TabIndex = 0
        Label3.Text = "SENATI"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FormatoToolStripMenuItem, FondoToolStripMenuItem, AcercaDeToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(618, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OtraPestañaToolStripMenuItem, FacturaToolStripMenuItem})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(64, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' OtraPestañaToolStripMenuItem
        ' 
        OtraPestañaToolStripMenuItem.Name = "OtraPestañaToolStripMenuItem"
        OtraPestañaToolStripMenuItem.Size = New Size(180, 22)
        OtraPestañaToolStripMenuItem.Text = "Calculadora"
        ' 
        ' FondoToolStripMenuItem
        ' 
        FondoToolStripMenuItem.Name = "FondoToolStripMenuItem"
        FondoToolStripMenuItem.Size = New Size(53, 20)
        FondoToolStripMenuItem.Text = "Fondo"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(80, 20)
        AcercaDeToolStripMenuItem.Text = "Acerca de..."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Label4.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(270, 320)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 32)
        Label4.TabIndex = 2
        Label4.Text = "Fecha"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(213, 281)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(234, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' FacturaToolStripMenuItem
        ' 
        FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        FacturaToolStripMenuItem.Size = New Size(180, 22)
        FacturaToolStripMenuItem.Text = "Factura"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 468)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
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
