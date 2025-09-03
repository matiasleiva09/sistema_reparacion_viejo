using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DAOReportes
    {
        public static DataTable getReporteCostoRepPorAni(String xDesde,String xHasta)
        {
            String vSQL = "";
            vSQL = "select anio,mes,sum(costo) as montototal,sum(montopago) as montopago";
            vSQL += " from(select EXTRACT(YEAR FROM fecha_entrada) as anio,";
            vSQL += " EXTRACT(MONTH FROM fecha_entrada) as mes,costo,montopago";
            vSQL += " from reparaciones";
            vSQL += " where fecha_entrada between '" + xDesde + "-01-01' and '" + xHasta + "-12-31')";
            vSQL += " as mix";
            vSQL += " group by anio,mes";
            vSQL +=" order by anio, mes asc";
            return Sql.getConsultar(vSQL);
        }
    }
}
