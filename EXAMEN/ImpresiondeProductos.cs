using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class ImpresiondeProductos:CrearStockProductos
    {
        public ImpresiondeProductos()
        {
        }
        public void ImprimirListaProductos()
        {
            Console.WriteLine("PRODUCTOS EN LA TIENDA");
            Console.WriteLine("{0}\t{1}\t\t\t\t{2}\t\t{3}", "CODIGO", "DETALLE", "PRECIO", "DESCUENTO");
            foreach (var item in this.StockProductos)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", item.Codigo, item.Descripcion, item.Precio, item.Descuento);
            }
            //}   aplicamos el principio de responsabilidad unica y creamos una nueva clase llamada inpresion de productos 
            //    y herenciamos la clase
        }
    }
}

