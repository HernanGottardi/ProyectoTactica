<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormsMenuPrincipal
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
        btn_ventas = New Button()
        btn_productos = New Button()
        btn_clientes = New Button()
        lb_tituloPrincipal = New Label()
        SuspendLayout()
        ' 
        ' btn_ventas
        ' 
        btn_ventas.BackColor = Color.Black
        btn_ventas.Font = New Font("Segoe UI", 12F)
        btn_ventas.ForeColor = Color.White
        btn_ventas.Location = New Point(126, 169)
        btn_ventas.Name = "btn_ventas"
        btn_ventas.Size = New Size(291, 81)
        btn_ventas.TabIndex = 0
        btn_ventas.Text = "Seccion Ventas"
        btn_ventas.UseVisualStyleBackColor = False
        ' 
        ' btn_productos
        ' 
        btn_productos.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        btn_productos.Font = New Font("Segoe UI", 12F)
        btn_productos.ForeColor = Color.White
        btn_productos.Location = New Point(126, 305)
        btn_productos.Name = "btn_productos"
        btn_productos.Size = New Size(291, 81)
        btn_productos.TabIndex = 1
        btn_productos.Text = "Seccion Productos"
        btn_productos.UseVisualStyleBackColor = False
        ' 
        ' btn_clientes
        ' 
        btn_clientes.BackColor = Color.MediumSlateBlue
        btn_clientes.Font = New Font("Segoe UI", 12F)
        btn_clientes.ForeColor = Color.White
        btn_clientes.Location = New Point(126, 434)
        btn_clientes.Name = "btn_clientes"
        btn_clientes.Size = New Size(291, 81)
        btn_clientes.TabIndex = 2
        btn_clientes.Text = "Seccion Clientes"
        btn_clientes.UseVisualStyleBackColor = False
        ' 
        ' lb_tituloPrincipal
        ' 
        lb_tituloPrincipal.AutoSize = True
        lb_tituloPrincipal.Font = New Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_tituloPrincipal.ForeColor = Color.White
        lb_tituloPrincipal.Location = New Point(126, 59)
        lb_tituloPrincipal.Name = "lb_tituloPrincipal"
        lb_tituloPrincipal.Size = New Size(317, 59)
        lb_tituloPrincipal.TabIndex = 3
        lb_tituloPrincipal.Text = "Menu Principal"
        ' 
        ' FormsMenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(539, 558)
        Controls.Add(lb_tituloPrincipal)
        Controls.Add(btn_clientes)
        Controls.Add(btn_productos)
        Controls.Add(btn_ventas)
        Name = "FormsMenuPrincipal"
        Text = "Menu Principal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_ventas As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents lb_tituloPrincipal As Label

End Class
