Imports System.Data.SqlClient

Public Class frmempleado
    Dim Conexion As String = "server=.;database=CLINICA;integrated security=true"
    Dim Comando As String = "Select * from ENFERMERAS"
    Private Da As SqlDataAdapter
    Private Ds As New DataSet()
    Private Cb As SqlCommandBuilder
    Private DVw As DataView
    Dim Posicion As Integer
    Dim Buscar As String
    Dim Consulta As String
    Dim dsbase As DataSet

    Private Sub frmempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Da = New SqlDataAdapter(Comando, Conexion)
            Da.Fill(Ds, "ENFERMERAS")
            Cb = New SqlCommandBuilder(Da)


            txtID_EMPLEADO.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.ID_EMPLEADO"))
            txtNOMBRE.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.NOMBRES"))
            txtAPELLIDO.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.APELLIDOS"))
            txtPUESTO.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.PUESTO"))
            txtID_AREA.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.ID_AREA"))
            txtTELEFONO.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.TELEFONO"))
            txtSUELDO.DataBindings.Add(New Binding("Text", Ds, "ENFERMERAS.SUELDO"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAGREGAR_Click(sender As Object, e As EventArgs) Handles btnAGREGAR.Click
        If btnAGREGAR.Text = "Agregar" Then
            Me.BindingContext(Ds, "ENFERMERAS").AddNew()
            btnAGREGAR.Text = "GUARDAR"
            btnMODIFICAR.Text = "CANCELAR"
            btnELIMINAR.Enabled = False
            btnREGRESAR.Enabled = False
            txtID_EMPLEADO.Enabled = True
            txtNOMBRE.Enabled = True
            txtAPELLIDO.Enabled = True
            txtPUESTO.Enabled = True
            txtID_AREA.Enabled = True
            txtTELEFONO.Enabled = True
            txtSUELDO.Enabled = True

            txtID_EMPLEADO.Focus()
        Else
            Try
                BindingContext(Ds, "ENFERMERAS").EndCurrentEdit()
                Da.Update(Ds, "ENFERMERAS")
                Ds.Tables("ENFERMERAS").AcceptChanges()
                btnAGREGAR.Text = "AGREGAR"
                btnMODIFICAR.Text = "MODIFICAR"
                btnELIMINAR.Enabled = True
                btnREGRESAR.Enabled = True
                txtID_EMPLEADO.Enabled = False
                txtNOMBRE.Enabled = False
                txtAPELLIDO.Enabled = False
                txtPUESTO.Enabled = False
                txtID_AREA.Enabled = False
                txtTELEFONO.Enabled = False
                txtSUELDO.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnMODIFICAR_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR.Click

        If btnMODIFICAR.Text = "Modificar" Then
            btnAGREGAR.Text = "GUARDAR"
            btnMODIFICAR.Text = "CANCELAR"
            btnELIMINAR.Enabled = False
            btnREGRESAR.Enabled = False
            txtID_EMPLEADO.Enabled = True
            txtNOMBRE.Enabled = True
            txtAPELLIDO.Enabled = True
            txtPUESTO.Enabled = True
            txtID_AREA.Enabled = True
            txtTELEFONO.Enabled = True
            txtSUELDO.Enabled = True

            txtID_EMPLEADO.Focus()
        Else
            Try
                BindingContext(Ds, "ENFERMERAS").EndCurrentEdit()
                Da.Update(Ds, "ENFERMERAS")
                Ds.Tables("ENFERMERAS").AcceptChanges()
                btnAGREGAR.Text = "Agregar"
                btnMODIFICAR.Text = "Modificar"
                btnELIMINAR.Enabled = True
                btnREGRESAR.Enabled = True
                txtID_EMPLEADO.Enabled = False
                txtNOMBRE.Enabled = False
                txtAPELLIDO.Enabled = False
                txtPUESTO.Enabled = False
                txtID_AREA.Enabled = False
                txtTELEFONO.Enabled = False
                txtSUELDO.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnELIMINAR_Click(sender As Object, e As EventArgs) Handles btnELIMINAR.Click

        If MsgBox("¿Está seguro de eliminar?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
            Try
                Posicion = BindingContext(Ds, "ENFERMERAS").Position
                Ds.Tables("ENFERMERAS").Rows(Posicion).Delete()
                Da.Update(Ds, "ENFERMERAS")
                Ds.Tables("ENFERMERAS").AcceptChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnMOSTRAR_Click(sender As Object, e As EventArgs) Handles btnMOSTRAR.Click

        DVw = Ds.Tables("ENFERMERAS").DefaultView
        dgvResultado.DataSource = DVw

    End Sub
    Private Sub btnBUSCAR_Click(sender As Object, e As EventArgs) Handles btnBUSCAR.Click

        Buscar = InputBox("Nombre a buscar", "BUSQUEDAS")
        Consulta = "SELECT * FROM ENFERMERAS WHERE Nombres LIKE '%" & Buscar _
            & "%'"
        Da = New SqlDataAdapter(Consulta, Conexion)
        dsbase = New DataSet
        Da.Fill(dsbase)
        dgvResultado.DataSource = dsbase.Tables(0)

    End Sub
    Private Sub btnREGRESAR_Click(sender As Object, e As EventArgs) Handles btnREGRESAR.Click

        indice.Show()
        Me.Hide()

    End Sub


End Class
