Imports Funciones

Public Class FormEliminarProducto

    Dim obP As New FProductos

    Public Sub New(id As String, nombre As String)

        InitializeComponent()

        txtIDP.Text = id
        txtNombre3.Text = nombre

    End Sub

    Private Sub ButtonS_Click(sender As Object, e As EventArgs) Handles ButtonS.Click

        Dim id As String = txtIDP.Text
        Dim del = obP.EliminiarProducto(id)

        If del Then
            MessageBox.Show("Se ha eliminado el producto correctamente")
        Else
            MessageBox.Show("Ha ocurrido un error")
        End If

        Dim formProductos As FormInicio = CType(Owner, FormInicio)
        formProductos.listarProductos()
        Close()
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        Close()
    End Sub


End Class