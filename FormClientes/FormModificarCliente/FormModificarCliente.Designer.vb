<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificarCliente
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
        lsb_clientes = New ListBox()
        lb_titulo = New Label()
        lb_seleccionarCliente = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txb_nombre = New TextBox()
        txb_correo = New TextBox()
        txb_telefono = New TextBox()
        btn_aceptar = New Button()
        lb_mensaje = New Label()
        SuspendLayout()
        ' 
        ' lsb_clientes
        ' 
        lsb_clientes.FormattingEnabled = True
        lsb_clientes.Location = New Point(12, 105)
        lsb_clientes.Name = "lsb_clientes"
        lsb_clientes.Size = New Size(356, 304)
        lsb_clientes.TabIndex = 0
        ' 
        ' lb_titulo
        ' 
        lb_titulo.AutoSize = True
        lb_titulo.Font = New Font("Courier New", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_titulo.Location = New Point(12, 9)
        lb_titulo.Name = "lb_titulo"
        lb_titulo.Size = New Size(523, 39)
        lb_titulo.TabIndex = 1
        lb_titulo.Text = "Modificacion de Cliente"
        ' 
        ' lb_seleccionarCliente
        ' 
        lb_seleccionarCliente.AutoSize = True
        lb_seleccionarCliente.Font = New Font("Segoe UI", 10.8F)
        lb_seleccionarCliente.Location = New Point(12, 68)
        lb_seleccionarCliente.Name = "lb_seleccionarCliente"
        lb_seleccionarCliente.Size = New Size(158, 25)
        lb_seleccionarCliente.TabIndex = 2
        lb_seleccionarCliente.Text = "Seleccionar Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F)
        Label1.Location = New Point(432, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 25)
        Label1.TabIndex = 6
        Label1.Text = "Modificar Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.Location = New Point(429, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 25)
        Label2.TabIndex = 7
        Label2.Text = "Modificar Correo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F)
        Label3.Location = New Point(429, 322)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 25)
        Label3.TabIndex = 8
        Label3.Text = "Modificar Telefono"
        ' 
        ' txb_nombre
        ' 
        txb_nombre.Location = New Point(432, 149)
        txb_nombre.Name = "txb_nombre"
        txb_nombre.Size = New Size(286, 27)
        txb_nombre.TabIndex = 9
        ' 
        ' txb_correo
        ' 
        txb_correo.Location = New Point(432, 255)
        txb_correo.Name = "txb_correo"
        txb_correo.Size = New Size(289, 27)
        txb_correo.TabIndex = 10
        ' 
        ' txb_telefono
        ' 
        txb_telefono.Location = New Point(432, 362)
        txb_telefono.Name = "txb_telefono"
        txb_telefono.Size = New Size(289, 27)
        txb_telefono.TabIndex = 11
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.BackColor = Color.MediumSlateBlue
        btn_aceptar.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_aceptar.ForeColor = Color.White
        btn_aceptar.Location = New Point(432, 425)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(289, 36)
        btn_aceptar.TabIndex = 12
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = False
        ' 
        ' lb_mensaje
        ' 
        lb_mensaje.AutoSize = True
        lb_mensaje.Font = New Font("Segoe UI", 10.8F)
        lb_mensaje.Location = New Point(12, 430)
        lb_mensaje.Name = "lb_mensaje"
        lb_mensaje.Size = New Size(77, 25)
        lb_mensaje.TabIndex = 14
        lb_mensaje.Text = "Mensaje"
        lb_mensaje.Visible = False
        ' 
        ' FormModificarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(741, 473)
        Controls.Add(lb_mensaje)
        Controls.Add(btn_aceptar)
        Controls.Add(txb_telefono)
        Controls.Add(txb_correo)
        Controls.Add(txb_nombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lb_seleccionarCliente)
        Controls.Add(lb_titulo)
        Controls.Add(lsb_clientes)
        Name = "FormModificarCliente"
        Text = "Modificar Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_clientes As ListBox
    Friend WithEvents lb_titulo As Label
    Friend WithEvents lb_seleccionarCliente As Label
    Friend WithEvents lb_detallar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents txb_correo As TextBox
    Friend WithEvents txb_telefono As TextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lb_mensaje As Label

End Class
