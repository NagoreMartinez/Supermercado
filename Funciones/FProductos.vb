Imports Datos
Imports Clases

Public Class FProductos

    ' Funcion que devuelve la lista de productos
    Public Function ListaProductos() As DataTable
        Return DProductos.QryListarProductos()
    End Function

    ' Generar un producto
    Public Function GenerarProducto(row As DataRow)
        Dim producto As New CProducto(row)
        Return producto
    End Function

    ' Insertar un producto
    Public Function InsertProducto(idProducto As String, nombre As String, precio As Double, fechaCaducidad As String)
        Dim p As New CProducto(idProducto, nombre, precio, fechaCaducidad)

        Dim insP = DProductos.CmdInsert(p)
        Return insP
    End Function

    ' Obtener producto por filtro
    Public Function ObtenerPorductosByFiltro(f As String) As DataTable
        Return DProductos.QryByFiltro(f)
    End Function

    ' Actualizar un producto 
    Public Function ActualizarProducto(idProducto As String, nombre As String, precio As Double, fechaCaducidad As String) As Integer
        Dim p As New CProducto(idProducto, nombre, precio, fechaCaducidad)

        Dim upP = DProductos.CmdUpdate(p)
        Return upP
    End Function

    ' Borrar un producto 
    Public Function EliminiarProducto(p As CProducto) As Integer
        Return DProductos.CmdDelete(p.ToString)
    End Function


End Class
