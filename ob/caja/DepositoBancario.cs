using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public class DepositoBancario: MedioPago
    {
        public string Banco { get; set; }
        public string NroDeCuenta { get; set; }
        public string Comprobante { get; set; }
    }
}
