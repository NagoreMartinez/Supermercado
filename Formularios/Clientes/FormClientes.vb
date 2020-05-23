Imports Funciones

Public Class FormClientes

    Dim obC As New FClientes
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Dim idC = txtIDC.Text
    Dim idS = txtIDS2.Text
    Dim dni = txtDNI2.Text
    Dim nombre = txtNombre2.Text
    Dim tel = txtTel.Text

    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click

        Dim insert = obC.InsertarCliente(idC, idS, dni, nombre, tel)

        If insert Then
            MessageBox.Show("Se ha insertado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Close()

    End Sub
End Class