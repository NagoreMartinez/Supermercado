Imports Datos
Imports Clases

Public Class FProductos

    Dim obP As New DProductos

    ' Funcion que devuelve la lista de productos
    Public Function ListaProductos() As DataTable
        Return obP.QryListarProductos()
    End Function

    ' Obtener producto por filtro
    Public Function ObtenerPorductosByFiltro(f As String) As DataTable
        Return obP.QryByFiltro(f)
    End Function

    ' Insertar un producto
    Public Function InsertProducto(idProducto As String, nombre As String, precio As Double, fechaCaducidad As String)
        Dim p As New CProducto(idProducto, nombre, precio, fechaCaducidad)

        Dim insP = obP.CmdInsert(p)
        Return insP
    End Function

    ' Actualizar un producto 
    Public Function ActualizarProducto(idProducto As String, nombre As String, precio As Double, fechaCaducidad As String)
        Dim p As New CProducto(idProducto, nombre, precio, fechaCaducidad)

        Dim upP = obP.CmdUpdate(p)
        Return upP
    End Function

    ' Borrar un producto 
    Public Function EliminiarProducto(id As String)
        Return obP.CmdDelete(id)
    End Function

    ' Coger el ultimo producto
    Public Function idUltProducto()
        Dim row = obP.QryUltProducto()
        Dim ult As New CProducto(row)
        Return ult.idProducto
    End Function

    ' Crear id automático
    Public Function crearIDP()
        Dim idUlt As String = idUltProducto()
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


End Class
