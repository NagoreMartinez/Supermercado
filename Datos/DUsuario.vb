Imports System.Data
Imports System.Data.OleDb
Imports Clases

Public Class DUsuario

    Private conectado As New DConexion

    ' Identificar a un usuario
    Function QryIdentificarUsuario(usuario As String, contraseña As String) As DataTable
        Dim query = "SELECT * FROM USUARIOS WHERE USUARIO LIKE @usuario AND CONTRASEÑA LIKE @contraseña"
        Dim conn = conectado.getConnection()
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
