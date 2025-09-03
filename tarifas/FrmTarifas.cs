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

namespace reparaciones2.tarifas
{
    public partial class FrmTarifas : Form
    {
        public FrmTarifas()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarGrilla()
        {
            dgwTarifa.DataSource = DaoTarifa.ObtenerTarifas(txtfiltro.Text);
            dgwTarifa.AutoResizeColumns();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            CargarGrilla();
        }
       
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmEditarTarifa vFormulario = new tarifas.FrmEditarTarifa();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.VengoDe= "CONSULTA";
            vFormulario.Show();
            this.Close();
        }

        private void FrmTarifas_Load_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgwTarifa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwTarifa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow vFilaSeleccionada = dgwTarifa.CurrentRow;
            if (vFilaSeleccionada != null)
            {
                FrmEditarTarifa vFormulario = new tarifas.FrmEditarTarifa();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.VengoDe = "CONSULTA";
                vFormulario.setearDatos(long.Parse(vFilaSeleccionada.Cells["Id"].Value.ToString()),
                    vFilaSeleccionada.Cells["Tarifa"].Value.ToString(),
                    float.Parse(vFilaSeleccionada.Cells["Monto"].Value.ToString()), vFilaSeleccionada.Cells["Servicio"].Value.ToString());
                vFormulario.Show();
                Close();
            }
        }
    }
}
