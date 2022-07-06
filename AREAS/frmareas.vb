Imports System.Data
Imports System.Data.SqlClient

Public Class frmareas
    Dim Conexion As String = "server=.;database=CLINICA;integrated security=true"
    Dim Comando As String = "Select * from AREA"
    Private Da As SqlDataAdapter
    Private Ds As New DataSet()
    Private Cb As SqlCommandBuilder
    Private DVw As DataView
    Dim Posicion As Integer

    Private Sub frmareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Da = New SqlDataAdapter(Comando, Conexion)
            Da.Fill(Ds, "AREA")
            Cb = New SqlCommandBuilder(Da)
            DVw = Ds.Tables("AREA").DefaultView
            txtID_AREA.DataBindings.Add(New Binding("Text", Ds, "AREA.IDAREA"))
            txtNOMBRE.DataBindings.Add(New Binding("Text", Ds, "AREA.NOMBRE"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtID_AREA.Clear()
        txtNOMBRE.Clear()
    End Sub
    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Agregar" Then
            Me.BindingContext(Ds, "AREA").AddNew()
            Button1.Text = "GUARDAR"
            Button2.Text = "CANCELAR"
            Button3.Enabled = False
            Button6.Enabled = False
            txtID_AREA.Enabled = True
            txtNOMBRE.Enabled = True
        Else
            Try
                BindingContext(Ds, "AREA").EndCurrentEdit()
                Da.Update(Ds, "AREA")
                Ds.Tables("AREA").AcceptChanges()
                Button1.Text = "AGREGAR"
                Button2.Text = "MODIFICAR"
                Button3.Enabled = True
                Button6.Enabled = True
                txtID_AREA.Enabled = False
                txtNOMBRE.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Text = "Modificar" Then
            Button1.Text = "GUARDAR"
            Button2.Text = "CANCELAR"
            Button3.Enabled = False
            Button6.Enabled = False
            txtID_AREA.Enabled = True
            txtNOMBRE.Enabled = True
        Else
            Try
                BindingContext(Ds, "AREA").EndCurrentEdit()
                Da.Update(Ds, "AREA")
                Ds.Tables("AREA").AcceptChanges()
                Button1.Text = "Agregar"
                Button2.Text = "Modificar"
                Button3.Enabled = True
                Button6.Enabled = True
                txtID_AREA.Enabled = False
                txtNOMBRE.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Está seguro de eliminar?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
            Try
                Posicion = BindingContext(Ds, "AREA").Position
                Ds.Tables("AREA").Rows(Posicion).Delete()
                Da.Update(Ds, "AREA")
                Ds.Tables("AREA").AcceptChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnMOSTRAR_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dtgresultado.DataSource = DVw
    End Sub
    Private Sub btnREGRESAR_Click(sender As Object, e As EventArgs) Handles Button6.Click
        indice.Show()
        Me.Hide()
    End Sub


    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Buscar As String
        Dim Consulta As String
        Buscar = InputBox("Nombre a buscar", "BUSQUEDAS")
        Consulta = "SELECT * FROM AREA WHERE NOMBRE LIKE '%" & Buscar _
            & "%'"
        Da = New SqlDataAdapter(Consulta, Conexion)
        Ds = New DataSet
        Da.Fill(Ds)
        dtgresultado.DataSource = Ds.Tables(0)
    End Sub
End Class
