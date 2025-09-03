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
    public static  class DaoProveedor
    {
        public static void Guardar(Proveedor xProveedor)
        {
            String vSQL = "";
            vSQL = "insert into proveedor";
            vSQL += " (nombre,condicioniva,cuit,calle,nro,";
            vSQL += "piso,dpto,localidad,provincia,cp,telefono,";
            vSQL += "celular,whatsapp,email)";
            vSQL += " values ('" + xProveedor.Nombre + "','" + xProveedor.CondicionIVA + "',";
            vSQL += "'" + xProveedor.Cuit + "','" + xProveedor.Calle +"','" + xProveedor.Nro +"',";
            vSQL += "" + xProveedor.Piso + ",'" + xProveedor.Dpto + "','" + xProveedor.Localidad + "',";
            vSQL += "'" + xProveedor.Provincia+"','"+xProveedor.Cp  +"','" + xProveedor.Telefono +"','"+ xProveedor.Celular + "',";
            vSQL += "'"+ xProveedor.Whatsapp +"','" + xProveedor.Email +"')";
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static void Borrar(long xId)
        {
            String vSQL = "";
            vSQL = "delete from proveedor where idproveedor=" + xId;
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static long ObtenerIdProveedor(String xNombre,String xCondicionIva,String xCuit,String xTelefono,String xCelular)
        {
            long vResultado = 0;
            String vSQL = "";
            vSQL = "select idproveedor from proveedor";
            vSQL += " where";
            vSQL += " nombre='" + xNombre + "'";
            vSQL += " and condicioniva='" + xCondicionIva + "'";
            vSQL += " and cuit='" + xCuit + "'";
            vSQL += " and telefono='" + xTelefono + "'";
            vSQL += " and celular='" + xCelular + "'";
            vSQL += " order by 1 desc limit 1";
            DataRow vDato = Sql.getBuscar(vSQL);
            vResultado = long.Parse(vDato["idproveedor"].ToString());
            vDato = null;
            return vResultado;
        }

        public static Proveedor ObtenerProveedor(long xId)
        {
            Proveedor vProveedor = new ob.insumos.Proveedor();
            String vSQL = "select nombre,condicioniva,cuit,calle,nro";
            vSQL += ",piso,dpto,localidad,provincia,telefono,celular,whatsapp,email,cp";
            vSQL += " from proveedor";
            vSQL += " where idproveedor=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            vSQL = null;
            if (vDato != null)
            {
                vProveedor.Id = xId;
                vProveedor.Nombre = vDato["nombre"].ToString();
                vProveedor.CondicionIVA = vDato["condicioniva"].ToString();
                vProveedor.Cuit = vDato["cuit"].ToString();
                vProveedor.Calle = vDato["calle"].ToString();
                vProveedor.Provincia = vDato["provincia"].ToString();
                vProveedor.Localidad = vDato["localidad"].ToString();
                vProveedor.Dpto = vDato["Dpto"].ToString();
                vProveedor.Piso = int.Parse(vDato["piso"].ToString());
                vProveedor.Nro = vDato["nro"].ToString();
                vProveedor.Telefono = vDato["telefono"].ToString();
                vProveedor.Celular = vDato["celular"].ToString();
                vProveedor.Whatsapp = vDato["whatsapp"].ToString();
                vProveedor.Email = vDato["email"].ToString();
                vProveedor.Cp = vDato["cp"].ToString();
            }
            vDato = null;
            return vProveedor;
        }

        public static void Editar(Proveedor xProveedor)
        {
            String vSQL = "";
            vSQL = "update proveedor";
            vSQL += " set ";
            vSQL += "nombre='"+ xProveedor.Nombre +"',";
            vSQL += "condicioniva='" + xProveedor.CondicionIVA + "',";
            vSQL += "cuit='" + xProveedor.Cuit + "',";
            vSQL += "calle='" + xProveedor.Calle + "',";
            vSQL += "nro='" + xProveedor.Nro + "',";
            vSQL += "piso=" + xProveedor.Piso + ",";
            vSQL += "dpto='" + xProveedor.Dpto + "',";
            vSQL += "localidad='" + xProveedor.Localidad + "',";
            vSQL += "provincia='" + xProveedor.Provincia + "',";
            vSQL += "telefono='" + xProveedor.Telefono + "',";
            vSQL += "celular='" + xProveedor.Celular + "',";
            vSQL += "whatsapp='" + xProveedor.Whatsapp + "',";
            vSQL += "email='" + xProveedor.Email + "',";
            vSQL += "cp='" + xProveedor.Cp + "'";
            vSQL += " where idproveedor=" + xProveedor.Id;
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static DataTable ObtenerProveedores(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idproveedor as \"Id\",nombre as \"Nombre\", condicioniva as \"Condicion de Iva\",";
            vSQL += "cuit as \"Cuit\", telefono as \"Telefono\", celular as \"Celular\",email as \"Email\"";
            vSQL += " from proveedor";
            if(xFiltro!=null && xFiltro.Trim()!="")
            {
                vSQL += " where nombre like '%" + xFiltro.Trim() +"%'";
                vSQL += " or condicioniva like '%" + xFiltro.Trim() + "%'";
                vSQL += " or cuit like '%" + xFiltro.Trim() + "%'";
                vSQL += " or telefono like '%" + xFiltro.Trim() +"%'";
                vSQL += " or celular like '%" + xFiltro.Trim() + "%'";
                vSQL += " or email like '%" + xFiltro.Trim() + "%'";
            }
            vSQL += " order by 2 asc";
            return Sql.getConsultar(vSQL);
        }
    }
}
