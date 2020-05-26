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

    ' Coger al ultimo cliente
    Public Function idUltCliente()
        Dim row = obC.QryUltCliente()
        Dim ult As New CCliente(row)
        Return ult.idCliente
    End Function

    ' Crear id automático
    Public Function crearIDC()
        Dim idUlt As String = idUltCliente()
        Dim letra As Char = idUlt.Substring(0, 1)
        Dim num As Integer = idUlt.Substring(1, idUlt.Length - 1)
        Dim nuevoID As String

        If num < 999 Then
            num = num + 1
            nuevoID = letra + num.ToString().PadLeft(3, "0")
        Else
            letra = Chr(Asc(letra) + 1)
            nuevoID = letra + 1.ToString().PadLeft(3, "0")
        End If
        Return nuevoID
    End Function

    ' Id fijo para el idSuper
    Public Function idFijoSuper()
        Dim idS As String
        idS = "S001"
        Return idS
    End Function

End Class
