Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DCompras

    Dim conectado As New DConexion

    ' Lista de compras
    Function QryListarCompras() As DataTable
        Dim query = "SELECT * FROM COMPRAS"
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

    'Buscar por fecha
    Public Function QryByFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM COMPRAS 
                        WHERE FECHA LIKE @fecha"
        Dim conn = conectado.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@fecha", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Insertar nueva compra
    Public Function CmdInsert(cp As CCompras)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO COMPRAS 
                 (IDCOMPRA, IDCLIENTE, IDCAJA, IMPORTE, FECHA) VALUES 
                 (@idCompra, @idCliente, @idCaja, @importe, @fecha)"
            cmd.Parameters.AddWithValue("@idCompra", cp.idCompra)
            cmd.Parameters.AddWithValue("@idCliente", cp.idCliente)
            cmd.Parameters.AddWithValue("@idCaja", cp.idCaja)
            cmd.Parameters.AddWithValue("@importe", cp.importe)
            cmd.Parameters.AddWithValue("@fecha", cp.fecha)
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
    Public Function CmdUpdate(cp As CCompras)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE COMPRAS 
                SET 
                IDCOMPRA= @idCompra
                IDCLIENTE=@idCliente
                IDCAJA=@idCaja
                IMPORTE = @importe
                FECHA = @fecha
                WHERE IDCOMPRA = @idCompra"
            cmd.Parameters.AddWithValue("@idCompra", cp.idCompra)
            cmd.Parameters.AddWithValue("@idCliente", cp.idCliente)
            cmd.Parameters.AddWithValue("@idCaja", cp.idCaja)
            cmd.Parameters.AddWithValue("@importe", cp.importe)
            cmd.Parameters.AddWithValue("@fecha", cp.fecha)
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

    ' Borrar una compra
    Public Function CmdDelete(id As String)
        Dim ok = False
        Dim conn = conectado.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM COMPRAS WHERE IDCOMPRA = @idCompra"
            cmd.Parameters.AddWithValue("@idCompra", id)
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
