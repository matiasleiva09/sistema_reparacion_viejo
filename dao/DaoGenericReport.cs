using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoGenericReport
    {
        public static DataTable reportePorModulo(string xModulo)
        {
            string vSQL = "select descripcion,query,tipochart from reportero where modulo='"+xModulo+"' ";
            vSQL += " and visible=true";
            return Sql.getConsultar(vSQL);
        }
    }
}
