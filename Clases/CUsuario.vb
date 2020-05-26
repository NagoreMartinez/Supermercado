Public Class CUsuario
    Private idU As String
    Private us As String
    Private password As String

    Public Sub New(idusuario As String, usuario As String, contraseña As String)
        idU = idusuario
        us = usuario
        password = contraseña
    End Sub

    Public ReadOnly Property idUsuario As String
        Get
            Return idU
        End Get
    End Property

    Public ReadOnly Property usuario As String
        Get
            Return us
        End Get
    End Property


    Public ReadOnly Property contraseña As String
        Get
            Return password
        End Get
    End Property
End Class
