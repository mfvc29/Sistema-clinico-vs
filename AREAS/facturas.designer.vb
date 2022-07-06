<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtgfactura = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.factura = New System.Windows.Forms.TextBox()
        Me.consulta = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.ruc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BUSCAR = New System.Windows.Forms.Button()
        Me.REGRESAR = New System.Windows.Forms.Button()
        Me.MOSTRAR = New System.Windows.Forms.Button()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.MODIFICAR = New System.Windows.Forms.Button()
        Me.AGREGAR = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgfactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 41)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "AREA DE REGISTRO DE FACTURAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'dtgfactura
        '
        Me.dtgfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgfactura.Location = New System.Drawing.Point(366, 150)
        Me.dtgfactura.Name = "dtgfactura"
        Me.dtgfactura.Size = New System.Drawing.Size(545, 250)
        Me.dtgfactura.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID FACTURA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ID CONSULTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "NOMBRE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "DIRECCION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "FECHA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "TELEFONO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "TOTAL"
        '
        'factura
        '
        Me.factura.Location = New System.Drawing.Point(214, 150)
        Me.factura.Name = "factura"
        Me.factura.Size = New System.Drawing.Size(100, 20)
        Me.factura.TabIndex = 30
        '
        'consulta
        '
        Me.consulta.Location = New System.Drawing.Point(214, 178)
        Me.consulta.Name = "consulta"
        Me.consulta.Size = New System.Drawing.Size(100, 20)
        Me.consulta.TabIndex = 31
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(214, 206)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 32
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(214, 234)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(100, 20)
        Me.direccion.TabIndex = 33
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(214, 262)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(100, 20)
        Me.fecha.TabIndex = 34
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(214, 290)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(100, 20)
        Me.telefono.TabIndex = 35
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(214, 345)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 36
        '
        'ruc
        '
        Me.ruc.Location = New System.Drawing.Point(214, 319)
        Me.ruc.Name = "ruc"
        Me.ruc.Size = New System.Drawing.Size(100, 20)
        Me.ruc.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(127, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "RUC"
        '
        'BUSCAR
        '
        Me.BUSCAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUSCAR.Location = New System.Drawing.Point(750, 442)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(161, 61)
        Me.BUSCAR.TabIndex = 81
        Me.BUSCAR.Text = "BUSCAR"
        Me.BUSCAR.UseVisualStyleBackColor = True
        '
        'REGRESAR
        '
        Me.REGRESAR.BackColor = System.Drawing.Color.RosyBrown
        Me.REGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.REGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGRESAR.Location = New System.Drawing.Point(775, 564)
        Me.REGRESAR.Name = "REGRESAR"
        Me.REGRESAR.Size = New System.Drawing.Size(119, 55)
        Me.REGRESAR.TabIndex = 80
        Me.REGRESAR.Text = "REGRESAR"
        Me.REGRESAR.UseVisualStyleBackColor = False
        '
        'MOSTRAR
        '
        Me.MOSTRAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOSTRAR.Location = New System.Drawing.Point(564, 558)
        Me.MOSTRAR.Name = "MOSTRAR"
        Me.MOSTRAR.Size = New System.Drawing.Size(151, 61)
        Me.MOSTRAR.TabIndex = 79
        Me.MOSTRAR.Text = "MOSTRAR"
        Me.MOSTRAR.UseVisualStyleBackColor = True
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.Location = New System.Drawing.Point(307, 556)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(151, 61)
        Me.ELIMINAR.TabIndex = 78
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'MODIFICAR
        '
        Me.MODIFICAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFICAR.Location = New System.Drawing.Point(469, 442)
        Me.MODIFICAR.Name = "MODIFICAR"
        Me.MODIFICAR.Size = New System.Drawing.Size(151, 61)
        Me.MODIFICAR.TabIndex = 77
        Me.MODIFICAR.Text = "MODIFICAR"
        Me.MODIFICAR.UseVisualStyleBackColor = True
        '
        'AGREGAR
        '
        Me.AGREGAR.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGREGAR.Location = New System.Drawing.Point(177, 442)
        Me.AGREGAR.Name = "AGREGAR"
        Me.AGREGAR.Size = New System.Drawing.Size(151, 61)
        Me.AGREGAR.TabIndex = 76
        Me.AGREGAR.Text = "AGREGAR"
        Me.AGREGAR.UseVisualStyleBackColor = True
        '
        'facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.BUSCAR)
        Me.Controls.Add(Me.REGRESAR)
        Me.Controls.Add(Me.MOSTRAR)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.MODIFICAR)
        Me.Controls.Add(Me.AGREGAR)
        Me.Controls.Add(Me.ruc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.consulta)
        Me.Controls.Add(Me.factura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgfactura)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "facturas"
        Me.Text = "factura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgfactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgfactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents factura As System.Windows.Forms.TextBox
    Friend WithEvents consulta As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.TextBox
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BUSCAR As Button
    Friend WithEvents REGRESAR As Button
    Friend WithEvents MOSTRAR As Button
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents MODIFICAR As Button
    Friend WithEvents AGREGAR As Button
End Class
