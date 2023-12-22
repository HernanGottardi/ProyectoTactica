<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAltaProducto
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txb_nombre = New TextBox()
        txb_precio = New TextBox()
        txb_categoria = New TextBox()
        Label4 = New Label()
        btn_aceptar = New Button()
        lb_mensajeNombre = New Label()
        lb_mensajePrecio = New Label()
        lb_mensajeCategoria = New Label()
        lb_mensajeVacio = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(32, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 1
        Label2.Text = "Precio"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(32, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 2
        Label3.Text = "Categoria"
        ' 
        ' txb_nombre
        ' 
        txb_nombre.Location = New Point(32, 145)
        txb_nombre.Name = "txb_nombre"
        txb_nombre.Size = New Size(422, 27)
        txb_nombre.TabIndex = 3
        ' 
        ' txb_precio
        ' 
        txb_precio.Location = New Point(32, 240)
        txb_precio.Name = "txb_precio"
        txb_precio.Size = New Size(422, 27)
        txb_precio.TabIndex = 4
        ' 
        ' txb_categoria
        ' 
        txb_categoria.Location = New Point(32, 331)
        txb_categoria.Name = "txb_categoria"
        txb_categoria.Size = New Size(422, 27)
        txb_categoria.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(75, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(330, 42)
        Label4.TabIndex = 6
        Label4.Text = "Alta Producto"
        ' 
        ' btn_aceptar
        ' 
        btn_aceptar.BackColor = Color.MidnightBlue
        btn_aceptar.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_aceptar.ForeColor = Color.White
        btn_aceptar.Location = New Point(32, 415)
        btn_aceptar.Name = "btn_aceptar"
        btn_aceptar.Size = New Size(422, 35)
        btn_aceptar.TabIndex = 7
        btn_aceptar.Text = "Aceptar"
        btn_aceptar.UseVisualStyleBackColor = False
        ' 
        ' lb_mensajeNombre
        ' 
        lb_mensajeNombre.AutoSize = True
        lb_mensajeNombre.ForeColor = Color.White
        lb_mensajeNombre.Location = New Point(485, 152)
        lb_mensajeNombre.Name = "lb_mensajeNombre"
        lb_mensajeNombre.Size = New Size(138, 20)
        lb_mensajeNombre.TabIndex = 8
        lb_mensajeNombre.Text = "lb_mensajeNombre"
        lb_mensajeNombre.Visible = False
        ' 
        ' lb_mensajePrecio
        ' 
        lb_mensajePrecio.AutoSize = True
        lb_mensajePrecio.ForeColor = Color.White
        lb_mensajePrecio.Location = New Point(485, 247)
        lb_mensajePrecio.Name = "lb_mensajePrecio"
        lb_mensajePrecio.Size = New Size(124, 20)
        lb_mensajePrecio.TabIndex = 9
        lb_mensajePrecio.Text = "lb_mensajePrecio"
        lb_mensajePrecio.Visible = False
        ' 
        ' lb_mensajeCategoria
        ' 
        lb_mensajeCategoria.AutoSize = True
        lb_mensajeCategoria.ForeColor = Color.White
        lb_mensajeCategoria.Location = New Point(485, 338)
        lb_mensajeCategoria.Name = "lb_mensajeCategoria"
        lb_mensajeCategoria.Size = New Size(148, 20)
        lb_mensajeCategoria.TabIndex = 10
        lb_mensajeCategoria.Text = "lb_mensajeCategoria"
        lb_mensajeCategoria.Visible = False
        ' 
        ' lb_mensajeVacio
        ' 
        lb_mensajeVacio.AutoSize = True
        lb_mensajeVacio.ForeColor = Color.White
        lb_mensajeVacio.Location = New Point(485, 423)
        lb_mensajeVacio.Name = "lb_mensajeVacio"
        lb_mensajeVacio.Size = New Size(119, 20)
        lb_mensajeVacio.TabIndex = 11
        lb_mensajeVacio.Text = "lb_mensajeVacio"
        lb_mensajeVacio.Visible = False
        ' 
        ' FormAltaProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(976, 474)
        Controls.Add(lb_mensajeVacio)
        Controls.Add(lb_mensajeCategoria)
        Controls.Add(lb_mensajePrecio)
        Controls.Add(lb_mensajeNombre)
        Controls.Add(btn_aceptar)
        Controls.Add(Label4)
        Controls.Add(txb_categoria)
        Controls.Add(txb_precio)
        Controls.Add(txb_nombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormAltaProducto"
        Text = "Alta Producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents txb_precio As TextBox
    Friend WithEvents txb_categoria As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lb_mensajeNombre As Label
    Friend WithEvents lb_mensajePrecio As Label
    Friend WithEvents lb_mensajeCategoria As Label
    Friend WithEvents lb_mensajeVacio As Label

End Class
