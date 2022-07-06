Imports System.Data
Imports System.Data.SqlClient
Public Class facturas
    Dim Conexion As String = "server=.;database=CLINICA;integrated security=true"
    Dim Comando As String = "Select * from FACTURA"
    Private Da As SqlDataAdapter
    Private Ds As New DataSet()
    Private Cb As SqlCommandBuilder
    Private DVw As DataView
    Dim Posicion As Integer
    Private Sub facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Da = New SqlDataAdapter(Comando, Conexion)
            Da.Fill(Ds, "FACTURA")
            Cb = New SqlCommandBuilder(Da)
            DVw = Ds.Tables("FACTURA").DefaultView
            factura.DataBindings.Add(New Binding("Text", Ds, "FACTURA.IDFACTURA"))
            nombre.DataBindings.Add(New Binding("Text", Ds, "FACTURA.IDCONSULTA"))
            consulta.DataBindings.Add(New Binding("Text", Ds, "FACTURA.NOMBRES"))
            direccion.DataBindings.Add(New Binding("Text", Ds, "FACTURA.DIRECCION"))
            fecha.DataBindings.Add(New Binding("Text", Ds, "FACTURA.FECHA_INGRESO"))
            telefono.DataBindings.Add(New Binding("Text", Ds, "FACTURA.TELEFONO"))
            ruc.DataBindings.Add(New Binding("Text", Ds, "FACTURA.RUC"))
            total.DataBindings.Add(New Binding("Text", Ds, "FACTURA.TOTAL"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MsgBox("¿Está seguro de eliminar?", MsgBoxStyle.YesNo, "FACTURA") = MsgBoxResult.Yes Then
            Try
                Posicion = BindingContext(Ds, "FACTURA").Position
                Ds.Tables("FACTURA").Rows(Posicion).Delete()
                Da.Update(Ds, "FACTURA")
                Ds.Tables("FACTURA").AcceptChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub AGREGA_Click(sender As Object, e As EventArgs) Handles AGREGAR.Click
        If AGREGAR.Text = "AGREGAR" Then
            Me.BindingContext(Ds, "FACTURA").AddNew()
            AGREGAR.Text = "GUARDAR"
            MODIFICAR.Text = "ELIMINAR"
            ELIMINAR.Enabled = False
            REGRESAR.Enabled = False
            factura.Enabled = True
            consulta.Enabled = True
            nombre.Enabled = True
            direccion.Enabled = True
            fecha.Enabled = True
            telefono.Enabled = True
            ruc.Enabled = True
            total.Enabled = True
            factura.Focus()
        Else
            Try
                BindingContext(Ds, "FACTURA").EndCurrentEdit()
                Da.Update(Ds, "FACTURA")
                Ds.Tables("FACTURA").AcceptChanges()
                MODIFICAR.Text = "Modificar"
                AGREGAR.Text = "agregar"
                ELIMINAR.Enabled = True
                REGRESAR.Enabled = True
                factura.Enabled = False
                consulta.Enabled = False
                nombre.Enabled = False
                direccion.Enabled = False
                fecha.Enabled = False
                telefono.Enabled = False
                ruc.Enabled = False
                total.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub MOSTRAR_Click(sender As Object, e As EventArgs) Handles MOSTRAR.Click
        dtgfactura.DataSource = DVw
    End Sub
    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs) Handles MODIFICAR.Click
        If MODIFICAR.Text = "Modificar" Then
            AGREGAR.Text = "GUARDAR"
            MODIFICAR.Text = "CANCELAR"
            ELIMINAR.Enabled = False
            REGRESAR.Enabled = False
            factura.Enabled = True
            consulta.Enabled = True
            nombre.Enabled = True
            direccion.Enabled = True
            fecha.Enabled = True
            telefono.Enabled = True
            ruc.Enabled = True
            total.Enabled = True
        Else
            Try
                BindingContext(Ds, "FACTURA").EndCurrentEdit()
                Da.Update(Ds, "FACTURA")
                Ds.Tables("FACTURA").AcceptChanges()
                AGREGAR.Text = "Agregar"
                MODIFICAR.Text = "Modificar"
                ELIMINAR.Enabled = True
                REGRESAR.Enabled = True
                factura.Enabled = False
                consulta.Enabled = False
                nombre.Enabled = False
                direccion.Enabled = False
                fecha.Enabled = False
                telefono.Enabled = False
                ruc.Enabled = False
                total.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub BUSCAR_Click(sender As Object, e As EventArgs) Handles BUSCAR.Click
        Dim Buscar As String
        Dim Consulta As String
        Dim dsbase As DataSet
        Buscar = InputBox("Nombre a buscar", "BUSQUEDAS")
        Consulta = "SELECT * FROM FACTURA WHERE NOMBRES LIKE '%" & Buscar _
            & "%'"
        Da = New SqlDataAdapter(Consulta, Conexion)
        dsbase = New DataSet
        Da.Fill(dsbase)
        dtgfactura.DataSource = dsbase.Tables(0)
    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles REGRESAR.Click
        indice.Show()
        Me.Hide()

    End Sub
End Class