Public Class FormsMenuPrincipal

    Public Sub New()
        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click
        Dim form As New FormVentaPrincipal.FormVentasPrincipal
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Dim form As New FormProductoPrincipal.FormProductoPrincipal
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Dim form As New FormClientePrincipal.FormBuscadorCliente
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub
End Class
