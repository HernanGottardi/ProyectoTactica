
Imports Clases
Public Class FormAltaProducto

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
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

        ' Valido si lo ingresado en los campos es correcto.
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

        If Not Decimal.TryParse(txb_precio.Text, precio) Then
            lb_mensajePrecio.Text = "-> Precio incorrecto. (numero mayor a 0)"
        End If

        ' Verificar si hay algún mensaje de error y mostrarlo en el Label
        If lb_mensajeCategoria.Text = "" And lb_mensajeNombre.Text = "" And lb_mensajePrecio.Text = "" And lb_mensajeVacio.Text = "" Then

            Dim p As Producto
            p = Producto.CrearProducto(nombre, precio, categoria)
            p.AltaProducto()

            Me.DialogResult = DialogResult.OK
            MessageBox.Show("El Producto se ha dado de Alta con exito!")

        End If
    End Sub
End Class
