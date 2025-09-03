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
    public static class DaoReparaciones
    {

       /* public static void guardar(String xNro,String xIdcliente,String xEquipo,String xFecha,String xAccesorios,
            String xFalla,String xTomado_por,
            String xSenia,String xEstado,String xObservaciones,String xEstadoInterno,bool xEnGarantia)
        {
            String vSQL = "";
            vSQL += "insert into reparaciones (ccliente,idequipo,fecha_entrada,accesorios,falla,tomado_por,senia,estado,";
            vSQL+="observaciones,informeinterno,costo,engarantia)";
            vSQL += " values (" + xNro + "," + xIdcliente + "," + xEquipo + ",'" +Utils.getFechaSinHoraBase(xFecha) + "'";
            vSQL += ",'" + Utils.EvitarCaractereres(xAccesorios) + "','" + Utils.EvitarCaractereres(xFalla) + "','"
                + xTomado_por + "'," + xSenia + ",'" + xEstado + "','" + xObservaciones +"','" + xEstadoInterno + "',0.00,"+xEnGarantia+")";
            Sql.ejecutar(vSQL);
        }*/

        public static void guardar( String xIdcliente, String xEquipo, String xFecha, String xAccesorios,
           String xFalla, String xTomado_por,
           String xSenia, String xEstado, String xObservaciones, String xEstadoInterno, bool xEnGarantia)
        {
            String vSQL = "";
            vSQL += "insert into reparaciones (cliente,idequipo,fecha_entrada,accesorios,falla,tomado_por,senia,estado,";
            vSQL += "observaciones,informeinterno,costo,engarantia)";
            vSQL += " values (" + xIdcliente + "," + xEquipo + ",'" + Utils.getFechaYHoraBase(xFecha) + "'";
            vSQL += ",'" + Utils.EvitarCaractereres(xAccesorios) + "','" + Utils.EvitarCaractereres(xFalla) + "','"
                + xTomado_por + "'," + xSenia + ",'" + xEstado + "','" + xObservaciones + "','" + xEstadoInterno + "',0.00," + xEnGarantia + ")";
            Sql.ejecutar(vSQL);
        }

        public static DataTable ConsultarPorEstado(String xEstado,String xFiltro)
        {
            String vSQL = "";
            vSQL += "select ";
            vSQL += " r.idreparacion as \"Codigo\",";
            vSQL += " estado as \"Estado\",";
            vSQL += " fecha_entrada as \"Fecha Entrada\",";
            vSQL += " c.idcliente as \"Nro Cliente\",";
            vSQL += " c.nombre as \"Cliente\",";
            vSQL += " c.telefono as \"Telefono\",";
            vSQL += " c.celular as \"Celular\",";
            vSQL += " 'Tel.: ' || c.telefono || ', Cel: ' || c.celular as  \"Contacto\", ";
            vSQL += " r.idequipo as \"Nro Equipo\",";
            vSQL += " e.tipo_equipo as \"Tipo Equipo\",";
            vSQL += " e.marca as \"Marca\",";
            vSQL += " e.modelo as \"Modelo\",";
            vSQL += " 'Equipo: ' || e.tipo_equipo || ', Marca: ' || e.marca || ', Modelo: ' || e.modelo as  \"Equipo\",";
            vSQL += " senia as \"Seña\",";
            vSQL += " costo as \"Costo\",";
            vSQL += " montopago as \"Pago\",";
            vSQL += " accesorios as \"Accesorios\",";
            vSQL += " falla as \"Falla\",";
            vSQL += " r.observaciones as \"Observaciones\",";
            vSQL += " r.informeinterno as \"Informe Interno\",";
            vSQL += " informe as \"Informe\",";
            vSQL += " tomado_por as \"Tomado por\", ";
            vSQL += " reparado_por as \"Reparado Por\",";
            vSQL += " fecha_realizada as \"Fecha Reparacion\",";
            vSQL += " entregado_por as \"Entregado Por\",";
            vSQL += " fecha_entrega as \"Fecha Entregada\"";
            vSQL += " from reparaciones r";
            vSQL += " inner join cliente c on c.idcliente=r.cliente";
            vSQL += " inner";
            vSQL += " join equipo e on e.idequipo = r.idequipo";
            vSQL += " where r.estado='" + xEstado + "'";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " and ";
                vSQL += " (upper(c.nombre) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or c.telefono like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or c.celular like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.tipo_equipo) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.marca) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.modelo) like '%" + xFiltro.Trim().ToUpper() + "%'";
                if (Utils.isNumeric(xFiltro.Trim()))
                {
                    vSQL += " or r.codigo=" + xFiltro.Trim();
                }
                vSQL += ")";
            }
            vSQL += " order by 1 desc";

            return Sql.getConsultar(vSQL);
        }
        
        public static void actualizarMontoPago(String xNroOrden,String xMonto)
        {
            String vSQL = "";
            vSQL = "update reparaciones set montopago=" + xMonto + " + montopago where codigo=" + xNroOrden;
            Sql.ejecutar(vSQL);
        }

        public static DataRow ObtenerIdDeNroDeOrden(String xReparacion)
        {
            String vSQL = "";
            vSQL = "select idreparacion from reparaciones where codigo=" + xReparacion;
            return Sql.getBuscar(vSQL);
            
        }

        public static String getClienteDeReparacion(String xIdReparacion)
        {
            String vSQL = "";
            vSQL += "select cliente from reparaciones where idreparacion=" + xIdReparacion;
            DataRow vRes = Sql.getBuscar(vSQL);
            if (vRes != null)
                return vRes["cliente"].ToString();
            else
                return "";
        }

        public static DataTable getReparacionesCliente(long xIdCliente)
        {
            String vSQL = "";
            vSQL += "select";
            vSQL += " r.idreparacion as \"Id\",r.idreparacion as \"Orden\",";
            vSQL +=" fecha_entrada as \"Fecha Entrada\", fecha_realizada as \"Fecha Realizada\", fecha_entrega as \"Fecha Entregada\",";
            vSQL += " r.idequipo as \"Nro Equipo\", estado as \"Estado\",";
            vSQL +=" accesorios as \"Accesorios\", falla as \"Falla\",r.observaciones as \"Observaciones\",";
            vSQL += "r.informeinterno as \"Informe Interno\",";
            vSQL += " informe as \"Informe\", tomado_por as \"Tomado por\", reparado_por as \"Reparado Por\",";
            vSQL +=" entregado_por as \"Entregado Por\",senia as \"Seña\", costo as \"Costo\"";
            vSQL += " from reparaciones r";
            vSQL += " inner";
            vSQL += " join equipo e on e.idequipo = r.idequipo";
            vSQL += " where cliente =" + xIdCliente;
            vSQL += " order by fecha_entrada desc";
            return Sql.getConsultar(vSQL);
        }

        public static void Editar(String xId,String xAccesorios,String xFalla,String xMontoSenia,String xMonto,String xFechaEntregada,
            String xFechaReparada,String xReparadoPor,String xEntregadoPor,String xEstado,String xInforme,String xObservaciones,
            String xInformeInterno,string xEntregadoA, bool xEnGarantia)
        {
            String vSQL = "";
            vSQL = "update reparaciones";
            vSQL += " set";
            vSQL += " accesorios='" + Utils.EvitarCaractereres(xAccesorios) + "',";
            vSQL += " falla='" + Utils.EvitarCaractereres(xFalla) + "',";
            vSQL += " senia=" + xMontoSenia + ",";
            vSQL += " informe='" + Utils.EvitarCaractereres(xInforme) + "',";
            vSQL += " costo=" + xMonto +",";
            if(xFechaReparada.Trim()!="")
                vSQL += " fecha_realizada='" + Utils.getFechaSinHoraBase(xFechaReparada) + "',";
            if(xFechaEntregada.Trim()!="")
               vSQL += " fecha_entrega='" + Utils.getFechaSinHoraBase(xFechaEntregada) + "',";
            vSQL += " entregado_por='" + xEntregadoPor + "',";
            vSQL += " retirada_por='" + xEntregadoA + "',";
            vSQL += " reparado_por='" + xReparadoPor + "',";
            vSQL += " estado='" + xEstado + "',";
            vSQL += " observaciones='" + xObservaciones + "',";
            vSQL += " informeinterno='" + xInformeInterno + "',";
            vSQL += " engarantia=" + xEnGarantia;
            vSQL += " where idreparacion=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static Reparacion getReparacionObj(long xidReparacion)
        {
            String vSQL = "";
            vSQL += "select r.idreparacion as \"Id\",";
            vSQL += " r.idreparacion as \"Codigo\",";
            vSQL += " fecha_entrada as \"Fecha Entrada\",";
            vSQL += " c.idcliente as \"Nro Cliente\",";
            vSQL += " c.nombre as \"Cliente\",";
            vSQL += " c.telefono as \"Telefono\",";
            vSQL += " c.celular as \"Celular\",";
            vSQL += " 'Tel.: ' || c.telefono || ', Cel: ' || c.celular as  \"Contacto\", ";
            vSQL += " r.idequipo as \"Nro Equipo\",";
            vSQL += " e.tipo_equipo as \"Tipo Equipo\",";
            vSQL += " e.marca as \"Marca\",";
            vSQL += " e.modelo as \"Modelo\",";
            vSQL += " 'Equipo: ' || e.tipo_equipo || ', Marca: ' || e.marca || ', Modelo: ' || e.modelo as  \"Equipo\",";
            vSQL += " estado as \"Estado\",";
            vSQL += " engarantia as \"En Garantia\",";
            vSQL += " accesorios as \"Accesorios\",";
            vSQL += " falla as \"Falla\",";
            vSQL += " r.observaciones as \"Observaciones\",";
            vSQL += " r.informeinterno as \"Informe Interno\",";
            vSQL += " informe as \"Informe\",";
            vSQL += " tomado_por as \"Tomado por\", ";
            vSQL += " reparado_por as \"Reparado Por\",";
            vSQL += " fecha_realizada as \"Fecha Reparacion\",";
            vSQL += " entregado_por as \"Entregado Por\",";
            vSQL += " fecha_entrega as \"Fecha Entregada\",";
            vSQL += " senia as \"Seña\",";
            vSQL += " costo as \"Costo\"";
            vSQL += " from reparaciones r";
            vSQL += " inner join cliente c on c.idcliente=r.cliente";
            vSQL += " inner";
            vSQL += " join equipo e on e.idequipo = r.idequipo";
            vSQL += " where r.idreparacion=" + xidReparacion;

            DataRow vQuery =Sql.getBuscar(vSQL);
            Reparacion vRep = new Reparacion();
            vRep.Id = long.Parse(vQuery["Id"].ToString());
            return vRep;
        }

        public static long getIdPorDatos(String xFechaIngreso,String xAccesorios, String xFalla, String xMontoSenia,
            String xEstado,String xObservaciones, string xTomadoPor, bool xEnGarantia)
        {
            String vSQL = "";
            vSQL = "select idreparacion from reparaciones";
            vSQL += " where";
            vSQL += " fecha_entrada='"+ Utils.getFechaYHoraBase(xFechaIngreso)+"' and";
            if(xAccesorios.Trim()!="")
               vSQL += " accesorios='" + Utils.EvitarCaractereres(xAccesorios) + "' and ";
            vSQL += " falla='" + Utils.EvitarCaractereres(xFalla) + "' and ";
            vSQL += " senia=" + xMontoSenia + " and ";
            vSQL += " tomado_por='" + xTomadoPor.Trim() + "' and ";
            vSQL += " estado='" + xEstado + "' and ";
            if(xObservaciones.Trim()!="")
               vSQL += " observaciones='" + xObservaciones + "' and ";
            vSQL += " engarantia=" + xEnGarantia;
            vSQL += " order by idreparacion desc limit 1";
            DataRow vResultado = Sql.getBuscar(vSQL);
            Console.WriteLine(vSQL);
            if (vResultado != null)
                return long.Parse(vResultado["idreparacion"].ToString());
            else
                return 0;
        }

        public static DataRow getReparacion(long xidReparacion)
        {
            String vSQL = "";
            vSQL += "select";
            vSQL += " r.idreparacion as \"Codigo\",";
            vSQL += " fecha_entrada as \"Fecha Entrada\",";
            vSQL += " c.idcliente as \"Nro Cliente\",";
            vSQL += " c.nombre as \"Cliente\",";
            vSQL += " c.telefono as \"Telefono\",";
            vSQL += " c.celular as \"Celular\",";
            vSQL += " 'Tel.: ' || c.telefono || ', Cel: ' || c.celular as  \"Contacto\", ";
            vSQL += " r.idequipo as \"Nro Equipo\",";
            vSQL += " e.tipo_equipo as \"Tipo Equipo\",";
            vSQL += " e.marca as \"Marca\",";
            vSQL += " e.modelo as \"Modelo\",";
            vSQL += " 'Equipo: ' || e.tipo_equipo || ', Marca: ' || e.marca || ', Modelo: ' || e.modelo as  \"Equipo\",";
            vSQL += " estado as \"Estado\",";
            vSQL += " engarantia as \"En Garantia\",";
            vSQL += " accesorios as \"Accesorios\",";
            vSQL += " falla as \"Falla\",";
            vSQL += " r.observaciones as \"Observaciones\",";
            vSQL += " r.informeinterno as \"Informe Interno\",";
            vSQL += " informe as \"Informe\",";
            vSQL += " tomado_por as \"Tomado por\", ";
            vSQL += " reparado_por as \"Reparado Por\",";
            vSQL += " fecha_realizada as \"Fecha Reparacion\",";
            vSQL += " entregado_por as \"Entregado Por\",";
            vSQL += " fecha_entrega as \"Fecha Entregada\",";
            vSQL += " senia as \"Seña\",";
            vSQL += " costo as \"Costo\"";
            vSQL += " from reparaciones r";
            vSQL += " inner join cliente c on c.idcliente=r.cliente";
            vSQL += " inner";
            vSQL += " join equipo e on e.idequipo = r.idequipo";
            vSQL += " where r.idreparacion=" + xidReparacion;
           
            return Sql.getBuscar(vSQL);
        }

       public static void ActualizarSenia(String xId,String xSenia)
       {
            String vSQL = "update reparaciones set senia= senia + " +xSenia;
            vSQL += " where idreparacion=" + xId;
            Sql.ejecutar(vSQL);
       }

        public static DataTable getReparaciones(bool xTodasIngreso, String xFechaDesdeIngreso, String xFechaHastaIngreso,
            bool xTodasEntrega, String xFechaDesdeEntrega, String xFechaHastaEntrega, String xIdCliente, String xIdEquipo,
            String xNro, String xEstado, String xTipoEquipo, String xMarca,String xModelo)
        {
            String vSQL="";
            vSQL +="select";
            vSQL += " r.idreparacion as \"Id\",";
            vSQL +=" r.idreparacion as \"Codigo\",";
            vSQL += " estado as \"Estado\",";
            vSQL +=" fecha_entrada as \"Fecha Entrada\",";
            vSQL +=" c.idcliente as \"Nro Cliente\",";
            vSQL +=" c.nombre as \"Cliente\",";
            vSQL += " c.telefono as \"Telefono\",";
            vSQL += " c.celular as \"Celular\",";
            vSQL += " 'Tel.: ' || c.telefono || ', Cel: ' || c.celular as  \"Contacto\", ";
            vSQL +=" r.idequipo as \"Nro Equipo\",";
            vSQL +=" e.tipo_equipo as \"Tipo Equipo\",";
            vSQL +=" e.marca as \"Marca\",";
            vSQL +=" e.modelo as \"Modelo\",";
            vSQL += " 'Equipo: ' || e.tipo_equipo || ', Marca: ' || e.marca || ', Modelo: ' || e.modelo as  \"Equipo\",";
            vSQL += " senia as \"Seña\",";
            vSQL += " costo as \"Costo\",";
            vSQL += " montopago as \"Pago\",";
            vSQL +=" accesorios as \"Accesorios\",";
            vSQL +=" falla as \"Falla\",";
            vSQL += " r.observaciones as \"Observaciones\",";
            vSQL += " r.informeinterno as \"Informe Interno\",";
            vSQL +=" informe as \"Informe\",";
            vSQL +=" tomado_por as \"Tomado por\", ";
            vSQL +=" reparado_por as \"Reparado Por\",";
            vSQL +=" fecha_realizada as \"Fecha Reparacion\",";
            vSQL +=" entregado_por as \"Entregado Por\",";
            vSQL +=" fecha_entrega as \"Fecha Entregada\"";
            
            vSQL +=" from reparaciones r";
            vSQL +=" inner join cliente c on c.idcliente=r.cliente";
            vSQL +=" inner";
            vSQL +=" join equipo e on e.idequipo = r.idequipo";
            if (xNro != "")
            {
                vSQL += " where r.codigo=" + xNro;
            }
            else
            {
                bool vWhere = true;
                if (!xTodasIngreso)
                {
                    vWhere = false;
                    vSQL += " where (fecha_entrada between '" + Utils.getFechaSinHoraBase(xFechaDesdeIngreso) + " 00:00:00'";
                    vSQL += " and ";
                    vSQL += "'" + Utils.getFechaSinHoraBase(xFechaHastaIngreso) + " 23:59:59')";
                }
                if (!xTodasEntrega)
                {
                    if(!vWhere)
                    {
                        vSQL += " and (fecha_entrega between '" + Utils.getFechaSinHoraBase(xFechaDesdeEntrega) + " 00:00:00'";
                        vSQL += " and '" + Utils.getFechaSinHoraBase(xFechaHastaEntrega) + "23:59:59')";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (fecha_entrega between '" + Utils.getFechaSinHoraBase(xFechaDesdeEntrega) + "'";
                        vSQL += " and '" + Utils.getFechaSinHoraBase(xFechaHastaEntrega) + "')";
                    }
                }
                if(xIdCliente!="")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (c.idcliente=" + xIdCliente + ")";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (c.idcliente=" + xIdCliente + ")";
                    }
                }
                if (xIdEquipo != "")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (r.idequipo=" + xIdEquipo + ")";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (r.idequipo=" + xIdEquipo + ")";
                    }
                }
                if(xEstado!="")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (estado='" + xEstado + "')";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (estado='" + xEstado + "')";
                    }
                }
                if(xTipoEquipo!="")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (e.tipo_equipo='" + xTipoEquipo + "')";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (e.tipo_equipo='" + xTipoEquipo + "')";
                    }
                }
                if (xMarca != "")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (e.marca='" + xMarca + "')";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (e.marca='" + xMarca + "')";
                    }
                }
                if (xModelo != "")
                {
                    if (!vWhere)
                    {
                        vSQL += " and (e.modelo='" + xModelo + "')";
                    }
                    else
                    {
                        vWhere = false;
                        vSQL += " where (e.modelo='" + xModelo + "')";
                    }
                }
            }
            vSQL += " order by 1 desc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable getReparaciones(String xFiltro)
        {
            String vSQL = "";
            vSQL += "select";
            vSQL += " r.idreparacion as \"Id\",";
            vSQL += " r.idreparacion as \"Codigo\",";
            vSQL += " fecha_entrada as \"Fecha Entrada\",";
            vSQL += " c.idcliente as \"Nro Cliente\",";
            vSQL += " c.nombre as \"Cliente\",";
            vSQL += " c.telefono as \"Telefono\",";
            vSQL += " c.celular as \"Celular\","; ;
            vSQL += " r.idequipo as \"Nro Equipo\",";
            vSQL += " e.tipo_equipo as \"Tipo Equipo\",";
            vSQL += " e.marca as \"Marca\",";
            vSQL += " e.modelo as \"Modelo\",";
            vSQL += " estado as \"Estado\",";
            vSQL += " accesorios as \"Accesorios\",";
            vSQL += " falla as \"Falla\",";
            vSQL += " r.observaciones as \"Observaciones\",";
            vSQL += " r.informeinterno as \"Informe Iterno\",";
            vSQL += " informe as \"Informe\",";
            vSQL += " tomado_por as \"Tomado por\", ";
            vSQL += " reparado_por as \"Reparado Por\",";
            vSQL += " fecha_realizada as \"Fecha Reparacion\",";
            vSQL += " entregado_por as \"Entregado Por\",";
            vSQL += " fecha_entrega as \"Fecha Entregada\",";
            vSQL += " senia as \"Seña\",";
            vSQL += " costo as \"Costo\"";
            vSQL += " from reparaciones r";
            vSQL += " inner join cliente c on c.idcliente=r.cliente";
            vSQL += " inner";
            vSQL += " join equipo e on e.idequipo = r.idequipo";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " where ";
                vSQL += " upper(c.nombre) like '%" +  xFiltro.Trim().ToUpper() +"%'";
                vSQL += " or c.telefono like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or c.celular like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.tipo_equipo) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.marca) like '%" + xFiltro.Trim().ToUpper() + "%'";
                vSQL += " or upper(e.modelo) like '%" + xFiltro.Trim().ToUpper() + "%'";
                if(Utils.isNumeric(xFiltro.Trim()))
                {
                    vSQL += " or r.codigo=" + xFiltro.Trim();
                }
            }
            vSQL += " order by 1 desc";
            return Sql.getConsultar(vSQL);
        }
    }
}
