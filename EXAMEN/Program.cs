using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearStockProductos crearStock = new CrearStockProductos();
            crearStock.GeneraProductos();
            ImpresiondeProductos impresiondeProductos = new ImpresiondeProductos();
            impresiondeProductos.ImprimirListaProductos();


            Cliente cliente = new Cliente();
            cliente.Apellido = "Campuzano";
            cliente.Nombres = "Jose";
            cliente.NumeroCedula = "1314191550";
            cliente.Email = "josecampu28@gmail.com";
            cliente.Contrasenia = ("12345");


            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.ClienteFactura = cliente;


            //Detalledelcarrito productoD = new Detalledelcarrito();
            //productoD.ProductoCarrito = stockproductos.ListaStockProductos[posicion];
            // productoD.Cantidad = cantidadp;
            // Console.WriteLine("Producto              ,\tCantidad        ,\t Precio total");
            // Console.WriteLine(productoD.ProductoCarrito.Descripcion + ",\t\t" + productoD.Cantidad  );

            string opcion;

            Factura factura = new Factura();
            //factura.ClienteFactura = cliente();


            ClienteSinRegistro clienteSinRegistro = new ClienteSinRegistro();
            do
            {
                Console.WriteLine("Ingrese el codigo del producto");
                int codigo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el valor de la compra");

                DetalleFactura detallefactura = new DetalleFactura();
                detallefactura.Producto = crearStock.StockProductos[codigo - 1];

                Console.WriteLine("Ingrese la cantidad del producto");
                detallefactura.Cantidad = int.Parse(Console.ReadLine());

                factura.Detalle.Add(detallefactura);

                Console.WriteLine("Escriba A seguir agregrandio productus S para salir");
                opcion = Console.ReadLine();


            } while (opcion != "S");

            Console.WriteLine("Productos en el Carrito-----------PRECIO--------CANTIDAD-----------DESCUENTO");


            foreach (var item in factura.Detalle)
            {



                Console.WriteLine("{0}\t\t{1}\t{2}\t\t{3}",
                item.Producto.Descripcion, item.Producto.Precio, item.Cantidad, item.Producto);
                Console.WriteLine("SUBTOTAL ^:" + item.Producto.Precio * item.Cantidad);

                Console.WriteLine("EL SUBTOTAL - DESCUENTO :" + (item.Producto.Precio * item.Cantidad));
                Console.WriteLine("IVA--12%:" + (item.Producto.Precio * item.Cantidad * item.Producto.Iva));
                Console.WriteLine("TOTAL:" + ((item.Producto.Precio * item.Cantidad) -
                (item.Producto.Descuento + item.Producto.Iva)));


                Console.ReadKey();

            }

            //item.Descripcion, item.ProductoCarrito.Precio, item.Cantidad, item.ProductoCarrito.CalcularDescuento(), item.ProductoCarrito.CalcularDescuento());
            //Console.WriteLine("SUBTOTAL^:" + item.ProductoCarrito.Precio * item.Cantidad);
            //Console.WriteLine("EL SUBTOTAL - DESCUENTO :" + (item.ProductoCarrito.Precio * item.Cantidad - item.ProductoCarrito.CalcularDescuento()));
            //Console.WriteLine("IVA--12%:" + (item.ProductoCarrito.Precio * item.Cantidad * item.ProductoCarrito.Iva));
            //Console.WriteLine("TOTAL:" + ((item.ProductoCarrito.Precio * item.Cantidad) -
            //    (item.ProductoCarrito.CalcularDescuento() + item.ProductoCarrito.Iva)));

        }
    }
}

//   for (int i = 11; i <= 20; i++)
//            {
//                //ClienteSinRegistro
//                ClienteSinRegistro clientesinregistro = new ClienteSinRegistro();
//clientesinregistro.Codigo = i;
//                numero = random.Next(20);
//                char letrasinregistro = (char)(((int)'A') + random.Next(26));
//clientesinregistro.Descripcion = "Producto " + letrasinregistro;
//                clientesinregistro.Precio = Decimal.Parse(random.Next(10).ToString());
//                clientesinregistro.CalcularDescuento();
//                StockProductos.Add(clientesinregistro);
//            }





       //return this.Precio* (this.Descuento / 100);