using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DAOParametros
    {
        public static String getObtenerProximoValorReparacion()
        {
            String vSQL = "";
            vSQL = "select (valoractual + 1) as valor from parametros where nombre='NR'";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["valor"].ToString();
        }

        public static String ObtenerProximoValorRecibo()
        {
            String vSQL = "";
            vSQL = "select (valoractual + 1) as valor from parametros where nombre='RB'";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["valor"].ToString();
        }

        public static String ObtenerProximoValorNotaCredito()
        {
            String vSQL = "";
            vSQL = "select (valoractual + 1) as valor from parametros where nombre='NC'";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["valor"].ToString();
        }

        public static String ObtenerProximoValorNotaDebito()
        {
            String vSQL = "";
            vSQL = "select (valoractual + 1) as valor from parametros where nombre='NC'";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["valor"].ToString();
        }

        public static void ActualizarParametroRecibo(String xNumero)
        {
            String vSQL = "";
            vSQL = "update parametros";
            vSQL += " set ";
            vSQL += " valoractual=" + xNumero;
            vSQL += " where";
            vSQL += " nombre='RB'";
            Sql.ejecutar(vSQL);
        }

        public static void ActualizarParametroOrdenReparacion(String xNumero)
        {
            String vSQL = "";
            vSQL = "update parametros";
            vSQL += " set ";
            vSQL += " valoractual=" + xNumero ;
            vSQL += " where";
            vSQL += " nombre='NR'";
            Sql.ejecutar(vSQL);
        }
    }
}
