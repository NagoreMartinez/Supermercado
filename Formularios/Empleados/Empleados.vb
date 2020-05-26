Imports Funciones

Public Class Empleados

    Dim obE As New FEmpleados

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idEmpleado As String = obE.crearIDE()
        txtIDE.Text = idEmpleado
        Dim idSuper As String = obE.idFijoSuper()
        txtIDS.Text = idSuper
    End Sub

    Private Sub buttonGuardar1_Click(sender As Object, e As EventArgs) Handles buttonGuardar1.Click

        Dim i = obE.InsertEmpleado(txtIDE.Text, cbT.SelectedItem, txtIDS.Text, txtDNI.Text, txtNombre.Text,
                                        txtEdad.Text, txtTel.Text, cbHorario.SelectedItem, txtSalario.Text)

        If i Then
            MessageBox.Show("Empleado agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Dim formEmpleados As FormInicio = CType(Owner, FormInicio)
        formEmpleados.listarEmpleado()

        Close()

    End Sub


End Class