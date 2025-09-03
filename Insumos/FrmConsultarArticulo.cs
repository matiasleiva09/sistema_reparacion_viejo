using Org.BouncyCastle.Asn1.Crmf;
using reparaciones2.caja;
using reparaciones2.dao;
using reparaciones2.ob.insumos;
using reparaciones2.Presupuesto;
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
    public partial class FrmConsultarArticulo : Form
    {
        private FrmFacturasProveedor mFacturaProveedor = null;
        public string Modo { get; set; }
        public FrmPresupuesto Presupuesto { get; set; }
        public frmEditarReparacion FrmRep { get; set; }
        public FrmService FrmService { get; set; }
        public FrmCobroIngreso CobroIngreso { get; set; }

        public FrmFacturasProveedor FacturaProveedor
        {
            get { return mFacturaProveedor; }
            set { mFacturaProveedor = value; }
        }

        public FrmConsultarArticulo()
        {
            InitializeComponent();
        }

        private void FrmConsultarArticulo_Load(object sender, EventArgs e)
        {
            if (Modo == "ITEMSREPARACION")
            {
                CargarGrillaItemsReparacion();
                btnEditar.Visible = false;
                btnsalir.Location = btnEditar.Location;
            }
            else if (Modo == "ITEMSSERVICE")
            {
                CargarGrillaItemsService();
                btnEditar.Visible = false;
                btnsalir.Location = btnEditar.Location;
            }

            else
                CargarGrilla();
        }

        public void CargarGrilla()
        {
            dgwArticulo.DataSource = DaoArticulo.ListarArticulos(txtfiltro.Text);
            dgwArticulo.AutoResizeColumns();
        }

        public void CargarGrillaItemsReparacion()
        {
            dgwArticulo.DataSource = DaoItemReparacion.ObtenerTarifaInsumo();
            dgwArticulo.AutoResizeColumns();
            dgwArticulo.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dgwArticulo.Columns["idp"].Visible = false;
            dgwArticulo.Columns["idt"].Visible = false;
        }

        public void CargarGrillaItemsService()
        {
            dgwArticulo.DataSource = DaoItemService.ObtenerTarifaInsumo();
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwArticulo.CurrentRow;
            if (selectedRow != null)
            {
                if (Modo == "ITEMSREPARACION")
                {
                    FrmRep.AgregarItem(selectedRow);
                    this.Close();
                }
                else if (Modo == "ITEMSSERVICE")
                {
                    FrmService.AgregarItem(selectedRow);
                    this.Close();
                }
                else
                {
                   Articulo vArticulo =
                   DaoArticulo.ObtenerPorId(long.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    if (FacturaProveedor != null)
                        FacturaProveedor.AgregarItem(vArticulo);
                    else if (Presupuesto != null)
                        Presupuesto.AgregarItem(vArticulo);
                    else if (CobroIngreso != null)
                        CobroIngreso.AgregarItem(vArticulo);
                    this.Close();
                }
                   
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Modo == "ITEMSREPARACION")
            {
               
            }
            else
            {
                DataGridViewRow selectedRow = dgwArticulo.CurrentRow;
                if (selectedRow != null)
                {
                    Articulo vArticulo =
                       DaoArticulo.ObtenerPorId(long.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    FrmEditarInsumo vFormulario = new FrmEditarInsumo();
                    vFormulario.Articulo = vArticulo;
                    vFormulario.FrmBusquedaArticulo = this;
                    vFormulario.ShowDialog();
                }
            }
           
        }
    }
}
