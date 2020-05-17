Imports Datos
Imports Clases

Public Class FEmpleados

    ' Crear el objeto de los datos de empleado
    Dim objEmp As New DEmpleados

    ' Funcion que devuelve la lista de empleados
    Public Function ListaEmpleados() As DataTable
        Return objEmp.QryListarClientes()
    End Function

    ' Insertar un empleado
    Public Function insertEmpleado(idEmpleado As String, dni As String, nombre As String, edad As Integer, idSuper As String, idTipo As String, horario As String, salario As Double)
        Dim cliente As New CEmpleado(idEmpleado, dni, nombre, edad, idSuper, idTipo, horario, salario)

        Dim ins = objEmp.CmdInsert(cliente)
        Return ins
    End Function

    ' Actualizar un empleado 
    Public Function updateEmpleado(idEmpleado As String, dni As String, nombre As String, edad As Integer, idSuper As String, idTipo As String, horario As String, salario As Double)
        Dim cliente As New CEmpleado(idEmpleado, dni, nombre, edad, idSuper, idTipo, horario, salario)

        Dim upd = objEmp.CmdUpdate(cliente)
        Return upd
    End Function

    ' Borrar un empleado 
    Public Function deleteEmpleado(id As String)
        Dim del = objEmp.CmdDelete(id)
        Return del
    End Function


    ' Generar un empleado
    Public Function generarEmpleado(row As DataRow)
        Dim empleado As New CEmpleado(row)
        Return empleado
    End Function

End Class
