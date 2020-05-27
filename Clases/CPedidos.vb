Public Class CPedidos
    ' Atributos
    Private idPd As String
    Private idP As String
    Private c As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idPedido As String, idProducto As String, cantidad As Integer)
        idPd = idPedido
        idP = idProducto
        c = cantidad

    End Sub

    Public Sub New(row As DataRow)
        idPd = row("IDPEDIDO")
        idP = row("IDPRODUCTO")
        c = row("CANTIDAD")

    End Sub

    ' Getters
    Public ReadOnly Property idPedido As String
        Get
            Return idPd
        End Get
    End Property

    Public ReadOnly Property idProducto As String
        Get
            Return idP
        End Get
    End Property

    Public ReadOnly Property cantidad As String
        Get
            Return c
        End Get
    End Property
End Class
