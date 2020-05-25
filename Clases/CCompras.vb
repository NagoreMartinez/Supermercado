Public Class CCompras

    ' Atributos
    Private idCp As String
    Private idC As String
    Private idCj As String
    Private imp As Double
    Private f As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idCompra As String, idCliente As String, idCaja As String, importe As Double, fecha As String)
        idCp = idCompra
        idC = idCliente
        idCj = idCaja
        imp = importe
        f = fecha
    End Sub

    Public Sub New(row As DataRow)
        idCp = row("IDCOMPRA")
        idC = row("IDCLIENTE")
        idCj = row("IDCAJA")
        imp = row("IMPORTE")
        f = row("FECHA")
    End Sub

    ' Getters
    Public ReadOnly Property idCompra As String
        Get
            Return idCp
        End Get
    End Property

    Public ReadOnly Property idCliente As String
        Get
            Return idC
        End Get
    End Property

    Public ReadOnly Property idCaja As String
        Get
            Return idCj
        End Get
    End Property

    Public ReadOnly Property importe As Double
        Get
            Return imp
        End Get
    End Property

    Public ReadOnly Property fecha As String
        Get
            Return f
        End Get
    End Property


End Class
