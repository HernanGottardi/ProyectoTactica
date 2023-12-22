Imports System
Imports Clases
Imports System.Data.SqlClient

Module Main
    Sub Main(args As String())

        ' ########################################################################################### ALTA CLIENTE

        'Dim cliente As Cliente
        'Dim cliente2 As Cliente
        'Dim cliente3 As Cliente
        'Dim cliente4 As Cliente
        'Dim cliente5 As Cliente
        'Dim cliente6 As Cliente
        'Dim cliente7 As Cliente

        'cliente = Cliente.CrearCliente("Nora", "noracanciani@gmail.com", "3569992")
        'cliente.AltaCliente()

        'cliente2 = Cliente.CrearCliente("Hugo", "huguito@gmail.com", "888999444")
        'cliente2.AltaCliente()

        'cliente3 = Cliente.CrearCliente("Mayra", "gottardima@gmail.com", "77423433")
        'cliente3.AltaCliente()

        'cliente4 = Cliente.CrearCliente("Diego", "Diego@gmail.com", "1234566")
        'cliente4.AltaCliente()

        'cliente5 = Cliente.CrearCliente("Francisco", "franflan@gmail.com", "00000000")
        'cliente5.AltaCliente()

        'cliente6 = Cliente.CrearCliente("Jose", "JuanTigre@gmail.com", "6546656")
        'cliente6.AltaCliente()

        'cliente7 = Cliente.CrearCliente("Maria", "Maria@gmail.com", "1234566")
        'cliente7.AltaCliente()



        'Filtro por nombre
        'Cliente.MostrarClientePorNombre("No")

        ' ########################################################################################### BAJA CLIENTE

        'Cliente.BajaCliente(1)
        'Cliente.BajaCliente(2)

        ' ########################################################################################### MOD CLIENTE

        ' Cliente.ModificarNombreClientePorID(2, "Hernan Gottardi")
        ' Cliente.ModificarTelefonoClientePorID(2, "123456789")
        ' Cliente.ModificarCorreoClientePorID(2, "herniag.2000@gmail.com")

        ' ########################################################################################### Mostrar CLIENTE.

        'Cliente.MostrarClientes()


        ' ************************************************************************************************************************************************************************************************************************
        ' ************************************************************************************************************************************************************************************************************************
        ' ************************************************************************************************************************************************************************************************************************

        ' ########################################################################################### ALTA PRODUCTO

        'Dim producto As Producto

        'producto = Producto.CrearProducto("Lata Coca Cola", 2500, "Bebida")
        'producto.AltaProducto()

        'Dim producto2 As Producto

        'producto2 = Producto.CrearProducto("Bolsa de papas fritas", 5000, "Snack")
        'producto2.AltaProducto()

        'Dim producto3 As Producto

        'producto3 = Producto.CrearProducto("Chocolate", 3000, "Golosina")
        'producto3.AltaProducto()

        ' ########################################################################################### BAJA PRODUCTO

        'Producto.BajaProducto(7)
        'Producto.BajaProducto(8)
        'Producto.BajaProducto(9)

        ' ########################################################################################### MOD PRODUCTO

        'Producto.ModificarNombreProductoPorID(4, "Pepsi")
        'Producto.ModificarPrecioProductoPorID(4, 2350)
        'Producto.ModificarCategoriaProductoPorID(4, "Bebida")

        'Producto.ModificarProducto(5, "Chupetin", 300, "Golosina")

        'Producto.ModificarProducto(6, "Helado", 4000, "Postre")

        ' ########################################################################################### Mostrar PRODUCTO.

        ' Producto.MostrarProductos()

        ' Crear instancias de Venta y ItemVenta
        'Dim venta As New Venta() With {
        '    .IDCliente = 1,
        '    .Fecha = DateTime.Now,
        '    .Total = 0,
        '    .Items = New List(Of ItemVenta)()
        '}

        '' Agregar items a la venta
        'venta.AgregarItem(New ItemVenta(idVenta:=1, idProducto:=1, precioUnitario:=10.0, cantidad:=12))
        'venta.AgregarItem(New ItemVenta(idVenta:=2, idProducto:=2, precioUnitario:=15.0, cantidad:=5))

        '' Calcular el total de la venta
        'Dim totalVenta As Double = venta.CalcularTotal()

        '' Actualizar el total de la venta
        'venta.ActualizarTotal(totalVenta)

        '' Dar de alta la venta
        'If venta.AltaVenta() Then
        '    Console.WriteLine("Venta dada de alta exitosamente.")
        'Else
        '    Console.WriteLine("Error al dar de alta la venta.")
        'End If

        '' Obtener todas las ventas
        'Dim ventas As List(Of Venta) = Venta.ObtenerVentas()

        '' Mostrar información de las ventas
        'For Each v In ventas
        '    Console.WriteLine($"Venta ID: {v.ID}, Cliente ID: {v.IDCliente}, Fecha: {v.Fecha}, Total: {v.Total}")

        '    ' Mostrar información de los items de la venta
        '    For Each item In v.Items
        '        Console.WriteLine($"  Item ID: {item.ID}, Producto ID: {item.IDProducto}, Precio Unitario: {item.PrecioUnitario}, Cantidad: {item.Cantidad}, Precio Total: {item.PrecioTotal}")
        '    Next
        'Next

        ' Venta.ModificarTotalPorID(1, 5000)


    End Sub

End Module
