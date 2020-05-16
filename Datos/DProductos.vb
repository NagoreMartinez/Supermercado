Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DProductos

    Dim conectadoProducto As New DConexion

    ' Listar los empleados
    Function ListarProductos() As DataTable
        Dim query = "SELECT * FROM PRODUCTOS"
        Dim conn = conectadoProducto.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nuevo producto
    Public Function InsertarPProducto(p As CProducto)
        Dim ok = False
        Dim conn = conectadoProducto.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO PRODUCTOS 
                 (IDPRODUCTO, NOMBRE, PRECIO, FECHACAD) VALUES 
                 (@idProducto, @nombre, @precio, @fechaCad)"
            cmd.Parameters.AddWithValue("@idProducto", p.idProducto)
            cmd.Parameters.AddWithValue("@nombre", p.nombre)
            cmd.Parameters.AddWithValue("@precio", p.precio)
            cmd.Parameters.AddWithValue("@fechaCad", p.fechaCad)
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
    Public Function ActualizarProducto(p As CProducto)
        Dim ok = False
        Dim conn = conectadoProducto.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE PRODUCTOS 
                SET 
                IDPRODUCTO =@idProducto,
                NOMBRE = @nombre,
                PRECIO = @precio,
                FECHA CADUCIDAD = @fechaCad
                WHERE IDPRODUCTO = @idProducto"
            cmd.Parameters.AddWithValue("@idProducto", p.idProducto)
            cmd.Parameters.AddWithValue("@nombre", p.nombre)
            cmd.Parameters.AddWithValue("@precio", p.precio)
            cmd.Parameters.AddWithValue("@fechaCad", p.fechaCad)
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

    ' Borrar a un producto
    Public Function BorrarProducto(id As String)
        Dim ok = False
        Dim conn = conectadoProducto.getConnection()
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
