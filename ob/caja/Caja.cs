using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public class Caja
    {
        public long Id { get; set; }
        public int Puesto { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public Double MontoAnteriorEfectivo { get; set; }
    }
}
