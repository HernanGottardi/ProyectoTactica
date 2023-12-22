
Imports Clases
Public Class FormBajaProducto

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub


    Private Sub configurarListaProductos()

        lsb_productos.Items.Clear()

        For Each p As Producto In Producto.ObtenerProductos()
            lsb_productos.Items.Add(p.Nombre)
        Next

    End Sub

    Private Sub FormBajaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaProductos()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim nombreSeleccionado As String
        Dim pro As Producto

        If (Me.lsb_productos.SelectedItem IsNot Nothing) Then

            nombreSeleccionado = Me.lsb_productos.SelectedItem.ToString()
            pro = Producto.ObtenerProducto(nombreSeleccionado)

            Producto.BajaProducto(pro.Id)
            ' Actualizamos

            configurarListaProductos()
            Me.DialogResult = DialogResult.OK
            MessageBox.Show("La Baja de Producto ha salido con exito!")
        End If
    End Sub
End Class
