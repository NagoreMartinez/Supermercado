﻿Public Class FormLogin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtIDU.Text = "E009" And txtPasswd.Text = "1234" Then
            Dim formI As New FormInicio
            FormInicio.ShowDialog()
        End If

    End Sub

End Class