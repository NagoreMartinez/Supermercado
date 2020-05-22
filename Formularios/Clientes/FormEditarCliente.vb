﻿Imports Clases
Imports Funciones


Public Class FormEditarCliente

    Dim Clientes As New FClientes
    Public Sub New(c As CCliente)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDC.Text = c.idCliente
        txtIDS2.Text = c.idSuper
        txtDNI2.Text = c.dni
        txtNombre2.Text = c.nombre
        txtTel.Text = c.telefono

    End Sub

    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Guardar cambios
    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click

        Dim c = Clientes.ActualizarCliente(txtIDC.Text, txtIDS2.Text, txtDNI2.Text, txtNombre2.Text, txtTel.Text)

        If c Then
            MessageBox.Show("Se ha actualizado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formClientes As FormInicio = CType(Owner, FormInicio)
        Clientes.ListaClientes()
        Close()
    End Sub

End Class