
Imports Clases
Public Class FormSeleccionarCliente

    Dim todosLosClientes As List(Of Cliente) = Cliente.ObtenerClientes()
    Public Property ClienteSeleccionado As Cliente


    Public Sub New()

        InitializeComponent()

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
    Private Sub FormSeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaClientes()
    End Sub
    Private Sub configurarListaClientes()

        lsb_clientes.Items.Clear()

        For Each cliente As Cliente In Cliente.ObtenerClientes()
            lsb_clientes.Items.Add(cliente.Nombre)
        Next

    End Sub

    Private Function ObtenerClienteSeleccionado() As Cliente
        Dim nombreSeleccionado As String
        Dim cliente As Cliente = Nothing

        If (Me.lsb_clientes.SelectedItem IsNot Nothing) Then
            nombreSeleccionado = Me.lsb_clientes.SelectedItem.ToString()
            cliente = Cliente.ObtenerCliente(nombreSeleccionado)
        End If

        Return cliente
    End Function

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Dim nombreSeleccionado As String
        Dim cliente As Cliente

        If (Me.lsb_clientes.SelectedItem IsNot Nothing) Then
            nombreSeleccionado = Me.lsb_clientes.SelectedItem.ToString()
            cliente = Cliente.ObtenerCliente(nombreSeleccionado)
            ClienteSeleccionado = cliente
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class
