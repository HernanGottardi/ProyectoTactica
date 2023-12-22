
Imports Clases

Public Class FormBajaCliente

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub FormBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaClientes()
    End Sub

    Private Sub configurarListaClientes()

        lsb_clientes.Items.Clear()

        For Each cliente As Cliente In Cliente.ObtenerClientes()
            lsb_clientes.Items.Add(cliente.Nombre)
        Next

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        Dim nombreSeleccionado As String
        Dim cliente As Cliente

        If (Me.lsb_clientes.SelectedItem IsNot Nothing) Then
            nombreSeleccionado = Me.lsb_clientes.SelectedItem.ToString()
            cliente = Cliente.ObtenerCliente(nombreSeleccionado)
            Cliente.BajaCliente(cliente.Id)
            ' Actualizamos
            configurarListaClientes()
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class
