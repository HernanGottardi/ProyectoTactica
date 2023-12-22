Imports Clases

Public Class FormModificarVenta

    Dim ventas As List(Of Venta)

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        ConfigurarListaVentas()
    End Sub

    Private Sub ConfigurarListaVentas()

        ventas = Venta.ObtenerVentas()
        lsb_listaVentas.Items.Clear()

        ' Agregar instancias de Venta al ListBox
        For Each venta As Venta In ventas
            ' Mostrar ID y Total en el ListBox
            lsb_listaVentas.Items.Add($"ID:{venta.ID} - TOTAL:{venta.Total}")
        Next
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If lsb_listaVentas.SelectedItem IsNot Nothing Then
            ' Obtener la cadena completa de la venta seleccionada
            Dim ventaSeleccionadaString As String = lsb_listaVentas.SelectedItem.ToString()

            ' Buscar la posición del primer espacio en blanco para obtener la subcadena antes de ese espacio
            Dim index As Integer = ventaSeleccionadaString.IndexOf(" ")

            If index >= 0 Then
                ' Extraer la subcadena antes del primer espacio en blanco (debería ser el ID)
                Dim idVentaString As String = ventaSeleccionadaString.Substring(3, index - 3)

                ' Declarar la variable idVentaSeleccionada antes de usarla
                Dim idVentaSeleccionada As Integer

                ' Intentar convertir la subcadena en un número entero
                If Integer.TryParse(idVentaString, idVentaSeleccionada) Then
                    ' Buscar la instancia de Venta correspondiente al ID
                    Dim ventaSeleccionada As Venta = ventas.Find(Function(v) v.ID = idVentaSeleccionada)

                    If ventaSeleccionada IsNot Nothing Then

                        Dim form As New FormModificarItems.FormModificarItems(ventaSeleccionada)
                        Dim res As DialogResult

                        res = form.ShowDialog
                        If (res = DialogResult.OK) Then
                            ConfigurarListaVentas()
                            Me.DialogResult = DialogResult.OK
                        End If
                    End If
                Else
                    ' Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("No se pudo obtener el ID de la venta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub



End Class
