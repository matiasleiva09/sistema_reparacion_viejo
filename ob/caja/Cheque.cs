using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public class Cheque : MedioPago
    {
        public string Titular { get; set; }
        public string Banco { get; set; }
        public string Nro { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}
