Imports Datos
Imports Clases

Public Class FUsuario
    Dim obU As New DUsuario

    ' Comprobar si existe un usuario con ese nombre
    Public Function buscarUsuario(u As CUsuario) As Boolean
        Dim dt As DataTable = obU.QryBuscarUsuario(u)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ' Registrar un usuario
    Public Function registrarUsuario(u As CUsuario) As Boolean
        Dim ok As Boolean = obU.CmdInsertarUsuario(u)
        Return ok
    End Function

    ' Identificar a un usuario
    Public Function identificarUsuario(usuario As String, contraseña As String) As Boolean
        Dim dt As DataTable = obU.QryIdentificarUsuario(usuario, contraseña)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
