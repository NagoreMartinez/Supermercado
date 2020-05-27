Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DPedidos
    Dim conectado As New DConexion

    ' Lista de productos
    Function QryListarPedidos() As DataTable
        Dim query = "SELECT * FROM PEDIDOS"
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
        Dim query = "SELECT * FROM PEDIDOS
                        WHERE IDPEDIDO LIKE @idPedido OR IDPRODUCTO LIKE @idProducto OR CANTIDAD LIKE @cantidad"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idPedido", filtro + "%")
        sqlCommand.Parameters.AddWithValue("@idProducto", filtro + "%")
        sqlCommand.Parameters.AddWithValue("@cantidad", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nuevo pedido
    Public Function CmdInsert(cp As CPedidos)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO PEDIDOS 
                 (IDPEDIDO, IDPRODUCTO, CANTIDAD) VALUES 
                 (@idPedido, @idProducto, @cantidad)"
            cmd.Parameters.AddWithValue("@idPedido", cp.idPedido)
            cmd.Parameters.AddWithValue("@idProducto", cp.idProducto)
            cmd.Parameters.AddWithValue("@cantidad", cp.cantidad)
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
    Public Function CmdUpdate(cp As CPedidos)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE PEDIDOS 
                SET 
                IDPEDIDO =@idPedido,
                IDPRODUCTO = @idProducto,
                CANTIDAD = @cantidad,
                WHERE IDPEDIDO = @idPedido"
            cmd.Parameters.AddWithValue("@idPedido", cp.idPedido)
            cmd.Parameters.AddWithValue("@idProducto", cp.idProducto)
            cmd.Parameters.AddWithValue("@cantidad", cp.cantidad)
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
            cmd.CommandText = "DELETE FROM PEDIDOS WHERE IDPEDIDO = @idPedido"
            cmd.Parameters.AddWithValue("@idProducto", id)
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


    ' Coger ultimo producto
    Function QryUltPedido() As DataRow
        Dim query = "SELECT * FROM PEDIDOS AS P, (SELECT Max(IDPEDIDO) AS ULTIMO FROM PEDIDOS) AS U WHERE P.IDPEDIDO LIKE U.ULTIMO"
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
