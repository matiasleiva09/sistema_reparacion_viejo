using reparaciones2.dao;
using reparaciones2.ob.insumos;
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
    public partial class FrmBuscarProveedor : Form
    {
        private FrmEditarInsumo frmInsumos = null;
        private FrmFacturasProveedor frmFacturaProveedor = null;

        public FrmEditarInsumo FrmInsumos
        {
            get { return frmInsumos; }
            set { frmInsumos = value; }
        } 

        public FrmFacturasProveedor FrmFacturaProveedor
        {
            get { return frmFacturaProveedor; }
            set { frmFacturaProveedor = value; }
        }

        public FrmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            dgwProveedor.DataSource = DaoProveedor.ObtenerProveedores(txtfiltro.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwProveedor.CurrentRow;
            if(selectedRow!=null)
            {
                String vId = selectedRow.Cells["Id"].Value.ToString();
                String vDescripcion = selectedRow.Cells["Nombre"].Value.ToString();
                if(FrmInsumos!=null)
                    frmInsumos.CargarProveedor(vId, vDescripcion);
                else if(FrmFacturaProveedor != null)
                    FrmFacturaProveedor.CargarProveedor(vId, vDescripcion);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un proveedor","ATENCION!");
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwProveedor.CurrentRow;
            if (selectedRow != null)
            {
                Proveedor vProveedor = DaoProveedor.ObtenerProveedor(long.Parse(selectedRow.Cells["Id"].ToString()));
                FrmProveedor vFormulario = new Insumos.FrmProveedor();
                vFormulario.FrmBusquedaProveedor = this;
                vFormulario.VengoDe = "SELECCION";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor para editar.","ATENCION!");
            }
               
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
