Imports Datos
Imports Clases

Public Class FCompras
    Dim obCp As New DCompras

    ' Funcion que devuelve la lista de productos
    Public Function ListaCompras() As DataTable
        Return obCp.QryListarCompras()
    End Function

    ' Obtener producto por filtro
    Public Function ObtenerComprasByFiltro(f As String) As DataTable
        Return obCp.QryByFiltro(f)
    End Function

End Class
