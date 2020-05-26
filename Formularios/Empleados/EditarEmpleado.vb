Imports Clases
Imports Funciones

Public Class EditarEmpleado

    Dim obE As New FEmpleados

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

    End Sub

    Public Sub New(e As CEmpleado)

        Me.New

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDE.Text = e.idEmpleado
        cbT.SelectedItem = e.idTipo
        txtIDS.Text = e.idSuper
        txtDNI.Text = e.dni
        txtNombre.Text = e.nombre
        txtEdad.Text = e.edad
        txtTel.Text = e.telefono
        cbHorario.SelectedItem = e.horario
        txtSalario.Text = e.salario

    End Sub


    ' Guardar cambios
    Private Sub buttonGuardar1_Click(sender As Object, e As EventArgs) Handles buttonGuardar1.Click

        Dim emp = obE.ActualizarEmpleado(txtIDE.Text, cbT.SelectedItem, txtIDS.Text, txtDNI.Text, txtNombre.Text,
                                        txtEdad.Text, txtTel.Text, cbHorario.SelectedItem, txtSalario.Text)

        If emp Then
            MessageBox.Show("Perfil de empleado editado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formEmpleados As FormInicio = CType(Owner, FormInicio)
        formEmpleados.listarEmpleado()
        Close()
    End Sub


End Class