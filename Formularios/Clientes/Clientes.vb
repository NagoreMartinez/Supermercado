Imports Funciones

Public Class Clientes

    Dim obC As New FClientes

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idCliente As String = obC.crearIDC()
        txtIDC.Text = idCliente
        Dim idSuper As String = obC.idFijoSuper()
        txtIDS2.Text = idSuper
    End Sub

    Private Sub buttonGuardar2_Click(sender As Object, e As EventArgs) Handles buttonGuardar2.Click

        Dim i = obC.InsertarCliente(txtIDC.Text, txtIDS2.Text, txtDNI2.Text, txtNombre2.Text, txtTel2.Text)

        If i Then
            MessageBox.Show("Cliente agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Dim formClientes As FormInicio = CType(Owner, FormInicio)
        formClientes.listarClientes()

        Close()

    End Sub


End Class