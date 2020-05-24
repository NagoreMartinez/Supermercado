Public Class CUsuario
    Private idU As String
    Private us As String
    Private pw As String

    Public Sub New(idusuario As String, usuario As String, pw As String)
        idU = idusuario
        us = usuario
        pw = pw
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
            Return pw
        End Get
    End Property
End Class
