<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductoPrincipal
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
        MenuStrip1 = New MenuStrip()
        AltaProductoToolStripMenuItem = New ToolStripMenuItem()
        BajaProductoToolStripMenuItem = New ToolStripMenuItem()
        ModificarProductoToolStripMenuItem = New ToolStripMenuItem()
        dgv_productos = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        txb_buscar = New TextBox()
        cb_filtros = New ComboBox()
        btn_limpiarBusqueda = New Button()
        MenuStrip1.SuspendLayout()
        CType(dgv_productos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.MidnightBlue
        MenuStrip1.Font = New Font("Segoe UI", 10.8F)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AltaProductoToolStripMenuItem, BajaProductoToolStripMenuItem, ModificarProductoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(982, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AltaProductoToolStripMenuItem
        ' 
        AltaProductoToolStripMenuItem.Font = New Font("Segoe UI", 10.8F)
        AltaProductoToolStripMenuItem.ForeColor = Color.White
        AltaProductoToolStripMenuItem.Name = "AltaProductoToolStripMenuItem"
        AltaProductoToolStripMenuItem.Size = New Size(135, 29)
        AltaProductoToolStripMenuItem.Text = "Alta Producto"
        ' 
        ' BajaProductoToolStripMenuItem
        ' 
        BajaProductoToolStripMenuItem.Font = New Font("Segoe UI", 10.8F)
        BajaProductoToolStripMenuItem.ForeColor = Color.White
        BajaProductoToolStripMenuItem.Name = "BajaProductoToolStripMenuItem"
        BajaProductoToolStripMenuItem.Size = New Size(136, 29)
        BajaProductoToolStripMenuItem.Text = "Baja Producto"
        ' 
        ' ModificarProductoToolStripMenuItem
        ' 
        ModificarProductoToolStripMenuItem.Font = New Font("Segoe UI", 10.8F)
        ModificarProductoToolStripMenuItem.ForeColor = Color.White
        ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        ModificarProductoToolStripMenuItem.Size = New Size(179, 29)
        ModificarProductoToolStripMenuItem.Text = "Modificar Producto"
        ' 
        ' dgv_productos
        ' 
        dgv_productos.BackgroundColor = Color.White
        dgv_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_productos.Location = New Point(55, 122)
        dgv_productos.Name = "dgv_productos"
        dgv_productos.RowHeadersWidth = 51
        dgv_productos.Size = New Size(870, 307)
        dgv_productos.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 28)
        Label1.TabIndex = 2
        Label1.Text = "Buscar Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(646, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 28)
        Label2.TabIndex = 3
        Label2.Text = "Filtros"
        ' 
        ' txb_buscar
        ' 
        txb_buscar.Location = New Point(215, 72)
        txb_buscar.Name = "txb_buscar"
        txb_buscar.Size = New Size(353, 27)
        txb_buscar.TabIndex = 4
        ' 
        ' cb_filtros
        ' 
        cb_filtros.FormattingEnabled = True
        cb_filtros.Location = New Point(718, 71)
        cb_filtros.Name = "cb_filtros"
        cb_filtros.Size = New Size(207, 28)
        cb_filtros.TabIndex = 5
        ' 
        ' btn_limpiarBusqueda
        ' 
        btn_limpiarBusqueda.BackColor = Color.MidnightBlue
        btn_limpiarBusqueda.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_limpiarBusqueda.Location = New Point(55, 448)
        btn_limpiarBusqueda.Name = "btn_limpiarBusqueda"
        btn_limpiarBusqueda.Size = New Size(232, 41)
        btn_limpiarBusqueda.TabIndex = 6
        btn_limpiarBusqueda.Text = "Limpiar Busqueda"
        btn_limpiarBusqueda.UseVisualStyleBackColor = False
        ' 
        ' FormProductoPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(982, 515)
        Controls.Add(btn_limpiarBusqueda)
        Controls.Add(cb_filtros)
        Controls.Add(txb_buscar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgv_productos)
        Controls.Add(MenuStrip1)
        ForeColor = Color.White
        MainMenuStrip = MenuStrip1
        Name = "FormProductoPrincipal"
        Text = "Producto Principal"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgv_productos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv_productos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txb_buscar As TextBox
    Friend WithEvents cb_filtros As ComboBox
    Friend WithEvents btn_limpiarBusqueda As Button

End Class
