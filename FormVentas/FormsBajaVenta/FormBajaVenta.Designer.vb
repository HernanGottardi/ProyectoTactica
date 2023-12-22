<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBajaVenta
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
        lb_titulo = New Label()
        btn_aceptar = New Button()
        lsb_ventas = New ListBox()
        SuspendLayout()
        ' 
        ' lb_titulo
        ' 
        lb_titulo.AutoSize = True
        lb_titulo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_titulo.ForeColor = Color.White
        lb_titulo.Location = New Point(28, 31)
        lb_titulo.Name = "lb_titulo"
        lb_titulo.Size = New Size(286, 28)
        lb_titulo.TabIndex = 0
        lb_titulo.Text = "Seleccionar venta a dar de baja:"
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_aceptar.Location = New Point(28, 375)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(210, 43)
        btn_aceptar.TabIndex = 1
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = True
        ' 
        ' lsb_ventas
        ' 
        lsb_ventas.FormattingEnabled = True
        lsb_ventas.Location = New Point(28, 81)
        lsb_ventas.Name = "lsb_ventas"
        lsb_ventas.Size = New Size(582, 264)
        lsb_ventas.TabIndex = 2
        ' 
        ' FormBajaVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(647, 450)
        Controls.Add(lsb_ventas)
        Controls.Add(btn_aceptar)
        Controls.Add(lb_titulo)
        Name = "FormBajaVenta"
        Text = "Baja Venta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb_titulo As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lsb_ventas As ListBox

End Class
