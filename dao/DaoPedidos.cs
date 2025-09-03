using desagotes;
using desagotes.sql;
using reparaciones2.dao;
using reparaciones2.ob.presupuestos;
using stocksires.ob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stocksires.dao
{
    public static class DaoPedidos
    {
        public static DataTable ObtenerPresupuestos(string xFechaDesde,string xFechaHasta, String xFiltro)
        {
            String vSQL = "";
            vSQL += " select idpedido as \"Nro\", fecha as \"Fecha\", cli.idcliente as idcliente,nombre as \"Nombre\",neto as \"Neto\",iva as \"Iva\",total as \"Total\"";
            vSQL += " from pedido pre";
            vSQL += " inner join cliente cli on pre.icliente = cli.idcliente";
            vSQL += " where ";
            vSQL += " (fecha between '" +Utils.getFechaSinHoraBase(xFechaDesde) + "'";
            vSQL += " and '" + Utils.getFechaSinHoraBase(xFechaHasta) + "')";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " and (nombre like '%" + xFiltro.Trim() + "%'";
                vSQL += " or id=" + xFiltro.Trim() + "";
                vSQL += ")";
            }
            Console.WriteLine(vSQL);
            vSQL += " order by fecha desc";
            return Sql.getConsultar(vSQL);
        }

       

        public static void borrarItem(long xId,string xCodigo)
        {
            string vSQL = "";
            vSQL="select idproducto from producto where codigobarra ='" + xCodigo + "'";
            DataRow vIdProducto = Sql.getBuscar(vSQL);
            if(vIdProducto!=null)
            {

                vSQL = "";
                vSQL = "select cantidad,total from item_pedido";
                vSQL += " where ";
                vSQL += " idpedido = "+xId;
                vSQL += " and codigo='" + vIdProducto["idproducto"].ToString() + "'";
                DataRow vCantidad = Sql.getBuscar(vSQL); 
                vSQL = "delete from item_pedido where idpedido="+xId;
                vSQL += " and codigo='" + vIdProducto["idproducto"].ToString()+"'";
                Sql.ejecutar(vSQL);
                if(vCantidad!=null)
                {
                    Sql.ejecutar("update producto set stockactual=(stockactual +" + vCantidad["cantidad"].ToString()+") where idproducto=" + vIdProducto["idproducto"].ToString());
                    Console.WriteLine("update producto set stockactual=stockactual +" + vCantidad["cantidad"].ToString() + " where idproducto=" + vIdProducto["idproducto"].ToString());
                    Console.WriteLine(vCantidad["cantidad"].ToString());


                }
              
            }
        }

        public static void AgregarItem(long xIdPedido, string xCodigo, double neto, double iva, float total, float montounitario, long cantidad)
        {
            string vSQL = "";
            vSQL = "select idproducto from producto where codigobarra ='" + xCodigo + "'";
            DataRow vIdProducto = Sql.getBuscar(vSQL);
            if (vIdProducto != null)
            {
                vSQL = "";
                vSQL = "insert into item_pedido";
                vSQL += " (idpedido,codigo,cantidad,neto,iva,montounitario,total)";
                vSQL += " values (" + xIdPedido + ",";
                vSQL += vIdProducto["idproducto"].ToString() + "," + cantidad;
                vSQL += "," + neto + "," + iva + "," + montounitario + "," + total + ")";
                Sql.ejecutar(vSQL);
                //Sql.ejecutar("update producto set stockactual=stockactual -" + vItem.Cantidad + " where idproducto=" + vItem.Articulo.Id);
            }
        }
        public static void EditarItem(long xIdPedido,string xCodigo, double neto, double iva, float total, float montounitario, long cantidad)
        {
            string vSQL = "";
            vSQL = "select idproducto from producto where codigobarra ='" + xCodigo + "'";
            DataRow vIdProducto = Sql.getBuscar(vSQL);
            if (vIdProducto != null)
            {
                vSQL = "select cantidad from item_pedido where codigo='" + vIdProducto["idproducto"].ToString() + "'";
                vSQL += " and idpedido=" + xIdPedido;
                DataRow vCantidad = Sql.getBuscar(vSQL);

                vSQL = "";
                vSQL = "update  item_pedido";
                vSQL += " set ";
                vSQL += " cantidad=" + cantidad;
                vSQL += ", neto=" + neto;
                vSQL += ", iva=" + iva;
                vSQL += ", montounitario=" + montounitario;
                vSQL += ", total=" + montounitario;
                vSQL +=" where idpedido=" + xIdPedido;
                vSQL += " and codigo='" + vIdProducto["idproducto"].ToString() + "'";

                Sql.ejecutar(vSQL);
                if(vCantidad!=null)
                {
                    long vCantidadAnterior = long.Parse(vCantidad["cantidad"].ToString());
                    if(vCantidadAnterior < cantidad)
                    {
                        Sql.ejecutar("update producto set stockactual=stockactual -" + cantidad + " where idproducto=" + vIdProducto["idproducto"].ToString());
                    }
                    else if(vCantidadAnterior > cantidad)
                    {
                        Sql.ejecutar("update producto set stockactual=stockactual +" + ( vCantidadAnterior - cantidad) + " where idproducto=" + vIdProducto["idproducto"].ToString());
                    }

                   
                }
            }
        }

        public static void Editar(Pedido xPedido)
        {
            String vSQL = "";
            vSQL = "update  pedido set";
            vSQL += " neto=" + xPedido.Neto ;
            vSQL += ",iva=" + xPedido.Iva;
            vSQL += ",montounitario=" + xPedido.MontoUnitario;
            vSQL += ",total=" + xPedido.Total;
            vSQL += " where idpedido=" + xPedido.Id;
            Sql.ejecutar(vSQL);
        }

        public static void Guardar(Pedido xFactura)
        {
            String vSQL = "";
            vSQL = "insert into pedido (fecha,icliente,neto,iva,montounitario,total)";
            vSQL += " values ('" + Utils.getFechaBase(xFactura.Fecha.ToString()) + "','";
            vSQL += xFactura.Cliente.Id + "',";
            vSQL += xFactura.Neto + "," + xFactura.Iva + "," + xFactura.MontoUnitario + "," + xFactura.Total;
            vSQL += ")";
            Sql.ejecutar(vSQL);
            DataRow vDatoID = Sql.getBuscar("select idpedido from pedido order by 1 desc limit 1");
            if (vDatoID != null)
            {
                foreach (ItemPedido vItem in xFactura.Items)
                {
                    vSQL = "";
                    vSQL = "insert into item_pedido";
                    vSQL += " (idpedido,codigo,cantidad,neto,iva,montounitario,total)";
                    vSQL += " values (" + vDatoID["idpedido"].ToString() + ",'" + vItem.Articulo.Id + "'," + vItem.Cantidad;
                    vSQL += "," + vItem.Neto + "," + vItem.Iva + "," + vItem.MontoUnitario + "," + vItem.Total + ")";
                    Console.WriteLine(vSQL);
                    Sql.ejecutar(vSQL);
                    Sql.ejecutar("update producto set stockactual=stockactual -" + vItem.Cantidad + " where idproducto=" + vItem.Articulo.Id);
                }
            }
        }

        public static Pedido ObtenerPorId(long xId)
        {
            Pedido vFactura = null;
            String vSQL = "";
            vSQL = "select idpedido,fecha,icliente,neto,iva,montounitario,total";
            vSQL += " from pedido";
            vSQL += " where idpedido=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vFactura = new Pedido();
                vFactura.Id = xId;
                vFactura.Fecha = DateTime.Parse(vDato["fecha"].ToString());
                vFactura.Cliente = DaoCliente.ObtenerCliente(long.Parse(vDato["icliente"].ToString()));
                vFactura.Neto = float.Parse(vDato["neto"].ToString());
                vFactura.Iva = float.Parse(vDato["iva"].ToString());
                vFactura.Total = float.Parse(vDato["total"].ToString());
                vFactura.MontoUnitario = float.Parse(vDato["montounitario"].ToString());
                vDato = null;
                vSQL = "";
                vSQL = "select  iditem,";
                vSQL += " codigo,cantidad,neto,iva,montounitario,total";
                vSQL += " from item_pedido";
                vSQL += " where idpedido=" + xId;
                DataTable vItems = Sql.getConsultar(vSQL);
                foreach (DataRow vItem in vItems.Rows)
                {
                    ItemPedido vItemF = new ItemPedido();
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
            vSQL = "select idpedido";
            vSQL += " from pedido";
            vSQL += " where icliente=" + xIdCliente;
            vSQL += " order by 1 desc limit 1";
            try
            {
                DataRow vDato = Sql.getBuscar(vSQL);
                if (vDato != null)
                    vResultado = long.Parse(vDato["idpedido"].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return vResultado;
        }
    }
}
