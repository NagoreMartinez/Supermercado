﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.buttonGuardar3 = New System.Windows.Forms.Button()
        Me.txtFCad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre3 = New System.Windows.Forms.TextBox()
        Me.txtIDP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonGuardar3
        '
        Me.buttonGuardar3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.buttonGuardar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGuardar3.Location = New System.Drawing.Point(594, 380)
        Me.buttonGuardar3.Name = "buttonGuardar3"
        Me.buttonGuardar3.Size = New System.Drawing.Size(115, 35)
        Me.buttonGuardar3.TabIndex = 58
        Me.buttonGuardar3.Text = "Guardar"
        Me.buttonGuardar3.UseVisualStyleBackColor = False
        '
        'txtFCad
        '
        Me.txtFCad.Location = New System.Drawing.Point(530, 297)
        Me.txtFCad.Name = "txtFCad"
        Me.txtFCad.Size = New System.Drawing.Size(127, 20)
        Me.txtFCad.TabIndex = 57
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 24)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Fecha de caducidad"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 51)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(50, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Datos "
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(134, 297)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(87, 20)
        Me.txtPrecio.TabIndex = 54
        '
        'txtNombre3
        '
        Me.txtNombre3.Location = New System.Drawing.Point(151, 203)
        Me.txtNombre3.Name = "txtNombre3"
        Me.txtNombre3.Size = New System.Drawing.Size(226, 20)
        Me.txtNombre3.TabIndex = 53
        '
        'txtIDP
        '
        Me.txtIDP.Location = New System.Drawing.Point(175, 38)
        Me.txtIDP.Name = "txtIDP"
        Me.txtIDP.Size = New System.Drawing.Size(160, 20)
        Me.txtIDP.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Precio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "ID Producto"
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 450)
        Me.Controls.Add(Me.buttonGuardar3)
        Me.Controls.Add(Me.txtFCad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre3)
        Me.Controls.Add(Me.txtIDP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Productos"
        Me.Text = "Nuevo producto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonGuardar3 As Button
    Friend WithEvents txtFCad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre3 As TextBox
    Friend WithEvents txtIDP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
