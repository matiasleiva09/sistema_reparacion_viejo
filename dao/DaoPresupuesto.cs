using desagotes;
using desagotes.sql;
using reparaciones2.ob.presupuestos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoPresupuesto
    {
        public static DataTable ObtenerPresupuestos(string xFechaDesde, string xFechaHasta, String xFiltro)
        {
            String vSQL = "";
            vSQL += " select idpresupuesto as \"Nro\", fecha as \"Fecha\", cli.idcliente as idcliente,nombre as \"Nombre\",neto as \"Neto\",iva as \"Iva\",total as \"Total\"";
            vSQL += " from presupuesto pre";
            vSQL += " inner join cliente cli on pre.idcliente = cli.idcliente";
            vSQL += " where ";
            vSQL += " (fecha between '" + Utils.getFechaSinHoraBase(xFechaDesde) + "'";
            vSQL += " and '" + Utils.getFechaSinHoraBase(xFechaHasta) + "')";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " and (nombre like '%" + xFiltro.Trim() + "%'";
                vSQL += " or id=" + xFiltro.Trim() + "";
                vSQL += ")";
            }

            vSQL += " order by fecha desc";
            return Sql.getConsultar(vSQL);
        }

        public static void Guardar(presupuestosCliente xFactura)
        {
            String vSQL = "";
            vSQL = "insert into presupuesto (fecha,idcliente,neto,iva,montounitario,total)";
            vSQL += " values ('" + Utils.getFechaBase(xFactura.Fecha.ToString()) + "','";
            vSQL += xFactura.Cliente.Id + "',";
            vSQL += xFactura.Neto + "," + xFactura.Iva + "," + xFactura.MontoUnitario + "," + xFactura.Total;
            vSQL += ")";
            Sql.ejecutar(vSQL);
            DataRow vDatoID = Sql.getBuscar("select idpresupuesto from presupuesto order by 1 desc limit 1");
            if (vDatoID != null)
            {
                foreach (ItemPresupuesto vItem in xFactura.Items)
                {
                    vSQL = "";
                    vSQL = "insert into item_presupuesto";
                    vSQL += " (idpresupuesto,codigo,cantidad,neto,iva,montounitario,total)";
                    vSQL += " values (" + vDatoID["idpresupuesto"].ToString() + "," + vItem.Articulo.Id + "," + vItem.Cantidad;
                    vSQL += "," + vItem.Neto + "," + vItem.Iva + "," + vItem.MontoUnitario + "," + vItem.Total + ")";
                    Sql.ejecutar(vSQL);
                    //Sql.ejecutar("update producto set stockactual=stockactual +" + vItem.Cantidad + " where idproducto=" + vItem.Articulo.Id);
                }
            }
        }

        public static presupuestosCliente ObtenerPorId(long xId)
        {
            presupuestosCliente vFactura = null;
            String vSQL = "";
            vSQL = "select idpresupuesto,fecha,idcliente,neto,iva,montounitario,total";
            vSQL += " from presupuesto";
            vSQL += " where idpresupuesto=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vFactura = new presupuestosCliente();
                vFactura.Id = xId;
                vFactura.Fecha = DateTime.Parse(vDato["fecha"].ToString());
                vFactura.Cliente = DaoCliente.ObtenerCliente(long.Parse(vDato["idcliente"].ToString()));
                vFactura.Neto = float.Parse(vDato["neto"].ToString());
                vFactura.Iva = float.Parse(vDato["iva"].ToString());
                vFactura.Total = float.Parse(vDato["total"].ToString());
                vFactura.MontoUnitario = float.Parse(vDato["montounitario"].ToString());
                vDato = null;
                vSQL = "";
                vSQL = "select  iditem,";
                vSQL += " codigo,cantidad,neto,iva,montounitario,total";
                vSQL += " from item_presupuesto";
                vSQL += " where idpresupuesto=" + xId;
                DataTable vItems = Sql.getConsultar(vSQL);
                foreach (DataRow vItem in vItems.Rows)
                {
                    ItemPresupuesto vItemF = new ItemPresupuesto();
                    vItemF.Cantidad = long.Parse(vItem["cantidad"].ToString());
                    vItemF.Id = long.Parse(vItem["iditem"].ToString());
                    vItemF.Iva = float.Parse(vItem["iva"].ToString());
                    vItemF.Neto = float.Parse(vItem["neto"].ToString());
                    vItemF.Total = float.Parse(vItem["total"].ToString());
                    vItemF.MontoUnitario = float.Parse(vItem["montounitario"].ToString());
                    vItemF.Articulo = DaoArticulo.ObtenerPorId(long.Parse(vItem["codigo"].ToString()));
                    vFactura.Items.Add(vItemF);
                    vItemF = null;
                }
            }
            return vFactura;
        }

        public static long ObtenerUltimoId(String xIdCliente)
        {
            long vResultado = 0;
            String vSQL = "";
            vSQL = "select idpresupuesto";
            vSQL += " from presupuesto";
            vSQL += " where idcliente=" + xIdCliente;
            vSQL += " order by 1 desc limit 1";
            Console.WriteLine(vSQL);
            try
            {
                DataRow vDato = Sql.getBuscar(vSQL);
                if (vDato != null)
                    vResultado = long.Parse(vDato["idpresupuesto"].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return vResultado;
        }

        /* public void DarDeBaja(long xId)
         {
             String vSQL = "";
             vSQL = "update factura_proveedor set fechabaja='current_date'";
             vSQL += " where idfactura=" + xId;
             Sql.ejecutar(vSQL);
         }*/
    }
}
