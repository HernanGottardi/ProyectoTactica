<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSeleccionarCliente
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
        lsb_clientes = New ListBox()
        btn_seleccionar = New Button()
        lb_seleccionarCliente = New Label()
        SuspendLayout()
        ' 
        ' lsb_clientes
        ' 
        lsb_clientes.FormattingEnabled = True
        lsb_clientes.Location = New Point(11, 74)
        lsb_clientes.Name = "lsb_clientes"
        lsb_clientes.Size = New Size(469, 164)
        lsb_clientes.TabIndex = 0
        ' 
        ' btn_seleccionar
        ' 
        btn_seleccionar.BackColor = Color.Gray
        btn_seleccionar.ForeColor = Color.White
        btn_seleccionar.Location = New Point(12, 261)
        btn_seleccionar.Name = "btn_seleccionar"
        btn_seleccionar.Size = New Size(168, 36)
        btn_seleccionar.TabIndex = 1
        btn_seleccionar.Text = "Seleccionar"
        btn_seleccionar.UseVisualStyleBackColor = False
        ' 
        ' lb_seleccionarCliente
        ' 
        lb_seleccionarCliente.AutoSize = True
        lb_seleccionarCliente.Font = New Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lb_seleccionarCliente.ForeColor = Color.White
        lb_seleccionarCliente.Location = New Point(12, 23)
        lb_seleccionarCliente.Name = "lb_seleccionarCliente"
        lb_seleccionarCliente.Size = New Size(237, 35)
        lb_seleccionarCliente.TabIndex = 2
        lb_seleccionarCliente.Text = "Seleccionar cliente"
        ' 
        ' FormSeleccionarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(493, 313)
        Controls.Add(lb_seleccionarCliente)
        Controls.Add(btn_seleccionar)
        Controls.Add(lsb_clientes)
        Name = "FormSeleccionarCliente"
        Text = "Seleccion de Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_clientes As ListBox
    Friend WithEvents btn_seleccionar As Button
    Friend WithEvents lb_seleccionarCliente As Label

End Class
