<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnMostrarTemp = New System.Windows.Forms.Button()
        Me.btnItrTemp = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMostrarTemp
        '
        Me.btnMostrarTemp.BackColor = System.Drawing.Color.Maroon
        Me.btnMostrarTemp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMostrarTemp.Location = New System.Drawing.Point(183, 327)
        Me.btnMostrarTemp.Name = "btnMostrarTemp"
        Me.btnMostrarTemp.Size = New System.Drawing.Size(165, 54)
        Me.btnMostrarTemp.TabIndex = 5
        Me.btnMostrarTemp.Text = "Mostrar Temperaturas"
        Me.btnMostrarTemp.UseVisualStyleBackColor = False
        '
        'btnItrTemp
        '
        Me.btnItrTemp.BackColor = System.Drawing.Color.Maroon
        Me.btnItrTemp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItrTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItrTemp.Location = New System.Drawing.Point(12, 327)
        Me.btnItrTemp.Name = "btnItrTemp"
        Me.btnItrTemp.Size = New System.Drawing.Size(165, 54)
        Me.btnItrTemp.TabIndex = 4
        Me.btnItrTemp.Text = "Introducir Temperaturas"
        Me.btnItrTemp.UseVisualStyleBackColor = False
        '
        'txtTemp
        '
        Me.txtTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTemp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTemp.Location = New System.Drawing.Point(12, 12)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTemp.Size = New System.Drawing.Size(336, 299)
        Me.txtTemp.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(361, 394)
        Me.Controls.Add(Me.btnMostrarTemp)
        Me.Controls.Add(Me.btnItrTemp)
        Me.Controls.Add(Me.txtTemp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Temperaturas de Arreglo Dinamico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMostrarTemp As Button
    Friend WithEvents btnItrTemp As Button
    Friend WithEvents txtTemp As TextBox
End Class
