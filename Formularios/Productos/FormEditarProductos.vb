Imports Clases
Imports Funciones

Public Class FormEditarProductos
    Dim Productos As New FProductos
    Public Sub New(p As CProducto)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDP.Text = p.idProducto
        txtNombre.Text = p.nombre
        txtPrecio.Text = p.precio
        txtFCad.Text = p.fechaCaducidad


    End Sub

    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Guardar cambios
    Private Sub buttonGuardar3_Click(sender As Object, e As EventArgs) Handles buttonGuardar3.Click

        Dim p = Productos.ActualizarProducto(txtIDP.Text, txtNombre.Text, txtPrecio.Text, txtFCad.Text)

        If p Then
            MessageBox.Show("Se ha actualizado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formProductos As FormInicio = CType(Owner, FormInicio)
        Productos.ListaProductos()
        Close()
    End Sub

End Class