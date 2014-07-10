<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenTrasiegos
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(15, 396)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(308, 49)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Terminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(317, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Producto incorrrecto en origen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 194)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(317, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Cantidad incorrecta en origen"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(317, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Producto incorrrecto en destino"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(317, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cantidad incorrecta en destino"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Deposito nº-, que contiene --  litros de ----"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Detalles destino"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Deposito nº-, que contiene --  litros de ----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Detalles del origen"
        '
        'frmResumenTrasiegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 481)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmResumenTrasiegos"
        Me.Text = "frmResumenTrasiegos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
