using desagotes;
using desagotes.sql;
using reparaciones2.ob;
using reparaciones2.ob.service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DAOService
    {
        public static void Guardar(Service xService)
        {
            String vSQL = "";
            vSQL = "insert into servicecalle";
            vSQL += " (scidcliente,scprioridad,scfechatomado,scfechaprometida,scfecharealizada,";
            vSQL += "sctomadopor,scasignadoa,scmonto,scsenia,sccalle,scnro,scpiso,scdpto,";
            vSQL += "sclocalidad,scprovincia,sccoordenada,sccp,scestado,scproblema,scsolucion,scobservaciondom)";
            vSQL += " values (";
            vSQL += xService.Cliente.Id + ",'" + xService.Prioridad + "','" + Utils.getFechaBase(xService.FechaTomado) + "','";
            vSQL += Utils.getFechaBase(xService.FechaPrometida) + "',null,'" + xService.TomadoPor + "','" + xService.AsignadoA + "',";
            vSQL += xService.Monto + "," + xService.Senia + ",'" + xService.Calle + "','" + xService.Nro + "','";
            vSQL += xService.Piso + "','" + xService.Dpto + "','" + xService.Localidad + "','" + xService.Provincia + "','";
            vSQL += xService.Coordenadas + "','" + xService.Cp + "','" + xService.Estado + "','" + xService.Problema + "','" + xService.Solucion + "','";
            vSQL += xService.ObservacionesDomicilio + "')";
            Sql.ejecutar(vSQL);
        }


        public static long ObtenerId(Service xService)
        {
            String vSQL = "select scidservice from servicecalle where ";
            vSQL += " scprioridad='" + xService.Prioridad + "' and ";
            vSQL += "scfechatomado='" + Utils.getFechaBase(xService.FechaPrometida) + "' and ";
            vSQL += "scfechaprometida='" + Utils.getFechaBase(xService.FechaPrometida) + "' and ";
           // vSQL += "scfecharealizada='" + Utils.getFechaBase(xService.FechaRealizada) + "' and ";
            vSQL += "scasignadoa='" + xService.AsignadoA + "' and ";
            vSQL += "sctomadopor='" + xService.TomadoPor + "' and ";
            vSQL += "scidcliente=" + xService.Cliente.Id + " and ";
            vSQL += "scmonto=" + xService.Monto + " and ";
            vSQL += "scsenia=" + xService.Senia + " and ";
            vSQL += "sccalle='" + xService.Calle + "' and ";
            vSQL += "scnro='" + xService.Nro + "' and ";
            vSQL += "scpiso='" + xService.Piso + "' and ";
            vSQL += "scestado='" + xService.Estado + "' and ";
            vSQL += "scproblema='" + xService.Problema + "' and ";
            vSQL += "scsolucion='" + xService.Solucion + "' and ";
            vSQL += "scobservaciondom='" + xService.ObservacionesDomicilio + "' and ";
            vSQL += "scdpto='" + xService.Dpto + "' and ";
            vSQL += "sclocalidad='" + xService.Localidad + "' and ";
            vSQL += "scprovincia='" + xService.Provincia + "' and ";
            vSQL += "sccoordenada='" + xService.Coordenadas + "' and ";
            vSQL += "sccp='" + xService.Cp + "'";
            Console.WriteLine(vSQL);
            DataRow vDato= Sql.getBuscar(vSQL);
            if (vDato == null)
                return 0;
            else
                return long.Parse(vDato["scidservice"].ToString());
        }

        public static void Editar(Service xService)
        {
            String vSQL = "";
            vSQL = "update servicecalle";
            vSQL += " set";
            vSQL += " scprioridad='" + xService.Prioridad + "',";
          //  vSQL += "scfechaprometida='" + xService.FechaPrometida + "',";
            vSQL += "scfecharealizada='" + xService.FechaRealizada + "',";
            vSQL += "scasignadoa='" + xService.TomadoPor + "',";
            vSQL += "scmonto=" + xService.Monto + ",";
            vSQL += "scsenia=" + xService.Senia + ",";
            vSQL += "sccalle='" + xService.Calle + "',";
            vSQL += "scnro='" + xService.Nro + "',";
            vSQL += "scpiso='" + xService.Piso + "',";
            vSQL += "scestado='" + xService.Estado + "',";
            vSQL += "scproblema='" + xService.Problema + "',";
            vSQL += "scsolucion='" + xService.Solucion + "',";
            vSQL += "scobservaciondom='" + xService.ObservacionesDomicilio + "',";
            vSQL += "scdpto='" + xService.Dpto + "',";
            vSQL += "sclocalidad='" + xService.Localidad + "',";
            vSQL += "scprovincia='" + xService.Provincia + "',";
            vSQL += "sccoordenada='" + xService.Coordenadas + "',";
            vSQL += "sccp='" + xService.Cp + "'";
            vSQL += " where scidservice=" + xService.Id;
            Sql.ejecutar(vSQL);
        }

        public static DataTable ObtenerServiceDeCliente(long xIdCliente)
        {
            DataTable vRes = null;
            String vSQL = "";
            vSQL = "select scidservice as \"Nro Service\",scestado as estado,scprioridad as prioridad,";
            vSQL += "scfechatomado as \"fecha de Tomado\",scfechaprometida as \"fecha de Prometida\",";
            vSQL += " cli.nombre as \"Cliente\",";
            vSQL += " 'Tel.: ' || cli.telefono || ', Cel: ' || cli.celular as  \"Contacto\", ";
            vSQL += " scproblema as \"Problema\" ,";
            vSQL += " scsenia as \"Seña\", scmonto as \"Monto\"";
            vSQL += " from servicecalle sc";
            vSQL += " inner join cliente cli on sc.scidcliente=cli.idcliente";
            vSQL += " where sc.scidcliente=" + xIdCliente;
            vSQL += " order by scidservice desc";
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }

        public static DataTable ObtenerServices(String xNroService,DateTime xFechaDesde,DateTime xFechaHasta,String xEstado,
            long xIdCliente)
        {
            DataTable vRes = null;
            String vSQL = "";
            vSQL = "select scidservice as \"Nro Service\",scidcliente as idcliente,scestado as estado,scprioridad as prioridad,";
            vSQL += "scfechatomado as \"fecha de Tomado\",scfechaprometida as \"fecha de Prometida\",";
            vSQL += " cli.nombre as \"Cliente\",";
            vSQL += " 'Tel.: ' || cli.telefono || ', Cel: ' || cli.celular as  \"Contacto\", ";
            vSQL += " scproblema as \"Problema\" ,";
            vSQL += " scsenia as \"Seña\", scmonto as \"Monto\"";
            vSQL += " from servicecalle sc";
            vSQL += " inner join cliente cli on sc.scidcliente=cli.idcliente";

            if (xNroService != "")
                vSQL += " where scidservice=" + xNroService;
            else
            {
                vSQL += " where (scfechatomado between '" + xFechaDesde + "' and '" + xFechaHasta + "')";
                if (xIdCliente != 0)
                    vSQL += " and scidcliente=" + xIdCliente;
                if (xEstado != "")
                   vSQL += " and scestado='" + xEstado + "'";
            }
            vSQL += " order by scidservice desc";
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }

        public static DataTable ObtenerCallesService(long xIdCliente)
        {
            DataTable vRes = null;
            string vSQL = "";
            vSQL = "select distinct 'Calle: ' || sccalle || ', ' || 'Nro: ' || scnro || ', Piso: ' ||scpiso || ";
            vSQL += "'Dpto: ' ||  scdpto || ', Localidad: ' || sclocalidad || ', Provincia: ' || scprovincia";
            vSQL += " from servicecalle where scidcliente=" + xIdCliente;
            vRes = Sql.getConsultar(vSQL);
            return vRes;
        }

        public static Service ObtenerService(long xIdService)
        {
            Service vService = new Service();
            String vSQL = "select ";
            vSQL += "scidservice,scidcliente,scprioridad,scfechatomado,scfechaprometida,scfecharealizada,";
            vSQL += "sctomadopor,scasignadoa,scmonto,scsenia,sccalle,scnro,scpiso,scdpto,";
            vSQL += "sclocalidad,scprovincia,sccoordenada,sccp,scestado,scproblema,scsolucion,scobservaciondom";
            vSQL += " from servicecalle";
            vSQL += " where scidservice=" + xIdService;
            Console.WriteLine(vSQL);
            DataRow vDato = Sql.getBuscar(vSQL);
            if(vDato!=null)
            {
                vService.Id = long.Parse(vDato["scidservice"].ToString());
                vService.Cliente = DaoCliente.ObtenerCliente(long.Parse(vDato["scidcliente"].ToString()));
                vService.Prioridad = vDato["scprioridad"].ToString();
                vService.FechaTomado = DateTime.Parse(vDato["scfechatomado"].ToString());
                vService.FechaPrometida = DateTime.Parse(vDato["scfechaprometida"].ToString());
                if (vDato["scfecharealizada"].ToString() != "")
                    vService.FechaRealizada = DateTime.Parse(vDato["scfecharealizada"].ToString());
                else
                    vService.FechaRealizada = DateTime.Now;
                vService.TomadoPor = vDato["sctomadopor"].ToString();
                vService.AsignadoA = vDato["scasignadoa"].ToString();
                vService.Monto = float.Parse(vDato["scmonto"].ToString());
                vService.Senia = float.Parse(vDato["scsenia"].ToString());
                vService.Calle = vDato["sccalle"].ToString();
                vService.Nro = vDato["scnro"].ToString();
                vService.Piso = vDato["scpiso"].ToString();
                vService.Dpto = vDato["scdpto"].ToString();
                vService.Localidad = vDato["sclocalidad"].ToString();
                vService.Provincia = vDato["scprovincia"].ToString();
                vService.Coordenadas = vDato["sccoordenada"].ToString();
                vService.Cp = vDato["sccp"].ToString();
                vService.Estado = vDato["scestado"].ToString();
                vService.Problema = vDato["scproblema"].ToString();
                vService.Solucion = vDato["scsolucion"].ToString();
                vService.ObservacionesDomicilio = vDato["scobservaciondom"].ToString();
            }
            return vService;
        }

        public static void ActualizarSeña(float xMonto, long xId)
        {
            string vSQL = "update servicecalle set scsenia = scsenia + " +xMonto;
            vSQL += " where scidservice=" + xId;
            try
            {
                Sql.ejecutar(vSQL);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void GuardarEmailPorOrden(string xNroOrden, string xEmail)
        {
            String vSQL = "update cliente";
            vSQL += " set mail='" + xEmail + "'";
            vSQL += " where idcliente =";
            vSQL += " (select distinct scidcliente from servicecalle where scidservice = " + xEmail + ")";
            try
            {
                Sql.ejecutar(vSQL);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
