using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoParametrosDatos
    {

        public static void UpdateParametro(String xNuevoValor,String xParametro)
        {
            String vSQL = "";
            vSQL = "update admparametros";
            vSQL += " set";
            vSQL += " valor='" + xNuevoValor + "'";
            vSQL += " where clave='" + xParametro + "'";
            Sql.ejecutar(vSQL);
        }

        public static Dictionary<string,string> ObtenerParametrosPDF()
        {
            string vSQL = "select clave,valor from admparametros";
            DataTable vQuery = Sql.getConsultar(vSQL);
            Dictionary<string, string> vRes = new Dictionary<string, string>();
            if (vQuery != null)
            {
                foreach (DataRow vFila in vQuery.Rows)
                    vRes.Add(vFila["clave"].ToString(), vFila["valor"].ToString());
            }
            return vRes;
        }

        public static String getParametro(String xParametro)
        {
            String vSQL = "";
            vSQL = "select valor from admparametros";
            vSQL += " where clave='" + xParametro + "'";
            DataRow vRes = Sql.getBuscar(vSQL);
            if (vRes != null)
                return vRes["valor"].ToString();
            else
                return "";
        }
    }
}
