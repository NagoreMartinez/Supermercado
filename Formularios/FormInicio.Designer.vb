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
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.PanelInicio = New System.Windows.Forms.Panel()
        Me.POpcionesEmpleado = New System.Windows.Forms.Panel()
        Me.VerEmpleado = New System.Windows.Forms.Button()
        Me.NuevoEmpleado = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelInicio.SuspendLayout()
        Me.POpcionesEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIO"
        '
        'ButtonEmpleados
        '
        Me.ButtonEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmpleados.Location = New System.Drawing.Point(320, 116)
        Me.ButtonEmpleados.Name = "ButtonEmpleados"
        Me.ButtonEmpleados.Size = New System.Drawing.Size(154, 49)
        Me.ButtonEmpleados.TabIndex = 1
        Me.ButtonEmpleados.Text = "EMPLEADOS"
        Me.ButtonEmpleados.UseVisualStyleBackColor = True
        '
        'ButtonClientes
        '
        Me.ButtonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.Location = New System.Drawing.Point(320, 209)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(154, 49)
        Me.ButtonClientes.TabIndex = 2
        Me.ButtonClientes.Text = "CLIENTES"
        Me.ButtonClientes.UseVisualStyleBackColor = True
        '
        'ButtonProductos
        '
        Me.ButtonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.Location = New System.Drawing.Point(320, 299)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(154, 49)
        Me.ButtonProductos.TabIndex = 3
        Me.ButtonProductos.Text = "PRODUCTOS"
        Me.ButtonProductos.UseVisualStyleBackColor = True
        '
        'PanelInicio
        '
        Me.PanelInicio.Controls.Add(Me.POpcionesEmpleado)
        Me.PanelInicio.Location = New System.Drawing.Point(4, 5)
        Me.PanelInicio.Name = "PanelInicio"
        Me.PanelInicio.Size = New System.Drawing.Size(763, 402)
        Me.PanelInicio.TabIndex = 4
        '
        'POpcionesEmpleado
        '
        Me.POpcionesEmpleado.Controls.Add(Me.VerEmpleado)
        Me.POpcionesEmpleado.Controls.Add(Me.NuevoEmpleado)
        Me.POpcionesEmpleado.Controls.Add(Me.Label2)
        Me.POpcionesEmpleado.Controls.Add(Me.ButtonProductos)
        Me.POpcionesEmpleado.Controls.Add(Me.ButtonClientes)
        Me.POpcionesEmpleado.Controls.Add(Me.ButtonEmpleados)
        Me.POpcionesEmpleado.Controls.Add(Me.Label1)
        Me.POpcionesEmpleado.Location = New System.Drawing.Point(5, 6)
        Me.POpcionesEmpleado.Name = "POpcionesEmpleado"
        Me.POpcionesEmpleado.Size = New System.Drawing.Size(755, 372)
        Me.POpcionesEmpleado.TabIndex = 4
        '
        'VerEmpleado
        '
        Me.VerEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerEmpleado.Location = New System.Drawing.Point(501, 153)
        Me.VerEmpleado.Name = "VerEmpleado"
        Me.VerEmpleado.Size = New System.Drawing.Size(212, 49)
        Me.VerEmpleado.TabIndex = 6
        Me.VerEmpleado.Text = "VER PERFIL"
        Me.VerEmpleado.UseVisualStyleBackColor = True
        '
        'NuevoEmpleado
        '
        Me.NuevoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoEmpleado.Location = New System.Drawing.Point(102, 143)
        Me.NuevoEmpleado.Name = "NuevoEmpleado"
        Me.NuevoEmpleado.Size = New System.Drawing.Size(212, 68)
        Me.NuevoEmpleado.TabIndex = 5
        Me.NuevoEmpleado.Text = "REGISTRAR EMPLEADO"
        Me.NuevoEmpleado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "EMPLEADOS"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelInicio)
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        Me.PanelInicio.ResumeLayout(False)
        Me.POpcionesEmpleado.ResumeLayout(False)
        Me.POpcionesEmpleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEmpleados As Button
    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonProductos As Button
    Friend WithEvents PanelInicio As Panel
    Friend WithEvents POpcionesEmpleado As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents NuevoEmpleado As Button
    Friend WithEvents VerEmpleado As Button
End Class
