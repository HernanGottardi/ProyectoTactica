<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAltaCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lb_tituloAltaCliente = New Label()
        lb_nombreCliente = New Label()
        lb_telefonoCliente = New Label()
        lb_correoCliente = New Label()
        txb_nombre = New TextBox()
        txb_telefono = New TextBox()
        txb_correo = New TextBox()
        btn_aceptarAltaCliente = New Button()
        lb_mensajeExito = New Label()
        lb_msjExito = New Label()
        SuspendLayout()
        ' 
        ' lb_tituloAltaCliente
        ' 
        lb_tituloAltaCliente.AutoSize = True
        lb_tituloAltaCliente.Font = New Font("Courier New", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_tituloAltaCliente.Location = New Point(40, 27)
        lb_tituloAltaCliente.Name = "lb_tituloAltaCliente"
        lb_tituloAltaCliente.Size = New Size(332, 47)
        lb_tituloAltaCliente.TabIndex = 0
        lb_tituloAltaCliente.Text = "Alta Cliente"
        ' 
        ' lb_nombreCliente
        ' 
        lb_nombreCliente.AutoSize = True
        lb_nombreCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_nombreCliente.Location = New Point(40, 110)
        lb_nombreCliente.Name = "lb_nombreCliente"
        lb_nombreCliente.Size = New Size(85, 28)
        lb_nombreCliente.TabIndex = 1
        lb_nombreCliente.Text = "Nombre"
        ' 
        ' lb_telefonoCliente
        ' 
        lb_telefonoCliente.AutoSize = True
        lb_telefonoCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_telefonoCliente.Location = New Point(40, 183)
        lb_telefonoCliente.Name = "lb_telefonoCliente"
        lb_telefonoCliente.Size = New Size(86, 28)
        lb_telefonoCliente.TabIndex = 2
        lb_telefonoCliente.Text = "Telefono"
        ' 
        ' lb_correoCliente
        ' 
        lb_correoCliente.AutoSize = True
        lb_correoCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_correoCliente.Location = New Point(40, 251)
        lb_correoCliente.Name = "lb_correoCliente"
        lb_correoCliente.Size = New Size(72, 28)
        lb_correoCliente.TabIndex = 3
        lb_correoCliente.Text = "Correo"
        ' 
        ' txb_nombre
        ' 
        txb_nombre.Location = New Point(40, 141)
        txb_nombre.Name = "txb_nombre"
        txb_nombre.Size = New Size(541, 27)
        txb_nombre.TabIndex = 4
        ' 
        ' txb_telefono
        ' 
        txb_telefono.Location = New Point(40, 214)
        txb_telefono.Name = "txb_telefono"
        txb_telefono.Size = New Size(541, 27)
        txb_telefono.TabIndex = 5
        ' 
        ' txb_correo
        ' 
        txb_correo.Location = New Point(40, 282)
        txb_correo.Name = "txb_correo"
        txb_correo.Size = New Size(541, 27)
        txb_correo.TabIndex = 6
        ' 
        ' btn_aceptarAltaCliente
        ' 
        btn_aceptarAltaCliente.BackColor = Color.MediumSlateBlue
        btn_aceptarAltaCliente.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_aceptarAltaCliente.ForeColor = Color.White
        btn_aceptarAltaCliente.Location = New Point(40, 340)
        btn_aceptarAltaCliente.Name = "btn_aceptarAltaCliente"
        btn_aceptarAltaCliente.Size = New Size(541, 36)
        btn_aceptarAltaCliente.TabIndex = 7
        btn_aceptarAltaCliente.Text = "Aceptar"
        btn_aceptarAltaCliente.UseVisualStyleBackColor = False
        ' 
        ' lb_mensajeExito
        ' 
        lb_mensajeExito.AutoSize = True
        lb_mensajeExito.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_mensajeExito.Location = New Point(40, 407)
        lb_mensajeExito.Name = "lb_mensajeExito"
        lb_mensajeExito.Size = New Size(0, 28)
        lb_mensajeExito.TabIndex = 8
        ' 
        ' lb_msjExito
        ' 
        lb_msjExito.AutoSize = True
        lb_msjExito.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_msjExito.ForeColor = Color.Red
        lb_msjExito.Location = New Point(636, 141)
        lb_msjExito.Name = "lb_msjExito"
        lb_msjExito.Size = New Size(73, 23)
        lb_msjExito.TabIndex = 9
        lb_msjExito.Text = "Mensaje"
        lb_msjExito.Visible = False
        ' 
        ' FormAltaCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(955, 400)
        Controls.Add(lb_msjExito)
        Controls.Add(lb_mensajeExito)
        Controls.Add(btn_aceptarAltaCliente)
        Controls.Add(txb_correo)
        Controls.Add(txb_telefono)
        Controls.Add(txb_nombre)
        Controls.Add(lb_correoCliente)
        Controls.Add(lb_telefonoCliente)
        Controls.Add(lb_nombreCliente)
        Controls.Add(lb_tituloAltaCliente)
        Name = "FormAltaCliente"
        Text = "Alta Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb_tituloAltaCliente As Label
    Friend WithEvents lb_nombreCliente As Label
    Friend WithEvents lb_telefonoCliente As Label
    Friend WithEvents lb_correoCliente As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents txb_telefono As TextBox
    Friend WithEvents txb_correo As TextBox
    Friend WithEvents btn_aceptarAltaCliente As Button
    Friend WithEvents lb_mensajeExito As Label
    Friend WithEvents lb_msjExito As Label

End Class
