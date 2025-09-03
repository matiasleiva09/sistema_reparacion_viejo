using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public abstract class Recibo
    {
        protected static string MEDIO_E = "EFECTIVO";
        protected static string MEDIO_CH = "CHEQUE";
        protected static string MEDIO_DP = "DEPOSITO";
        protected static string MEDIO_T = "TARJETA";
        public long Id { get; set; }
        public string Nro { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Double Monto { get; set; }
        public string Concepto { get; set; }
        public string MedioDePago { get; set; }
        public string Descripcion { get; set; }

    }
}
