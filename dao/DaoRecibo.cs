using desagotes;
using desagotes.sql;
using reparaciones2.ob.caja;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoRecibo
    {
        public static long GuardarRecibo(String xIdCliente,
            String xMonto, String xConcepto, String xIdReparacion,String xIdService,String xMedioPago,
            Efectivo xEfectivo,Tarjeta xTarjeta,Cheque xCheque,DepositoBancario xDeposito)
        {
            long vId = 0;
            String vSQL = "insert into reciboingreso";
            if(xIdReparacion!="")
            {
                vSQL += " (idcliente,monto,idreparacion,concepto,fecha,mediopago)";
                vSQL += " values (" + xIdCliente + "," + xMonto + "," + xIdReparacion;
                vSQL += ",'" + xConcepto + "',current_date,'" + xMedioPago + "')";
            }
            else if(xIdService!="")
            {
                vSQL += " (idcliente,monto,idservice,concepto,fecha,mediopago)";
                vSQL += " values (" + xIdCliente + "," + xMonto + "," + xIdService;
                vSQL += ",'" + xConcepto + "',current_date,'" + xMedioPago + "')";
            }
            else
            {
                vSQL += " (idcliente,monto,concepto,fecha,mediopago)";
                vSQL += " values (" + xIdCliente + "," + xMonto;
                vSQL += ",'" + xConcepto + "',current_date,'" + xMedioPago + "')";
            }
           
            Sql.ejecutar(vSQL);
            vSQL = "select idreciboingreso from reciboingreso where";
            vSQL += "  idcliente=" + xIdCliente;
            vSQL += " and monto=" + xMonto;
            if (xIdService != "")
                vSQL += " and idservice=" + xIdService;
          /*  else
                vSQL += " and idservice is null";*/
            if (xIdReparacion != "")
                vSQL += " and idreparacion =" + xIdReparacion;
          /*  else
                vSQL += " and idreparacion is null";*/
            vSQL += " and concepto='" + xConcepto + "'";
            DataRow idrecibo=Sql.getBuscar(vSQL);
            vId = long.Parse(idrecibo["idreciboingreso"].ToString());
            vSQL = "update reciboingreso set nrorecibo='" + UtilsPdf.agregarCerosIzquierda(
                long.Parse(idrecibo["idreciboingreso"].ToString()), 8) + "' where idreciboingreso=" + idrecibo["idreciboingreso"].ToString();
            Sql.ejecutar(vSQL);
            if(idrecibo!=null)
            {
                if(xEfectivo!=null)
                {
                    vSQL = "insert into efectivo (efidingreso,efmonto)";
                    vSQL += " values (" + idrecibo["idreciboingreso"] + "," + xEfectivo.Monto +")";
                    Sql.ejecutar(vSQL);
                }
                if(xCheque!=null)
                {
                    vSQL = "insert into cheque (chidingreso,chbanco,chnrocheque,chefechavenc,chemonto)";
                    vSQL += " values (" + idrecibo["idreciboingreso"] + ",'" + xCheque.Banco;
                    vSQL += "','" + xCheque.Nro + "','";
                    vSQL += xCheque.FechaVencimiento.Year + "-" + xCheque.FechaVencimiento.Month + "-" +
                        xCheque.FechaVencimiento.Day + "',";
                    vSQL+=+ xCheque.Monto + ")";
                    Sql.ejecutar(vSQL);
                }
                if(xTarjeta!=null)
                {
                    vSQL = "insert into tarjeta (taidingreso,taempresa,tanro,tatipo,tamonto)";
                    vSQL += " values (";
                    vSQL += idrecibo["idreciboingreso"] + ",'";
                    vSQL += xTarjeta.Empresa + "','";
                    vSQL += xTarjeta.Nro + "','";
                    vSQL += xTarjeta.Tipo + "',";
                    vSQL +=xTarjeta.Monto + ")";
                    Sql.ejecutar(vSQL);
                }
                if(xDeposito!=null)
                {
                    vSQL = "insert into deposito_bancario (dpidingreso,dpbanco,dpcomprobante,dpcbu,dpmonto)";
                    vSQL += " values (";
                    vSQL += idrecibo["idreciboingreso"] + ",'";
                    vSQL += xDeposito.Banco + "','";
                    vSQL += xDeposito.Comprobante + "','";
                    vSQL += xDeposito.NroDeCuenta + "',";
                    vSQL += xDeposito.Monto + ")";
                    Sql.ejecutar(vSQL);
                }
            }
            return vId;
        }

        public static double ObtenerMontoPorCaja(long xIdCaja)
        {
            double vRes = 0.00;
            string vSQL = "select sum(monto) as monto from reciboingreso";
            vSQL += " where idcaja=" + xIdCaja;
            DataRow vQuery = Sql.getBuscar(vSQL);
            if (vQuery != null && vQuery["monto"].ToString()!="")
                vRes = double.Parse(vQuery["monto"].ToString());
            else
                vRes = 0.00;
            return vRes;
        }



      /* public static Recibo ObtenerRecibo(string xId)
        {
            Recibo vRecibo = null;
            string vSQL="select idreciboingreso from reciboingreso where ";
            return vRecibo;
        }*/
    }
}
