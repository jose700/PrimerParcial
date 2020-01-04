using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    public class ClienteSinRegistro : Cliente
    {
        public ClienteSinRegistro()
        {
            //this.Descuento = 0.5M;
        }
        public Producto Compras { get; set; }

        //public  decimal Descuento{ get; set; }



    }    
}
    
        //public double Subto(double descuento, double iva)
        //{
        //double Subtotal = descuento
        //return Subtotal;
        
    


        //public new string NumeroCedula { get; set; }

        //public new string Nombres { get; set; }

        //public new string Apellido { get; set; }

        //public new string Email { get; set; }

        //public string Contraseña { get; set; }

        //public int Ntelefonico { get; set; }
        //public double Compra { get; set; }
        //public double Descuento { get; set; }
        //public double Iva { get; set; }
        //public double Subt { get; set; }
        //public double Tot { get; set; }

        //public double CalcularDescuento()
        //{ 
        //      if (Compra > 100)
        //          this.Descuento =  Descuento/100;
        //          return 0;

        //  }

        //public double IvaT()
        //{
        //    return 0;
        //}

        //    public double Subtotal()
        //{
        //    double pagar =  CalcularDescuento()+Iva;
        //    return pagar;
        //}
        //public double Total()
        //{
        //    double PagoTotal = Subtotal() + Iva();

        //    return PagoTotal;
    //}
    //    }
        
 



