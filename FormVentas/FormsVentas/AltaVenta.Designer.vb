<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVenta
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
        lsb_productos = New ListBox()
        GroupBox1 = New GroupBox()
        btn_seleccionarCliente = New Button()
        lb_detalle = New Label()
        rtb_detalles = New RichTextBox()
        lb_cantidad = New Label()
        nud_cantidad = New NumericUpDown()
        btn_agregar = New Button()
        dgv_itemsVenta = New DataGridView()
        btn_finalizar = New Button()
        lb_carrito = New Label()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        lb_clienteSeleccionado = New Label()
        lb_total = New Label()
        GroupBox1.SuspendLayout()
        CType(nud_cantidad, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_itemsVenta, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lsb_productos
        ' 
        lsb_productos.FormattingEnabled = True
        lsb_productos.ItemHeight = 21
        lsb_productos.Location = New Point(44, 42)
        lsb_productos.Name = "lsb_productos"
        lsb_productos.Size = New Size(209, 214)
        lsb_productos.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_seleccionarCliente)
        GroupBox1.Controls.Add(lb_detalle)
        GroupBox1.Controls.Add(rtb_detalles)
        GroupBox1.Controls.Add(lb_cantidad)
        GroupBox1.Controls.Add(nud_cantidad)
        GroupBox1.Controls.Add(lsb_productos)
        GroupBox1.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(297, 559)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Seleccion de Productos"
        ' 
        ' btn_seleccionarCliente
        ' 
        btn_seleccionarCliente.BackColor = Color.DarkGray
        btn_seleccionarCliente.ForeColor = Color.Black
        btn_seleccionarCliente.Location = New Point(44, 499)
        btn_seleccionarCliente.Name = "btn_seleccionarCliente"
        btn_seleccionarCliente.Size = New Size(209, 41)
        btn_seleccionarCliente.TabIndex = 6
        btn_seleccionarCliente.Text = "Seleccionar Cliente"
        btn_seleccionarCliente.UseVisualStyleBackColor = False
        ' 
        ' lb_detalle
        ' 
        lb_detalle.AutoSize = True
        lb_detalle.ForeColor = Color.White
        lb_detalle.Location = New Point(44, 272)
        lb_detalle.Name = "lb_detalle"
        lb_detalle.Size = New Size(75, 21)
        lb_detalle.TabIndex = 5
        lb_detalle.Text = "Detalles"
        ' 
        ' rtb_detalles
        ' 
        rtb_detalles.Location = New Point(44, 296)
        rtb_detalles.Name = "rtb_detalles"
        rtb_detalles.Size = New Size(209, 124)
        rtb_detalles.TabIndex = 5
        rtb_detalles.Text = ""
        ' 
        ' lb_cantidad
        ' 
        lb_cantidad.AutoSize = True
        lb_cantidad.ForeColor = Color.White
        lb_cantidad.Location = New Point(44, 423)
        lb_cantidad.Name = "lb_cantidad"
        lb_cantidad.Size = New Size(82, 21)
        lb_cantidad.TabIndex = 4
        lb_cantidad.Text = "Cantidad"
        ' 
        ' nud_cantidad
        ' 
        nud_cantidad.Location = New Point(44, 447)
        nud_cantidad.Name = "nud_cantidad"
        nud_cantidad.Size = New Size(209, 28)
        nud_cantidad.TabIndex = 2
        ' 
        ' btn_agregar
        ' 
        btn_agregar.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn_agregar.Font = New Font("Segoe UI", 10.2F)
        btn_agregar.ForeColor = Color.White
        btn_agregar.Location = New Point(347, 511)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(209, 41)
        btn_agregar.TabIndex = 5
        btn_agregar.Text = "Agregar al Carrito"
        btn_agregar.UseVisualStyleBackColor = False
        ' 
        ' dgv_itemsVenta
        ' 
        dgv_itemsVenta.BackgroundColor = Color.White
        dgv_itemsVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_itemsVenta.Location = New Point(344, 107)
        dgv_itemsVenta.Name = "dgv_itemsVenta"
        dgv_itemsVenta.RowHeadersWidth = 51
        dgv_itemsVenta.Size = New Size(621, 349)
        dgv_itemsVenta.TabIndex = 6
        ' 
        ' btn_finalizar
        ' 
        btn_finalizar.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn_finalizar.Font = New Font("Segoe UI", 10.2F)
        btn_finalizar.ForeColor = Color.White
        btn_finalizar.Location = New Point(762, 511)
        btn_finalizar.Name = "btn_finalizar"
        btn_finalizar.Size = New Size(203, 41)
        btn_finalizar.TabIndex = 7
        btn_finalizar.Text = "Finalizar Venta"
        btn_finalizar.UseVisualStyleBackColor = False
        ' 
        ' lb_carrito
        ' 
        lb_carrito.AutoSize = True
        lb_carrito.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_carrito.ForeColor = Color.White
        lb_carrito.Location = New Point(344, 54)
        lb_carrito.Name = "lb_carrito"
        lb_carrito.Size = New Size(212, 35)
        lb_carrito.TabIndex = 8
        lb_carrito.Text = "Carrito de ventas"
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' lb_clienteSeleccionado
        ' 
        lb_clienteSeleccionado.AutoSize = True
        lb_clienteSeleccionado.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_clienteSeleccionado.ForeColor = Color.White
        lb_clienteSeleccionado.Location = New Point(344, 23)
        lb_clienteSeleccionado.Name = "lb_clienteSeleccionado"
        lb_clienteSeleccionado.Size = New Size(175, 23)
        lb_clienteSeleccionado.TabIndex = 9
        lb_clienteSeleccionado.Text = "Cliente seleccionado: "
        ' 
        ' lb_total
        ' 
        lb_total.AutoSize = True
        lb_total.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_total.ForeColor = Color.White
        lb_total.Location = New Point(344, 468)
        lb_total.Name = "lb_total"
        lb_total.Size = New Size(75, 28)
        lb_total.TabIndex = 10
        lb_total.Text = "TOTAL: "
        ' 
        ' FormVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(993, 583)
        Controls.Add(lb_total)
        Controls.Add(lb_clienteSeleccionado)
        Controls.Add(lb_carrito)
        Controls.Add(btn_finalizar)
        Controls.Add(dgv_itemsVenta)
        Controls.Add(btn_agregar)
        Controls.Add(GroupBox1)
        Name = "FormVenta"
        Text = "Ventas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nud_cantidad, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_itemsVenta, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_productos As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lb_cantidad As Label
    Friend WithEvents nud_cantidad As NumericUpDown
    Friend WithEvents lb_detalle As Label
    Friend WithEvents rtb_detalles As RichTextBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dgv_itemsVenta As DataGridView
    Friend WithEvents btn_finalizar As Button
    Friend WithEvents lb_carrito As Label
    Friend WithEvents btn_seleccionarCliente As Button
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents lb_clienteSeleccionado As Label
    Friend WithEvents lb_total As Label

End Class
