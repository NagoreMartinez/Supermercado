Public Class CCliente

    ' Atributos
    Public idCliente As String
    Public dni As String
    Public nombre As String
    Public telefono As String
    Public idSuper As String

    ' Constructora por defecto
    Public Sub New()

    End Sub

    ' Constructora
    Public Sub New(idCliente As String, dni As String, nombre As String, telefono As String, idSuper As String)
        idCliente = idCliente
        dni = dni
        nombre = nombre
        telefono = telefono
        idSuper = idSuper
    End Sub

    Public Sub New(row As DataRow)
        idCliente = row("IDCLIENTE")
        dni = row("DNI")
        nombre = row("NOMBRE")
        telefono = row("TELEFONO")
        idSuper = row("IDSUPER")
    End Sub


End Class
