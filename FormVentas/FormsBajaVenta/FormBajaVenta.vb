
Imports Clases
Public Class FormBajaVenta

    Dim ventas As List(Of Venta)
    Dim ventaSeleccionada As Venta

    Public Sub New()
        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub FormBajaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarListaVentas()
    End Sub
    Private Sub ConfigurarListaVentas()

        ventas = Venta.ObtenerVentas()

        lsb_ventas.Items.Clear()

        For Each v As Venta In ventas
            lsb_ventas.Items.Add($"ID:{v.ID} - CANT: {v.IDCliente} - FECHA: {v.Fecha} - TOTAL: {v.Total}")
        Next

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If lsb_ventas.SelectedItem IsNot Nothing Then

            Dim ventaSeleccionadaString As String = lsb_ventas.SelectedItem.ToString()
            Dim index As Integer = ventaSeleccionadaString.IndexOf(" ")

            If index >= 0 Then

                Dim idVentaString As String = ventaSeleccionadaString.Substring(3, index - 3)
                Dim idVentaSeleccionada As Integer

                If Integer.TryParse(idVentaString, idVentaSeleccionada) Then

                    ventaSeleccionada = ventas.Find(Function(v) v.ID = idVentaSeleccionada)

                    If ventaSeleccionada IsNot Nothing Then

                        ItemVenta.DarDeBajaItemsPorIDVenta(ventaSeleccionada.ID)
                        Venta.BajaVenta(ventaSeleccionada.ID)

                        ConfigurarListaVentas()

                        Me.DialogResult = DialogResult.OK

                    End If
                End If
            End If
        End If
    End Sub
End Class
