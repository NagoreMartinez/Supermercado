Imports Funciones

Public Class Productos

    Dim obP As New FProductos

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idProducto As String = obP.crearIDP()
        txtIDP.Text = idProducto
    End Sub

    Private Sub buttonGuardar3_Click(sender As Object, e As EventArgs) Handles buttonGuardar3.Click

        Dim insert = obP.InsertProducto(txtIDP.Text, txtNombre3.Text, txtPrecio.Text, txtFCad.Text)

        If insert Then
            MessageBox.Show("Producto agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        'Dim formProductos As FormInicio = CType(Owner, FormInicio)
        'formProductos.listarProductos()

        Close()

    End Sub


End Class