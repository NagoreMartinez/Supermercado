Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DEmpleados

    Dim conectado As New DConexion

    ' Listar los empleados
    Function QryListarEmpleados() As DataTable
        Dim query = "SELECT * FROM EMPLEADOS"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Buscar por filtro
    Public Function QryByFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM EMPLEADOS
                        WHERE NOMBRE LIKE @nombre OR DNI LIKE @dni"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@nombre", filtro + "%")
        sqlCommand.Parameters.AddWithValue("@dni", "%" + filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nuevo empleado
    Public Function CmdInsert(e As CEmpleado)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO EMPLEADOS 
                 (IDEMPLEADO, IDTIPO, IDSUPER, DNI, NOMBRE, EDAD, TELEFONO, HORARIO, SALARIO MENSUAL) VALUES 
                 (@idEmpleado, @idTipo, @idSuper, @dni, @nombre, @edad, @telefono, @horario, @salario)"
            cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado)
            cmd.Parameters.AddWithValue("@idTipo", e.idTipo)
            cmd.Parameters.AddWithValue("@idSuper", e.idSuper)
            cmd.Parameters.AddWithValue("@dni", e.dni)
            cmd.Parameters.AddWithValue("@nombre", e.nombre)
            cmd.Parameters.AddWithValue("@edad", e.edad)
            cmd.Parameters.AddWithValue("@telefono", e.telefono)
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
    Public Function CmdUpdate(e As CEmpleado)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE EMPLEADOS 
                SET 
                IDEMPLEADO =@idEmpleado,
                IDTIPO = @idTipo,
                IDSUPER = @idSuper,
                DNI = @dni,
                NOMBRE = @nombre,
                EDAD = @edad,
                TELEFONO = @telefono,
                HORARIO = @horario, 
                SALARIO MENSUAL = @salario
                WHERE IDEMPLEADO = @idEmpleado"
            cmd.Parameters.AddWithValue("@idEmpleado", e.idEmpleado)
            cmd.Parameters.AddWithValue("@idTipo", e.idTipo)
            cmd.Parameters.AddWithValue("@idSuper", e.idSuper)
            cmd.Parameters.AddWithValue("@dni", e.dni)
            cmd.Parameters.AddWithValue("@nombre", e.nombre)
            cmd.Parameters.AddWithValue("@edad", e.edad)
            cmd.Parameters.AddWithValue("@telefono", e.telefono)
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
    Public Function CmdDelete(id As String)
        Dim ok = False
        Dim conn = conectado.getConnection()
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

    ' Coger ultimo empleado
    Function QryUltEmpleado() As DataRow
        Dim query = "SELECT * FROM EMPLEADOS AS E, (SELECT Max(IDEMPLEADO) AS ULTIMO FROM EMPLEADOS) AS U WHERE E.IDEMPLEADO LIKE U.ULTIMO"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Dim row = table.Select.FirstOrDefault()
        Return row
    End Function


End Class
