Imports Datos
Imports Clases

Public Class FProductos

    ' Crear el objeto de los datos del producto
    Dim objPro As New DProductos

    ' Funcion que devuelve la lista de productos
    Public Function ObtenerProductos() As DataTable
        Return objPro.QryListarProductos()
    End Function

    ' Insertar un nuevo producto
    Public Function insertProducto(idProducto As String, nombre As String, precio As Double, fechaCad As String)
        Dim producto As New CProducto(idProducto, nombre, precio, fechaCad)

        Dim ins = objPro.CmdInsert(producto)
        Return ins
    End Function

    ' Actualizar un producto 
    Public Function updateProducto(idProducto As String, nombre As String, precio As Double, fechaCad As String)
        Dim producto As New CProducto(idProducto, nombre, precio, fechaCad)

        Dim upd = objPro.CmdUpdate(producto)
        Return upd
    End Function

    ' Borrar un producto
    Public Function deleteProducto(id As String)
        Dim del = objPro.CmdDelete(id)
        Return del
    End Function

    ' Funcion que comprueba si existe un id de producto
    Public Function comprobarId(id As String)
        Dim res = objPro.QryBuscarId(id)
        Dim valido = False
        If res.Rows.Count = 0 Then
            valido = True
        End If
        Return valido
    End Function

    ' Generar un producto
    Public Function generarCliente(row As DataRow)
        Dim producto As New CProducto(row)
        Return producto
    End Function

End Class
