<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificarVenta
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
        lsb_listaVentas = New ListBox()
        lb_titulo = New Label()
        btn_modificar = New Button()
        SuspendLayout()
        ' 
        ' lsb_listaVentas
        ' 
        lsb_listaVentas.FormattingEnabled = True
        lsb_listaVentas.Location = New Point(37, 98)
        lsb_listaVentas.Name = "lsb_listaVentas"
        lsb_listaVentas.Size = New Size(635, 284)
        lsb_listaVentas.TabIndex = 0
        ' 
        ' lb_titulo
        ' 
        lb_titulo.AutoSize = True
        lb_titulo.BackColor = Color.Gray
        lb_titulo.Font = New Font("Courier New", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_titulo.ForeColor = Color.White
        lb_titulo.Location = New Point(37, 34)
        lb_titulo.Name = "lb_titulo"
        lb_titulo.Size = New Size(317, 37)
        lb_titulo.TabIndex = 1
        lb_titulo.Text = "Modificar venta"
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_modificar.Location = New Point(37, 407)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(317, 43)
        btn_modificar.TabIndex = 4
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' FormModificarVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(709, 480)
        Controls.Add(btn_modificar)
        Controls.Add(lb_titulo)
        Controls.Add(lsb_listaVentas)
        ForeColor = Color.Black
        Name = "FormModificarVenta"
        Text = "Modificar Venta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_listaVentas As ListBox
    Friend WithEvents lb_titulo As Label
    Friend WithEvents btn_modificar As Button

End Class
