using reparaciones2.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace reparaciones2
{
    public partial class FrmReparacionPorAnio : Form
    {
        public FrmReparacionPorAnio()
        {
            InitializeComponent();
        }

        private void CargarCombos()
        {
            int anioActual = DateTime.Now.Year;
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cmbAnioDesde.Items.Add(i);
                cmbAnioHasta.Items.Add(i);
            }
            cmbAnioDesde.SelectedItem = anioActual - 1 +"";
            cmbAnioHasta.SelectedItem = anioActual +"";
        }

        private void FrmReparacionPorAnio_Load(object sender, EventArgs e)
        {
            CargarCombos();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable vResultado = DAOReportes.getReporteCostoRepPorAni(
                cmbAnioDesde.SelectedItem.ToString(),
                cmbAnioHasta.SelectedItem.ToString());
            dgwResultado.DataSource = vResultado;
            chartResultado.DataSource = vResultado;
            if (cmbAnioDesde.SelectedItem.ToString() !=cmbAnioHasta.SelectedItem.ToString())
            {
                chartResultado.Series.Add(cmbAnioDesde.SelectedItem.ToString());
                chartResultado.Series.Add(cmbAnioHasta.SelectedItem.ToString());
            }
        }
    }
}
