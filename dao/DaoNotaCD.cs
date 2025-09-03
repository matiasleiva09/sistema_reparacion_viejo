using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoNotaCD
    {
        public static void GuardarC(string xFecha,long xIdCliente,float xMonto,string xDescripcion,string xNro)
        {
            
            string vSQL = "insert into notacredito (ccfecha,ccidcliente,monto,ccdescripcion,ccnro)";
            vSQL += " values ('" + xFecha + "'," + xIdCliente + "," + xMonto + ",'" + xDescripcion + "','";
            vSQL += xNro +  "')";
            Sql.ejecutar(vSQL);
        }

        public static void GuardarD(string xFecha, long xIdCliente, float xMonto, string xDescripcion,string xNro)
        {

            string vSQL = "insert into notadebito (cdfecha,cdidcliente,cdmonto,cddescripcion,cdnro)";
            vSQL += " values ('" + xFecha + "'," + xIdCliente + "," + xMonto + ",'" + xDescripcion + "','";
            vSQL += xNro + "')";
            Sql.ejecutar(vSQL);
        }

    }
}
