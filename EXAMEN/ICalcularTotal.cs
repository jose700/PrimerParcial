using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    interface ICalcularTotal
    {

        //principio de liskov
        //ya que sus productos varian dependiendo del tipo de cliente
        Factura  Descuento { get; set; }
    }
}
     
