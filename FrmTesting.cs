using reparaciones2.dao;
using reparaciones2.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmTesting : Form
    {
        public FrmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReciboPDF vReporte = new ReciboPDF();
            DataRow vRes = DaoReparaciones.getReparacion(9302);
            //vReporte.Fecha = desagotes.Utils.getFechaSinHora(selectedRow.Cells["Fecha Entrada"].Value.ToString());
            vReporte.NroOrden = vRes["Codigo"].ToString();
            vReporte.Cliente = vRes["Nro Cliente"].ToString() + "-" + vRes["Cliente"].ToString();
            vReporte.Monto = 200.00;
            vReporte.MedioDePago = "EFECTIVO";
            vReporte.Concepto = "REPARACION DE EQUIPO INFORMATICO";
            vReporte.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
            vReporte.Horario = DaoParametrosDatos.getParametro("HORARIO");
            vReporte.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
            vReporte.Calle = DaoParametrosDatos.getParametro("DIRECCION");
            System.Diagnostics.Process.Start(vReporte.crearPdf());
        }
    }
}
