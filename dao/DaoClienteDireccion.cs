using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoClienteDireccion
    {
        public static DataRow GetDireccionService(long xId)
        {
            DataRow vRes = null;
            String vSQL = "";
            vSQL = "select cdcalle as calle,cdnro as nro,cdpiso as piso,cddpto as dpto,";
            vSQL += "cdlocalidad as localidad,cdprovincia as provincia, cdcoordenada as coordenada,";
            vSQL += "cdcp as cp";
            vSQL += " from cliente_direccion";
            vSQL += " where cdid=" + xId;
            vRes = Sql.getBuscar(vSQL);
            return vRes;
        }
        public static DataTable getDireccionesCliente(long xCliente)
        {
            DataTable vRes = null;
            String vSQL = "select cdcalle as calle,cdnro as nro,cdpiso as piso,cddpto as dpto,";
            vSQL += "cdlocalidad as localidad,cdprovincia as provincia, cdcoordenada as coordenada,";
            vSQL += "cdcp as cp";
            vSQL += " from cliente_direccion";
            vSQL += " where cdicliente=" + xCliente;
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }
        //POR CONCURRENCIA DE DATOS
        public static long GetBuscarExacto(String xCalle, String xNro, String xPiso, String xDpto,
            String xLocalidad, String xProvincia, String xCp, String xCoordenadas, long xIdCliente)
        {
            String vSQL = "select ccid from cliente_direccion";
            vSQL += " where";
            vSQL += "cdcalle='" + xCalle + "' and ";
            vSQL += "cdnro='" + xNro + "' and ";
            vSQL += "cdpiso='" + xPiso + "' and ";
            vSQL += "cddpto='" + xDpto + "' and ";
            vSQL += "cdlocalidad='" + xLocalidad + "' and ";
            vSQL += "cdprovincia='" + xProvincia + "' and ";
            vSQL += "cdcoordenada='" + xCoordenadas + "' and ";
            vSQL += "cdcp='" + xCp + "' and cdidcliente=" + xIdCliente; 
            vSQL +="order by 1 desc limit 1";
            DataRow vRes = Sql.getBuscar(vSQL);
            if (vRes != null)
                return long.Parse(vRes["ccid"].ToString());
            else
                return 0;
        }

        public static void GuardarDireccion(String xCalle, String xNro, String xPiso, String xDpto,
            String xLocalidad, String xProvincia, String xCp, String xCoordenadas, long xIdCliente)
        {
            String vSQL = "insert into cliente_direccion";
            vSQL = " (cdidcliente,cdcalle,cdnro,cdpiso,cddpto,cdlocalidad,cdprovincia,cdcoordenada,cdcp)";
            vSQL += " values (" + xIdCliente + ",'" + xCalle + "','" + xNro + "','" + xPiso + "','" + xDpto + "','";
            vSQL += xLocalidad + "','" + xProvincia + "','" + xCoordenadas + "','" + xCp + "')";
            try
            {
                Sql.ejecutar(vSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void EditarDireccion(String xCalle, String xNro, String xPiso, String xDpto,
            String xLocalidad, String xProvincia, String xCp, String xCoordenadas, long xId)
        {
            String vSQL = "update cliente_direccion";
            vSQL += "set ";
            vSQL += "cdcalle='" + xCalle + "',";
            vSQL += "cdnro='" + xNro + "',";
            vSQL += "cdpiso='" + xPiso + "',";
            vSQL += "cddpto='" + xDpto + "',";
            vSQL += "cdlocalidad='" + xLocalidad + "',";
            vSQL += "cdprovincia='" + xProvincia + "',";
            vSQL += "cdcoordenada='" + xCoordenadas + "',";
            vSQL += "cdcp='" + xCp + "',";
            vSQL += " where cdid=" + xId;
            try
            {
                Sql.ejecutar(vSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
