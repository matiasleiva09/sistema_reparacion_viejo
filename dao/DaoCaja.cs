using desagotes;
using desagotes.sql;
using Org.BouncyCastle.Asn1.Mozilla;
using reparaciones2.ob.caja;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoCaja
    {
        
        public static void Guardar(Caja xCaja)
        {
            String vSQL = "";
            vSQL = "insert into caja (capuesto,causuario,cafechaapertura,casaldoanterior)";
            vSQL += " values (";
            vSQL += xCaja.Puesto + ",'" + xCaja.Usuario + "','" + Utils.getFechaSinHoraBase(xCaja.FechaApertura.ToString());
            vSQL += "'," + xCaja.MontoAnteriorEfectivo + ")";
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static void Editar(Caja xCaja)
        {
            string vSQL = "";
            vSQL = "update caja set";
            vSQL += " cafechaapertura='" + xCaja.FechaApertura + "',";
            vSQL += " cafechacierre='" + xCaja.FechaCierre + "'";
            vSQL += " where caidcaja=" + xCaja.Id;

        }

       
        public static double GetSaldoInicial(long xIdCaja)
        {
            double vRes = 0.00;
            double vIngresos = DaoRecibo.ObtenerMontoPorCaja(xIdCaja);
            vRes = vIngresos;
            return vRes;
        }

        public static int[] CajasSinAbrir()
        {
            int[] vCajas;

            string vSQL = "select distinct capuesto from caja where cafechacierre is null order by capuesto asc";
            DataTable vQuery = Sql.getConsultar(vSQL);
            int cantidadCajas = int.Parse(DaoParametrosDatos.getParametro("CANTIDADCAJAS"));
            if (vQuery != null && vQuery.Rows.Count > 0)
            {
                int cantidadAbiertas = vQuery.Rows.Count;
                if (cantidadAbiertas == cantidadCajas)
                    vCajas = new int[0];
                else if (cantidadAbiertas < cantidadCajas)
                {
                    vCajas = new int[(cantidadCajas - cantidadAbiertas)];
                    int j=0,indFinal = 0;
                    bool vEncontrado = false;
                    int vPuesto = 0;
                    for (int i = 1; i <= cantidadCajas; i++)
                    {
                        while(j<vQuery.Rows.Count && !vEncontrado)
                        {
                            vPuesto = int.Parse(vQuery.Rows[j]["capuesto"].ToString());
                            if (vPuesto == i)
                            {
                                vCajas[indFinal] = i;
                                indFinal++;
                                vEncontrado = true;
                            }
                            else
                                j++;
                        }
                        vEncontrado = false;
                        j = 0;
                    }
                }
                else
                    vCajas = new int[0];

            }
            else
            {
                vCajas = new int[cantidadCajas];
                for(int i=1;i<=cantidadCajas;i++)
                {
                    vCajas[(i - 1)] = i;
                }
            }
               
            return vCajas;
        }

        public static DataTable Consultar()
        {
            DataTable vRes = null;
            return vRes;
        }

        public static DataRow Encontrar()
        {
            DataRow vRes = null;
            return vRes;
        }
        public static DataTable ConsultaIngresoFiltro(string xFiltro)
        {
            string vSQL = "select rb.fecha,nrorecibo,rep.codigo as reparacion,";
            vSQL += "scidservice as service,cl.nombre,rb.concepto,mediopago,";
            vSQL += " rb.monto";
            vSQL += " from reciboingreso as rb";
            vSQL += " inner join cliente as cl on cl.idcliente = rb.idcliente";
            vSQL += " left join reparaciones as rep on rb.idreparacion = rep.idreparacion";
            vSQL += " left join servicecalle as ser on scidservice = rb.idservice";
            vSQL += " where nrorecibo like '%" + xFiltro +"%'";
            vSQL += " or rep.codigo like '%"+xFiltro+"%'";
            vSQL += " or service like '%"+xFiltro+"%'";
            vSQL += " or concepto like '%"+ xFiltro +"%'";
            vSQL += " or cl.nombre like '%"+xFiltro +"%'";
            vSQL += " order by rb.fecha desc limit 500";
            return Sql.getConsultar(vSQL);
        }
        public static DataTable ConsultarIngresos(bool xTodasFechas,string xFechaDesde,
            string xFechaHasta, string xNroReparacion,string xNroService,string xIdCliente,string xMedioPago)
        {
            string vSQL = "select rb.fecha,nrorecibo,rep.codigo as reparacion,";
            vSQL += "scidservice as service,cl.nombre,rb.concepto,mediopago,";
            vSQL += " rb.monto";
            vSQL += " from reciboingreso as rb";
            vSQL += " inner join cliente as cl on cl.idcliente = rb.idcliente";
            vSQL += " left join reparaciones as rep on rb.idreparacion = rep.idreparacion";
            vSQL += " left join servicecalle as ser on scidservice = rb.idservice";
            if(!xTodasFechas)
            {
                vSQL += " where (rb.fecha between '" + xFechaDesde + " 00:00:00' and '" +xFechaHasta+" 23:59:59')";

                if(xNroReparacion!="")
                    vSQL += " and rep.codigo='" + xNroReparacion + "'";
                if (xNroService != "")
                    vSQL += " and service =" + xNroService;
                if (xIdCliente != "")
                    vSQL += " and  cl.idcliente=" + xIdCliente;
                if (xMedioPago != "")
                    vSQL += " and mediopago='" + xMedioPago + "'";
            }
            else
            {
                bool vWhere = true;
                if (xNroReparacion != "")
                {
                    if(vWhere)
                    {
                        vWhere = false;
                        vSQL += " where rep.codigo='" + xNroReparacion + "'";
                    }
                    else
                        vSQL += " and rep.codigo='" + xNroReparacion + "'";

                }
                if (xNroService != "")
                {
                    if (vWhere)
                    {
                        vWhere = false;
                        vSQL += " where service =" + xNroService;
                    }
                    else
                        vSQL += " and service =" + xNroService;

                }
                if (xIdCliente != "")
                {
                    if (vWhere)
                    {
                        vWhere = false;
                        vSQL += " where cl.idcliente =" + xIdCliente;
                    }
                    else
                        vSQL += " and cl.idcliente =" + xIdCliente;

                }

                if (xMedioPago != "")
                {
                    if (vWhere)
                    {
                        vWhere = false;
                        vSQL += " where mediopago ='" + xMedioPago + "'";
                    }
                    else
                        vSQL += " and mediopago ='" + xMedioPago +"'";

                }

            }
            vSQL += " order by rb.fecha desc";
            return Sql.getConsultar(vSQL);
        }

        public static Caja ObtenerCajaAbiertaDelDia(string xUsuario)
        {
            Caja vCaja = null;
            string vSQL = "select caidcaja,capuesto,causuario,";
            vSQL +="cafechaapertura,cafechacierre,casaldoanterior";
            vSQL += " from caja";
            vSQL += " where causuario='" + xUsuario + "'";
            DateTime vFechaActual = DateTime.Now;
            string vFechaSinHora = Utils.getFechaSinHoraBase(vFechaActual.ToString());
            vSQL += " and (cafechaapertura between '" + vFechaSinHora + " 00:00:00' and ";
            vSQL += " '" + vFechaSinHora + " 23:59:59') and cafechacierre is null";
            Console.WriteLine(vSQL);
            DataRow vQuery = Sql.getBuscar(vSQL);
            if(vQuery!=null)
            {
                vCaja = new Caja();
                vCaja.Id = long.Parse(vQuery["caidcaja"].ToString());
               // vCaja.FechaCierre = DateTime.Parse(vQuery["cafechacierre"].ToString());
                vCaja.FechaApertura = DateTime.Parse(vQuery["cafechaapertura"].ToString());
                vCaja.MontoAnteriorEfectivo = double.Parse(vQuery["casaldoanterior"].ToString());
                vCaja.Usuario =vQuery["causuario"].ToString();
                vCaja.Puesto = int.Parse(vQuery["capuesto"].ToString());
            }
            vQuery = null;
            return vCaja;
        }
    }
}
