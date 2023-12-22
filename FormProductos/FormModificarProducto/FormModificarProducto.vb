Imports Clases

Public Class FormModificarProducto
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

    Private Sub FormModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaProductos()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim nombreSeleccionado As String
        Dim prdEncontrado As Producto

        Dim nombre As String = txb_nombre.Text
        Dim precio As Decimal
        Dim categoria As String = txb_categoria.Text

        lb_mensajeCategoria.Text = ""
        lb_mensajeCategoria.Visible = True

        lb_mensajeNombre.Text = ""
        lb_mensajeNombre.Visible = True

        lb_mensajePrecio.Text = ""
        lb_mensajePrecio.Visible = True

        lb_mensajeVacio.Text = ""
        lb_mensajeVacio.Visible = True

        If Me.lsb_productos.SelectedItem IsNot Nothing Then
            nombreSeleccionado = Me.lsb_productos.SelectedItem.ToString()
            prdEncontrado = Producto.ObtenerProducto(nombreSeleccionado)

            ' Validar si lo ingresado en los campos es correcto.
            If String.IsNullOrWhiteSpace(txb_nombre.Text) Or String.IsNullOrWhiteSpace(txb_precio.Text) Or String.IsNullOrEmpty(txb_categoria.Text) Then
                lb_mensajeVacio.Text = "-> Por favor rellenar todos los campos." & vbCrLf
            End If

            ' Realizar la validación y mostrar mensajes de error si es necesario
            If Not ValidacionesEntidades.validarNombre(nombre) Then
                lb_mensajeNombre.Text = "-> Nombre incorrecto. (letras a-z, min:4, max:255)"
            End If

            If Not ValidacionesEntidades.validarNombre(categoria) Then
                lb_mensajeCategoria.Text = "-> Categoria incorrecta. (letras a-z, min:4, max:255)"
            End If

            If Not Decimal.TryParse(txb_precio.Text, precio) OrElse precio <= 0 Then
                lb_mensajePrecio.Text = "-> Precio incorrecto. (numero mayor a 0)"
            End If

            ' Verificar si hay algún mensaje de error y mostrarlo en el Label
            If lb_mensajeCategoria.Text = "" And lb_mensajeNombre.Text = "" And lb_mensajePrecio.Text = "" And lb_mensajeVacio.Text = "" Then
                Producto.ModificarProducto(prdEncontrado.Id, nombre, precio, categoria)

                configurarListaProductos()

                Me.DialogResult = DialogResult.OK
                MessageBox.Show("El Producto se ha Modificado con éxito!")
            End If
        Else
            MessageBox.Show("Primero se debe seleccionar un Producto.")
        End If
    End Sub

    Private Sub FormModificarProducto_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ActualizarCamposProductoSeleccionado()
    End Sub

    Private Sub ActualizarCamposProductoSeleccionado()

        If Me.lsb_productos.SelectedItem IsNot Nothing Then
            Dim nombreSeleccionado As String = Me.lsb_productos.SelectedItem.ToString()
            Dim prd As Producto = Producto.ObtenerProducto(nombreSeleccionado)

            MostrarInformacionProducto(prd)
        End If
    End Sub

    Private Sub MostrarInformacionProducto(producto As Producto)
        txb_nombre.Text = producto.Nombre
        txb_precio.Text = producto.Precio.ToString()
        txb_categoria.Text = producto.Categoria
    End Sub

    Private Sub lsb_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsb_productos.SelectedIndexChanged
        ActualizarCamposProductoSeleccionado()
    End Sub
End Class
