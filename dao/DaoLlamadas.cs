using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoLlamadas
    {
        public static DataTable getLlamadas(String xIdReparacion)
        {
            String vSQL = "";
            vSQL = "select rlfecha as Fecha,rllamadopor as \"Llamado Por\",rldescripcion as \"Descripcion\"";
            vSQL += " from registrollamada";
            vSQL += " where rlidreparacion=" + xIdReparacion;
            vSQL += " order by 1 desc";
            return Sql.getConsultar(vSQL);
        }

        public static void guardar(String xIdReparacion,String xFecha,String xQuienLlamo,String xDescripcion)
        {
            String vSQL = "";
            vSQL += "insert into registrollamada (rlidreparacion,rlfecha,rllamadopor,rldescripcion)";
            vSQL += " values (" + xIdReparacion + ",'" + xFecha + "','" + xQuienLlamo + "','"+ xDescripcion + "')";
            Sql.ejecutar(vSQL);
        }
    }
}
