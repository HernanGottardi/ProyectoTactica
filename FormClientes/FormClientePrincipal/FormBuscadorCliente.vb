Imports Clases

Public Class FormBuscadorCliente

    Dim todosLosClientes As List(Of Cliente) = Cliente.ObtenerClientes()

    Public Sub New()

        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        CargarClientes()

    End Sub

    Private Sub CargarClientes()
        todosLosClientes = Cliente.ObtenerClientes()
        dgv_resultadosBusquedaCliente.DataSource = todosLosClientes
        ConfigurarColumnasDataGridView()
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_opcionesBuscarCliente.DropDownStyle = ComboBoxStyle.DropDownList
        cb_opcionesBuscarCliente.Items.AddRange({"Teléfono", "Correo"})
        cb_opcionesBuscarCliente.Items.Insert(0, "Nombre")

        cb_opcionesBuscarCliente.SelectedIndex = 0

        todosLosClientes = Cliente.ObtenerClientes()
        dgv_resultadosBusquedaCliente.DataSource = todosLosClientes

        ConfigurarColumnasDataGridView()

    End Sub


    Private Sub ConfigurarColumnasDataGridView()
        ' Configurar las columnas según las propiedades de Cliente
        dgv_resultadosBusquedaCliente.AutoGenerateColumns = False
        dgv_resultadosBusquedaCliente.Columns.Clear()

        dgv_resultadosBusquedaCliente.Columns.Add("Nombre", "Nombre")
        dgv_resultadosBusquedaCliente.Columns.Add("Correo", "Correo")
        dgv_resultadosBusquedaCliente.Columns.Add("Telefono", "Teléfono")

        dgv_resultadosBusquedaCliente.Columns("Nombre").DataPropertyName = "Nombre"
        dgv_resultadosBusquedaCliente.Columns("Correo").DataPropertyName = "Correo"
        dgv_resultadosBusquedaCliente.Columns("Telefono").DataPropertyName = "Telefono"


        ' Ajustar el ancho de las columnas
        For Each column As DataGridViewColumn In dgv_resultadosBusquedaCliente.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            column.ReadOnly = True
        Next


    End Sub

    Private Sub ActualizarDataGridView()
        Try

            Dim criterio As String = tb_buscadorClientes.Text
            Dim opcion As String = If(cb_opcionesBuscarCliente.SelectedItem IsNot Nothing, cb_opcionesBuscarCliente.SelectedItem.ToString(), "Nombre")

            Dim resultados As List(Of Cliente)

            Select Case opcion
                Case "Nombre"
                    resultados = todosLosClientes.Where(Function(c) c.Nombre.ToLower().Contains(criterio.ToLower())).ToList()
                Case "Teléfono"
                    resultados = todosLosClientes.Where(Function(c) c.Telefono.ToLower().Contains(criterio.ToLower())).ToList()
                Case "Correo"
                    resultados = todosLosClientes.Where(Function(c) c.Correo.ToLower().Contains(criterio.ToLower())).ToList()
                Case Else
                    MessageBox.Show("Opción de búsqueda no válida")
                    Return
            End Select

            dgv_resultadosBusquedaCliente.DataSource = Nothing
            dgv_resultadosBusquedaCliente.DataSource = resultados

        Catch ex As Exception
            MessageBox.Show($"Error al actualizar el DataGridView: {ex.Message}")

        End Try

    End Sub

    Private Sub tb_buscadorClientes_TextChanged(sender As Object, e As EventArgs) Handles tb_buscadorClientes.TextChanged
        ActualizarDataGridView()
    End Sub

    Private Sub cb_opcionesBuscarCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_opcionesBuscarCliente.SelectedIndexChanged
        ActualizarDataGridView()
    End Sub

    Private Sub btn_limpiarBuscarCliente_Click(sender As Object, e As EventArgs) Handles btn_limpiarBuscarCliente.Click
        Me.tb_buscadorClientes.Clear()
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Dim form As New FormAltaCliente.FormAltaCliente
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarClientes()
        End If
    End Sub

    Private Sub BajaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClienteToolStripMenuItem.Click
        Dim form As New FormBajaCliente.FormBajaCliente
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarClientes()
        End If
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        Dim form As New FormModificarCliente.FormModificarCliente
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarClientes()
        End If
    End Sub
End Class
