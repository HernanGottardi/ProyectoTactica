<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificarItems
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
        lsb_listaItemsVenta = New ListBox()
        lb_titulo = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btn_modificar = New Button()
        txb_cantidad = New TextBox()
        txb_precioUnitario = New TextBox()
        SuspendLayout()
        ' 
        ' lsb_listaItemsVenta
        ' 
        lsb_listaItemsVenta.FormattingEnabled = True
        lsb_listaItemsVenta.Location = New Point(36, 81)
        lsb_listaItemsVenta.Name = "lsb_listaItemsVenta"
        lsb_listaItemsVenta.Size = New Size(318, 304)
        lsb_listaItemsVenta.TabIndex = 0
        ' 
        ' lb_titulo
        ' 
        lb_titulo.AutoSize = True
        lb_titulo.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_titulo.ForeColor = Color.White
        lb_titulo.Location = New Point(36, 25)
        lb_titulo.Name = "lb_titulo"
        lb_titulo.Size = New Size(269, 38)
        lb_titulo.TabIndex = 1
        lb_titulo.Text = "Lista de Items Venta:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(399, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 25)
        Label1.TabIndex = 4
        Label1.Text = "Modificar Cantidad:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(399, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 25)
        Label2.TabIndex = 5
        Label2.Text = "Modificar Precio Unitario:"
        ' 
        ' btn_modificar
        ' 
        btn_modificar.Location = New Point(399, 356)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(362, 29)
        btn_modificar.TabIndex = 6
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = True
        ' 
        ' txb_cantidad
        ' 
        txb_cantidad.Location = New Point(399, 133)
        txb_cantidad.Name = "txb_cantidad"
        txb_cantidad.Size = New Size(362, 27)
        txb_cantidad.TabIndex = 7
        ' 
        ' txb_precioUnitario
        ' 
        txb_precioUnitario.Location = New Point(399, 269)
        txb_precioUnitario.Name = "txb_precioUnitario"
        txb_precioUnitario.Size = New Size(362, 27)
        txb_precioUnitario.TabIndex = 8
        ' 
        ' FormModificarItems
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(791, 416)
        Controls.Add(txb_precioUnitario)
        Controls.Add(txb_cantidad)
        Controls.Add(btn_modificar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lb_titulo)
        Controls.Add(lsb_listaItemsVenta)
        Name = "FormModificarItems"
        Text = "Modificar Items"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_listaItemsVenta As ListBox
    Friend WithEvents lb_titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_modificar As Button
    Friend WithEvents txb_cantidad As TextBox
    Friend WithEvents txb_precioUnitario As TextBox

End Class
