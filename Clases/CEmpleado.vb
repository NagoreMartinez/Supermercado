Public Class CEmpleado

    ' Declaramos los atributos
    Private idE As String
    Private d As String
    Private nom As String
    Private e As Integer
    Private idS As String
    Private idT As String
    Private hora As String
    Private sal As Double

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idEmpleado As String, dni As String, nombre As String, edad As Integer, idSuper As String,
                   idTipo As String, horario As String, salario As Double)
        idE = idEmpleado
        d = dni
        nom = nombre
        e = edad
        idS = idSuper
        idT = idTipo
        hora = horario
        sal = salario
    End Sub

    Public Sub New(row As DataRow)
        idE = row("IDEMPLEADO")
        d = row("DNI")
        nom = row("NOMBRE")
        e = row("EDAD")
        idS = row("IDSUPER")
        idT = row("IDTIPO")
        hora = row("HORARIO")
        sal = row("SALARIO")
    End Sub

    ' Getters
    Public ReadOnly Property idEmpleado As String
        Get
            Return idE
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

    Public ReadOnly Property edad As String
        Get
            Return e
        End Get
    End Property

    Public ReadOnly Property idSuper As String
        Get
            Return idS
        End Get
    End Property

    Public ReadOnly Property idTipo As String
        Get
            Return idT
        End Get
    End Property

    Public ReadOnly Property horario As String
        Get
            Return hora
        End Get
    End Property

    Public ReadOnly Property salario As Double
        Get
            Return sal
        End Get
    End Property

End Class
