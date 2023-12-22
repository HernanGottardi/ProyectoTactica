Imports System.Data.SqlClient

Public Class Venta

    Public Property ID As Integer
    Public Property IDCliente As Integer
    Public Property Fecha As DateTime
    Public Property Total As Double
    Public Property Items As List(Of ItemVenta)

    Public Sub New()
        Items = New List(Of ItemVenta)()
    End Sub

    Public Shared Function CrearVenta(idCliente As Integer) As Venta
        Dim venta As New Venta()
        venta.IDCliente = idCliente
        Return venta
    End Function

    Public Function CalcularTotal() As Double
        Dim totalVenta As Double = 0
        For Each item As ItemVenta In Items
            totalVenta += item.PrecioTotal
        Next
        Return totalVenta
    End Function

    Public Sub ActualizarTotal(total As Double)
        Me.Total = total
    End Sub

    Public Sub AgregarItem(item As ItemVenta)
        Items.Add(item)
    End Sub

    Public Sub EliminarItem(idProducto As Integer)
        Dim item As ItemVenta = Items.Find(Function(i) i.IdProducto = idProducto)
        If item IsNot Nothing Then
            Items.Remove(item)
        End If
    End Sub

    Public Sub ModificarItem(idProducto As Integer, nuevoItem As ItemVenta)
        Dim item As ItemVenta = Items.Find(Function(i) i.IdProducto = idProducto)
        If item IsNot Nothing Then
            item.Cantidad = nuevoItem.Cantidad
            item.PrecioUnitario = nuevoItem.PrecioUnitario
            item.PrecioTotal = nuevoItem.PrecioTotal
        End If
    End Sub


    Public Function AltaVenta() As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total); SELECT SCOPE_IDENTITY()")

            consulta.Parameters.AddWithValue("@idCliente", IDCliente)
            consulta.Parameters.AddWithValue("@fecha", Fecha)
            consulta.Parameters.AddWithValue("@total", Total)
            Id = Convert.ToInt32(consulta.ExecuteScalar())

            ' Guardar los items de la venta
            For Each item As ItemVenta In Items
                consulta = instanciaAcceso.Consulta("INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@idVenta, @idProducto, @precioUnitario, @cantidad, @precioTotal)")

                consulta.Parameters.AddWithValue("@idVenta", Id)
                consulta.Parameters.AddWithValue("@idProducto", item.IdProducto)
                consulta.Parameters.AddWithValue("@precioUnitario", item.PrecioUnitario)
                consulta.Parameters.AddWithValue("@cantidad", item.Cantidad)
                consulta.Parameters.AddWithValue("@precioTotal", item.PrecioTotal)

                consulta.ExecuteNonQuery()
            Next

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error al dar de alta venta: {ex.Message}")
            Return False
        End Try
    End Function

    Public Shared Function BajaVenta(id As Integer) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("DELETE FROM ventas WHERE ID = @id")

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

    Private Shared Function ModificarAtributoVentaPorID(id As Integer, atributo As String, nuevoValor As String) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta($"UPDATE ventas SET {atributo} = @nuevoValor WHERE ID = @id")

            ' Bindeo de parámetros
            consulta.Parameters.AddWithValue("@nuevoValor", nuevoValor)
            consulta.Parameters.AddWithValue("@id", id)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            ' Verificar si la modificación fue exitosa
            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar {atributo} de la venta: {ex.Message}")
            Return False
        End Try
    End Function

    Public Shared Function ModificarVenta(id As Integer, nuevoIDCliente As Integer, nuevaFecha As DateTime, nuevoTotal As Double) As Boolean
        Return ModificarAtributoVentaPorID(id, "IDCliente", nuevoIDCliente) And ModificarAtributoVentaPorID(id, "Fecha", nuevaFecha) And ModificarAtributoVentaPorID(id, "Total", nuevoTotal)
    End Function

    Public Shared Function ModificarIdClientePorID(id As Integer, nuevoIDCliente As Integer) As Boolean
        Return ModificarAtributoVentaPorID(id, "IDCliente", nuevoIDCliente)
    End Function

    Public Shared Function ModificarFechaPorID(id As Integer, nuevaFecha As DateTime) As Boolean
        Return ModificarAtributoVentaPorID(id, "Fecha", nuevaFecha)
    End Function

    Public Shared Function ModificarTotalPorID(id As Integer, nuevoTotal As Double) As Boolean
        Return ModificarAtributoVentaPorID(id, "Total", nuevoTotal)
    End Function


    Public Shared Function ObtenerVentas() As List(Of Venta)
        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM ventas")

        Dim ventas As New List(Of Venta)()

        Using reader As SqlDataReader = consulta.ExecuteReader()
            While reader.Read()
                Dim venta As New Venta()
                venta.ID = Convert.ToInt32(reader("ID"))
                venta.IDCliente = Convert.ToInt32(reader("IDCliente"))
                venta.Fecha = Convert.ToDateTime(reader("Fecha"))
                venta.Total = Convert.ToDouble(reader("Total"))

                ventas.Add(venta)
            End While
        End Using

        Return ventas
    End Function

    Public Function CargarItemsVenta() As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM ventasitems WHERE IDVenta = @idVenta")

            consulta.Parameters.AddWithValue("@idVenta", Me.ID)

            Using reader As SqlDataReader = consulta.ExecuteReader()
                Items.Clear() ' Limpiar la lista actual de Items antes de cargar los nuevos

                While reader.Read()
                    Dim item As New ItemVenta()
                    item.ID = Convert.ToInt32(reader("ID"))
                    item.IDProducto = Convert.ToInt32(reader("IDProducto"))
                    item.PrecioUnitario = Convert.ToDouble(reader("PrecioUnitario"))
                    item.Cantidad = Convert.ToDouble(reader("Cantidad"))
                    item.PrecioTotal = Convert.ToDouble(reader("PrecioTotal"))

                    Items.Add(item)
                End While
            End Using

            Return True
        Catch ex As Exception
            Console.WriteLine($"Error al cargar items de la venta: {ex.Message}")
            Return False
        End Try
    End Function


    Public Shared Function ObtenerUltimoID() As Integer
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta($"SELECT MAX(ID) FROM ventas")

            ' Ejecutar la consulta y obtener el último ID
            Dim ultimoID As Object = consulta.ExecuteScalar()

            If ultimoID IsNot Nothing AndAlso Not DBNull.Value.Equals(ultimoID) Then
                Return Convert.ToInt32(ultimoID)
            Else
                Return -1 ' Retornar un valor que indique que no se encontró ningún ID
            End If
        Catch ex As Exception
            Console.WriteLine($"Error al obtener el último ID: {ex.Message}")
            Return -1 ' Retornar un valor que indique error
        End Try
    End Function

    Public Shared Function ObtenerVentaPorID(id As Integer) As Venta

        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM ventas WHERE ID = @id")

            consulta.Parameters.AddWithValue("@id", id)

            Using reader As SqlDataReader = consulta.ExecuteReader()
                If reader.Read() Then
                    Dim venta As New Venta()
                    venta.ID = Convert.ToInt32(reader("ID"))
                    venta.IDCliente = Convert.ToInt32(reader("IDCliente"))
                    venta.Fecha = Convert.ToDateTime(reader("Fecha"))
                venta.Total = Convert.ToDouble(reader("Total"))

                Return venta
            Else
                    Return Nothing ' Retornar null si no se encuentra la venta con ese ID
                End If
            End Using

        Return Nothing
    End Function

End Class