Public Class indice

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        inicio.Show()
        Me.Hide()

    End Sub

    Private Sub EMPLEADO_Click(sender As Object, e As EventArgs) Handles EMPLEADO.Click
        frmempleado.Show()
        Me.Hide()
    End Sub
    Private Sub FACTURA_Click(sender As Object, e As EventArgs) Handles FACTURA.Click
        facturas.Show()
        Me.Hide()

    End Sub

    Private Sub AREA_Click(sender As Object, e As EventArgs) Handles AREA.Click
        frmareas.Show()
        Me.Hide()
    End Sub
    Private Sub CONSULTA_Click(sender As Object, e As EventArgs) Handles CONSULTA.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub PACIENTE_Click(sender As Object, e As EventArgs) Handles PACIENTE.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class