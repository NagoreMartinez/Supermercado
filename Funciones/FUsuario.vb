Imports Datos
Imports Clases

Public Class FUsuario
    Dim obU As New DUsuario

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
