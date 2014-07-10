<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmREsumenNiveles
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalles del origen"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "El deposito - marcaba ---- litros de ------."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resumen de la operacion"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(43, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Se aplicara una diferencia de - litros para cuadrar su cantidad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(364, 66)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Terminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(43, 237)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 111)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Observaciones de la operacion"
        '
        'frmREsumenNiveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 608)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmREsumenNiveles"
        Me.Text = "frmREsumenNiveles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
