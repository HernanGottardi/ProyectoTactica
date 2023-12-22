<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBajaProducto
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
        Label1 = New Label()
        btn_eliminar = New Button()
        SuspendLayout()
        ' 
        ' lsb_productos
        ' 
        lsb_productos.FormattingEnabled = True
        lsb_productos.Location = New Point(44, 105)
        lsb_productos.Name = "lsb_productos"
        lsb_productos.Size = New Size(645, 224)
        lsb_productos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Courier New", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(44, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 31)
        Label1.TabIndex = 1
        Label1.Text = "Seleccionar Producto a dar de Baja:"
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.BackColor = Color.Navy
        btn_eliminar.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_eliminar.Location = New Point(44, 361)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(243, 40)
        btn_eliminar.TabIndex = 2
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = False
        ' 
        ' FormBajaProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(741, 428)
        Controls.Add(btn_eliminar)
        Controls.Add(Label1)
        Controls.Add(lsb_productos)
        ForeColor = Color.White
        Name = "FormBajaProducto"
        Text = "Baja Producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsb_productos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_eliminar As Button

End Class
