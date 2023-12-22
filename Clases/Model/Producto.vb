Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.X86
Imports Microsoft.Identity

Public Class Producto

    Private idProducto As Integer
    Private nombreProducto As String
    Private precioProducto As Decimal
    Private categoriaProducto As String

    Shared listaProductos As List(Of Producto)

    Public Property Id As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nombreProducto
        End Get
        Set(value As String)
            nombreProducto = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return precioProducto
        End Get
        Set(value As Decimal)
            precioProducto = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return categoriaProducto
        End Get
        Set(value As String)
            categoriaProducto = value
        End Set
    End Property

    Public Shared Property Productos As List(Of Producto)
        Get
            Return listaProductos
        End Get
        Set(value As List(Of Producto))
            listaProductos = value
        End Set
    End Property


    Public Shared Function ObtenerProductos() As List(Of Producto)
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM productos")
            Dim resultados As New List(Of Producto)()

            Using reader As SqlDataReader = consulta.ExecuteReader()
                While reader.Read()
                    Dim producto As New Producto()

                    ' Asigna valores a las propiedades de la clase Cliente
                    producto.Id = Convert.ToInt32(reader("ID"))
                    producto.Nombre = Convert.ToString(reader("Nombre"))
                    producto.Precio = Convert.ToString(reader("Precio"))
                    producto.Categoria = Convert.ToString(reader("Categoria"))
                    ' Asigna más propiedades según la estructura de tu tabla "clientes"

                    resultados.Add(producto)
                End While
            End Using

            Return resultados
        Catch ex As Exception
            Console.WriteLine($"Error al obtener productos: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Shared Function ObtenerProducto(nombre As String) As Producto

        Dim productoEncontrado As New Producto()

        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM productos where Nombre = @nombre")

        consulta.Parameters.AddWithValue("@nombre", nombre)

        Using reader As SqlDataReader = consulta.ExecuteReader()

            While reader.Read()

                ' Asigna valores a las propiedades de la clase Cliente
                productoEncontrado.Id = Convert.ToInt32(reader("ID"))
                productoEncontrado.Nombre = Convert.ToString(reader("Nombre"))
                productoEncontrado.Precio = Convert.ToString(reader("Precio"))
                productoEncontrado.Categoria = Convert.ToString(reader("Categoria"))
                ' Asigna más propiedades según la estructura de tu tabla "clientes"
            End While

        End Using

        Return productoEncontrado
    End Function

    Public Shared Function CrearProducto(nombre As String, precio As Decimal, categoria As String) As Producto
        Dim productoAux As New Producto()

        productoAux.Nombre = nombre
        productoAux.Precio = precio
        productoAux.Categoria = categoria

        Return productoAux
    End Function

    Public Function AltaProducto() As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@n, @p, @c)")

            ' Bindeo:
            consulta.Parameters.AddWithValue("@n", Me.Nombre)
            consulta.Parameters.AddWithValue("@p", Me.Precio)
            consulta.Parameters.AddWithValue("@c", Me.Categoria)

            Return consulta.ExecuteNonQuery() > 0
        Catch ex As Exception
            Console.WriteLine($"Error al dar de alta producto: {ex.Message}")
            Return False
        End Try
    End Function

    Public Shared Function BajaProducto(id As Integer) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("DELETE FROM productos WHERE ID = @id")

            ' Bindeo de parámetros
            consulta.Parameters.AddWithValue("@id", id)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            ' Verificar si la eliminación fue exitosa
            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al dar de baja producto: {ex.Message}")
            Return False
        End Try
    End Function

    Private Shared Function ModificarAtributoProductoPorID(id As Integer, atributo As String, nuevoValor As Object) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta($"UPDATE productos SET {atributo} = @nuevoValor WHERE ID = @id")

            ' Bindeo de parámetros
            consulta.Parameters.AddWithValue("@nuevoValor", nuevoValor)
            consulta.Parameters.AddWithValue("@id", id)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            ' Verificar si la modificación fue exitosa
            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar {atributo} del producto: {ex.Message}")
            Return False
        End Try
    End Function

    Public Shared Function ModificarNombreProductoPorID(id As Integer, nuevoNombre As String) As Boolean
        Return ModificarAtributoProductoPorID(id, "Nombre", nuevoNombre)
    End Function

    Public Shared Function ModificarPrecioProductoPorID(id As Integer, nuevoPrecio As Decimal) As Boolean
        Return ModificarAtributoProductoPorID(id, "Precio", nuevoPrecio)
    End Function

    Public Shared Function ModificarCategoriaProductoPorID(id As Integer, nuevaCategoria As String) As Boolean
        Return ModificarAtributoProductoPorID(id, "Categoria", nuevaCategoria)
    End Function

    Public Shared Function ModificarProducto(id As Integer, nombre As String, precio As Decimal, categoria As String) As Boolean
        Return ModificarAtributoProductoPorID(id, "Nombre", nombre) And ModificarAtributoProductoPorID(id, "Precio", precio) And ModificarAtributoProductoPorID(id, "Categoria", categoria)
    End Function

    Public Shared Sub MostrarProductos()
        Try
            Dim productos As List(Of Producto) = ObtenerProductos()

            If productos IsNot Nothing AndAlso productos.Count > 0 Then
                For Each producto In productos
                    Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio: {producto.Precio}, Categoria: {producto.Categoria}")
                Next
            Else
                Console.WriteLine("No se encontraron productos.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try
    End Sub

    Public Shared Function productoExiste(id As Integer) As Boolean

        For Each p As Producto In Productos

            If p.Id = id Then
                Return True
            End If

        Next

        Return False

    End Function
    Public Function ObtenerDatosProducto() As String
        Return $"ID: {Id}{vbCrLf}Nombre: {Nombre}{vbCrLf}Precio: {Precio}{vbCrLf}Catalogo: {Categoria}"
    End Function


End Class
