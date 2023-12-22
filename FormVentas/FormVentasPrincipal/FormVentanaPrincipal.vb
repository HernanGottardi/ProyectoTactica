
Imports Clases
Imports FormAltaVenta
Imports FormBajaVenta
Imports FormModificarVenta


Public Class FormVentasPrincipal

    Dim todasLasVentas As List(Of Venta) = Venta.ObtenerVentas()

    Public Sub New()
        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        CargarVentas()
        CargarTotalGeneral()
    End Sub

    Private Sub FormVentasPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_filtros.DropDownStyle = ComboBoxStyle.DropDownList
        cb_filtros.Items.AddRange({"IDCliente", "Fecha", "Total"})
        cb_filtros.Items.Insert(0, "ID")

        cb_filtros.SelectedIndex = 0

        CargarVentas()
        CargarTotalGeneral()
    End Sub

    Private Sub ConfigurarColumnasDataGridView()

        dgv_ventas.AutoGenerateColumns = False
        dgv_ventas.Columns.Clear()

        dgv_ventas.Columns.Add("ID", "ID")
        dgv_ventas.Columns.Add("IDCliente", "IDCliente")
        dgv_ventas.Columns.Add("Fecha", "Fecha")
        dgv_ventas.Columns.Add("Total", "Total")

        dgv_ventas.Columns("ID").DataPropertyName = "ID"
        dgv_ventas.Columns("IDCliente").DataPropertyName = "IDCliente"
        dgv_ventas.Columns("Fecha").DataPropertyName = "Fecha"
        dgv_ventas.Columns("Total").DataPropertyName = "Total"


        For Each column As DataGridViewColumn In dgv_ventas.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            column.ReadOnly = True
        Next

        dgv_ventas.DefaultCellStyle.ForeColor = Color.Black

    End Sub

    Private Sub CargarVentas()
        todasLasVentas = Venta.ObtenerVentas()
        dgv_ventas.DataSource = todasLasVentas
        ConfigurarColumnasDataGridView()
    End Sub

    Private Sub CargarTotalGeneral()
        Dim totalGeneral As Decimal
        totalGeneral = 0

        For Each venta As Venta In todasLasVentas
            totalGeneral += venta.Total
        Next

        Me.lb_totalGeneral.Text = $"Total General: ${totalGeneral}"

    End Sub

    Private Sub ActualizarDataGridView()
        Try
            Dim criterio As String = txb_buscador.Text
            Dim opcion As String = If(cb_filtros.SelectedItem IsNot Nothing, cb_filtros.SelectedItem.ToString(), "ID")

            Dim resultados As List(Of Venta)

            Select Case opcion
                Case "ID"
                    resultados = todasLasVentas.Where(Function(v) v.ID.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case "IDCliente"
                    resultados = todasLasVentas.Where(Function(v) v.IDCliente.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case "Fecha"
                    resultados = todasLasVentas.Where(Function(v) v.Fecha.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case "Total"
                    resultados = todasLasVentas.Where(Function(v) v.Total.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case Else
                    MessageBox.Show("Opción de búsqueda no válida")
                    Return
            End Select

            dgv_ventas.DataSource = Nothing
            dgv_ventas.DataSource = resultados
        Catch ex As Exception
            MessageBox.Show($"Error al actualizar el DataGridView: {ex.Message}")
        End Try
    End Sub

    Private Sub txb_buscador_TextChanged(sender As Object, e As EventArgs) Handles txb_buscador.TextChanged
        ActualizarDataGridView()
    End Sub

    Private Sub cb_filtros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filtros.SelectedIndexChanged
        ActualizarDataGridView()
    End Sub

    Private Sub btn_limpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btn_limpiarBusqueda.Click
        Me.txb_buscador.Clear()
    End Sub

    Private Sub AltaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaVentaToolStripMenuItem.Click
        Dim form As New FormVenta
        Dim res As DialogResult

        res = form.ShowDialog()

        If (res = DialogResult.OK) Then
            CargarVentas()
            CargarTotalGeneral()
        End If
    End Sub

    Private Sub BajaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaVentaToolStripMenuItem.Click
        Dim form As New FormBajaVenta.FormBajaVenta
        Dim res As DialogResult

        res = form.ShowDialog()

        If (res = DialogResult.OK) Then
            CargarVentas()
            CargarTotalGeneral()
        End If
    End Sub

    Private Sub ModificarVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarVentaToolStripMenuItem.Click

        Dim form As New FormModificarVenta.FormModificarVenta
        Dim res As DialogResult

        res = form.ShowDialog()

        If (res = DialogResult.OK) Then
            CargarVentas()
            CargarTotalGeneral()
        End If

    End Sub
End Class
