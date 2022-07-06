Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim Conexion As String = "server=.;database=CLINICA;integrated security=true"
    Dim Comando As String = "Select * from PACIENTE"
    Private Da As SqlDataAdapter
    Private Ds As New DataSet()
    Private Cb As SqlCommandBuilder
    Private DVw As DataView
    Dim Posicion As Integer
    Dim buscar As String, consulta As String, dsbase As DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Agregar" Then
            Me.BindingContext(Ds, "PACIENTE").AddNew()
            Button1.Text = "GUARDAR"
            Button2.Text = "CANCELAR"
            Button3.Enabled = False
            Button6.Enabled = False
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox1.Focus()
        Else
            Try
                BindingContext(Ds, "PACIENTE").EndCurrentEdit()
                Da.Update(Ds, "PACIENTE")
                Ds.Tables("PACIENTE").AcceptChanges()
                Button1.Text = "AGREGAR"
                Button2.Text = "MODIFICAR"
                Button3.Enabled = True
                Button6.Enabled = True
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Da = New SqlDataAdapter(Comando, Conexion)
            Da.Fill(Ds, "PACIENTE")
            Cb = New SqlCommandBuilder(Da)
            DVw = Ds.Tables("PACIENTE").DefaultView
            TextBox1.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.DPI_PACIENTE"))
            TextBox2.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.NOMBRES"))
            TextBox3.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.APELLIDOS"))
            TextBox4.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.DISTRITO"))
            TextBox5.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.FECHA_INGRESO"))
            TextBox6.DataBindings.Add(New Binding("Text", Ds, "PACIENTE.SEGURO"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        buscar = InputBox("Nombre a buscar", "BUSQUEDAS")
        consulta = "SELECT * FROM PACIENTE WHERE NOMBRES LIKE '%" & buscar _
            & "%'"
        Da = New SqlDataAdapter(consulta, Conexion)
        dsbase = New DataSet
        Da.Fill(dsbase)
        DataGridView1.DataSource = dsbase.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Modificar" Then
            Button1.Text = "GUARDAR"
            Button2.Text = "CANCELAR"
            Button3.Enabled = False
            Button6.Enabled = False
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox1.Focus()
        Else
            Try
                BindingContext(Ds, "PACIENTE").EndCurrentEdit()
                Da.Update(Ds, "PACIENTE")
                Ds.Tables("PACIENTE").AcceptChanges()
                Button1.Text = "Agregar"
                Button2.Text = "Modificar"
                Button3.Enabled = True
                Button6.Enabled = True
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Está seguro de eliminar?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
            Try
                Posicion = BindingContext(Ds, "PACIENTE").Position
                Ds.Tables("PACIENTE").Rows(Posicion).Delete()
                Da.Update(Ds, "PACIENTE")
                Ds.Tables("PACIENTE").AcceptChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView1.DataSource = DVw
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        indice.Show()
        Me.Hide()
    End Sub


End Class
