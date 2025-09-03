using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public class Tarjeta : MedioPago
    {
        public string Empresa { get; set; }
        public string Tipo { get; set; }
        public string Nro { get; set; }
    }
}
