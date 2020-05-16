Public Class CProducto

    ' Declaramos los atributos
    Private idP As String
    Private nom As String
    Private p As Double
    Private fCad As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idProducto As String, nombre As String, precio As Double, fechaCaducidad As String)
        idP = idProducto
        nom = nombre
        p = precio
        fCad = fechaCaducidad
    End Sub

    Public Sub New(row As DataRow)
        idP = row("IDPRODUCTO")
        nom = row("NOMBRE")
        p = row("PRECIO")
        fCad = row("FECHA CADUCIDAD")
    End Sub

    ' Getters
    Public ReadOnly Property idProducto As String
        Get
            Return idP
        End Get
    End Property

    Public ReadOnly Property nombre As String
        Get
            Return nom
        End Get
    End Property

    Public ReadOnly Property precio As Double
        Get
            Return p
        End Get
    End Property

    Public ReadOnly Property fechaCaducidad As String
        Get
            Return fCad
        End Get
    End Property


End Class
