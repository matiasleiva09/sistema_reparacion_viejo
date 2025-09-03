using reparaciones2.dao;
using reparaciones2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.service
{
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            UtilidadesComunes.CargarComboEstadosService(cmbEstado);
            dtpFechaDesdeIngreso.Value = DateTime.Now.AddMonths(-1);
            dtpFechaIngresoHasta.Value = DateTime.Now.AddMonths(1);
            Consultar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultar();  
        }

        private void Consultar()
        {
            long vIdCliente = 0;
            String vEstado = "";
            if (txtidcliente.Text != "")
                vIdCliente = long.Parse(txtidcliente.Text);
            if (cmbEstado.SelectedValue != null && cmbEstado.SelectedValue.ToString() != "")
                vEstado = cmbEstado.SelectedValue.ToString();

            dgwServices.DataSource=DAOService.ObtenerServices(txtnro.Text, dtpFechaDesdeIngreso.Value, dtpFechaIngresoHasta.Value, vEstado, vIdCliente);
            dgwServices.AutoResizeColumns();
            dgwServices.Columns["idcliente"].Visible = false;
        }

        private void btneditardatos_Click(object sender, EventArgs e)
        {

            GetEditar();
            
        }

        private void GetEditar()
        {
            DataGridViewRow selectedRow = dgwServices.CurrentRow;
            if(dgwServices.CurrentRow!=null)
            {
                FrmService vFormulario = new FrmService();
                vFormulario.Service = DAOService.ObtenerService(long.Parse(selectedRow.Cells["Nro Service"].Value.ToString()));
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero un service para poder editarlo.");
            }
        }

        private void dgwServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwServices.CurrentRow;
            if (selectedRow != null)
            {
                float vCosto = float.Parse(selectedRow.Cells["Monto"].Value.ToString());
                float vMontoPagado = float.Parse(selectedRow.Cells["Seña"].Value.ToString());
               
                if (vCosto > vMontoPagado)
                {
                    FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                    String vIdReparacion = selectedRow.Cells["Nro Service"].Value.ToString();
                    vFormulario.Service = DAOService.ObtenerService(long.Parse(
                        selectedRow.Cells["Nro Service"].Value.ToString()));
                    Console.WriteLine(vFormulario.Service);
                    vFormulario.IdCliente = selectedRow.Cells["idcliente"].Value.ToString();
                    vFormulario.IdReparacion = vIdReparacion;
                    vFormulario.Cliente = selectedRow.Cells["idcliente"].Value.ToString() + "-" + selectedRow.Cells["Cliente"].Value.ToString(); ;
                    vFormulario.ReporteOrdenReparacion = null;
                    vFormulario.EntregaReporte = null;
                    vFormulario.VengoDe = "ConsultarServices";
                    vFormulario.MdiParent = this.MdiParent;
                    float vMonto = float.Parse(selectedRow.Cells["Monto"].Value.ToString()) -
                        float.Parse(selectedRow.Cells["Seña"].Value.ToString());
                    vFormulario.Monto= vMonto + "";
                    vFormulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede generar un ingreso por una orden que ya está paga y entregada.", "Atención!");
                }

            }
            else
            {
                MessageBox.Show("Tiene que elegir una orden para generar recibos.", "Atención!");
            }

        }
    }
}
