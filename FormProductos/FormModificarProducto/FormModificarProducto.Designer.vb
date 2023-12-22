<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificarProducto
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
        labellll = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txb_precio = New TextBox()
        txb_categoria = New TextBox()
        txb_nombre = New TextBox()
        btn_modificar = New Button()
        lsb_productos = New ListBox()
        Label4 = New Label()
        lb_mensajeNombre = New Label()
        lb_mensajePrecio = New Label()
        lb_mensajeCategoria = New Label()
        lb_mensajeVacio = New Label()
        SuspendLayout()
        ' 
        ' labellll
        ' 
        labellll.AutoSize = True
        labellll.Font = New Font("Segoe UI", 10.8F)
        labellll.ForeColor = Color.White
        labellll.Location = New Point(383, 82)
        labellll.Name = "labellll"
        labellll.Size = New Size(78, 25)
        labellll.TabIndex = 0
        labellll.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(383, 181)
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
        Label3.Location = New Point(383, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 2
        Label3.Text = "Categoria"
        ' 
        ' txb_precio
        ' 
        txb_precio.Location = New Point(383, 209)
        txb_precio.Name = "txb_precio"
        txb_precio.Size = New Size(353, 27)
        txb_precio.TabIndex = 3
        ' 
        ' txb_categoria
        ' 
        txb_categoria.Location = New Point(383, 306)
        txb_categoria.Name = "txb_categoria"
        txb_categoria.Size = New Size(353, 27)
        txb_categoria.TabIndex = 4
        ' 
        ' txb_nombre
        ' 
        txb_nombre.Location = New Point(383, 110)
        txb_nombre.Name = "txb_nombre"
        txb_nombre.Size = New Size(353, 27)
        txb_nombre.TabIndex = 5
        ' 
        ' btn_modificar
        ' 
        btn_modificar.BackColor = Color.DarkBlue
        btn_modificar.ForeColor = Color.White
        btn_modificar.Location = New Point(383, 379)
        btn_modificar.Name = "btn_modificar"
        btn_modificar.Size = New Size(353, 34)
        btn_modificar.TabIndex = 6
        btn_modificar.Text = "Modificar"
        btn_modificar.UseVisualStyleBackColor = False
        ' 
        ' lsb_productos
        ' 
        lsb_productos.FormattingEnabled = True
        lsb_productos.Location = New Point(38, 89)
        lsb_productos.Name = "lsb_productos"
        lsb_productos.Size = New Size(298, 324)
        lsb_productos.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Courier New", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(38, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(320, 31)
        Label4.TabIndex = 8
        Label4.Text = "Modificar Producto"
        ' 
        ' lb_mensajeNombre
        ' 
        lb_mensajeNombre.AutoSize = True
        lb_mensajeNombre.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_mensajeNombre.ForeColor = Color.White
        lb_mensajeNombre.Location = New Point(797, 112)
        lb_mensajeNombre.Name = "lb_mensajeNombre"
        lb_mensajeNombre.Size = New Size(77, 25)
        lb_mensajeNombre.TabIndex = 9
        lb_mensajeNombre.Text = "Mensaje"
        lb_mensajeNombre.Visible = False
        ' 
        ' lb_mensajePrecio
        ' 
        lb_mensajePrecio.AutoSize = True
        lb_mensajePrecio.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_mensajePrecio.ForeColor = Color.White
        lb_mensajePrecio.Location = New Point(797, 209)
        lb_mensajePrecio.Name = "lb_mensajePrecio"
        lb_mensajePrecio.Size = New Size(77, 25)
        lb_mensajePrecio.TabIndex = 10
        lb_mensajePrecio.Text = "Mensaje"
        lb_mensajePrecio.Visible = False
        ' 
        ' lb_mensajeCategoria
        ' 
        lb_mensajeCategoria.AutoSize = True
        lb_mensajeCategoria.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_mensajeCategoria.ForeColor = Color.White
        lb_mensajeCategoria.Location = New Point(797, 305)
        lb_mensajeCategoria.Name = "lb_mensajeCategoria"
        lb_mensajeCategoria.Size = New Size(77, 25)
        lb_mensajeCategoria.TabIndex = 11
        lb_mensajeCategoria.Text = "Mensaje"
        lb_mensajeCategoria.Visible = False
        ' 
        ' lb_mensajeVacio
        ' 
        lb_mensajeVacio.AutoSize = True
        lb_mensajeVacio.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_mensajeVacio.ForeColor = Color.White
        lb_mensajeVacio.Location = New Point(797, 379)
        lb_mensajeVacio.Name = "lb_mensajeVacio"
        lb_mensajeVacio.Size = New Size(77, 25)
        lb_mensajeVacio.TabIndex = 12
        lb_mensajeVacio.Text = "Mensaje"
        lb_mensajeVacio.Visible = False
        ' 
        ' FormModificarProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(1266, 447)
        Controls.Add(lb_mensajeVacio)
        Controls.Add(lb_mensajeCategoria)
        Controls.Add(lb_mensajePrecio)
        Controls.Add(lb_mensajeNombre)
        Controls.Add(Label4)
        Controls.Add(lsb_productos)
        Controls.Add(btn_modificar)
        Controls.Add(txb_nombre)
        Controls.Add(txb_categoria)
        Controls.Add(txb_precio)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(labellll)
        Name = "FormModificarProducto"
        Text = "Modificar Producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labellll As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txb_precio As TextBox
    Friend WithEvents txb_categoria As TextBox
    Friend WithEvents txb_nombre As TextBox
    Friend WithEvents btn_modificar As Button
    Friend WithEvents lsb_productos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_mensajeNombre As Label
    Friend WithEvents lb_mensajePrecio As Label
    Friend WithEvents lb_mensajeCategoria As Label
    Friend WithEvents lb_mensajeVacio As Label

End Class
