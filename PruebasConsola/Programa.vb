Imports System.Data
Imports Datos
Imports Clases


Module Programa
    Sub Main(args As String())
        Randomize()

        Console.WriteLine("PRUEBAS DE ACCESO A DATOS")

        'INSERT
        Dim c = New Clases.CCliente()
        c.nombre = "Us#" + CStr(CInt(1000 * Rnd()))
        c.dni = "DNI"
        c.telefono = "TELEFONO"
        c.idSuper = "IDSUPER"
        c.idCliente = DClientes.CmdInsert(c)
        'u.id = UseCase.CrearUsuario(u)
        Console.WriteLine($"ID insertado {c.idCliente}")

        'UPDATE
        c.nombre = "CAMBIO#" + CStr(CInt(1000 * Rnd()))
        Console.WriteLine($"#actualizados {DClientes.CmdUpdate(c)}")

        'SELECT
        Dim list = DClientes.ListarClientes()
        For Each row In list.Rows
            Console.WriteLine($"{row("IDCLIENTE")}: {row("DNI")} {row("NOMBRE")} {row("DNI")}{row("TELEFONO")}{row("IDSUPER")}")
        Next

    End Sub
End Module
