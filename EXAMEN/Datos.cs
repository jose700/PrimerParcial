using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class Datos
    {
        public Datos()
        {
        }
        
        public void ImprimirDatosCliente(Cliente cliente)
        {
            Console.WriteLine(cliente.Apellido+cliente.Nombres);

            //return cliente.Nombres+ " "
        }
    }
}
// principio de responsabilidad unic