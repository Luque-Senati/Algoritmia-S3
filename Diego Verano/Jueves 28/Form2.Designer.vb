<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Buno = New Button()
        Bdos = New Button()
        Btres = New Button()
        Bcuatro = New Button()
        Bcinco = New Button()
        Bseis = New Button()
        Bsiete = New Button()
        Bocho = New Button()
        Bnueve = New Button()
        Bcero = New Button()
        Bmas = New Button()
        Bmenos = New Button()
        Bmult = New Button()
        Bdiv = New Button()
        Bresultado = New Button()
        Blimpiar = New Button()
        resolucion = New TextBox()
        SuspendLayout()
        ' 
        ' Buno
        ' 
        Buno.Location = New Point(14, 143)
        Buno.Name = "Buno"
        Buno.Size = New Size(57, 60)
        Buno.TabIndex = 0
        Buno.Text = "1"
        Buno.UseVisualStyleBackColor = True
        Buno.UseWaitCursor = True
        ' 
        ' Bdos
        ' 
        Bdos.Location = New Point(77, 143)
        Bdos.Name = "Bdos"
        Bdos.Size = New Size(57, 60)
        Bdos.TabIndex = 0
        Bdos.Text = "2"
        Bdos.UseVisualStyleBackColor = True
        ' 
        ' Btres
        ' 
        Btres.Location = New Point(140, 143)
        Btres.Name = "Btres"
        Btres.Size = New Size(57, 60)
        Btres.TabIndex = 0
        Btres.Text = "3"
        Btres.UseVisualStyleBackColor = True
        ' 
        ' Bcuatro
        ' 
        Bcuatro.Location = New Point(14, 209)
        Bcuatro.Name = "Bcuatro"
        Bcuatro.Size = New Size(57, 60)
        Bcuatro.TabIndex = 0
        Bcuatro.Text = "4"
        Bcuatro.UseVisualStyleBackColor = True
        ' 
        ' Bcinco
        ' 
        Bcinco.Location = New Point(77, 209)
        Bcinco.Name = "Bcinco"
        Bcinco.Size = New Size(57, 60)
        Bcinco.TabIndex = 0
        Bcinco.Text = "5"
        Bcinco.UseVisualStyleBackColor = True
        ' 
        ' Bseis
        ' 
        Bseis.Location = New Point(140, 209)
        Bseis.Name = "Bseis"
        Bseis.Size = New Size(57, 60)
        Bseis.TabIndex = 0
        Bseis.Text = "6"
        Bseis.UseVisualStyleBackColor = True
        ' 
        ' Bsiete
        ' 
        Bsiete.Location = New Point(14, 275)
        Bsiete.Name = "Bsiete"
        Bsiete.Size = New Size(57, 60)
        Bsiete.TabIndex = 0
        Bsiete.Text = "7"
        Bsiete.UseVisualStyleBackColor = True
        ' 
        ' Bocho
        ' 
        Bocho.Location = New Point(77, 275)
        Bocho.Name = "Bocho"
        Bocho.Size = New Size(57, 60)
        Bocho.TabIndex = 0
        Bocho.Text = "8"
        Bocho.UseVisualStyleBackColor = True
        ' 
        ' Bnueve
        ' 
        Bnueve.Location = New Point(140, 275)
        Bnueve.Name = "Bnueve"
        Bnueve.Size = New Size(57, 60)
        Bnueve.TabIndex = 0
        Bnueve.Text = "9"
        Bnueve.UseVisualStyleBackColor = True
        ' 
        ' Bcero
        ' 
        Bcero.Location = New Point(77, 341)
        Bcero.Name = "Bcero"
        Bcero.Size = New Size(57, 60)
        Bcero.TabIndex = 0
        Bcero.Text = "0"
        Bcero.UseVisualStyleBackColor = True
        ' 
        ' Bmas
        ' 
        Bmas.Location = New Point(203, 143)
        Bmas.Name = "Bmas"
        Bmas.Size = New Size(57, 60)
        Bmas.TabIndex = 0
        Bmas.Text = "+"
        Bmas.UseVisualStyleBackColor = True
        ' 
        ' Bmenos
        ' 
        Bmenos.Location = New Point(203, 209)
        Bmenos.Name = "Bmenos"
        Bmenos.Size = New Size(57, 60)
        Bmenos.TabIndex = 0
        Bmenos.Text = "-"
        Bmenos.UseVisualStyleBackColor = True
        ' 
        ' Bmult
        ' 
        Bmult.Location = New Point(203, 275)
        Bmult.Name = "Bmult"
        Bmult.Size = New Size(57, 60)
        Bmult.TabIndex = 0
        Bmult.Text = "*"
        Bmult.UseVisualStyleBackColor = True
        ' 
        ' Bdiv
        ' 
        Bdiv.Location = New Point(203, 341)
        Bdiv.Name = "Bdiv"
        Bdiv.Size = New Size(57, 60)
        Bdiv.TabIndex = 0
        Bdiv.Text = "/"
        Bdiv.UseVisualStyleBackColor = True
        ' 
        ' Bresultado
        ' 
        Bresultado.Location = New Point(140, 341)
        Bresultado.Name = "Bresultado"
        Bresultado.Size = New Size(57, 60)
        Bresultado.TabIndex = 0
        Bresultado.Text = "="
        Bresultado.UseVisualStyleBackColor = True
        ' 
        ' Blimpiar
        ' 
        Blimpiar.Location = New Point(14, 341)
        Blimpiar.Name = "Blimpiar"
        Blimpiar.Size = New Size(57, 60)
        Blimpiar.TabIndex = 0
        Blimpiar.Text = "CE"
        Blimpiar.UseVisualStyleBackColor = True
        ' 
        ' resolucion
        ' 
        resolucion.BorderStyle = BorderStyle.FixedSingle
        resolucion.Font = New Font("Segoe UI Semibold", 34.25F, FontStyle.Bold)
        resolucion.Location = New Point(14, 28)
        resolucion.Multiline = True
        resolucion.Name = "resolucion"
        resolucion.Size = New Size(246, 97)
        resolucion.TabIndex = 1
        resolucion.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(272, 422)
        Controls.Add(resolucion)
        Controls.Add(Blimpiar)
        Controls.Add(Bresultado)
        Controls.Add(Bdiv)
        Controls.Add(Bmult)
        Controls.Add(Bmenos)
        Controls.Add(Bmas)
        Controls.Add(Bcero)
        Controls.Add(Bnueve)
        Controls.Add(Bocho)
        Controls.Add(Bsiete)
        Controls.Add(Bseis)
        Controls.Add(Bcinco)
        Controls.Add(Bcuatro)
        Controls.Add(Btres)
        Controls.Add(Bdos)
        Controls.Add(Buno)
        Name = "Form2"
        Text = "Calculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Buno As Button
    Friend WithEvents Bdos As Button
    Friend WithEvents Btres As Button
    Friend WithEvents Bcuatro As Button
    Friend WithEvents Bcinco As Button
    Friend WithEvents Bseis As Button
    Friend WithEvents Bsiete As Button
    Friend WithEvents Bocho As Button
    Friend WithEvents Bnueve As Button
    Friend WithEvents Bcero As Button
    Friend WithEvents Bmas As Button
    Friend WithEvents Bmenos As Button
    Friend WithEvents Bmult As Button
    Friend WithEvents Bdiv As Button
    Friend WithEvents Bresultado As Button
    Friend WithEvents Blimpiar As Button
    Friend WithEvents resolucion As TextBox

End Class
