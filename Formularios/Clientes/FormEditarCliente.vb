Imports Clases
Imports Funciones


Public Class FormEditarCliente

    Dim Clientes As New FClientes
    Public Sub New(c As CCliente)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDC.Text = c.idCliente
        txtIDS.Text = c.idSuper
        txtDni.Text = c.dni
        txtNombre.Text = c.nombre
        txtTef.Text = c.telefono

    End Sub

    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Guardar cambios
    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click

        Dim c = Clientes.ActualizarCliente(txtIDC.Text, txtIDS.Text, txtDni.Text, txtNombre.Text, txtTef.Text)

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