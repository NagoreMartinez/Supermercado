Imports System.Data
Imports Datos
Imports Clases


Module Programa
    Sub Main(args As String())
        Randomize()

        Console.WriteLine("PRUEBAS DE ACCESO A DATOS")

        'SELECT
        Dim list = DClientes.QryListarClientes()
        For Each row In list.Rows
            Console.WriteLine($"{row("IDCLIENTE")}: {row("DNI")} {row("NOMBRE")} {row("TELEFONO")}{row("IDSUPER")}")
        Next

    End Sub


End Module
