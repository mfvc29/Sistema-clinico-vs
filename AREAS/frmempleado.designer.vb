<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmempleado))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID_EMPLEADO = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.txtAPELLIDO = New System.Windows.Forms.TextBox()
        Me.txtPUESTO = New System.Windows.Forms.TextBox()
        Me.txtID_AREA = New System.Windows.Forms.TextBox()
        Me.txtTELEFONO = New System.Windows.Forms.TextBox()
        Me.txtSUELDO = New System.Windows.Forms.TextBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.btnBUSCAR = New System.Windows.Forms.Button()
        Me.btnREGRESAR = New System.Windows.Forms.Button()
        Me.btnMOSTRAR = New System.Windows.Forms.Button()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(123, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 124)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(308, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REGISTRO DE ENFERMERAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID_EMPLEADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOMBRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "APELLIDO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "PUESTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(76, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID_AREA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TELEFONO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "SUELDO"
        '
        'txtID_EMPLEADO
        '
        Me.txtID_EMPLEADO.Location = New System.Drawing.Point(165, 222)
        Me.txtID_EMPLEADO.Name = "txtID_EMPLEADO"
        Me.txtID_EMPLEADO.Size = New System.Drawing.Size(270, 20)
        Me.txtID_EMPLEADO.TabIndex = 10
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(165, 248)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(270, 20)
        Me.txtNOMBRE.TabIndex = 11
        '
        'txtAPELLIDO
        '
        Me.txtAPELLIDO.Location = New System.Drawing.Point(165, 274)
        Me.txtAPELLIDO.Name = "txtAPELLIDO"
        Me.txtAPELLIDO.Size = New System.Drawing.Size(270, 20)
        Me.txtAPELLIDO.TabIndex = 12
        '
        'txtPUESTO
        '
        Me.txtPUESTO.Location = New System.Drawing.Point(165, 306)
        Me.txtPUESTO.Name = "txtPUESTO"
        Me.txtPUESTO.Size = New System.Drawing.Size(270, 20)
        Me.txtPUESTO.TabIndex = 13
        '
        'txtID_AREA
        '
        Me.txtID_AREA.Location = New System.Drawing.Point(165, 337)
        Me.txtID_AREA.Name = "txtID_AREA"
        Me.txtID_AREA.Size = New System.Drawing.Size(270, 20)
        Me.txtID_AREA.TabIndex = 14
        '
        'txtTELEFONO
        '
        Me.txtTELEFONO.Location = New System.Drawing.Point(165, 367)
        Me.txtTELEFONO.Name = "txtTELEFONO"
        Me.txtTELEFONO.Size = New System.Drawing.Size(270, 20)
        Me.txtTELEFONO.TabIndex = 15
        '
        'txtSUELDO
        '
        Me.txtSUELDO.Location = New System.Drawing.Point(165, 403)
        Me.txtSUELDO.Name = "txtSUELDO"
        Me.txtSUELDO.Size = New System.Drawing.Size(270, 20)
        Me.txtSUELDO.TabIndex = 16
        '
        'dgvResultado
        '
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(465, 178)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.Size = New System.Drawing.Size(836, 255)
        Me.dgvResultado.TabIndex = 24
        '
        'btnBUSCAR
        '
        Me.btnBUSCAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR.Location = New System.Drawing.Point(759, 476)
        Me.btnBUSCAR.Name = "btnBUSCAR"
        Me.btnBUSCAR.Size = New System.Drawing.Size(161, 61)
        Me.btnBUSCAR.TabIndex = 75
        Me.btnBUSCAR.Text = "BUSCAR"
        Me.btnBUSCAR.UseVisualStyleBackColor = True
        '
        'btnREGRESAR
        '
        Me.btnREGRESAR.BackColor = System.Drawing.Color.RosyBrown
        Me.btnREGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnREGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnREGRESAR.Location = New System.Drawing.Point(784, 598)
        Me.btnREGRESAR.Name = "btnREGRESAR"
        Me.btnREGRESAR.Size = New System.Drawing.Size(119, 55)
        Me.btnREGRESAR.TabIndex = 74
        Me.btnREGRESAR.Text = "REGRESAR"
        Me.btnREGRESAR.UseVisualStyleBackColor = False
        '
        'btnMOSTRAR
        '
        Me.btnMOSTRAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOSTRAR.Location = New System.Drawing.Point(573, 592)
        Me.btnMOSTRAR.Name = "btnMOSTRAR"
        Me.btnMOSTRAR.Size = New System.Drawing.Size(151, 61)
        Me.btnMOSTRAR.TabIndex = 73
        Me.btnMOSTRAR.Text = "MOSTRAR"
        Me.btnMOSTRAR.UseVisualStyleBackColor = True
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.Location = New System.Drawing.Point(316, 590)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(151, 61)
        Me.btnELIMINAR.TabIndex = 72
        Me.btnELIMINAR.Text = "ELIMINAR"
        Me.btnELIMINAR.UseVisualStyleBackColor = True
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.Location = New System.Drawing.Point(478, 476)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(151, 61)
        Me.btnMODIFICAR.TabIndex = 71
        Me.btnMODIFICAR.Text = "MODIFICAR"
        Me.btnMODIFICAR.UseVisualStyleBackColor = True
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.Location = New System.Drawing.Point(186, 476)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(151, 61)
        Me.btnAGREGAR.TabIndex = 70
        Me.btnAGREGAR.Text = "AGREGAR"
        Me.btnAGREGAR.UseVisualStyleBackColor = True
        '
        'frmempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnBUSCAR)
        Me.Controls.Add(Me.btnREGRESAR)
        Me.Controls.Add(Me.btnMOSTRAR)
        Me.Controls.Add(Me.btnELIMINAR)
        Me.Controls.Add(Me.btnMODIFICAR)
        Me.Controls.Add(Me.btnAGREGAR)
        Me.Controls.Add(Me.dgvResultado)
        Me.Controls.Add(Me.txtSUELDO)
        Me.Controls.Add(Me.txtTELEFONO)
        Me.Controls.Add(Me.txtID_AREA)
        Me.Controls.Add(Me.txtPUESTO)
        Me.Controls.Add(Me.txtAPELLIDO)
        Me.Controls.Add(Me.txtNOMBRE)
        Me.Controls.Add(Me.txtID_EMPLEADO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmempleado"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtID_EMPLEADO As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents txtAPELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents txtPUESTO As System.Windows.Forms.TextBox
    Friend WithEvents txtID_AREA As System.Windows.Forms.TextBox
    Friend WithEvents txtTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents txtSUELDO As System.Windows.Forms.TextBox
    Friend WithEvents dgvResultado As System.Windows.Forms.DataGridView
    Friend WithEvents btnBUSCAR As Button
    Friend WithEvents btnREGRESAR As Button
    Friend WithEvents btnMOSTRAR As Button
    Friend WithEvents btnELIMINAR As Button
    Friend WithEvents btnMODIFICAR As Button
    Friend WithEvents btnAGREGAR As Button
End Class
