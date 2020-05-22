Imports Funciones

Public Class FormEliminarEmpleado

    Dim obE As New FEmpleados

    Public Sub New(id As String, nombre As String)

        InitializeComponent()

        txtIDE.Text = id
        txtNombre.Text = nombre

    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click

        Dim id As String = txtIDE.Text
        Dim del = obE.EliminiarEmpleado(id)

        If del Then
            MessageBox.Show("Se ha eliminado el perfil del empleado correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formEmpleados As FormInicio = CType(Owner, FormInicio)
        formEmpleados.listarEmpleado()
        Close()

    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        Close()
    End Sub

End Class