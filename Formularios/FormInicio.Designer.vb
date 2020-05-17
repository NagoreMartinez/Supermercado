<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEmpleados = New System.Windows.Forms.Button()
        Me.Clientes = New System.Windows.Forms.Button()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIO"
        '
        'ButtonEmpleados
        '
        Me.ButtonEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmpleados.Location = New System.Drawing.Point(329, 127)
        Me.ButtonEmpleados.Name = "ButtonEmpleados"
        Me.ButtonEmpleados.Size = New System.Drawing.Size(154, 49)
        Me.ButtonEmpleados.TabIndex = 1
        Me.ButtonEmpleados.Text = "EMPLEADOS"
        Me.ButtonEmpleados.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clientes.Location = New System.Drawing.Point(329, 220)
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(154, 49)
        Me.Clientes.TabIndex = 2
        Me.Clientes.Text = "CLIENTES"
        Me.Clientes.UseVisualStyleBackColor = True
        '
        'ButtonProductos
        '
        Me.ButtonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.Location = New System.Drawing.Point(329, 310)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(154, 49)
        Me.ButtonProductos.TabIndex = 3
        Me.ButtonProductos.Text = "PRODUCTOS"
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonProductos)
        Me.Controls.Add(Me.Clientes)
        Me.Controls.Add(Me.ButtonEmpleados)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEmpleados As Button
    Friend WithEvents Clientes As Button
    Friend WithEvents ButtonProductos As Button
End Class
