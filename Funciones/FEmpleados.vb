Imports Datos
Imports Clases

Public Class FEmpleados

    ' Creamos el objeto de la capa datos
    Dim objDatos As New DEmpleados

    ' Funcion que devuelve la lista de empleados
    Public Function ListaEmpleados() As DataTable
        Return objDatos.QryListarClientes()
    End Function

    ' Insertar un empleado
    Public Function insertEmpleado(idEmpleado As String, dni As String, nombre As String, edad As Integer, idSuper As String, idTipo As String, horario As String, salario As Double)
        Dim cliente As New CEmpleado(idEmpleado, dni, nombre, edad, idSuper, idTipo, horario, salario)

        Dim ok = objDatos.CmdInsert(cliente)
        Return ok
    End Function

    ' Actualizar un empleado 
    Public Function updateEmpleado(idEmpleado As String, dni As String, nombre As String, edad As Integer, idSuper As String, idTipo As String, horario As String, salario As Double)
        Dim cliente As New CEmpleado(idEmpleado, dni, nombre, edad, idSuper, idTipo, horario, salario)

        Dim ok = objDatos.CmdUpdate(cliente)
        Return ok
    End Function

    ' Borrar un empleado 
    Public Function deleteEmpleado(id As String)
        Dim ok = objDatos.CmdDelete(id)
        Return ok
    End Function


    ' Crear id de un nuevo empleado
    Public Function crearId()
        Dim ultID As String = idUltCliente()
        Dim letra As Char = ultID.Substring(0, 1)
        Dim num As Integer = ultID.Substring(1, ultID.Length - 1)
        Dim newID As String

        If num < 999 Then
            num = num + 1
            newID = letra + num.ToString().PadLeft(3, "0")
        Else
            letra = Chr(Asc(letra) + 1)
            newID = letra + 1.ToString().PadLeft(3, "0")
        End If
        Return newID
    End Function

    ' Generar una instancia de un empleado
    Public Function generarEmpleado(row As DataRow)
        Dim empleado As New CEmpleado(row)
        Return empleado
    End Function

End Class
