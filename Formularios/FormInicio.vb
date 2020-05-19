Public Class FormInicio
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonEmpleados.Click
        FormEmpleados.ShowDialog()

    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles Clientes.Click
        FormClientes.ShowDialog()

    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        FormProductos.showDialog()
    End Sub
End Class