using desagotes;
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
    public static class DaoCliente
    {

        public static String ObtenerId(String xNombre,String xCalle,String xPiso,String xDpto,String xLocalidad,String xProvincia,
            String xTelefono,String xCelular,String xMail,String xObservaciones,String xGeo,String xTipoDocumento,String xNroDocumento,
            String xCondicionIVA,String xCuit)
        {
            String vSQL = "select idcliente";
            vSQL += " from cliente";
            vSQL += " where ";
            vSQL += " nombre='" + xNombre +"' and calle='" + xCalle + "' and piso='" +xPiso +"' and ";
            vSQL += " dpto='" + xDpto +"' and localidad='" + xLocalidad +"' and provincia='" + xProvincia +"'";
            vSQL += " and telefono='" + xTelefono +"' and celular='" + xCelular +"' and mail='" + xMail +"'";
            vSQL += " and geo='" + xGeo + "'";
            vSQL += " and tipodocumento='" + xTipoDocumento + "'";
            vSQL += " and nrodocumento='" + xNroDocumento + "'";
            vSQL += " and condicioniva='" + xCondicionIVA + "'";
            vSQL += " and cuit='" + xCuit + "'";
            vSQL += " and observaciones='" + xObservaciones + "' order by 1 desc";
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["idcliente"].ToString();
        }

        public static String obtenerMail(String xId)
        {
            String vSQL = "select mail";
            vSQL += " from cliente";
            vSQL += " where idcliente=" + xId;
            DataRow vRes = Sql.getBuscar(vSQL);
            return vRes["mail"].ToString();
        }

        public static void guardar(Cliente xCliente)
        {
            String vSQL = "insert into cliente";
            vSQL += "(nombre,calle,nro,piso,dpto,cp,localidad,provincia,telefono,";
            vSQL += "celular,mail,observaciones,geo,tipodocumento,nrodocumento,condicioniva,cuit)";
            vSQL += " values ('" + Utils.EvitarCaractereres(xCliente.Nombre) + "','" + Utils.EvitarCaractereres(xCliente.Calle) + "','" + xCliente.Nro + "','";
            vSQL += xCliente.Piso + "','" + xCliente.Dpto +"','" + Utils.EvitarCaractereres(xCliente.Cp)+ "','" + Utils.EvitarCaractereres(xCliente.Localidad) +"','" + Utils.EvitarCaractereres(xCliente.Provincia) + "','";
            vSQL += xCliente.Telefono + "','" + xCliente.Celular + "','" + xCliente.Email + "','" + Utils.EvitarCaractereres(xCliente.Observaciones) + "','" 
                + xCliente.Geo + "','"+xCliente.TipoDocumento +"','"+ xCliente.NroDocumento +"','"
                + xCliente.CondicionIVA + "','" + xCliente.Cuit +"' )";
            Sql.ejecutar(vSQL);
        }

        public static void editar(Cliente xCliente)
        {
            String vSQL = "update cliente";
            vSQL += " set";
            vSQL += " nombre='" + Utils.EvitarCaractereres(xCliente.Nombre) + "',";
            vSQL += " calle='" + Utils.EvitarCaractereres(xCliente.Calle) + "',";
            vSQL += " nro='" + xCliente.Nro +"',";
            vSQL += " piso='" + xCliente.Piso + "',";
            vSQL += " cp='" + xCliente.Cp + "',";
            vSQL += " localidad='" + Utils.EvitarCaractereres(xCliente.Localidad) + "',";
            vSQL += " provincia='" + Utils.EvitarCaractereres(xCliente.Provincia) + "',";
            vSQL += " telefono='" + xCliente.Telefono + "',";
            vSQL += " celular='" + xCliente.Celular + "',";
            vSQL += " tipodocumento='" + xCliente.TipoDocumento + "',";
            vSQL += " nroDocumento='" + xCliente.NroDocumento + "',";
            vSQL += " condicioniva='" + xCliente.CondicionIVA + "',";
            vSQL += " cuit='" + xCliente.Cuit + "',";
            vSQL += " mail='" + Utils.EvitarCaractereres(xCliente.Email) + "',";
            vSQL += " geo='" + xCliente.Geo + "',";
            vSQL += " observaciones='" + Utils.EvitarCaractereres(xCliente.Observaciones) + "'";
            vSQL += " where idcliente=" + xCliente.Id;
            Sql.ejecutar(vSQL);
        }

        public static void borrar(long xId)
        {
            String vSQL = "";
            vSQL = "delete from cliente where idcliente=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static void borrar(Cliente xCliente)
        {
            String vSQL = "";
            vSQL = "delete from cliente where idcliente=" + xCliente.Id;
            Sql.ejecutar(vSQL);
        }
        public static DataTable ListarClientes()
        {
            String vSQL = "select idcliente as \"Id\",nombre as \"Nombre\",";
            vSQL += " case when trim(calle) <> '' then";
            vSQL += " 'Calle: ' || calle || ', Nro: ' || nro || ' Piso:' || piso || ' Dpto:' || dpto";
            vSQL += " else";
            vSQL += " ''";
            vSQL += " end as \"Domicilio\", localidad as \"Localidad\", provincia as \"Provincia\",";
            vSQL += " tipodocumento as \"Tipo Doc.\", nrodocumento as \"Nro. Documento\", condicionIVA as \"Condición IVA\",";
            vSQL += " Cuit as \"Cuit\", telefono as telefono";
            vSQL += " from cliente order by nombre asc; ";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable ListarClientes(String xFiltro)
        {
            String vSQL = "select idcliente as \"Id\",nombre as \"Nombre\",telefono as telefono, celular as celular,";
            vSQL += " case when trim(calle) <> '' then";
            vSQL += " 'Calle: ' || calle || ', Nro: ' || nro || ' Piso:' || piso || ' Dpto:' || dpto";
            vSQL += " else";
            vSQL += " ''";
            vSQL += " end as \"Domicilio\", localidad as \"Localidad\", provincia as \"Provincia\",";
            vSQL += " tipodocumento as \"Tipo Doc.\", nrodocumento as \"Nro. Documento\", condicionIVA as \"Condición IVA\",";
            vSQL += " Cuit as \"Cuit\",geo as \"Geo\"";
            vSQL += " from cliente";
            if(xFiltro!=null && xFiltro.Trim()!="")
            {
                vSQL += " where upper(nombre) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(calle)  like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or cuit like '%" + xFiltro.Trim() + "%'";
                vSQL += " or telefono like '%" + xFiltro.Trim() + "%'";
                vSQL += " or celular like '%" + xFiltro.Trim() + "%'";
            }
            
            vSQL +=" order by nombre asc; ";
            return Sql.getConsultar(vSQL);
        }

        public static Cliente ObtenerCliente(long xId)
        {
            String vSQL = "select idcliente,nombre,calle,nro,piso,dpto,localidad,cp,provincia,tipodocumento,nrodocumento,";
            vSQL += "condicioniva,cuit,telefono,celular,mail,observaciones,geo";
            vSQL += " from cliente";
            vSQL += " where idcliente=" + xId;
            //Console.WriteLine(vSQL);
            DataRow vRes = Sql.getBuscar(vSQL);
            Console.WriteLine(vRes);
            if (vRes != null)
            {
                Cliente vCliente = new Cliente();
                vCliente.Id = xId;
                vCliente.Nombre = vRes["nombre"].ToString();
                vCliente.Calle = vRes["calle"].ToString();
                vCliente.Nro = vRes["nro"].ToString();
                vCliente.Piso = vRes["piso"].ToString();
                vCliente.Dpto = vRes["dpto"].ToString();
                vCliente.Localidad = vRes["localidad"].ToString();
                vCliente.Provincia = vRes["provincia"].ToString();
                vCliente.CondicionIVA = vRes["condicioniva"].ToString();
                vCliente.TipoDocumento = vRes["tipodocumento"].ToString();
                vCliente.NroDocumento = vRes["nrodocumento"].ToString();
                vCliente.Cuit = vRes["cuit"].ToString();
                vCliente.Celular = vRes["celular"].ToString();
                vCliente.Telefono = vRes["telefono"].ToString();
                vCliente.Cp = vRes["cp"].ToString();
                vCliente.Email = vRes["mail"].ToString();
                vCliente.Observaciones = vRes["observaciones"].ToString();
                vCliente.Geo = vRes["geo"].ToString();
                return vCliente;

            }
            else
            {
                return null;
            }
        }

        public static DataTable GetClientesParaComboBox()
        {
            String vSQL = "";
            vSQL = "select idcliente, nombre || ' - Id: ' || idcliente  as nombre from cliente order by 2 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getCuentaCorrienteCliente(String xIdCliente)
        {
            String vSQL = "";
            vSQL = "select case when mix.fecha is null then current_date else mix.fecha end as \"Fecha\",";
            vSQL += " case when mix.nro is null then '' else mix.nro end  as \"Nro\",";
            vSQL += " case when  mix.descripcion is null then '' else mix.descripcion end as \"Descripcion\", mix.monto as \"Monto\"";
            vSQL +=" from";
            vSQL += "(select fecha_entrada as fecha,idreparacion || '' as nro, 'Tipo: ' || tipo_equipo || ',";
            vSQL += " Marca: '|| marca || ', Modelo: ' || modelo as descripcion, costo as monto";
            vSQL += " from reparaciones as re";
            vSQL += " inner";
            vSQL += " join equipo eq on eq.idequipo = re.idequipo";
            vSQL += " where cliente =" + xIdCliente + " and re.costo > 0";
            vSQL += " union";
            vSQL += " select fecha as fecha,nrorecibo as nro,";
            vSQL += " concepto as descripcion, monto * -1 as monto";
            vSQL += " from reciboingreso";
            vSQL += " where idcliente =" + xIdCliente;
            vSQL += " union";
            vSQL += " select ccfecha as fecha,'NC' || ccnro as nro,ccdescripcion as descripcion,(monto * -1) as monto";
            vSQL += " from notacredito";
            vSQL += " where ccidcliente =" + xIdCliente;
            vSQL += " union";
            vSQL += " select cdfecha as fecha,'ND' || cdnro as nro,cddescripcion as descripcion,cdmonto as monto";
            vSQL += " from notadebito";
            vSQL += " where cdidcliente =" + xIdCliente;
            vSQL +=") as mix order by fecha desc";
            Console.WriteLine(vSQL);
            return Sql.getConsultar(vSQL);
        }
    }
}
