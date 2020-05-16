Imports Datos
Imports Clases

Public Class FProductos

    Dim objDatos As New DProductos

    ' Funcion que devuelve la lista de productos
    Public Function ObtenerProductos() As DataTable
        Return objDatos.QryListarProductos()
    End Function

    ' Funcion para determinar el id de un nuevo producto
    Public Function idProducto(nombre As String)
        Dim id = ""
        If nombre.Length > 0 Then
            If nombre.Length = 1 Then
                id = nombre.Substring(0, 1)
            ElseIf nombre.Length = 2 Then
                id = nombre.Substring(0, 2)
            ElseIf nombre.Length = 3 Then
                id = nombre.Substring(0, 3)
            Else
                id = nombre.Substring(0, 4)
            End If
        End If
        Return id
    End Function

    ' Insertar un nuevo producto
    Public Function insertProducto(idProducto As String, nombre As String, precio As Double, fechaCad As String)
        Dim producto As New CProducto(idProducto, nombre, precio, fechaCad)

        Dim ok = objDatos.CmdInsert(producto)
        Return ok
    End Function

    ' Actualizar un producto 
    Public Function updateProducto(idProducto As String, nombre As String, precio As Double, fechaCad As String)
        Dim producto As New CProducto(idProducto, nombre, precio, fechaCad)

        Dim ok = objDatos.CmdUpdate(producto)
        Return ok
    End Function

    ' Borrar un producto
    Public Function deleteProducto(id As String)
        Dim ok = objDatos.CmdDelete(id)
        Return ok
    End Function

    ' Funcion que comprueba si existe un id de producto
    Public Function comprobarId(id As String)
        Dim res = objDatos.QryBuscarId(id)
        Dim valido = False
        If res.Rows.Count = 0 Then
            valido = True
        End If
        Return valido
    End Function

    ' Generar una instancia de un producto
    Public Function generarCliente(row As DataRow)
        Dim producto As New CProducto(row)
        Return producto
    End Function

End Class
