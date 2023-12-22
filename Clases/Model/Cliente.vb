Imports System.Data.SqlClient
Imports System.Reflection.Metadata.Ecma335

Public Class Cliente

    Private idCliente As Integer
    Private nombreCliente As String
    Private CorreoCliente As String
    Private telefonoCliente As String

    Shared listaClientes As List(Of Cliente)

    Public Property Id As Integer
        Get
            Return idCliente
        End Get
        Set(value As Integer)
            idCliente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return CorreoCliente
        End Get
        Set(value As String)
            CorreoCliente = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return telefonoCliente
        End Get
        Set(value As String)
            telefonoCliente = value
        End Set
    End Property

    Public Shared Property Clientes As List(Of Cliente)
        Get
            Return listaClientes
        End Get
        Set(value As List(Of Cliente))
            listaClientes = value
        End Set
    End Property


    Public Shared Function CrearCliente(nombreCliente As String, correoCliente As String, telefonoCliente As String) As Cliente
        Dim clienteAux As New Cliente()

        clienteAux.Nombre = nombreCliente
        clienteAux.Correo = correoCliente
        clienteAux.Telefono = telefonoCliente

        Return clienteAux
    End Function

    Public Function AltaCliente() As Boolean
        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@n, @t, @c)")
        ' Bindeo:
        consulta.Parameters.AddWithValue("@n", Me.Nombre)
        consulta.Parameters.AddWithValue("@t", Me.Telefono)
        consulta.Parameters.AddWithValue("@c", Me.Correo)

        Return consulta.ExecuteNonQuery() > 0
    End Function

    Public Shared Function BajaCliente(id As Integer) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("DELETE FROM clientes WHERE ID = @id")

            ' Bindeo de parámetros
            consulta.Parameters.AddWithValue("@id", id)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            ' Verificar si la eliminación fue exitosa
            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al dar de baja cliente: {ex.Message}")
            Return False
        End Try
    End Function
    Private Shared Function ModificarAtributoClientePorID(id As Integer, atributo As String, nuevoValor As String) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta($"UPDATE clientes SET {atributo} = @nuevoValor WHERE ID = @id")

            ' Bindeo de parámetros
            consulta.Parameters.AddWithValue("@nuevoValor", nuevoValor)
            consulta.Parameters.AddWithValue("@id", id)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            ' Verificar si la modificación fue exitosa
            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar {atributo} del cliente: {ex.Message}")
            Return False
        End Try
    End Function
    Public Shared Function ModificarNombreClientePorID(id As Integer, nuevoNombre As String) As Boolean
        Return ModificarAtributoClientePorID(id, "Cliente", nuevoNombre)
    End Function

    Public Shared Function ModificarTelefonoClientePorID(id As Integer, nuevoTelefono As String) As Boolean
        Return ModificarAtributoClientePorID(id, "Telefono", nuevoTelefono)
    End Function

    Public Shared Function ModificarCorreoClientePorID(id As Integer, nuevoCorreo As String) As Boolean
        Return ModificarAtributoClientePorID(id, "Correo", nuevoCorreo)
    End Function

    Public Shared Function ModificarCliente(id As Integer, nombre As String, telefono As String, correo As String) As Boolean
        Return ModificarNombreClientePorID(id, nombre) And ModificarTelefonoClientePorID(id, telefono) And ModificarCorreoClientePorID(id, correo)
    End Function

    Public Shared Function ObtenerClientes() As List(Of Cliente)
        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM clientes")

        Dim resultados As New List(Of Cliente)()

        Using reader As SqlDataReader = consulta.ExecuteReader()
            While reader.Read()
                Dim cliente As New Cliente()

                ' Asigna valores a las propiedades de la clase Cliente
                cliente.Id = Convert.ToInt32(reader("ID"))
                cliente.Nombre = Convert.ToString(reader("Cliente"))
                cliente.Correo = Convert.ToString(reader("Correo"))
                cliente.Telefono = Convert.ToString(reader("Telefono"))
                ' Asigna más propiedades según la estructura de tu tabla "clientes"

                resultados.Add(cliente)
            End While
        End Using

        Return resultados
    End Function

    Public Shared Function ObtenerCliente(nombre As String) As Cliente

        Dim clienteEncontrado As New Cliente()

        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM clientes where Cliente = @nombre")

        consulta.Parameters.AddWithValue("@nombre", nombre)

        Using reader As SqlDataReader = consulta.ExecuteReader()

            While reader.Read()

                ' Asigna valores a las propiedades de la clase Cliente
                clienteEncontrado.Id = Convert.ToInt32(reader("ID"))
                clienteEncontrado.Nombre = Convert.ToString(reader("Cliente"))
                clienteEncontrado.Correo = Convert.ToString(reader("Correo"))
                clienteEncontrado.Telefono = Convert.ToString(reader("Telefono"))
                ' Asigna más propiedades según la estructura de tu tabla "clientes"
            End While

        End Using

        Return clienteEncontrado
    End Function

    Public Shared Sub MostrarClientes()
        Try
            Dim clientes As List(Of Cliente) = ObtenerClientes()

            If clientes IsNot Nothing AndAlso clientes.Count > 0 Then
                For Each c In clientes
                    Console.WriteLine($"ID: {c.Id}, Nombre: {c.Nombre}, Telefono: {c.Telefono}, Mail: {c.Correo}")
                Next
            Else
                Console.WriteLine("No se encontraron clientes.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub

    Public Shared Sub MostrarClientePorID(id As Integer)
        Try
            Dim consulta As SqlCommand = ConexionDB.Acceso().Consulta("SELECT * FROM clientes WHERE Id = @id")
            consulta.Parameters.AddWithValue("@id", id)

            Using reader As SqlDataReader = consulta.ExecuteReader()
                If reader.Read() Then
                    Console.WriteLine($"ID: {reader("ID")}, Nombre: {reader("Cliente")}, Correo: {reader("Correo")}, Teléfono: {reader("Telefono")}")
                Else
                    Console.WriteLine($"No se encontró cliente con ID {id}.")
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub

    Public Shared Sub MostrarClientePorNombre(nombre As String)
        Try
            Dim consulta As SqlCommand = ConexionDB.Acceso().Consulta("SELECT * FROM clientes WHERE Cliente = @nombre")
            consulta.Parameters.AddWithValue("@nombre", nombre)

            Using reader As SqlDataReader = consulta.ExecuteReader()
                If reader.Read() Then
                    Console.WriteLine($"ID: {reader("ID")}, Nombre: {reader("Cliente")}, Correo: {reader("Correo")}, Teléfono: {reader("Telefono")}")
                Else
                    Console.WriteLine($"No se encontró cliente con nombre {nombre}.")
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub

    ' Función para obtener el ID de cliente por nombre (solo como ejemplo)
    Public Shared Function ObtenerIdClientePorNombre(nombreCliente As String) As Integer
        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT ID FROM clientes WHERE Cliente = @nombreCliente")

        consulta.Parameters.AddWithValue("@nombreCliente", nombreCliente)

        Dim idCliente As Integer = 0

        Try
            idCliente = Convert.ToInt32(consulta.ExecuteScalar())
        Catch ex As Exception
            Console.WriteLine($"Error al obtener ID de cliente: {ex.Message}")
        End Try

        Return idCliente
    End Function

    Public Function ObtenerDatosCliente() As String
        Return $"ID: {Id}{vbCrLf}Nombre: {Nombre}{vbCrLf}Teléfono: {Telefono}{vbCrLf}Correo: {Correo}"
    End Function


End Class
