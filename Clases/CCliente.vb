Public Class CCliente

    ' Atributos
    Public idC As String
    Public idS As String
    Public d As String
    Public nom As String
    Public tel As String

    ' Constructora por defecto
    Public Sub New()

    End Sub

    ' Constructora
    Public Sub New(idCliente As String, idSuper As String, dni As String, nombre As String, telefono As String)
        idC = idCliente
        idS = idSuper
        d = dni
        nom = nombre
        tel = telefono
    End Sub

    Public Sub New(row As DataRow)
        idC = row("IDCLIENTE")
        idS = row("IDSUPER")
        d = row("DNI")
        nom = row("NOMBRE")
        tel = row("TELEFONO")
    End Sub

    ' Getters

    Public ReadOnly Property idCliente As String
        Get
            Return idC
        End Get
    End Property

    Public ReadOnly Property idSuper As String
        Get
            Return idS
        End Get
    End Property

    Public ReadOnly Property dni As String
        Get
            Return d
        End Get
    End Property

    Public ReadOnly Property nombre As String
        Get
            Return nom
        End Get
    End Property

    Public ReadOnly Property telefono As String
        Get
            Return tel
        End Get
    End Property

End Class
