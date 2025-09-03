using desagotes;
using desagotes.sql;
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

namespace reparaciones2.caja
{
    public partial class ConsultarCobros : Form
    {
        public ConsultarCobros()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarCobros_Load(object sender, EventArgs e)
        {
            PorDefectoGrilla();
        }

        private void cargarGrilla()
        {
            string vMedioPago = "";
            if (cmbMedioPago.SelectedItem != null)
                vMedioPago = cmbMedioPago.SelectedItem.ToString();
            dwgIngresos.DataSource = DaoCaja.ConsultarIngresos(checkTodasIngreso.Checked,
                Utils.getFechaSinHoraBase(dtpFechaDesdeIngreso.Text), Utils.getFechaSinHoraBase(dtpFechaIngresoHasta.Text),
                txtreparacion.Text,txtservice.Text,txtidcliente.Text,vMedioPago);
            dwgIngresos.AutoResizeColumns();
            dwgIngresos.AllowUserToAddRows = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.ConsultarCobros = this;
            vFormulario.DeshabilitarEditar();
            vFormulario.ShowDialog();
        }

        public void CargarCliente(string xIdCliente,string xNombre)
        {
            txtidcliente.Text = xIdCliente;
            txtnombrecliente.Text = xNombre;
        }

        private void btnXCliente_Click(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            PorDefectoGrilla();
        }

        private void PorDefectoGrilla()
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
            txtreparacion.Text = "";
            txtservice.Text = "";
            checkTodasIngreso.Checked = false;
            utils.UtilidadesComunes.CargarComboMedioPago(cmbMedioPago);
            dtpFechaDesdeIngreso.Value = DateTime.Now.AddMonths(-1);
            dtpFechaIngresoHasta.Value = DateTime.Now.AddMonths(1);
            cargarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtfiltro.Text != "")
                DaoCaja.ConsultaIngresoFiltro(txtfiltro.Text);
            else
                PorDefectoGrilla();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Utils.ExportarDataGridViewExcel(dwgIngresos, "Consulta de ingresos");
        }
    }
}
