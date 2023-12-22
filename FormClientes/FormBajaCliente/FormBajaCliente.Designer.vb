<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBajaCliente
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
        lb_tituloBajaCliente = New Label()
        btn_eliminar = New Button()
        SuspendLayout()
        ' 
        ' lsb_clientes
        ' 
        lsb_clientes.FormattingEnabled = True
        lsb_clientes.Location = New Point(12, 144)
        lsb_clientes.Name = "lsb_clientes"
        lsb_clientes.Size = New Size(592, 184)
        lsb_clientes.TabIndex = 0
        ' 
        ' lb_titulo
        ' 
        lb_titulo.AutoSize = True
        lb_titulo.Location = New Point(12, 108)
        lb_titulo.Name = "lb_titulo"
        lb_titulo.Size = New Size(195, 20)
        lb_titulo.TabIndex = 1
        lb_titulo.Text = "Seleccionar cliente a quitar: "
        ' 
        ' lb_tituloBajaCliente
        ' 
        lb_tituloBajaCliente.AutoSize = True
        lb_tituloBajaCliente.Font = New Font("Courier New", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_tituloBajaCliente.Location = New Point(12, 35)
        lb_tituloBajaCliente.Name = "lb_tituloBajaCliente"
        lb_tituloBajaCliente.Size = New Size(306, 42)
        lb_tituloBajaCliente.TabIndex = 2
        lb_tituloBajaCliente.Text = "Baja Cliente"
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.MediumSlateBlue
        btn_eliminar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_eliminar.ForeColor = Color.White
        btn_eliminar.Location = New Point(12, 356)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(173, 37)
        btn_eliminar.TabIndex = 3
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' FormBajaCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(623, 405)
        Controls.Add(btn_eliminar)
        Controls.Add(lb_tituloBajaCliente)
        Controls.Add(lb_titulo)
        Controls.Add(lsb_clientes)
        Name = "FormBajaCliente"
        Text = "Baja Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_clientes As ListBox
    Friend WithEvents lb_titulo As Label
    Friend WithEvents lb_tituloBajaCliente As Label
    Friend WithEvents btn_eliminar As Button

End Class
