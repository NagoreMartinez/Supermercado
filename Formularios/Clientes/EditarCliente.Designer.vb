﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCliente
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIDC = New System.Windows.Forms.TextBox()
        Me.txtIDS2 = New System.Windows.Forms.TextBox()
        Me.txtDNI2 = New System.Windows.Forms.TextBox()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.buttonGuardar2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Supermercado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(50, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Datos personales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(285, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Teléfono"
        '
        'txtIDC
        '
        Me.txtIDC.Location = New System.Drawing.Point(159, 55)
        Me.txtIDC.Name = "txtIDC"
        Me.txtIDC.Size = New System.Drawing.Size(148, 20)
        Me.txtIDC.TabIndex = 6
        '
        'txtIDS2
        '
        Me.txtIDS2.Location = New System.Drawing.Point(541, 55)
        Me.txtIDS2.Name = "txtIDS2"
        Me.txtIDS2.Size = New System.Drawing.Size(148, 20)
        Me.txtIDS2.TabIndex = 7
        '
        'txtDNI2
        '
        Me.txtDNI2.Location = New System.Drawing.Point(112, 231)
        Me.txtDNI2.Name = "txtDNI2"
        Me.txtDNI2.Size = New System.Drawing.Size(123, 20)
        Me.txtDNI2.TabIndex = 8
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(384, 231)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(214, 20)
        Me.txtNombre2.TabIndex = 9
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(159, 325)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(148, 20)
        Me.txtTel.TabIndex = 10
        '
        'buttonGuardar2
        '
        Me.buttonGuardar2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.buttonGuardar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGuardar2.Location = New System.Drawing.Point(586, 362)
        Me.buttonGuardar2.Name = "buttonGuardar2"
        Me.buttonGuardar2.Size = New System.Drawing.Size(103, 35)
        Me.buttonGuardar2.TabIndex = 11
        Me.buttonGuardar2.Text = "Guardar"
        Me.buttonGuardar2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 51)
        Me.Panel1.TabIndex = 12
        '
        'FormEditarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.buttonGuardar2)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.txtDNI2)
        Me.Controls.Add(Me.txtIDS2)
        Me.Controls.Add(Me.txtIDC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEditarCliente"
        Me.Text = "Editar cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIDC As TextBox
    Friend WithEvents txtIDS2 As TextBox
    Friend WithEvents txtDNI2 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents buttonGuardar2 As Button
    Friend WithEvents Panel1 As Panel
End Class