Imports Funciones

Public Class FormProductos

    Dim obP As FProductos

    Private Sub buttonGuardar3_Click(sender As Object, e As EventArgs) Handles buttonGuardar3.Click
        Dim idP = txtIDP.Text
        Dim nombre = txtNombre3.Text
        Dim precio = txtPrecio.Text
        Dim fCad = txtFCad.Text

        Dim insert = obP.InsertProducto(idP, nombre, precio, fCad)

        If insert Then
            MessageBox.Show("Producto agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Dim formProductos As FormInicio = CType(Owner, FormInicio)
        formProductos.listarProductos()

        Close()

    End Sub

End Class