Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DClientes
    Dim conectadoCliente As New DConexion

    ' Listar los clientes
    Function ListarClientes() As DataTable
        Dim query = "SELECT * FROM CLIENTES"
        Dim conn = conectadoCliente.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nuevo cliente
    Public Function InsertarCliente(c As CCliente)
        Dim ok = False
        Dim conn = conectadoCliente.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO CLIENTES 
                 (IDCLIENTE, DNI, NOMBRE, TELEFONO, IDSUPER) VALUES 
                 (@idCliente, @dni, @nombre, @telefono, @idSuper)"
            cmd.Parameters.AddWithValue("@idCliente", c.idCliente)
            cmd.Parameters.AddWithValue("@dni", c.dni)
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
            cmd.Parameters.AddWithValue("@idSuper", c.idSuper)
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
    Public Function ActualizarCliente(c As CCliente)
        Dim ok = False
        Dim conn = conectadoCliente.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE CLIENTES 
                SET 
                IDCLIENTE =@idCliente,
                DNI = @dni,
                NOMBRE = @nombre,
                TELEFONO = @telefono,
                IDSUPER = @idSuper
                WHERE IDCLIENTE = @idCliente"
            cmd.Parameters.AddWithValue("@idCliente", c.idCliente)
            cmd.Parameters.AddWithValue("@dni", c.dni)
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
            cmd.Parameters.AddWithValue("@idSuper", c.idSuper)
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
    Public Function BorrarCliente(id As String)
        Dim ok = False
        Dim conn = conectadoCliente.getConnection()
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

End Class
