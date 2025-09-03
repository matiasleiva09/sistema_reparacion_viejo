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
    public static class DaoEquipo
    {
        public static DataTable EquiposDeCliente(long xId)
        {
            String vSQL = "";
            vSQL += "select idequipo as \"Nro\",";
            vSQL += " fecha_ingreso as \"Fecha\",";
            vSQL += " tipo_equipo as \"Tipo Equipo\",";
            vSQL += " marca as \"Marca\",";
            vSQL += " modelo as \"Modelo\"";
            vSQL += " from equipo";
            vSQL += " where idcliente =" + xId;
            vSQL += " order by idequipo";
            return Sql.getConsultar(vSQL);
        }

        public static String IdEquipoCliente(String xIdCliente, String xTipo, String xMarca, String xModelo)
        {
            String vSQL = "";
            vSQL = "select idequipo from equipo";
            vSQL += " where idcliente= " + xIdCliente;
            vSQL += " and tipo_equipo='" + xTipo + "'";
            vSQL += " and marca='" + xMarca + "'";
            vSQL += " and modelo='" + xModelo  +"'";
            vSQL += " order by 1 desc";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["idequipo"].ToString();
        }

        public static Equipo ObtenerEquipoPorId(long xId)
        {
            String vSQL = "";
            vSQL += "select idequipo as \"Nro\",";
            vSQL += " tipo_equipo as \"Tipo Equipo\",";
            vSQL += " marca as \"Marca\",";
            vSQL += " modelo as \"Modelo\"";
            vSQL += " from equipo";
            vSQL += " where idequipo =" + xId;
            DataRow vDato=Sql.getBuscar(vSQL);
            Equipo vEquipo = new ob.Equipo();
            vEquipo.Id = long.Parse(vDato["Nro"].ToString());
            vEquipo.Marca = vDato["marca"].ToString();
            vEquipo.Modelo = vDato["modelo"].ToString();
            vEquipo.TipoEquipo = vDato["Tipo Equipo"].ToString();
            return vEquipo;
        }

        public static DataTable getTodosLosEquipos(String xFiltro)
        {
            String vSQL = "";
            vSQL += "select idequipo as \"Nro\","; 
            vSQL += " tipo_equipo as \"Tipo Equipo\",";
            vSQL += " marca as \"Marca\",";
            vSQL += " modelo as \"Modelo\",";
            vSQL += " c.idcliente as \"Nro. Cliente\",";
            vSQL += " nombre as \"Nombre\"";
            vSQL += " from equipo e";
            vSQL += " inner join cliente c on c.idcliente=e.idcliente";
            if (xFiltro != "")
            {
                vSQL += " where nombre like '%" + xFiltro +"%' or";
                vSQL += " where tipo_equipo like '%" + xFiltro + "%' or";
                vSQL += " where marca like '%" + xFiltro + "%' or";
                vSQL += " where modelo like '%" + xFiltro + "%' or";
            }
            vSQL += " order by nombre asc";
            return Sql.getConsultar(vSQL);
        }

        public static void Guardar(Equipo xEquipo)
        {
            String vSQL = "";
            vSQL = "insert into equipo";
            vSQL += " (fecha_ingreso,tipo_equipo,marca,modelo,idcliente)";
            vSQL += " values (current_date,'" + xEquipo.TipoEquipo + "','" + xEquipo.Marca + "','" + xEquipo.Modelo + "',";
            vSQL += xEquipo.Cliente.Id + ")";
            Sql.ejecutar(vSQL);
        }

        public static void editar(Equipo xEquipo)
        {
            String vSQL = "";
            vSQL = "update equipo";
            vSQL += " set";
            vSQL += " tipo_equipo='" + xEquipo.TipoEquipo + "',";
            vSQL += " marca='" + xEquipo.Marca + "',";
            vSQL += " modelo='" + xEquipo.Modelo + "'";
            vSQL += " where idequipo=" + xEquipo.Id;
            Sql.ejecutar(vSQL);
        }

        public static DataTable getEquiposComboBox(String xId)
        {
            String vSQL = "";
            vSQL = "select idequipo, 'Id: ' || idequipo || '- Tipo: ' || tipo_equipo || ' Marca:' || marca || ' Modelo: ' || modelo ";
            vSQL += " from equipo";
            vSQL += " where idcliente=" + xId;
            return Sql.getConsultar(vSQL);
        }
    }
}
