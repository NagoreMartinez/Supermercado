﻿Imports Clases
Imports Funciones

Public Class EditarProductos
    Dim obP As New FProductos
    Public Sub New(p As CProducto)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDP.Text = p.idProducto
        txtNombre3.Text = p.nombre
        txtPrecio.Text = p.precio
        txtFCad.Text = p.fechaCaducidad

    End Sub


    ' Guardar cambios
    Private Sub buttonGuardar3_Click(sender As Object, e As EventArgs) Handles buttonGuardar3.Click

        Dim p = obP.ActualizarProducto(txtIDP.Text, txtNombre3.Text, txtPrecio.Text, txtFCad.Text)

        If p Then
            MessageBox.Show("Se ha actualizado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formProductos As FormInicio = CType(Owner, FormInicio)
        formProductos.listarProductos()
        Close()
    End Sub


End Class