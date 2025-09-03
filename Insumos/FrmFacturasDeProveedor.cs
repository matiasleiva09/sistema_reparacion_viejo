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

namespace reparaciones2.Insumos
{
    public partial class FrmFacturasDeProveedor : Form
    {
        public FrmFacturasDeProveedor()
        {
            InitializeComponent();
        }

        private void FrmFacturasDeProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgwFacturas.DataSource = DaoFacturaProveedor.ObtenerFacturas(txtfiltro.Text.Trim());
            dgwFacturas.Columns["idfactura"].Visible = false;
            dgwFacturas.Columns["idprov"].Visible = false;
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmFacturasProveedor vFormulario = new FrmFacturasProveedor();
        }

        private void dgwFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgwFacturas.CurrentRow;
            FrmFacturasProveedor vFormulario = new FrmFacturasProveedor();
            vFormulario.VengoDe = "CONSULTA";
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Factura = DaoFacturaProveedor.ObtenerPorId(long.Parse(selectedRow.Cells["idfactura"].Value.ToString()));
            vFormulario.Show();
            Close();
        }
    }
}
