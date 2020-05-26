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

End Class
