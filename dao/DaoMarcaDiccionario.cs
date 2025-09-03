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
    public class DaoMarcaDiccionario
    {
        public static DataTable ObtenerMarcas()
        {
            String vSQL = "";
            vSQL = "select idmarca as \"Id\", descripcion as \"Descripcion\" from marca order by 1 asc";
            DataTable vResultado = Sql.getConsultar(vSQL);
            return vResultado;
        }

        public static Marca ObtenerPorId(long xId)
        {
            Marca vMarca = null;
            String vSQL = "";
            vSQL = "select idmarca, descripcion from marca";
            vSQL += " where idmarca=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if(vDato!=null)
            {
                vMarca = new ob.insumos.Marca();
                vMarca.Descripcion=vDato["descripcion"].ToString();
                vMarca.Id = long.Parse(vDato["idmarca"].ToString());
            }
            return vMarca;
        }

        public static DataTable ObtenerMarcas(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idmarca as \"Id\", descripcion as \"Descripcion\" from marca";
            if (xFiltro != null && xFiltro.Trim() != "")
                vSQL += " where upper(marca) like '%" + xFiltro.Trim().ToUpper() + "%'";
            vSQL+=" order by 1 asc";
            DataTable vResultado = Sql.getConsultar(vSQL);
            return vResultado;
        }

        public static long ObtenerId(String xMarca)
        {
            String vSQL = "";
            long vRes = 0;
            vSQL = "select idmarca from marca";
            vSQL += " where descripcion='" + xMarca.Trim().ToUpper() +"'";
            vSQL += " order by idmarca desc limit 1";
            DataRow vDato =Sql.getBuscar(vSQL);
            if(vDato!=null)
            {
                vRes = long.Parse(vDato["idmarca"].ToString());
                vDato = null;
            }
            return vRes;
        }       

        public static void Guardar(String xMarca)
        {
            String vSQL = "";
            vSQL = "insert into marca (descripcion)";
            vSQL += " values ('" + xMarca.Trim().ToUpper() + "')";
            Sql.ejecutar(vSQL);
        }

        public static void Editar(String xMarca,long xId)
        {
            String vSQL = "";
            vSQL = "update marca set descripcion='" + xMarca + "'";
            vSQL += " where idmarca=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static void Borrar(long xId)
        {
            String vSQL = "";
            vSQL = "delete from marca where idmarca="+ xId;
            Sql.ejecutar(vSQL);
        }
    }
}
