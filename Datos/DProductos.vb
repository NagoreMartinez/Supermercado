Imports System.Data
Imports System.Data.OleDb

Public Module DProductos

    Dim conectado As New DConexion

    ' Lista de productos
    Function QryListarProductos() As DataTable
        Dim query = "SELECT * FROM PRODUCTOS"
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
        Dim query = "SELECT * FROM PRODUCTOS
                        WHERE NOMBRE LIKE @nombre"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@nombre", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function


    'Insertar nuevo producto
    Public Function CmdInsert(p As Clases.CProducto)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO PRODUCTOS 
                 (IDPRODUCTO, NOMBRE, PRECIO, FECHACAD) VALUES 
                 (@idProducto, @nombre, @precio, @fechaCad)"
            cmd.Parameters.AddWithValue("@idProducto", p.idProducto)
            cmd.Parameters.AddWithValue("@nombre", p.nombre)
            cmd.Parameters.AddWithValue("@precio", p.precio)
            cmd.Parameters.AddWithValue("@fechaCad", p.fechaCaducidad)
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

    ' Actualizar informacion del producto
    Public Function CmdUpdate(p As Clases.CProducto)
        Dim ok = False
        Dim conn = conectado.getConnection()
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
            cmd.Parameters.AddWithValue("@fechaCad", p.fechaCaducidad)
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

    ' Borrar un producto
    Public Function CmdDelete(id As String)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM PRODUCTOS WHERE IDPRODUCTO = @idProducto"
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


End Module
