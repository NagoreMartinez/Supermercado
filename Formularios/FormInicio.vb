Imports Funciones
Imports Datos
Public Class FormInicio

    Dim Clientes As New FClientes
    Dim Empleados As New FEmpleados
    Dim Productos As New FProductos


    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SupermercadoDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.SupermercadoDataSet.EMPLEADOS)
        'TODO: esta línea de código carga datos en la tabla 'SupermercadoDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.SupermercadoDataSet.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'SupermercadoDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.SupermercadoDataSet.CLIENTES)
        QryListarEmpleados()
        QryListarClientes()
        QryListarProductos()
        PanelEmpleados.Show()
        PanelClientes.Hide()
        PanelProductos.Hide()

    End Sub

    Private Sub ButtonEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonEmpleados.Click
        PanelEmpleados.Show()
        PanelClientes.Hide()
        PanelProductos.Hide()
    End Sub

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        PanelClientes.Show()
        PanelEmpleados.Hide()
        PanelProductos.Hide()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        PanelProductos.Show()
        PanelEmpleados.Hide()
        PanelClientes.Hide()
    End Sub

    ' LISTENERS  EMPLEADOS

    ' Listar empleados

    Sub listarEmpleado()
        dgvEmpleados.DataSource = Empleados.ListaEmpleados()
    End Sub

    ' Buscar empleado
    Private Sub BuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles BuscarEmpleado.TextChanged
        dgvEmpleados.DataSource = Empleados.ObtenerEmpleadosByFiltro(BuscarEmpleado.Text)
    End Sub




    ' LISTENERS CLIENTES

    ' Listar clientes
    Sub listarClientes()
        dgvClientes.DataSource = Clientes.ListaClientes()
    End Sub

    ' Buscar cliente
    Private Sub BuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles BuscarCliente.TextChanged
        dgvClientes.DataSource = Clientes.ObtenerClientesByFiltro(BuscarCliente.Text)
    End Sub




    ' LISTENERS PRODUCTOS

    ' Listar productos
    Sub listarProductos()
        dgvProductos.DataSource = Productos.ListaProductos
    End Sub

    ' Buscar producto
    Private Sub BuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles BuscarProducto.TextChanged
        dgvProductos.DataSource = Productos.ObtenerPorductosByFiltro(BuscarProducto.Text)
    End Sub



End Class