<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentasPrincipal
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
        AltaVentaToolStripMenuItem = New ToolStripMenuItem()
        BajaVentaToolStripMenuItem = New ToolStripMenuItem()
        ModificarVentaToolStripMenuItem = New ToolStripMenuItem()
        dgv_ventas = New DataGridView()
        Label1 = New Label()
        txb_buscador = New TextBox()
        cb_filtros = New ComboBox()
        Label2 = New Label()
        btn_limpiarBusqueda = New Button()
        lb_totalGeneral = New Label()
        MenuStrip1.SuspendLayout()
        CType(dgv_ventas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AltaVentaToolStripMenuItem, BajaVentaToolStripMenuItem, ModificarVentaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(991, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AltaVentaToolStripMenuItem
        ' 
        AltaVentaToolStripMenuItem.Font = New Font("Segoe UI", 10.2F)
        AltaVentaToolStripMenuItem.ForeColor = Color.White
        AltaVentaToolStripMenuItem.Name = "AltaVentaToolStripMenuItem"
        AltaVentaToolStripMenuItem.Size = New Size(103, 27)
        AltaVentaToolStripMenuItem.Text = "Alta Venta"
        ' 
        ' BajaVentaToolStripMenuItem
        ' 
        BajaVentaToolStripMenuItem.Font = New Font("Segoe UI", 10.2F)
        BajaVentaToolStripMenuItem.ForeColor = Color.White
        BajaVentaToolStripMenuItem.Name = "BajaVentaToolStripMenuItem"
        BajaVentaToolStripMenuItem.Size = New Size(105, 27)
        BajaVentaToolStripMenuItem.Text = "Baja Venta"
        ' 
        ' ModificarVentaToolStripMenuItem
        ' 
        ModificarVentaToolStripMenuItem.Font = New Font("Segoe UI", 10.2F)
        ModificarVentaToolStripMenuItem.ForeColor = Color.White
        ModificarVentaToolStripMenuItem.Name = "ModificarVentaToolStripMenuItem"
        ModificarVentaToolStripMenuItem.Size = New Size(144, 27)
        ModificarVentaToolStripMenuItem.Text = "Modificar Venta"
        ' 
        ' dgv_ventas
        ' 
        dgv_ventas.BackgroundColor = Color.White
        dgv_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ventas.Location = New Point(45, 168)
        dgv_ventas.Name = "dgv_ventas"
        dgv_ventas.RowHeadersWidth = 51
        dgv_ventas.Size = New Size(904, 256)
        dgv_ventas.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(45, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 28)
        Label1.TabIndex = 2
        Label1.Text = "Buscar Venta"
        ' 
        ' txb_buscador
        ' 
        txb_buscador.Location = New Point(209, 105)
        txb_buscador.Name = "txb_buscador"
        txb_buscador.Size = New Size(291, 30)
        txb_buscador.TabIndex = 3
        ' 
        ' cb_filtros
        ' 
        cb_filtros.FormattingEnabled = True
        cb_filtros.Location = New Point(688, 109)
        cb_filtros.Name = "cb_filtros"
        cb_filtros.Size = New Size(260, 31)
        cb_filtros.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(588, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 28)
        Label2.TabIndex = 5
        Label2.Text = "Filtros"
        ' 
        ' btn_limpiarBusqueda
        ' 
        btn_limpiarBusqueda.BackColor = Color.White
        btn_limpiarBusqueda.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_limpiarBusqueda.ForeColor = Color.Black
        btn_limpiarBusqueda.Location = New Point(45, 484)
        btn_limpiarBusqueda.Name = "btn_limpiarBusqueda"
        btn_limpiarBusqueda.Size = New Size(230, 43)
        btn_limpiarBusqueda.TabIndex = 6
        btn_limpiarBusqueda.Text = "Limpiar Busqueda"
        btn_limpiarBusqueda.UseVisualStyleBackColor = False
        ' 
        ' lb_totalGeneral
        ' 
        lb_totalGeneral.AutoSize = True
        lb_totalGeneral.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_totalGeneral.Location = New Point(45, 440)
        lb_totalGeneral.Name = "lb_totalGeneral"
        lb_totalGeneral.Size = New Size(132, 25)
        lb_totalGeneral.TabIndex = 7
        lb_totalGeneral.Text = "Total General: $"
        ' 
        ' FormVentasPrincipal
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(991, 553)
        Controls.Add(lb_totalGeneral)
        Controls.Add(btn_limpiarBusqueda)
        Controls.Add(Label2)
        Controls.Add(cb_filtros)
        Controls.Add(txb_buscador)
        Controls.Add(Label1)
        Controls.Add(dgv_ventas)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 10.2F)
        ForeColor = Color.White
        MainMenuStrip = MenuStrip1
        Name = "FormVentasPrincipal"
        Text = "Ventas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgv_ventas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv_ventas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txb_buscador As TextBox
    Friend WithEvents cb_filtros As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_limpiarBusqueda As Button
    Friend WithEvents lb_totalGeneral As Label

End Class
