using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class DetalleFactura
    {
        public DetalleFactura()
        {
        }

        public  Producto Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
