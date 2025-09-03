using desagotes.sql;
using reparaciones2.ob.insumos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoInsumo
    {
      

        public static void Guardar(Articulo xArticulo)
        {
            String vSQL = "";
            vSQL = "insert into producto";
            vSQL += " (codigobarra,nombre,idproveedor,marca,tipo,costo,iva,ganancia";
            vSQL += ",monto,stockminimo,stockmaximo)";
            vSQL += " values ('" + xArticulo.Codigo + "','" + xArticulo.Nombre + "'," + xArticulo.Proveedor.Id + ",";
            vSQL += xArticulo.Marca.Id + "," + xArticulo.Modelo.Id + "," + xArticulo.Costo + "," +xArticulo.Iva + "," +xArticulo.Ganancia + ",";
            vSQL += xArticulo.Monto + "," + xArticulo.StockMinimo + "," + xArticulo.StockMaximo + ",";
            Sql.ejecutar(vSQL);
        }
    }
}
