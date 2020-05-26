Imports Funciones

Public Class FormLogin

    Dim obU As New FUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = txtIDU.Text
        Dim contraseña As String = txtPasswd.Text

        Dim ok As Boolean = obU.identificarUsuario(usuario, contraseña)

        If ok Then
            MessageBox.Show("Identificado correctamente")
            Dim FInicio As New FormInicio
            Visible = False
            FormInicio.ShowDialog()
            Close()
        Else
            MessageBox.Show("El nombre de usuario o la contraseña son incorrectos")
        End If

    End Sub


End Class