using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class ListaProductos123 : Factura
    {
        public ListaProductos123()
        {
        }
        public decimal Subtotal { get; set; }

        public decimal Compra { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public CabezaFactura ClienteFactura { get; set; }
        public List<DetalleFactura> Detalle { get; set; }
        public Producto productos { get; set; }
        public ListaProductos123(decimal subtotal, decimal compra, decimal descuento, CabezaFactura clienteFactura, List<DetalleFactura> detalle)
        {
            Subtotal = subtotal;
            Compra = compra;
            Descuento = descuento;
            ClienteFactura = clienteFactura;
            Detalle = detalle;




            Producto producto = new Producto();
            producto.Precio=500;
            producto.Descuento =5/100;
            foreach (DetalleFactura item in this.Detalle)
            {
                Total = item.Cantidad + item.Producto.Precio + Subtotal + Descuento;
            }
            //principios de open closed
       
        }
    }
}