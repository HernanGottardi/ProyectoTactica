Imports Clases

Public Class FormModificarItems

    Dim ventaSeleccionado As Venta
    Dim itemVentaSeleccionado As ItemVenta

    Public Sub New(venta As Venta)
        ventaSeleccionado = venta
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ConfigurarListaItems()
        ventaSeleccionado.CargarItemsVenta()
        lsb_listaItemsVenta.Items.Clear()

        For Each item As ItemVenta In ventaSeleccionado.Items
            lsb_listaItemsVenta.Items.Add($"ID:{item.ID} - CANT: {item.Cantidad} -TOTAL: {item.PrecioTotal}")
        Next
    End Sub

    Private Sub FormModificarItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarListaItems()
    End Sub

    Private Sub lsb_listaItemsVenta_Click(sender As Object, e As EventArgs) Handles lsb_listaItemsVenta.Click
        If lsb_listaItemsVenta.SelectedItem IsNot Nothing Then
            Dim ventaSeleccionadaString As String = lsb_listaItemsVenta.SelectedItem.ToString()
            Dim index As Integer = ventaSeleccionadaString.IndexOf(" ")

            If index >= 0 Then
                Dim idVentaString As String = ventaSeleccionadaString.Substring(3, index - 3)
                Dim idVentaSeleccionada As Integer

                If Integer.TryParse(idVentaString, idVentaSeleccionada) Then
                    itemVentaSeleccionado = ventaSeleccionado.Items.Find(Function(v) v.ID = idVentaSeleccionada)

                    If itemVentaSeleccionado IsNot Nothing Then
                        ' Actualizar los valores en los controles TextBox
                        txb_cantidad.Text = itemVentaSeleccionado.Cantidad.ToString()
                        txb_precioUnitario.Text = itemVentaSeleccionado.PrecioUnitario.ToString()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If itemVentaSeleccionado IsNot Nothing Then
            ' Obtener los valores de los controles TextBox
            Dim nuevaCantidad As Double
            Dim nuevoPrecioUnitario As Double

            If Double.TryParse(txb_cantidad.Text, nuevaCantidad) AndAlso Double.TryParse(txb_precioUnitario.Text, nuevoPrecioUnitario) Then
                Dim precioTotal As Double = nuevaCantidad * nuevoPrecioUnitario

                If nuevaCantidad > 0 And nuevoPrecioUnitario > 0 Then
                    ' Actualizo el item venta
                    itemVentaSeleccionado.ModificarCantidadEnDB(nuevaCantidad)
                    itemVentaSeleccionado.ModificarPrecioUnitarioEnDB(nuevoPrecioUnitario)
                    itemVentaSeleccionado.ModificarPrecioTotalEnDB(precioTotal)

                    Dim ventaAux2 As Venta
                    ventaAux2 = Venta.ObtenerVentaPorID(ventaSeleccionado.ID)
                    ventaAux2.CargarItemsVenta()
                    ' Actualizo la venta

                    Venta.ModificarTotalPorID(ventaAux2.ID, ventaAux2.CalcularTotal())
                    ConfigurarListaItems()

                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Los valores deben ser mayores a 0.")
                End If
            Else
                MessageBox.Show("Ingrese valores numéricos válidos en Cantidad y Precio Unitario.")
            End If
        Else
            MessageBox.Show("Debe seleccionarse un Item de Venta.")
        End If
    End Sub
End Class
