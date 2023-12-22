<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuscadorCliente
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
        tb_buscadorClientes = New TextBox()
        dgv_resultadosBusquedaCliente = New DataGridView()
        cb_opcionesBuscarCliente = New ComboBox()
        lb_buscadorClientes = New Label()
        lb_filtrarOpciones = New Label()
        btn_limpiarBuscarCliente = New Button()
        mt_abm = New MenuStrip()
        AltaClienteToolStripMenuItem = New ToolStripMenuItem()
        BajaClienteToolStripMenuItem = New ToolStripMenuItem()
        ModificarClienteToolStripMenuItem = New ToolStripMenuItem()
        CType(dgv_resultadosBusquedaCliente, ComponentModel.ISupportInitialize).BeginInit()
        mt_abm.SuspendLayout()
        SuspendLayout()
        ' 
        ' tb_buscadorClientes
        ' 
        tb_buscadorClientes.Location = New Point(211, 82)
        tb_buscadorClientes.Margin = New Padding(5, 4, 5, 4)
        tb_buscadorClientes.Name = "tb_buscadorClientes"
        tb_buscadorClientes.Size = New Size(309, 30)
        tb_buscadorClientes.TabIndex = 0
        ' 
        ' dgv_resultadosBusquedaCliente
        ' 
        dgv_resultadosBusquedaCliente.BackgroundColor = Color.White
        dgv_resultadosBusquedaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_resultadosBusquedaCliente.Location = New Point(68, 139)
        dgv_resultadosBusquedaCliente.Margin = New Padding(5, 4, 5, 4)
        dgv_resultadosBusquedaCliente.Name = "dgv_resultadosBusquedaCliente"
        dgv_resultadosBusquedaCliente.RowHeadersWidth = 51
        dgv_resultadosBusquedaCliente.Size = New Size(832, 302)
        dgv_resultadosBusquedaCliente.TabIndex = 1
        ' 
        ' cb_opcionesBuscarCliente
        ' 
        cb_opcionesBuscarCliente.FormattingEnabled = True
        cb_opcionesBuscarCliente.Location = New Point(654, 82)
        cb_opcionesBuscarCliente.Margin = New Padding(5, 4, 5, 4)
        cb_opcionesBuscarCliente.Name = "cb_opcionesBuscarCliente"
        cb_opcionesBuscarCliente.Size = New Size(246, 33)
        cb_opcionesBuscarCliente.TabIndex = 3
        ' 
        ' lb_buscadorClientes
        ' 
        lb_buscadorClientes.AutoSize = True
        lb_buscadorClientes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_buscadorClientes.Location = New Point(68, 82)
        lb_buscadorClientes.Margin = New Padding(5, 0, 5, 0)
        lb_buscadorClientes.Name = "lb_buscadorClientes"
        lb_buscadorClientes.Size = New Size(133, 28)
        lb_buscadorClientes.TabIndex = 2
        lb_buscadorClientes.Text = "Buscar Cliente"
        ' 
        ' lb_filtrarOpciones
        ' 
        lb_filtrarOpciones.AutoSize = True
        lb_filtrarOpciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_filtrarOpciones.Location = New Point(578, 84)
        lb_filtrarOpciones.Margin = New Padding(5, 0, 5, 0)
        lb_filtrarOpciones.Name = "lb_filtrarOpciones"
        lb_filtrarOpciones.Size = New Size(66, 28)
        lb_filtrarOpciones.TabIndex = 4
        lb_filtrarOpciones.Text = "Filtros"
        ' 
        ' btn_limpiarBuscarCliente
        ' 
        btn_limpiarBuscarCliente.BackColor = Color.MediumSlateBlue
        btn_limpiarBuscarCliente.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_limpiarBuscarCliente.ForeColor = Color.White
        btn_limpiarBuscarCliente.Location = New Point(68, 463)
        btn_limpiarBuscarCliente.Margin = New Padding(5, 4, 5, 4)
        btn_limpiarBuscarCliente.Name = "btn_limpiarBuscarCliente"
        btn_limpiarBuscarCliente.Size = New Size(293, 46)
        btn_limpiarBuscarCliente.TabIndex = 6
        btn_limpiarBuscarCliente.Text = "Limpiar busqueda"
        btn_limpiarBuscarCliente.UseVisualStyleBackColor = False
        ' 
        ' mt_abm
        ' 
        mt_abm.BackColor = Color.MediumSlateBlue
        mt_abm.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mt_abm.ImageScalingSize = New Size(20, 20)
        mt_abm.Items.AddRange(New ToolStripItem() {AltaClienteToolStripMenuItem, BajaClienteToolStripMenuItem, ModificarClienteToolStripMenuItem})
        mt_abm.Location = New Point(0, 0)
        mt_abm.Name = "mt_abm"
        mt_abm.Padding = New Padding(10, 2, 0, 2)
        mt_abm.Size = New Size(972, 33)
        mt_abm.TabIndex = 7
        mt_abm.Text = "MenuStrip1"
        ' 
        ' AltaClienteToolStripMenuItem
        ' 
        AltaClienteToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F)
        AltaClienteToolStripMenuItem.ForeColor = Color.White
        AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        AltaClienteToolStripMenuItem.Size = New Size(126, 29)
        AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        ' 
        ' BajaClienteToolStripMenuItem
        ' 
        BajaClienteToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F)
        BajaClienteToolStripMenuItem.ForeColor = Color.White
        BajaClienteToolStripMenuItem.Name = "BajaClienteToolStripMenuItem"
        BajaClienteToolStripMenuItem.Size = New Size(131, 29)
        BajaClienteToolStripMenuItem.Text = "Baja Cliente"
        ' 
        ' ModificarClienteToolStripMenuItem
        ' 
        ModificarClienteToolStripMenuItem.Font = New Font("Microsoft Sans Serif", 12F)
        ModificarClienteToolStripMenuItem.ForeColor = Color.White
        ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        ModificarClienteToolStripMenuItem.Size = New Size(171, 29)
        ModificarClienteToolStripMenuItem.Text = "Modificar Cliente"
        ' 
        ' FormBuscadorCliente
        ' 
        AutoScaleDimensions = New SizeF(12F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(972, 524)
        Controls.Add(btn_limpiarBuscarCliente)
        Controls.Add(lb_filtrarOpciones)
        Controls.Add(cb_opcionesBuscarCliente)
        Controls.Add(lb_buscadorClientes)
        Controls.Add(dgv_resultadosBusquedaCliente)
        Controls.Add(tb_buscadorClientes)
        Controls.Add(mt_abm)
        Font = New Font("Microsoft Sans Serif", 12F)
        MainMenuStrip = mt_abm
        Margin = New Padding(5, 4, 5, 4)
        Name = "FormBuscadorCliente"
        Text = "Clientes"
        CType(dgv_resultadosBusquedaCliente, ComponentModel.ISupportInitialize).EndInit()
        mt_abm.ResumeLayout(False)
        mt_abm.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tb_buscadorClientes As TextBox
    Friend WithEvents dgv_resultadosBusquedaCliente As DataGridView
    Friend WithEvents cb_opcionesBuscarCliente As ComboBox
    Friend WithEvents lb_buscadorClientes As Label
    Friend WithEvents lb_filtrarOpciones As Label
    Friend WithEvents btn_limpiarBuscarCliente As Button
    Friend WithEvents mt_abm As MenuStrip
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem

End Class
