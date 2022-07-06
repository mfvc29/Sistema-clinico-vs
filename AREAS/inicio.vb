Public Class inicio

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Dim usuario As String
        Dim contraseña As String

        usuario = "usuario"
        contraseña = "contraseña"

        If txtUSUARIO.Text = usuario And txtCONTRASEÑA.Text = contraseña Then
            indice.Show()
            Me.Hide()

        Else
            MsgBox("El nombre de usuario o contraseña es incorrecto.", MsgBoxStyle.Information, "Accesos denegado al sistema")
            txtCONTRASEÑA.Clear()
            txtUSUARIO.Clear()

        End If

    End Sub


End Class
