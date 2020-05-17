Public Class CCliente

    ' Atributos
    Private idC As String
    Private d As String
    Private nom As String
    Private tel As String
    Private idS As String

    ' Constructora por defecto
    Public Sub New()

    End Sub

    ' Constructora
    Public Sub New(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        idC = idCliente
        d = dni
        nom = nombre
        tel = telefono
        idS = idSuper
    End Sub

    Public Sub New(row As DataRow)
        idC = row("IDCLIENTE")
        d = row("DNI")
        nom = row("NOMBRE")
        tel = row("TELEFONO")
        idS = row("IDSUPER")
    End Sub

    ' Getters
    Public ReadOnly Property idCliente As String
        Get
            Return idC
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

    Public ReadOnly Property idSuper As String
        Get
            Return idS
        End Get
    End Property

End Class
