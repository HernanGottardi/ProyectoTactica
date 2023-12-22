Imports System.Data.SqlClient

Public Class ItemVenta
    Public Property ID As Integer
    Public Property IDVenta As Integer
    Public Property IDProducto As Integer
    Public Property PrecioUnitario As Double
    Public Property Cantidad As Double
    Public Property PrecioTotal As Double

    Public Shared Function CrearItemVenta(IDVenta As Integer, IDProducto As Integer, PrecioUnitario As Double, Cantidad As Double) As ItemVenta

        Dim item As New ItemVenta()

        item.IDVenta = IDVenta
        item.IDProducto = IDProducto
        item.PrecioUnitario = PrecioUnitario
        item.Cantidad = Cantidad
        item.PrecioTotal = Cantidad * PrecioUnitario

        Return item

    End Function

    Public Shared Function ObtenerItemsVenta(idVenta As Integer) As List(Of ItemVenta)

        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM ventasitems WHERE IDVenta = @idVenta")

        consulta.Parameters.AddWithValue("@idVenta", idVenta)

        Dim items As New List(Of ItemVenta)()

        Using reader As SqlDataReader = consulta.ExecuteReader()

            Dim itemVentaAux As ItemVenta

            While reader.Read()
                ' Crear un nuevo objeto ItemVenta usando el constructor adecuado
                itemVentaAux = ItemVenta.CrearItemVenta(
                idVenta,
                Convert.ToInt32(reader("IDProducto")),
                Convert.ToDouble(reader("PrecioUnitario")),
                Convert.ToDouble(reader("Cantidad")))

                items.Add(itemVentaAux)
            End While
        End Using

        Return items
    End Function

    Public Shared Function DarDeBajaItemsPorIDVenta(idVenta As Integer) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("DELETE FROM ventasitems WHERE IDVenta = @idVenta")

            consulta.Parameters.AddWithValue("@idVenta", idVenta)

            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al dar de baja los ItemVenta en la base de datos: {ex.Message}")
            Return False
        End Try
    End Function


    Public Shared Function ObtenerItemVentaPorID(idProducto As Integer) As ItemVenta
        Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
        Dim consulta As SqlCommand = instanciaAcceso.Consulta("SELECT * FROM ventasitems WHERE IDProducto = @idProducto")

        consulta.Parameters.AddWithValue("@idProducto", idProducto)

        Using reader As SqlDataReader = consulta.ExecuteReader()
            If reader.Read() Then
                ' Crear un nuevo objeto ItemVenta usando el constructor adecuado
                Dim itemVenta As ItemVenta = ItemVenta.CrearItemVenta(
                Convert.ToInt32(reader("IDVenta")),
                idProducto,
                Convert.ToDouble(reader("PrecioUnitario")),
                Convert.ToDouble(reader("Cantidad")))

                Return itemVenta
            End If
        End Using

        ' Si no se encuentra el ItemVenta, devolver Nothing
        Return Nothing
    End Function

    ' Método para modificar la cantidad de un ItemVenta en la base de datos
    Public Function ModificarCantidadEnDB(nuevaCantidad As Double) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("UPDATE ventasitems SET Cantidad = @cantidad WHERE ID = @id")

            consulta.Parameters.AddWithValue("@cantidad", nuevaCantidad)
            consulta.Parameters.AddWithValue("@id", Me.ID)

            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar la cantidad del ItemVenta en la base de datos: {ex.Message}")
            Return False
        End Try
    End Function

    ' Método para modificar el precio unitario de un ItemVenta en la base de datos
    Public Function ModificarPrecioUnitarioEnDB(precioUnitario As Double) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("UPDATE ventasitems SET PrecioUnitario = @precioUnitario WHERE ID = @id")

            consulta.Parameters.AddWithValue("@precioUnitario", precioUnitario)
            consulta.Parameters.AddWithValue("@id", Me.ID)

            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar el precio unitario del ItemVenta en la base de datos: {ex.Message}")
            Return False
        End Try
    End Function

    ' Método para modificar el precio total de un ItemVenta en la base de datos
    Public Function ModificarPrecioTotalEnDB(precioTotal As Double) As Boolean
        Try
            Dim instanciaAcceso As ConexionDB = ConexionDB.Acceso()
            Dim consulta As SqlCommand = instanciaAcceso.Consulta("UPDATE ventasitems SET PrecioTotal = @precioTotal WHERE ID = @id")

            consulta.Parameters.AddWithValue("@precioTotal", precioTotal)
            consulta.Parameters.AddWithValue("@id", Me.ID)

            Dim filasAfectadas As Integer = consulta.ExecuteNonQuery()

            Return filasAfectadas > 0
        Catch ex As Exception
            Console.WriteLine($"Error al modificar el precio total del ItemVenta en la base de datos: {ex.Message}")
            Return False
        End Try
    End Function


End Class
