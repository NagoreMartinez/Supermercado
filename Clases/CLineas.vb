Public Class CLineas

    ' Atributos
    Private idCp As String
    Private idP As String
    Private cant As Integer

    ' Constructoras
    Public Sub New()

    End Sub

    Public Sub New(idCompra As String, idProducto As String, cantidad As Integer)
        idCp = idCompra
        idP = idProducto
        cant = cantidad
    End Sub

    Public Sub New(row As DataRow)
        idCp = row("IDCOMPRA")
        idP = row("IDPRODUCTO")
        cant = row("CANTIDAD")
    End Sub

    ' Getters

    Public ReadOnly Property idCompra As String
        Get
            Return idCp
        End Get
    End Property

    Public ReadOnly Property idProducto As String
        Get
            Return idP
        End Get
    End Property

    Public ReadOnly Property cantidad As Integer
        Get
            Return cant
        End Get
    End Property



End Class
