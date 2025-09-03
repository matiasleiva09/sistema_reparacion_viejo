using reparaciones2.ob.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.caja
{
    public class ReciboIngreso : Recibo
    {
         public Reparacion Reparacion { get; set; }
         public Service Service { get; set; }
    }
}
