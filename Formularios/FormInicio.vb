Imports Funciones
Imports Datos
Imports Clases
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

    ' Nuevo empleado
    Private Sub NuevoEmpleado_Click(sender As Object, e As EventArgs) Handles NuevoEmpleado.Click
        Dim FormNEmpleado As New FormEmpleados()
        AddOwnedForm(FormNEmpleado)
        FormNEmpleado.ShowDialog()
    End Sub

    ' Ver/Editar empleado
    Private Sub EditarPEmpleado_Click(sender As Object, e As EventArgs) Handles EditarPEmpleado.Click
        editarEmpleado()
    End Sub

    Sub editarEmpleado()
        If dgvEmpleados.SelectedRows.Count = 0 Then
            Dim row = dgvEmpleados.CurrentRow
            Dim idEmpleado = row.Cells(0).Value.ToString
            Dim idTipo = row.Cells(1).Value.ToString
            Dim idSuper = row.Cells(2).Value.ToString
            Dim dni = row.Cells(3).Value.ToString
            Dim nombre = row.Cells(4).Value.ToString
            Dim edad = row.Cells(5).Value.ToString
            Dim horario = row.Cells(6).Value.ToString
            Dim salario = row.Cells(7).Value.ToString

            Dim e As New CEmpleado(idEmpleado, idTipo, idSuper, dni, nombre, edad, horario, salario)
            Dim formEEmpleado As New FormEditarEmpleado(e)
            AddOwnedForm(formEEmpleado)
            formEEmpleado.ShowDialog()
        Else
            MessageBox.Show("Selecione una fila para poder editar el perfil")
        End If
    End Sub

    ' Eliminar empleado
    Private Sub EliminarEmpleado_Click(sender As Object, e As EventArgs) Handles EliminarEmpleado.Click
        If dgvEmpleados.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim dni = row.Cells(3).Value.ToString
            Dim nombre = row.Cells(4).Value.ToString

            Dim formBEmpleado As New s(dni, nombre)
            AddOwnedForm(formBEmpleado)
            formBEmpleado.ShowDialog()

        Else
            MessageBox.Show("Sleccione una fila para borrar el perfil")
        End If
    End Sub


    ' LISTENERS CLIENTES

    ' Listar clientes
    Sub listarClientes()
        dgvClientes.DataSource = Clientes.ListaClientes()
    End Sub

    ' Buscar cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvClientes.DataSource = Clientes.ObtenerClientesByFiltro(BuscarCliente.Text)
    End Sub

    ' Nuevo cliente
    Private Sub NuevoCliente_Click(sender As Object, e As EventArgs) Handles NuevoCliente.Click
        Dim FormNCliente As New FormClientes()
        AddOwnedForm(FormNCliente)
        FormNCliente.ShowDialog()
    End Sub

    ' Ver/editar perfil
    Private Sub EditarPCliente_Click(sender As Object, e As EventArgs) Handles EditarPCliente.Click
        editarCliente()
    End Sub

    Sub editarCliente()
        If dgvClientes.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim idCliente = row.Cells(0).Value.ToString
            Dim idSuper = row.Cells(1).Value.ToString
            Dim dni = row.Cells(2).Value.ToString
            Dim nombre = row.Cells(3).Value.ToString
            Dim telefono = row.Cells(4).Value.ToString

            Dim c As New CCliente(idCliente, idSuper, dni, nombre, telefono)
            Dim formECliente As New FormEditarCliente(c)
            AddOwnedForm(formECliente)
            formECliente.ShowDialog()
        Else
            MessageBox.Show("Selecione una fila para poder editar el perfil")
        End If
    End Sub

    ' Eliminar cliente
    Private Sub EliminarCliente_Click(sender As Object, e As EventArgs) Handles EliminarCliente.Click
        If dgvClientes.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim dni = row.Cells(2).Value.ToString
            Dim nombre = row.Cells(3).Value.ToString

            Dim formBCliente As New FormEliminarCliente(dni, nombre)
            AddOwnedForm(formBCliente)
            formBCliente.ShowDialog()

        Else
            MessageBox.Show("Sleccione una fila para borrar el perfil")
        End If
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

    ' Nuevo producto
    Private Sub NuevoProducto_Click(sender As Object, e As EventArgs) Handles NuevoProducto.Click
        Dim FormNProducto As New FormProductos()
        AddOwnedForm(FormNProducto)
        FormNProducto.ShowDialog()
    End Sub

    ' Ver/editar producto
    Private Sub EditarPProducto_Click(sender As Object, e As EventArgs) Handles EditarPProducto.Click
        editarProducto()
    End Sub

    Sub editarProducto()
        If dgvProductos.SelectedRows.Count = 0 Then
            Dim row = dgvProductos.CurrentRow
            Dim idProducto = row.Cells(0).Value.ToString
            Dim nombre = row.Cells(1).Value.ToString
            Dim precio = row.Cells(2).Value.ToString
            Dim fechaCaducidad = row.Cells(3).Value.ToString

            Dim p As New CProducto(idProducto, nombre, precio, fechaCaducidad)
            Dim formEProducto As New FormEditarProductos(p)
            AddOwnedForm(formEProducto)
            formEProducto.ShowDialog()
        Else
            MessageBox.Show("Selecione una fila para poder editar los datos")
        End If
    End Sub

    ' Eliminar producto
    Private Sub EliminarProducto_Click(sender As Object, e As EventArgs) Handles EliminarProducto.Click
        If dgvProductos.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim nombre = row.Cells(2).Value.ToString

            Dim formBProducto As New FormEliminarProducto(nombre)
            AddOwnedForm(formBProducto)
            formBProducto.ShowDialog()

        Else
            MessageBox.Show("Sleccione una fila para borrar el perfil")
        End If
    End Sub



End Class