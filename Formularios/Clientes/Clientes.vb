Imports Funciones

Public Class Clientes

    Dim obC As New FClientes


    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click
        Dim idC = txtIDC.Text
        Dim idS = txtIDS2.Text
        Dim dni = txtDNI2.Text
        Dim nombre = txtNombre2.Text
        Dim tel = txtTel2.Text

        Dim insert = obC.InsertarCliente(idC, idS, dni, nombre, tel)

        If insert Then
            MessageBox.Show("Cliente agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        'Dim formClientes As FormInicio = CType(Owner, FormInicio)
        'formClientes.listarClientes()

        Close()

    End Sub


End Class