Imports Datos
Imports Clases

Public Class FPedidos
    Dim obPd As New DPedidos

    ' Funcion que devuelve la lista de pedidos
    Public Function ListaPedidos() As DataTable
        Return obPd.QryListarPedidos()
    End Function

    ' Obtener producto por filtro
    Public Function ObtenerPedidosByFiltro(f As String) As DataTable
        Return obPd.QryByFiltro(f)
    End Function

    ' Insertar un producto
    Public Function InsertPedido(idPedido As String, idProducto As String, cantidad As Integer)
        Dim cp As New CPedidos(idPedido, idProducto, cantidad)

        Dim insP = obPd.CmdInsert(cp)
        Return insP
    End Function

    ' Actualizar un producto 
    Public Function ActualizarPedido(idPedido As String, idProducto As String, cantidad As Integer)
        Dim cp As New CPedidos(idPedido, idProducto, cantidad)

        Dim insP = obPd.CmdUpdate(cp)
        Return insP
    End Function

    ' Borrar un producto 
    Public Function EliminiarPedido(id As String)
        Return obPd.CmdDelete(id)
    End Function

    ' Coger el ultimo producto
    Public Function idUltPedido()
        Dim row = obPd.QryUltPedido()
        Dim ult As New CPedidos(row)
        Return ult.idPedido
    End Function

    ' Crear id automático
    Public Function crearIDPc()
        Dim idUlt As String = idUltPedido()
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
