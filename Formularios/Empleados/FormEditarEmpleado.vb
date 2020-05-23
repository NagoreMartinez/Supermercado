Imports Clases
Imports Funciones

Public Class FormEditarEmpleado
    Dim Empleados As New FEmpleados

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(e As CEmpleado)

        Me.New

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDE.Text = e.idEmpleado
        txtIDT.Text = e.idTipo
        txtIDS.Text = e.idSuper
        txtDNI.Text = e.dni
        txtNombre.Text = e.nombre
        txtEdad.Text = e.edad
        txtHorario.Text = e.horario
        txtSalario.Text = e.salario

    End Sub


    ' Guardar cambios
    Private Sub buttonGuardar1_Click(sender As Object, e As EventArgs) Handles buttonGuardar1.Click

        Dim em = Empleados.ActualizarEmpleado(txtIDE.Text, txtIDT.Text, txtIDS.Text, txtDNI.Text,
                                             txtNombre.Text, txtEdad.Text, txtHorario.Text, txtSalario.Text)

        If em Then
            MessageBox.Show("Se ha actualizado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formEmpleados As FormInicio = CType(Owner, FormInicio)
        formEmpleados.listarEmpleado()
        Close()
    End Sub


End Class