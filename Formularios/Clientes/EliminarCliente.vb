Imports Funciones

Public Class EliminarCliente

    Dim obC As New FClientes

    Public Sub New(id As String, nombre As String)

        InitializeComponent()

        txtIDC.Text = id
        txtNombre2.Text = nombre

    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click

        Dim id As String = txtIDC.Text
        Dim del = obC.EliminiarCliente(id)

        If del Then
            MessageBox.Show("Se ha eliminado el perfil del cliente correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formClientes As FormInicio = CType(Owner, FormInicio)
        formClientes.listarClientes()
        Close()
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        Close()
    End Sub


End Class