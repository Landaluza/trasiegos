<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinSeleccion
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "El deposito nº--, que contiene --- litros de --------- , y el deposito -, que con" & _
    "tiene - litros de ----, seran bloqueados hasta que se reanude la operacion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "El producto del deposito no es correcto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 58)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "La cantidad del deposito no es correcta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(51, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(248, 58)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Confirmar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmFinSeleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFinSeleccion"
        Me.Text = "frmFinSeleccion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
