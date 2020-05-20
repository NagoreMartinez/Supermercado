Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelInicio.Show()

    End Sub

    Private Sub PanelInicio_Paint(sender As Object, e As PaintEventArgs) Handles PanelInicio.Paint
        ButtonEmpleados.Show()
        ButtonClientes.Show()
        ButtonProductos.Show()

    End Sub
    Private Sub ButtonEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonEmpleados.Click
        POpcionesEmpleado.Show()
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        FormClientes.ShowDialog()

    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        FormProductos.ShowDialog()
    End Sub

    Private Sub POpcionesEmpleado_Paint(sender As Object, e As PaintEventArgs) Handles POpcionesEmpleado.Paint
        NuevoEmpleado.Show()
        VerEmpleado.Show()
    End Sub

    Private Sub NuevoEmpleado_Click(sender As Object, e As EventArgs) Handles NuevoEmpleado.Click

    End Sub

    Private Sub VerEmpleado_Click(sender As Object, e As EventArgs) Handles VerEmpleado.Click

    End Sub
End Class