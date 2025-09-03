using desagotes.sql;
using reparaciones2.ob.reparaciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoItemService
    {
        public static void Guardar(ItemInsumoTarifa xItem)
        {
            string vSQL = "";
            vSQL = "insert into item_service ";
            vSQL += "(idservice,idtarifa,idinsumo,cantidad,neto,iva,monto)";
            vSQL += " values (";
            vSQL += xItem.Service.Id + ",";
            vSQL += xItem.IdTarifaParaBase() + ",";
            vSQL += xItem.IdArticuloParaBase() + ",";
            vSQL += xItem.Cantidad + ",";
            vSQL += xItem.Neto + ",";
            vSQL += xItem.Iva + ",";
            vSQL += xItem.Total + ")";
            Sql.ejecutar(vSQL);
        }

        public static long ObtenerId(ItemInsumoTarifa xItem)
        {
            long vRes = 0;
            string vSQL = "";
            vSQL += "select id from item_service where ";
            if(xItem.IdTarifaParaBase()!="null")
               vSQL += " idtarifa=" + xItem.IdTarifaParaBase() + " and";
            else
                vSQL += " idtarifa is null and";
            if (xItem.IdArticuloParaBase() != "null")
                vSQL += " idinsumo=" + xItem.IdArticuloParaBase() + " and";
            else
                vSQL += " idinsumo is null and";
            vSQL += " idservice=" + xItem.Service.Id + " and";
            vSQL += " cantidad=" + xItem.Cantidad + " and";
            vSQL += " neto=" + xItem.Neto + " and";
            vSQL += " iva=" + xItem.Iva + " and";
            vSQL += " monto=" + xItem.Total;

            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato!=null)
                vRes = long.Parse(vDato["id"].ToString());
            return vRes;
        }

       
        public static void Editar(ItemInsumoTarifa xItem)
        {
            string vSQL = "";
            vSQL = "update item_service";
            vSQL += " set";
            vSQL += " idtarifa=" + xItem.IdTarifaParaBase() + ",";
            vSQL += " idinsumo=" + xItem.IdArticuloParaBase() + ",";
            vSQL +=  "idservice=" + xItem.Service.Id + ",";
            vSQL += " cantidad=" + xItem.Cantidad + ",";
            vSQL += " neto=" + xItem.Neto + ",";
            vSQL += " iva=" + xItem.Iva + ",";
            vSQL += " monto=" + xItem.Total;
            vSQL += " where ";
            vSQL += " id=" + xItem.Id;
            Sql.ejecutar(vSQL);
        }

        public static void Borrar(ItemInsumoTarifa xItem)
        {
            string vSQL = "";
            vSQL = "delete from item_service";
            vSQL += " where id=" + xItem.Id;
            Sql.ejecutar(vSQL);
        }
        public static void Borrar(long xId)
        {
            string vSQL = "";
            vSQL = "delete from item_service";
            vSQL += " where id=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static DataTable ObtenerItemDeReparacion(long xIdReparacion)
        {
            DataTable vRes = null;
            string vSQL = "";
            vSQL = "select id as \"Id\",cantidad as \"Cantidad\",";
            vSQL +=" ir.idtarifa as \"Tarifa\",ir.idinsumo as \"Insumo\",";
            vSQL += "case when ir.idtarifa is not null then";
            vSQL += " t.descripcion";
            vSQL += " else";
            vSQL += "    nombre";
            vSQL += " end as \"Descripcion\",";
           // vSQL += " idrecibo as \"Recibo\",";
            //vSQL += " nrorecibo as \"Nro Recibo\",";
            vSQL += " ir.monto as \"Monto\"";
            vSQL += " from item_service ir";
         //   vSQL += " left join reciboingreso ri on ri.idreciboingreso = ir.idrecibo";
            vSQL += " left join tarifa t on t.idtarifa = ir.idtarifa";
            vSQL +=" left join producto p on p.idproducto = ir.idinsumo ";
            vSQL += " where ir.idservice=" + xIdReparacion;
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }

        public static DataTable ObtenerTarifaInsumo()
        {
            DataTable vRes = null;
            string vSQL = "";
            vSQL = "select * from(";
            vSQL += " select null as idp,idtarifa as idt,descripcion as descripcion,";
            vSQL += " monto as monto,'TARIFA' as tipo ";
            vSQL += " from tarifa where servicio = 'SERVICE'";
            vSQL += " union";
            vSQL += " select idproducto as idp,null as idt,";
            vSQL += " nombre as descripcion,monto as monto,'PRODUCTO' as producto";
            vSQL +=" from producto)";
            vSQL += " as mix order by tipo desc, descripcion asc;";
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }
    }
}
