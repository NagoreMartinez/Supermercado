Public Class CCliente

    ' Declaramos los atributos
    Private idCliente As String
    Private dni As String
    Private nombre As String
    Private telefono As String
    Private idSuper As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idC As String, d As String, nom As String, tel As String, idS As String)
        idCliente = idC
        dni = d
        nombre = nom
        telefono = tel
        idSuper = idS
    End Sub

    Public Sub New(row As DataRow)
        idCliente = row("IDCLIENTE")
        dni = row("DNI")
        nombre = row("NOMBRE")
        telefono = row("TELEFONO")
        idSuper = row("IDSUPER")
    End Sub

    ' Getters
    Public ReadOnly Property idC As String
        Get
            Return idCliente
        End Get
    End Property

    Public ReadOnly Property d As String
        Get
            Return dni
        End Get
    End Property

    Public ReadOnly Property nom As String
        Get
            Return nombre
        End Get
    End Property

    Public ReadOnly Property tel As String
        Get
            Return telefono
        End Get
    End Property

    Public ReadOnly Property idS As String
        Get
            Return idSuper
        End Get
    End Property

End Class
