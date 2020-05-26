Imports Datos
Imports Clases

Public Class FEmpleados
    Private obE As New DEmpleados

    ' Funcion que devuelve la lista de empleados
    Public Function ListaEmpleados() As DataTable
        Return obE.QryListarEmpleados()
    End Function

    ' Obtener empleado por filtro
    Public Function ObtenerEmpleadosByFiltro(f As String) As DataTable
        Return obE.QryByFiltro(f)
    End Function

    ' Insertar un empleado
    Public Function InsertEmpleado(idEmpleado As String, idTipo As String, idSuper As String, dni As String, nombre As String, edad As Integer,
                                   telefono As String, horario As String, salario As Double)
        Dim e As New CEmpleado(idEmpleado, idTipo, idSuper, dni, nombre, edad, telefono, horario, salario)

        Dim ins = obE.CmdInsert(e)
        Return ins
    End Function

    ' Actualizar un empleado 
    Public Function ActualizarEmpleado(idEmpleado As String, idTipo As String, idSuper As String, dni As String,
                                       nombre As String, edad As Integer, telefono As String, horario As String, salario As Double)
        Dim e As New CEmpleado(idEmpleado, idTipo, idSuper, dni, nombre, edad, telefono, horario, salario)
        Dim upE = obE.CmdUpdate(e)
        Return upE
    End Function

    ' Borrar un empleado 
    Public Function EliminiarEmpleado(id As String)
        Return obE.CmdDelete(id)
    End Function

    ' Coger al ultimo empleado
    Public Function idUltEmpleado()
        Dim row = obE.QryUltEmpleado()
        Dim ult As New CEmpleado(row)
        Return ult.idEmpleado
    End Function

    ' Crear id automático
    Public Function crearIDE()
        Dim idUlt As String = idUltEmpleado()
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
