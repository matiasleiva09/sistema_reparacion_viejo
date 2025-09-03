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
    class DaoTipo
    {
        public static DataTable ObtenerTipoProducto(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idtipo_producto as \"Id\",descripcion as \"Descripcion\"";
            vSQL += " from tipo_producto";
            if (xFiltro != null && xFiltro.Trim().ToUpper()!="")
            {
                vSQL += " where descripcion like '%" + xFiltro.Trim().ToUpper() + "%'";
            }
            vSQL +=" order by 1 asc";
            DataTable vResultado = Sql.getConsultar(vSQL);
            return vResultado;
        }

        public static TipoArticulo ObtenerPorId(long xId)
        {
            TipoArticulo vRes = null;
            String vSQL = "";
            vSQL = "select idtipo_producto,descripcion";
            vSQL += " from tipo_producto";
            vSQL += " where";
            vSQL += " idtipo_producto=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if(vDato!=null)
            {
                vRes = new TipoArticulo();
                vRes.Id=long.Parse(vDato["idtipo_producto"].ToString());
                vRes.Descripcion = vDato["descripcion"].ToString();
            }
            return vRes;
        }

        public static long ObtenerId(String xDescripcion)
        {
            String vSQL = "";
            vSQL = "select idtipo_producto";
            vSQL += " from tipo_producto";
            vSQL += " where";
            vSQL += " descripcion='"+ xDescripcion.ToUpper() + "'";
            vSQL += " order by idtipo_producto desc limit 1";
            DataRow vDato = Sql.getBuscar(vSQL);
            long vRes = 0;
            if (vDato != null)
                vRes = long.Parse(vDato["idtipo_producto"].ToString());
            vDato = null;
            return vRes;
        }

        public static void Guardar(String xTipoProducto)
        {
            String vSQL = "";
            vSQL = "insert into tipo_producto (descripcion)";
            vSQL += " values ('" + xTipoProducto + "')";
            Sql.ejecutar(vSQL);
        }

        public static void Editar(String xTipoProducto, long xId)
        {
            String vSQL = "";
            vSQL = "update tipo_producto set descripcion='" + xTipoProducto + "'";
            vSQL += " where idtipo_producto=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static void Borrar(long xId)
        {
            String vSQL = "";
            vSQL = "delete from tipo_producto where idtipo_producto=" + xId;
            Sql.ejecutar(vSQL);
        }
    }
}
