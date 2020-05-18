Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DEmpleados

    Dim conectadoEmpleado As New DConexion

    ' Listar los empleados
    Function ListarEmpleados() As DataTable
        Dim query = "SELECT * FROM EMPLEADOS"
        Dim conn = conectadoEmpleado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nuevo empleado
    Public Function InsertarEmpleado(e As CEmpleado)
        Dim ok = False
        Dim conn = conectadoEmpleado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO EMPLEADOS 
                 (IDEMPLEADO, DNI, NOMBRE, EDAD, IDSUPER, IDTIPO, HORARIO, SALARIO) VALUES 
                 (@idEmpleado, @dni, @nombre, @edad, @idSuper, @idTipo, @horario, @salario)"
            cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado)
            cmd.Parameters.AddWithValue("@dni", e.dni)
            cmd.Parameters.AddWithValue("@nombre", e.nombre)
            cmd.Parameters.AddWithValue("@edad", e.edad)
            cmd.Parameters.AddWithValue("@idSuper", e.idSuper)
            cmd.Parameters.AddWithValue("@idTipo", e.idTipo)
            cmd.Parameters.AddWithValue("@horario", e.horario)
            cmd.Parameters.AddWithValue("@salario", e.salario)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' Actualizar informacion
    Public Function ActualizarEmpleado(e As CEmpleado)
        Dim ok = False
        Dim conn = conectadoEmpleado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE EMPLEADOS 
                SET 
                IDEMPLEADO =@idEmpleado,
                DNI = @dni,
                NOMBRE = @nombre,
                EDAD = @edad,
                IDSUPER = @idSuper,
                IDTIPO = @idTipo,
                HORARIO = @horario, 
                SALARIO = @salario
                WHERE IDEMPLEADO = @idEmpleado"
            cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado)
            cmd.Parameters.AddWithValue("@dni", e.dni)
            cmd.Parameters.AddWithValue("@nombre", e.nombre)
            cmd.Parameters.AddWithValue("@edad", e.edad)
            cmd.Parameters.AddWithValue("@idSuper", e.idSuper)
            cmd.Parameters.AddWithValue("@idTipo", e.idTipo)
            cmd.Parameters.AddWithValue("@horario", e.horario)
            cmd.Parameters.AddWithValue("@salario", e.salario)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' Borrar a un empleado
    Public Function BorrarEmpleado(id As String)
        Dim ok = False
        Dim conn = conectadoEmpleado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM EMPLEADOS WHERE IDEMPLEADO = @idEmpleado"
            cmd.Parameters.AddWithValue("@idEmpleado", id)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

End Class
