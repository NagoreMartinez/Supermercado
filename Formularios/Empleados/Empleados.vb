Imports Funciones

Public Class Empleados

    Dim obE As New FEmpleados

    Private Sub buttonGuardar1_Click(sender As Object, e As EventArgs) Handles buttonGuardar1.Click
        Dim idE = txtIDE.Text
        Dim idT = txtIDT.Text
        Dim idS = txtIDS.Text
        Dim dni = txtDNI.Text
        Dim nombre = txtNombre.Text
        Dim edad = txtEdad.Text
        Dim telefono = txtTel.Text
        Dim horario = txtHorario.Text
        Dim salario = txtSalario.Text

        Dim insert = obE.InsertEmpleado(idE, idT, idS, dni, nombre, edad, telefono, horario, salario)

        If insert Then
            MessageBox.Show("Empleado agregado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        'Dim formEmpleados As FormInicio = CType(Owner, FormInicio)
        'formEmpleados.listarEmpleado()

        Close()

    End Sub

End Class