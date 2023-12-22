Imports System.Text.RegularExpressions

Public Class ValidacionesEntidades
    Public Shared Function validarNombre(nombre As String) As Boolean

        Dim patron As String = "^[a-zA-Z]{4,255}$"

        If Regex.IsMatch(nombre, patron) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function ValidarCorreo(correo As String) As Boolean

        Dim patron As String = "^[a-zA-Z0-9._%+-]{5,}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        Return Regex.IsMatch(correo, patron) AndAlso correo.Length <= 255

    End Function

    Public Shared Function ValidarTelefono(telefono As String) As Boolean


        Dim patron As String = "^[0-9]{8,255}$"

        Return Regex.IsMatch(telefono, patron)
    End Function

End Class
