Public Class CEmpleado

    ' Atributos
    Private idE As String
    Private idT As String
    Private idS As String
    Private d As String
    Private nom As String
    Private e As Integer
    Private tel As String
    Private hora As String
    Private sal As Double

    ' Constructora por defecto
    Public Sub New()

    End Sub

    ' Constructoar
    Public Sub New(idEmpleado As String, idTipo As String, idSuper As String, dni As String, nombre As String, edad As Integer,
                    telefono As String, horario As String, salario As Double)
        idE = idEmpleado
        idT = idTipo
        idS = idSuper
        d = dni
        nom = nombre
        e = edad
        tel = telefono
        hora = horario
        sal = salario
    End Sub

    Public Sub New(row As DataRow)
        idE = row("IDEMPLEADO")
        idT = row("IDTIPO")
        idS = row("IDSUPER")
        d = row("DNI")
        nom = row("NOMBRE")
        e = row("EDAD")
        tel = row("TELEFONO")
        hora = row("HORARIO")
        sal = row("SALARIO")
    End Sub

    ' Getters
    Public ReadOnly Property idEmpleado As String
        Get
            Return idE
        End Get
    End Property

    Public ReadOnly Property idTipo As String
        Get
            Return idT
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

    Public ReadOnly Property edad As String
        Get
            Return e
        End Get
    End Property

    Public ReadOnly Property telefono As String
        Get
            Return tel
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
