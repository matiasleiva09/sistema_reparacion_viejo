using desagotes;
using desagotes.sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.caja
{
    public partial class FrmConsultarEgresos : Form
    {
        public FrmConsultarEgresos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            buscar("");
        }

        private void buscar(string xFiltro)
        {
            bool vWhere = true;
            string vSQL = "select idegreso as nro,fecha, concepto, monto from pagoegreso";
            if (!checkTodasIngreso.Checked)
            {
                vSQL += " where fecha between '"+Utils.getFechaYHoraBase(dtpFechaDesdeIngreso.Text + " 00:00:00")+"'";
                vSQL += " and '"+ Utils.getFechaYHoraBase(dtpFechaIngresoHasta.Text + " 23:59:59") + "'";
                vWhere = false;
                Sql.ejecutar(vSQL);
            }
            if(xFiltro.Trim()!="")
            {
                if(vWhere)
                {
                    vSQL = " where concepto like '%" + xFiltro.Trim().ToUpper() + "%'";
                    vWhere = false;
                }
                else
                {
                    vSQL = " and concepto like '%" + xFiltro.Trim().ToUpper() + "%'";
                }
            }
            DataTable vRes = Sql.getConsultar(vSQL);
            if (vRes != null)
                dwgIngresos.DataSource = vRes;
           
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarEgresos_Load(object sender, EventArgs e)
        {
            dtpFechaIngresoHasta.Value = DateTime.Now;
            dtpFechaDesdeIngreso.Value = DateTime.Now;
            dtpFechaDesdeIngreso.Value = dtpFechaDesdeIngreso.Value.AddDays(-30);
            dtpFechaIngresoHasta.Value = dtpFechaIngresoHasta.Value.AddDays(1);
            buscar("");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            buscar(txtfiltro.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Utils.ExportarDataGridViewExcel(dwgIngresos, "Consulta de egresos");
        }
    }
}
