Imports Datos
Imports Clases

Public Class FEmpleados

    ' Funcion que devuelve la lista de empleados
    Public Function ListaEmpleados() As DataTable
        Return DEmpleados.QryListarEmpleados()
    End Function

    ' Generar un empleado
    Public Function GenerarEmpleado(row As DataRow)
        Dim empleado As New CEmpleado(row)
        Return empleado
    End Function

    ' Insertar un empleado
    Public Function InsertEmpleado(idEmpleado As String, dni As String, nombre As String, edad As Integer,
                                  idSuper As String, idTipo As String, horario As String, salario As Double)
        Dim e As New CEmpleado(idEmpleado, dni, nombre, edad, idSuper, idTipo, horario, salario)

        Dim ins = DEmpleados.CmdInsert(e)
        Return ins
    End Function

    ' Obtener empleado por filtro
    Public Function ObtenerEmpleadosByFiltro(f As String) As DataTable
        Return DEmpleados.QryByFiltro(f)
    End Function

    ' Actualizar un empleado 
    Public Function ActualizarEmpleado(e As CEmpleado) As Integer
        Return DEmpleados.CmdUpdate(e)
    End Function

    ' Borrar un empleado 
    Public Function EliminiarEmpleado(e As CEmpleado) As Integer
        Return DEmpleados.CmdDelete(e.ToString)
    End Function

End Class
