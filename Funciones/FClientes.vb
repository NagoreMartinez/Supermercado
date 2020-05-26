Imports Datos
Imports Clases

Public Class FClientes

    Private obC As New DClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ListaClientes() As DataTable
        Return obC.QryListarClientes()
    End Function

    ' Obtener cliente por filtro
    Public Function ObtenerClientesByFiltro(f As String) As DataTable
        Return obC.QryByFiltro(f)
    End Function

    ' Insertar un cliente
    Public Function InsertarCliente(idCliente As String, idSuper As String, dni As String, nombre As String, telefono As String)
        Dim c As New CCliente(idCliente, idSuper, dni, nombre, telefono)

        Dim insC = obC.CmdInsert(c)
        Return insC
    End Function

    ' Actualizar un cliente 
    Public Function ActualizarCliente(idCliente As String, idSuper As String, dni As String, nombre As String, telefono As String)
        Dim c As New CCliente(idCliente, idSuper, dni, nombre, telefono)

        Dim upC = obC.CmdUpdate(c)
        Return upC
    End Function

    ' Borrar un cliente 
    Public Function EliminiarCliente(id As String)
        Return obC.CmdDelete(id)
    End Function

End Class
