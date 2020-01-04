using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class Factura
    {
        public Factura()
        {

            this.Detalle = new List<DetalleFactura>();
        }

        public decimal Subtotal { get; set; }

        public decimal Compra { get; set; }
        public decimal Descuento { get; set; }
        public CabezaFactura ClienteFactura { get; set; }
        public List<DetalleFactura> Detalle { get; set; }



        //public void CalcularSubtotal()
        //{
        //    decimal subtotal = 0;

        //    foreach (var item in this.Detalle)
        //    {
        //        subtotal = subtotal + (item.Cantidad * item.Producto.Precio);
        //    }
        //    this.Subtotal = subtotal;
        //}
        //public void CalcularDescuento()
        //{

        //    if (Compra > 100)
        //    {
        //        decimal descuento = 0.05M;
        //        foreach (var item in this.Detalle)
        //        {
        //            descuento = descuento + (item.Cantidad * item.Producto.Precio + Subtotal);
        //        }
        //        this.Descuento = descuento;

        //    }

        //}
        //    public void Total()
        //    {
        //    decimal total = 0;
        //    foreach(DetalleFactura item in this.Detalle)
        //    {
        //        total = (item.Cantidad + item.Producto.Precio + Subtotal + Descuento);
        //    }
        //    }
        }
    }

        
    


        //prop cabecera de carrito 

        // clases que hay que crear detalle de carrito
        // lista detalle de carrito(producto Cantidad)


    

