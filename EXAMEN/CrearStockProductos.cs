using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class CrearStockProductos
    {



        public CrearStockProductos()
        {
            StockProductos = new List<Producto>();
        }

        public CrearStockProductos(List<Producto> stockProductos)
        {
            StockProductos = stockProductos;
        }

        public List<Producto> StockProductos { get; set; }

        public void GeneraProductos()
        {


            Random random = new Random();
            int numero = 0;
            for (int i = 1; i <= 8; i++)
            {

                Producto producto = new Producto();
                producto.Codigo = i;

                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "Producto con descuento " + letra + numero + i;

                producto.Precio = numero;
                //producto.Descuento = 0.5M;
                producto.Precio = Decimal.Parse(random.Next(10).ToString());
                this.StockProductos.Add(producto);

                //ClienteSinRegistro clienteSinRegistro = new ClienteSinRegistro();
                //this.StockProductos.Add(clienteSinRegistro);
            }
        }
    }
}
//}   aplicamos el principio de responsabilidad unica y creamos una nueva clase llamada inpresion de productos 
//    y herenciamos la clase
    //    public void ImprimirListaProductos()
    //    {
    //        Console.WriteLine("PRODUCTOS EN LA TIENDA");
    //        Console.WriteLine("{0}\t{1}\t\t\t\t{2}\t\t{3}", "CODIGO", "DETALLE", "PRECIO", "DESCUENTO");
    //        foreach (var item in this.StockProductos)
    //        {
    //            Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.Codigo, item.Descripcion, item.Precio, item.Descuento);
    //        }

    //    }
    //}



        
            //for (int i = 0; i < 10; i++)
            //{
            //    Producto producto = new Producto();
            //    {

            //        producto.Codigo = i;


            //        numero = random.Next(20);
            //        char letra = (char)(((int)'A') + random.Next(26));
            //        producto.Descripcion = "Producto con descuento " + letra + numero + i;

            //        producto.Precio = numero;
            //        producto.Descuento = 5;
            //        producto.Precio = Decimal.Parse(random.Next(10).ToString());
            //        this.StockProductos.Add(producto);

                
                //for (int i = 11; i <= 20; i++)
                //{
                //    ClienteSinRegistro clienteSinRegistro = new ClienteSinRegistro();
                //    clienteSinRegistro.Identificador = i;
                //    numero = random.Next(20);
                //    char letrasindescuento = (char)(((int)'A') + random.Next(26));
                //    productosindescuento.Descripcion = "Producto *sin*descuento " + letrasindescuento + numero + i;
                //    productosindescuento.Precio = numero;
                //    productosindescuento.FechaInicioDescuento = new DateTime(11 / 11 / 2019);
                //    this.ListaStockProductos.Add(productosindescuento);
                //}
            

        
            
//   }
//}

