using desagotes.sql;
using reparaciones2.ob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public class DaoTarifa
    {
        public static void Guardar(String xDescripcion, float xMonto, String xServicio)
        {
            String vSQL = "";
            vSQL = "insert into tarifa (descripcion,monto,servicio)";
            vSQL += " values ('" + xDescripcion + "'," + xMonto + ",'" + xServicio + "')";
            Sql.ejecutar(vSQL);
        }

        public static void Editar(long xId, String xDescripcion, float xMonto, String xServicio)
        {
            String vSQL = "";
            vSQL = "update tarifa ";
            vSQL += " set ";
            vSQL += " descripcion='" + xDescripcion + "'";
            vSQL += ", servicio='" + xServicio + "'";
            vSQL += ", monto=" + xMonto;
            vSQL += " where idtarifa=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static DataTable ObtenerTarifas(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idtarifa as \"Id\", servicio as \"Servicio\", descripcion as \"Tarifa\", monto as \"Monto\"";
            vSQL += " from tarifa";
            if (xFiltro != null && xFiltro.Trim() != "")
                vSQL += " where descripcion like '%" + xFiltro.Trim().ToUpper() + "%'";
            vSQL += " order by servicio,descripcion asc";
            return Sql.getConsultar(vSQL);
        }

        public static Tarifa obtenerTarifa(long xId)
        {
            Tarifa vRes = null;
            String vSQL = "";
            vSQL = "select idtarifa,descripcion,monto,servicio";
            vSQL += " from tarifa";
            vSQL += " where idtarifa=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vRes = new Tarifa();
                vRes.Id = long.Parse(vDato["idtarifa"].ToString());
                vRes.Descripcion = vDato["descripcion"].ToString();
                vRes.Monto = float.Parse(vDato["monto"].ToString());
                vRes.Servicio = vDato["servicio"].ToString();
                vDato = null;
            }
            vSQL = null;
            return vRes;
        }

        public static double getMontoTarifa(string xId)
        {
            double vRes = 0.00;
            string vSQL = "select monto from tarifa where idtarifa=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null && vDato["monto"].ToString() != "")
                vRes = double.Parse(vDato["monto"].ToString());
            return vRes;
        }
    }
}
