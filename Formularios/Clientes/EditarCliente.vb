Imports Clases
Imports Funciones

Public Class EditarCliente

    Dim objC As New FClientes

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(c As CCliente)

        Me.New

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDC.Text = c.idCliente
        txtIDS2.Text = c.idSuper
        txtDNI2.Text = c.dni
        txtNombre2.Text = c.nombre
        txtTel.Text = c.telefono

    End Sub

    ' Guardar cambios
    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click

        Dim c = objC.ActualizarCliente(txtIDC.Text, txtIDS2.Text, txtDNI2.Text, txtNombre2.Text, txtTel.Text)

        If c Then
            MessageBox.Show("Se ha actualizado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formClientes As FormInicio = CType(Owner, FormInicio)
        formClientes.listarClientes()
        Close()
    End Sub


End Class