using desagotes;
using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoFotosReparacion
    {
        public static DataTable ObtenerFotosReparacion(long xIdReparacion)
        {
            String vSQL = "";
            vSQL = "select frarchivo";
            vSQL += " from fotosreparacion";
            vSQL += " where fridreparacion=" + xIdReparacion;
            return Sql.getConsultar(vSQL);
        }

        public static void GuardarFoto(long xIdReparacion,String xNombreArchivo)
        {
            String vSQL = "insert into fotosreparacion";
            vSQL += " (frarchivo,fridreparacion)";
            vSQL += " values ('" + xNombreArchivo + "'," + xIdReparacion + ")";
            Sql.ejecutar(vSQL);
        }

        public static void BorrarFoto(long xIdReparacion,String xNombreArchivo)
        {
            String vSQL = "delete from fotosreparacion where";
            vSQL += " frarchivo='" + xNombreArchivo + "' and fridreparacion=" + xIdReparacion;
            Sql.ejecutar(vSQL);
          
        }
    }
}
