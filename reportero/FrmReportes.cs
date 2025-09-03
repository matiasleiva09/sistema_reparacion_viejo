using reparaciones2.frmReporte;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cmbReporte.Items.Add("Consultar Reparaciones Pendientes");
            cmbReporte.Items.Add("Consultar Reparaciones en Reparación");
            cmbReporte.Items.Add("Consultar Reparaciones Reparadas");
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String vValorElejido = "";
            if (cmbReporte.SelectedValue == null)
                vValorElejido = cmbReporte.Text.ToString();
            else
                vValorElejido = cmbReporte.SelectedValue.ToString();

            if (vValorElejido == "Consultar Reparaciones Pendientes")
            {
                FrmReparacionesPendientes vFormulario = new FrmReparacionesPendientes();
                vFormulario.Metodo = "TOMADA";
                vFormulario.Titulo = "REPARACIONES PENDIENTES";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
            else if (vValorElejido == "Consultar Reparaciones en Reparación")
            {
                FrmReparacionesPendientes vFormulario = new FrmReparacionesPendientes();
                vFormulario.Metodo = "EN REPARACION";
                vFormulario.Titulo = "REPARACIONES EN REPARACION";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
            else if (vValorElejido == "Consultar Reparaciones Reparadas")
            {
                FrmReparacionesPendientes vFormulario = new FrmReparacionesPendientes();
                vFormulario.Metodo = "REPARADA";
                vFormulario.Titulo = "REPARACIONES REPARADAS";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
            else if (vValorElejido == "")
                MessageBox.Show("Debe seleccionar un reporte para poder continuar!.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
