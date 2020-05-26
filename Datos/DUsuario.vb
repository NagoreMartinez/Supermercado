Imports Clases
Imports System.Data
Imports System.Data.OleDb

Public Class DUsuario

    Private conexion As New DConexion

    ' Comprobar si un usuario ya existe
    Function QryBuscarUsuario(u As CUsuario) As DataTable
        Dim query = "SELECT * FROM USUARIOS WHERE USUARIO LIKE @usuario"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@usuario", u.usuario)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Registrar nuevo usuario
    Function CmdInsertarUsuario(u As CUsuario)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO USUARIOS 
                 (IDUSUARIO, USUARIO, CONTRASEÑA) VALUES 
                 (@idUsuario, @usuario, @contraseña)"
            cmd.Parameters.AddWithValue("@idUsuario", u.idUsuario)
            cmd.Parameters.AddWithValue("@usuario", u.usuario)
            cmd.Parameters.AddWithValue("@contraseña", u.contraseña)
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

    ' Identificar a un usuario
    Function QryIdentificarUsuario(usuario As String, contraseña As String) As DataTable
        Dim query = "SELECT * FROM USUARIOS WHERE USUARIO LIKE @usuario AND CONTRASEÑA LIKE @contraseña"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@usuario", usuario)
        sqlCommand.Parameters.AddWithValue("@contraseña", contraseña)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

End Class
