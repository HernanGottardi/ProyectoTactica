Imports System.Data.SqlClient

Public Class ConexionDB
    Private Shared _objetoConexion As ConexionDB
    Private _objetoSqlConexion As SqlConnection

    Private Sub New()
        Try
            _objetoSqlConexion = New SqlConnection("Data Source=localhost;Initial Catalog=pruebademo;Integrated Security=True")
            _objetoSqlConexion.Open()
        Catch ex As Exception
            Console.WriteLine("Error de conexión: " & ex.Message)
            Environment.Exit(0) ' Salir del script para evitar más errores.
        End Try
    End Sub

    Public Sub New(other As ConexionDB)
        ' Constructor privado para prevenir la clonación del objeto.
    End Sub

    Public Shared ReadOnly Property Acceso As ConexionDB
        Get
            If _objetoConexion Is Nothing Then
                _objetoConexion = New ConexionDB()
            End If
            Return _objetoConexion
        End Get
    End Property

    Public Function Consulta(sql As String) As SqlCommand
        Return New SqlCommand(sql, _objetoSqlConexion)
    End Function

    Public Function UltimoId() As Integer
        Dim cmd As New SqlCommand("SELECT SCOPE_IDENTITY()", _objetoSqlConexion)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
End Class

