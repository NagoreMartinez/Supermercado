Imports Datos
Imports Clases

Public Class FClientes

    ' Crear el objeto de los datos del cliente
    Dim objCli As New DClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ListaClientes() As DataTable
        Return objCli.QryListarClientes()
    End Function

    ' Insertar un cliente
    Public Function insertCliente(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        Dim cliente As New CCliente(idCliente, dni, nombre, telefono, idSuper)

        Dim ins = objCli.CmdInsert(cliente)
        Return ins
    End Function

    ' Actualizar un cliente 
    Public Function updateCliente(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        Dim cliente As New CCliente(idCliente, dni, nombre, telefono, idSuper)

        Dim ok = objCli.CmdUpdate(cliente)
        Return ok
    End Function

    ' Borrar un cliente 
    Public Function deleteCliente(id As String)
        Dim del = objCli.CmdDelete(id)
        Return del
    End Function

    ' Generar un cliente
    Public Function generarCliente(row As DataRow)
        Dim cliente As New CCliente(row)
        Return cliente
    End Function

End Class
