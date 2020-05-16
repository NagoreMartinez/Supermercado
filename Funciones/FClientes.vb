Imports Datos
Imports Clases

Public Class FClientes
    ' Creamos el objeto de la capa datos
    Dim objDatos As New DClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerClientes() As DataTable
        Return objDatos.QryListarClientes()
    End Function

    ' Funcion que devuelve la lista de clientes segun parametro de entrada
    Public Function ObtenerClientesFiltro(filtro As String) As DataTable
        Return objDatos.QryListarClientesFiltro(filtro)
    End Function

    ' Función para insertar un tipo de cliente en la BD
    Public Function insertCliente(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        Dim cliente As New CCliente(idCliente, dni, nombre, telefono, idSuper)

        Dim ok = objDatos.CmdInsert(cliente)
        Return ok
    End Function

    ' Funcion para actualizar un cliente en la BD
    Public Function updateCliente(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        Dim cliente As New CCliente(idCliente, dni, nombre, telefono, idSuper)

        Dim ok = objDatos.CmdUpdate(cliente)
        Return ok
    End Function

    ' Funcion para eliminar un cliente de la BD
    Public Function deleteCliente(id As String)
        Dim ok = objDatos.CmdDelete(id)
        Return ok
    End Function

    'Función para obtener RE
    Public Function reSeleccionado(cb As Boolean)

        If cb Then
            Return -1
        Else
            Return 0
        End If
    End Function

    ' Funcion para obtener el ultimo registro de clientes
    Public Function idUltCliente()
        Dim row = objDatos.QryUltimoCliente
        Dim ultimo As New CCliente(row)
        Return ultimo.idcliente
    End Function

    ' Funcion para obtener el id de un nuevo cliente
    Public Function nuevoID()
        Dim ultID As String = idUltCliente()
        Dim letra As Char = ultID.Substring(0, 1)
        Dim num As Integer = ultID.Substring(1, ultID.Length - 1)
        Dim newID As String

        If num < 999 Then
            num = num + 1
            newID = letra + num.ToString().PadLeft(3, "0")
        Else
            letra = Chr(Asc(letra) + 1)
            newID = letra + 1.ToString().PadLeft(3, "0")
        End If
        Return newID
    End Function

    ' Funcion para generar una instancia de un cliente
    Public Function generarCliente(row As DataRow)
        Dim cliente As New CCliente(row)
        Return cliente
    End Function

End Class
