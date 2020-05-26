Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DClientes


    Dim conectado As New DConexion

    ' Listar los clientes
    Function QryListarClientes() As DataTable
        Dim query = "SELECT * FROM CLIENTES"
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
        Dim query = "SELECT * FROM CLIENTES
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

    'Insertar nuevo cliente
    Public Function CmdInsert(c As CCliente)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO CLIENTES 
                 (IDCLIENTE, IDSUPER, DNI, NOMBRE, TELEFONO) VALUES 
                 (@idCliente, @idSuper, @dni, @nombre, @telefono)"
            cmd.Parameters.AddWithValue("@idCliente", c.idCliente)
            cmd.Parameters.AddWithValue("@idSuper", c.idSuper)
            cmd.Parameters.AddWithValue("@dni", c.dni)
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
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
    Public Function CmdUpdate(c As CCliente)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE CLIENTES 
                SET 
                IDCLIENTE = @idCliente,
                IDSUPER = @idSuper,
                DNI = @dni,
                NOMBRE = @nombre,
                TELEFONO = @telefono 
                WHERE IDCLIENTE = @idCliente"
            cmd.Parameters.AddWithValue("@idCliente", c.idCliente)
            cmd.Parameters.AddWithValue("@idSuper", c.idSuper)
            cmd.Parameters.AddWithValue("@dni", c.dni)
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
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

    ' Borrar a un cliente
    Public Function CmdDelete(id As String)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM CLIENTES WHERE IDCLIENTE = @idCliente"
            cmd.Parameters.AddWithValue("@idCliente", id)
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

    ' Coger último cliente
    Function QryUltCliente() As DataRow
        Dim query = "SELECT * FROM CLIENTES AS C, (SELECT Max(IDCLIENTE) AS ULTIMO FROM CLIENTES) AS U WHERE C.IDCLIENTE LIKE U.ULTIMO"
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

