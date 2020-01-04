using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class ListadoClientes
    {

        public ListadoClientes()
        {
            ListaClientes = new List<Cliente>();
        }

        public List<Cliente> ListaClientes { get; set; }

        //Crear método para agregar clientes
        public Cliente ClienteFactura{ get; set; }



    }
          
}

