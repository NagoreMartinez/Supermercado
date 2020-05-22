Imports Datos
Imports Clases

Public Class FClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ListaClientes() As DataTable
        Return DClientes.QryListarClientes()
    End Function

    ' Generar un cliente
    Public Function GenerarCliente(row As DataRow)
        Dim cliente As New CCliente(row)
        Return cliente
    End Function

    ' Insertar un cliente
    Public Function InsertarCliente(idCliente As String, idSuper As String, dni As String, nombre As String, telefono As String)
        Dim c As New CCliente(idCliente, idSuper, dni, nombre, telefono)

        Dim ins = DClientes.CmdInsert(c)
        Return ins
    End Function

    ' Obtener cliente por filtro
    Public Function ObtenerClientesByFiltro(f As String) As DataTable
        Return DClientes.QryByFiltro(f)
    End Function

    ' Actualizar un cliente 
    Public Function ActualizarCliente(idCliente As String, idSuper As String, dni As String, nombre As String, telefono As String)
        Dim c As New CCliente(idCliente, idSuper, dni, nombre, telefono)
        Dim upC = DClientes.CmdUpdate(c)
        Return upC
    End Function

    ' Borrar un cliente 
    Public Function EliminiarCliente(c As CCliente) As Integer
        Return DClientes.CmdDelete(c.ToString)
    End Function

End Class
