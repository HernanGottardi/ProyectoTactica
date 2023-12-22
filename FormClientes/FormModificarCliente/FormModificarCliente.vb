
Imports Clases
Public Class FormModificarCliente

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub configurarListaClientes()

        lsb_clientes.Items.Clear()

        For Each cliente As Cliente In Cliente.ObtenerClientes()
            lsb_clientes.Items.Add(cliente.Nombre)
        Next

    End Sub
    Private Sub FormModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurarListaClientes()
    End Sub



    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        Dim nombreSeleccionado As String
        Dim clienteEncontrado As Cliente

        ' Obtener los valores desde los TextBox
        Dim nombre As String = txb_nombre.Text
        Dim correo As String = txb_correo.Text
        Dim telefono As String = txb_telefono.Text

        lb_mensaje.Text = ""
        lb_mensaje.Visible = True

        If (Me.lsb_clientes.SelectedItem IsNot Nothing) Then

            nombreSeleccionado = Me.lsb_clientes.SelectedItem.ToString()
            clienteEncontrado = Cliente.ObtenerCliente(nombreSeleccionado)

            ' Valido si lo ingresado en los campos es correcto.
            If String.IsNullOrWhiteSpace(txb_nombre.Text) Or String.IsNullOrWhiteSpace(txb_telefono.Text) Or String.IsNullOrEmpty(txb_correo.Text) Then
                lb_mensaje.Text = "Por favor rellenar todos los campos." & vbCrLf
            End If

            ' Realizar la validación y mostrar mensajes de error si es necesario
            If Not ValidacionesEntidades.validarNombre(nombre) Then
                lb_mensaje.Text += " - Nombre incorrecto. (minimo 4 letras y caracteres a-z)" & vbCrLf
            End If

            If Not ValidacionesEntidades.ValidarCorreo(correo) Then
                lb_mensaje.Text += " - Correo incorrecto. (minimo 5 letras y debe cumplir con el formato)" & vbCrLf
            End If

            If Not ValidacionesEntidades.ValidarTelefono(telefono) Then
                lb_mensaje.Text += " - Teléfono incorrecto. (minimo 8 numeros) " & vbCrLf
            End If

            ' Verificar si hay algún mensaje de error y mostrarlo en el Label
            If lb_mensaje.Text = "" Then
                lb_mensaje.ForeColor = Color.Green
                lb_mensaje.Text = "El Usuario se cargo con exito!" & vbCrLf
                Cliente.ModificarCliente(clienteEncontrado.Id, nombre, telefono, correo)
                configurarListaClientes()
                Me.DialogResult = DialogResult.OK
            End If
        Else
            lb_mensaje.Text += " - Falta seleccionar un usuario. " & vbCrLf

        End If


    End Sub

    Private Sub lsb_clientes_Click(sender As Object, e As EventArgs) Handles lsb_clientes.Click
        Dim nombreSeleccionado As String
        Dim clienteEncontrado As Cliente


        If (Me.lsb_clientes.SelectedItem IsNot Nothing) Then

            nombreSeleccionado = Me.lsb_clientes.SelectedItem.ToString()
            clienteEncontrado = Cliente.ObtenerCliente(nombreSeleccionado)

            txb_nombre.Text = clienteEncontrado.Nombre
            txb_correo.Text = clienteEncontrado.Correo
            txb_telefono.Text = clienteEncontrado.Telefono

        End If
    End Sub

End Class
