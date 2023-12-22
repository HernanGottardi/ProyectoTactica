Imports Clases

Public Class FormProductoPrincipal
    Dim listaProductos As List(Of Producto) = Producto.ObtenerProductos()

    Public Sub New()
        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

        CargarProductos()
        ConfigurarColumnasDataGridView()
    End Sub

    Private Sub ConfigurarColumnasDataGridView()
        ' Configurar las columnas según las propiedades de Producto
        dgv_productos.AutoGenerateColumns = False
        dgv_productos.Columns.Clear()

        dgv_productos.Columns.Add("ID", "ID")
        dgv_productos.Columns.Add("Nombre", "Nombre")
        dgv_productos.Columns.Add("Precio", "Precio")
        dgv_productos.Columns.Add("Categoria", "Categoria")

        dgv_productos.Columns("ID").DataPropertyName = "ID"
        dgv_productos.Columns("Nombre").DataPropertyName = "Nombre"
        dgv_productos.Columns("Precio").DataPropertyName = "Precio"
        dgv_productos.Columns("Categoria").DataPropertyName = "Categoria"

        ' Ajustar el ancho de las columnas
        For Each column As DataGridViewColumn In dgv_productos.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            column.ReadOnly = True
            column.DefaultCellStyle.ForeColor = Color.Black
        Next
    End Sub

    Private Sub ActualizarDataGridView()
        Try
            Dim criterio As String = txb_buscar.Text
            Dim opcion As String = If(cb_filtros.SelectedItem IsNot Nothing, cb_filtros.SelectedItem.ToString(), "Nombre")

            Dim resultados As List(Of Producto)

            Select Case opcion
                Case "ID"
                    resultados = listaProductos.Where(Function(p) p.Id.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case "Nombre"
                    resultados = listaProductos.Where(Function(p) p.Nombre.ToLower().Contains(criterio.ToLower())).ToList()
                Case "Precio"
                    resultados = listaProductos.Where(Function(p) p.Precio.ToString().ToLower().Contains(criterio.ToLower())).ToList()
                Case "Categoria"
                    resultados = listaProductos.Where(Function(p) p.Categoria.ToLower().Contains(criterio.ToLower())).ToList()
                Case Else
                    MessageBox.Show("Opción de búsqueda no válida")
                    Return
            End Select

            dgv_productos.DataSource = Nothing
            dgv_productos.DataSource = resultados

        Catch ex As Exception
            MessageBox.Show($"Error al actualizar el DataGridView: {ex.Message}")
        End Try
    End Sub


    Private Sub tb_buscadorClientes_TextChanged(sender As Object, e As EventArgs) Handles txb_buscar.TextChanged
        ActualizarDataGridView()
    End Sub

    Private Sub cb_opcionesBuscarCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_filtros.SelectedIndexChanged
        ActualizarDataGridView()
    End Sub

    Private Sub CargarProductos()
        listaProductos = Producto.ObtenerProductos()
        dgv_productos.DataSource = listaProductos
    End Sub
    Private Sub btn_limpiarBusqueda_Click(sender As Object, e As EventArgs) Handles btn_limpiarBusqueda.Click
        Me.txb_buscar.Clear()
    End Sub

    Private Sub AltaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaProductoToolStripMenuItem.Click
        Dim form As New FormAltaProducto.FormAltaProducto
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarProductos()
        End If
    End Sub

    Private Sub BajaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaProductoToolStripMenuItem.Click
        Dim form As New FormBajaProducto.FormBajaProducto
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarProductos()
        End If
    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        Dim form As New FormModificarProducto.FormModificarProducto
        Dim res As DialogResult

        res = form.ShowDialog()

        If res = DialogResult.OK Then
            CargarProductos()
        End If
    End Sub

    Private Sub FormProductoPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_filtros.DropDownStyle = ComboBoxStyle.DropDownList
        cb_filtros.Items.AddRange({"Nombre", "Precio", "Categoria"})
        cb_filtros.Items.Insert(0, "ID")

        cb_filtros.SelectedIndex = 0

        listaProductos = Producto.ObtenerProductos
        dgv_productos.DataSource = listaProductos

        ConfigurarColumnasDataGridView()
    End Sub
End Class
