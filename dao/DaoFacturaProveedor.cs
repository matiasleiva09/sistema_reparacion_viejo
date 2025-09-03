using desagotes;
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
    public class DaoFacturaProveedor
    {

        public static DataTable ObtenerFacturas(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idfactura,f.idproveedor as idprov,fecha as \"Fecha\",tipofactura as \"Tipo\",";
            vSQL +=" nrofactura as \"Nro\",nombre as \"Prov\",neto as \"Neto\",iva as \"IVA\",total as \"Total\"";
            vSQL += " from factura_proveedor f";
            vSQL += " inner join proveedor p on p.idproveedor=f.idproveedor";
            vSQL += " where fechabaja is null";
            if(xFiltro!=null && xFiltro.Trim()!="")
            {
                vSQL += " and (nrofactura like '%"+xFiltro.Trim() +"%'";
                vSQL += " or tipoFactura='" + xFiltro.Trim() + "'";
                vSQL += " or nombre like '%"+ xFiltro.Trim() +"%'";
                vSQL += ")";
            }
            
            vSQL+=" order by fecha desc";
            return Sql.getConsultar(vSQL);
        }

        public static void Guardar(FacturaProveedor xFactura)
        {
            String vSQL = "";
            vSQL = "insert into factura_proveedor (fecha,tipofactura,nrofactura,idproveedor,neto,iva,total)";
            vSQL += " values ('" + Utils.getFechaBase(xFactura.Fecha.ToString()) + "','";
            vSQL += xFactura.TipoFactura + "','" + xFactura.NroFactura + "',";
            vSQL += xFactura.Proveedor.Id + "," + xFactura.Neto + "," + xFactura.IVA + "," + xFactura.Total;
            vSQL += ")";
            Sql.ejecutar(vSQL);
            DataRow vDatoID = Sql.getBuscar("select idfactura from factura_proveedor order by 1 desc limit 1");
            if (vDatoID != null)
            {
                foreach (ItemFactura vItem in xFactura.Items)
                {
                    vSQL = "";
                    vSQL = "insert into itemfactura";
                    vSQL += " (idfactura,idarticulo,cantidad,neto,iva,total)";
                    vSQL += " values (" + vDatoID["idfactura"].ToString() + "," + vItem.Articulo.Id + "," + vItem.Cantidad;
                    vSQL += "," + vItem.Neto + "," + vItem.IVA + "," + vItem.Total + ")";
                    Sql.ejecutar(vSQL);
                    Sql.ejecutar("update producto set stockactual=stockactual +" + vItem.Cantidad + " where idproducto=" + vItem.Articulo.Id);
                }
            }
        }

        public static FacturaProveedor ObtenerPorId(long xId)
        {
            FacturaProveedor vFactura = null;
            String vSQL = "";
            vSQL = "select idfactura,fecha,tipofactura,nrofactura,idproveedor,neto,iva,total";
            vSQL += " from factura_proveedor";
            vSQL += " where idfactura=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if(vDato!=null)
            {
                vFactura = new FacturaProveedor();
                vFactura.Id = xId;
                vFactura.Fecha = DateTime.Parse(vDato["fecha"].ToString());
                vFactura.TipoFactura = vDato["tipofactura"].ToString();
                vFactura.NroFactura = vDato["nrofactura"].ToString();
                vFactura.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(vDato["idproveedor"].ToString()));
                vFactura.Neto = float.Parse(vDato["neto"].ToString());
                vFactura.IVA = float.Parse(vDato["iva"].ToString());
                vFactura.Total = float.Parse(vDato["total"].ToString());
                vDato = null;
                vSQL = "";
                vSQL = "select  iditemfactura,";
                vSQL += " idarticulo,cantidad,neto,iva,total";
                vSQL += " from itemfactura";
                vSQL += " where idfactura=" + xId;
                DataTable vItems = Sql.getConsultar(vSQL);
                foreach(DataRow vItem in vItems.Rows)
                {
                    ItemFactura vItemF = new ItemFactura();
                    vItemF.Id = long.Parse(vItem["iditemfactura"].ToString());
                    vItemF.IVA = float.Parse(vItem["iva"].ToString());
                    vItemF.Neto = float.Parse(vItem["neto"].ToString());
                    vItemF.Total = float.Parse(vItem["total"].ToString());
                    vItemF.Articulo = DaoArticulo.ObtenerPorId(long.Parse(vItem["idarticulo"].ToString()));
                    vFactura.Items.Add(vItemF);
                    vItemF = null;
                }
            }
            return vFactura;
        }

        public void DarDeBaja(long xId)
        {
            String vSQL = "";
            vSQL = "update factura_proveedor set fechabaja='current_date'";
            vSQL += " where idfactura=" + xId;
            Sql.ejecutar(vSQL);
        }
    }
}
