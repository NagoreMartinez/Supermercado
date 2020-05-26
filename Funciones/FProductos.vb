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


End Class
