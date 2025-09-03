using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DAOEquipoDiccionario
    {
        public static DataTable getEquipos()
        {
            String vSQL = "select distinct upper(tipoequipo) as tipoequipo from equipodiccionario order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getMarcas()
        {
            String vSQL = "select distinct upper(marca) as marca from equipodiccionario order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getMarcas(String xEquipo)
        {
            String vSQL = "select distinct upper(marca) as marca from equipodiccionario where tipoequipo='" + xEquipo + "'";
            vSQL += " order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getModelos()
        {
            String vSQL = "select distinct upper(modelo) as modelo from equipodiccionario order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getModelos(String xMarca)
        {
            String vSQL = "select distinct upper(modelo) as modelo from equipodiccionario where marca='" + xMarca + "'";
            vSQL += " order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static bool Existe(String xTipo,String xMarca,String xModelo)
        {
            String vSQL = "";
            vSQL = "select id from equipodiccionario";
            vSQL += " where ";
            vSQL += " tipoequipo='" + xTipo +"' and";
            vSQL += " marca='" + xMarca + "' and";
            vSQL += " modelo='" + xModelo + "'";
            DataRow vRes = Sql.getBuscar(vSQL);
            if (vRes != null)
                return true;
            else
                return false;
        }

        public static void Guardar(String xTipo, String xMarca, String xModelo)
        {
            String vSQL = "";
            vSQL = "insert into equipodiccionario(tipoequipo,marca,modelo)";
            vSQL += " values ('" + xTipo + "','" + xMarca + "','" + xModelo + "')" ;
            Sql.ejecutar(vSQL);
        }
    }
}
