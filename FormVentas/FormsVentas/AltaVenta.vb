
Imports Clases
Imports FormEleccionCliente
Public Class FormVenta

    Dim clienteSeleccionado As Cliente
    Dim todosLosProductos As List(Of Producto) = Producto.ObtenerProductos()
    Dim listaItemVentas As List(Of ItemVenta)
    Dim ventaAux As New Venta()

    Public Sub New()

        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaProductos()
        ConfigurarListaItemsVentas()

    End Sub

    Private Sub btn_seleccionarCliente_Click(sender As Object, e As EventArgs) Handles btn_seleccionarCliente.Click

        Dim form As New FormEleccionCliente.FormSeleccionarCliente
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then

            If Me.clienteSeleccionado Is Nothing Then
                clienteSeleccionado = form.ClienteSeleccionado
            ElseIf Me.clienteSeleccionado IsNot form.ClienteSeleccionado Then
                ventaAux.Items.Clear()
                dgv_itemsVenta.Rows.Clear()
                clienteSeleccionado = form.ClienteSeleccionado
            End If

            lb_clienteSeleccionado.Text = "Cliente seleccionado: " + clienteSeleccionado.Nombre

            ' Le agrego el id de cliente al objeto Ventas.
            ventaAux.IDCliente = clienteSeleccionado.Id
        End If

    End Sub

    Private Sub configurarListaProductos()

        lsb_productos.Items.Clear()

        For Each producto As Producto In Producto.ObtenerProductos()
            lsb_productos.Items.Add(producto.Nombre)
        Next

    End Sub

    Private Sub ConfigurarListaItemsVentas()
        ' Configurar las columnas del DataGridView
        dgv_itemsVenta.Columns.Add("Nombre", "Nombre")
        dgv_itemsVenta.Columns.Add("Cantidad", "Cantidad")
        dgv_itemsVenta.Columns.Add("PrecioUnitario", "Precio Unitario")
        dgv_itemsVenta.Columns.Add("PrecioTotal", "Precio Total")

        For Each columna As DataGridViewColumn In dgv_itemsVenta.Columns
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub lsb_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsb_productos.SelectedIndexChanged

        Dim nombreSeleccionado As String
        Dim productoEncontrado As Producto

        If (Me.lsb_productos.SelectedItem IsNot Nothing) Then

            nombreSeleccionado = Me.lsb_productos.SelectedItem.ToString()
            productoEncontrado = Producto.ObtenerProducto(nombreSeleccionado)

            rtb_detalles.Text = productoEncontrado.ObtenerDatosProducto()

        End If

    End Sub

    Private Sub AgregarItemVentaYActualizarDataGridView(itemVenta As ItemVenta, producto As Producto)
        ' Agregar el itemVenta a ventaAux
        ventaAux.AgregarItem(itemVenta)

        ' Actualizar el DataGridView
        dgv_itemsVenta.Rows.Add(producto.Nombre, itemVenta.Cantidad, itemVenta.PrecioUnitario, itemVenta.PrecioTotal)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Dim mensaje As String = ""
        Dim itemVenta As ItemVenta
        Dim productoSeleccionado As Producto

        ' validar cantidad (mayor a 0)
        If nud_cantidad.Value <= 0 Then
            mensaje += $"- La cantidad debe ser mayor a 0.{vbCrLf}"
            ' validar cliente (Cliente seleccionado, variable diferente a null)
        End If
        If Me.clienteSeleccionado Is Nothing Then
            mensaje += $"- Debe seleccionarse un cliente.{vbCrLf}"
            ' validar producto (producto seleccionado)
        End If
        If Me.lsb_productos.SelectedItem Is Nothing Then
            mensaje += $"- Debe seleccionarse un producto.{vbCrLf}"
        End If

        ' Si mensaje sigue siendo vacío, establecer el mensaje de éxito
        If String.IsNullOrEmpty(mensaje) Then
            ' Logica para agregar venta, item venta
            productoSeleccionado = Producto.ObtenerProducto(Me.lsb_productos.SelectedItem.ToString())

            ' Creamos un objeto "ventas" temporal, por si el usuario concreta la venta.
            Dim id_venta_temporal As Integer
            id_venta_temporal = Venta.ObtenerUltimoID()

            ' Creamos un objeto "item venta" temporal 
            itemVenta = ItemVenta.CrearItemVenta(id_venta_temporal, productoSeleccionado.Id, productoSeleccionado.Precio, nud_cantidad.Value)
            AgregarItemVentaYActualizarDataGridView(itemVenta, productoSeleccionado)

            Dim total As Double
            total = ventaAux.CalcularTotal()

            lb_total.Text = $"TOTAL: ${total}"
        Else
            ' Mostrar el mensaje
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub btn_finalizar_Click(sender As Object, e As EventArgs) Handles btn_finalizar.Click

        Dim resultado As DialogResult
        Dim total As Double

        total = ventaAux.CalcularTotal()

        resultado = MessageBox.Show("¿Seguro que desea realizar esta venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            ventaAux.Total = total
            ventaAux.Fecha = DateTime.Now
            ventaAux.AltaVenta()
            Me.DialogResult = DialogResult.OK
        End If

    End Sub
End Class
