using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class ModuloSistemaDAO
    {
        public static bool habilitado(String xModulo)
        {
            bool vRes = false;
            String vSQL = "";
            vSQL = "select msactivo as activo";
            vSQL += " from modulo_sistema";
            vSQL += " where";
            vSQL += " msnombre='" + xModulo + "'";
            DataRow vItem=Sql.getBuscar(vSQL);
            if(vItem!=null)
            {
                vRes = (Boolean)vItem["activo"];
            }
            vItem = null;
            vSQL = null;
            return vRes;
        }

        public static bool MandarMailsHabilitado()
        {
            return habilitado("ENVIARMAIL");
        }

        public static bool MandarWhatsappBusiness()
        {
            return habilitado("WHATSAPP");
        }
    }
}
