using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.utils
{
    public static class Security
    {
        public static String TextoSinComas(String xTexto)
        {
            return xTexto.Replace("'"," ");
        }
    }
}
