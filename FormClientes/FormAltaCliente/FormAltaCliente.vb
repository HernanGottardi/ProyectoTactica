Imports System.Text.RegularExpressions

Imports clases

Public Class FormAltaCliente

    Public Sub New()
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btn_aceptarAltaCliente_Click(sender As Object, e As EventArgs) Handles btn_aceptarAltaCliente.Click

        ' Obtener los valores desde los TextBox
        Dim nombre As String = txb_nombre.Text
        Dim correo As String = txb_correo.Text
        Dim telefono As String = txb_telefono.Text


        lb_msjExito.Text = ""
        lb_msjExito.Visible = True

        ' Valido si lo ingresado en los campos es correcto.
        If String.IsNullOrWhiteSpace(txb_nombre.Text) Or String.IsNullOrWhiteSpace(txb_telefono.Text) Or String.IsNullOrEmpty(txb_correo.Text) Then
            lb_msjExito.Text = "Por favor rellenar todos los campos." & vbCrLf
        End If

        ' Realizar la validación y mostrar mensajes de error si es necesario
        If Not ValidacionesEntidades.validarNombre(nombre) Then
            lb_msjExito.Text += " - Nombre incorrecto. " & vbCrLf
        End If

        If Not ValidacionesEntidades.ValidarCorreo(correo) Then
            lb_msjExito.Text += " - Correo incorrecto. " & vbCrLf
        End If

        If Not ValidacionesEntidades.ValidarTelefono(telefono) Then
            lb_msjExito.Text += " - Teléfono incorrecto. " & vbCrLf
        End If

        ' Verificar si hay algún mensaje de error y mostrarlo en el Label
        If lb_msjExito.Text = "" Then
            lb_msjExito.ForeColor = Color.Green
            lb_msjExito.Text = "El Usuario se cargo con exito!" & vbCrLf
            GuardarInformacion(nombre, correo, telefono)
            Me.DialogResult = DialogResult.OK
        End If


    End Sub

    Private Sub GuardarInformacion(nombre As String, correo As String, telefono As String)

        Dim clienteAux As New Cliente

        clienteAux = Cliente.CrearCliente(nombre, correo, telefono)
        clienteAux.AltaCliente()

    End Sub

End Class
