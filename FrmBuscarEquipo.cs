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

namespace reparaciones2
{
    public partial class FrmBuscarEquipo : Form
    {
        private FrmConsultarReparaciones frmConsultarReparaciones;
        private frmEditarReparacion frmEditarReparacion;
       
        public void deshabilitarBotonEditar()
        {
            btnEditar.Enabled = false;
        }

        public frmEditarReparacion FrmEditarReparacion
        {
            get { return frmEditarReparacion; }
            set { frmEditarReparacion = value; }
        }

        public FrmConsultarReparaciones FrmConsultarReparaciones
        {
            get { return frmConsultarReparaciones; }
            set { frmConsultarReparaciones = value; }
        }

        public FrmBuscarEquipo()
        {
            InitializeComponent();
        }

        public void resetearGrilla()
        {
            if (FrmConsultarReparaciones != null)
            {
                if (frmConsultarReparaciones.TxtIdEquipo != "")
                {
                    dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(frmConsultarReparaciones.TxtIdEquipo));
                }
                else
                {
                    dgwEquipo.DataSource = DaoEquipo.getTodosLosEquipos(txtfiltro.Text);
                }
            }
            else if (FrmEditarReparacion != null)
            {
                if (FrmEditarReparacion.TxtIdCliente() != "")
                    dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(FrmEditarReparacion.TxtIdCliente()));
            }
        }

        private void FrmBuscarEquipo_Load(object sender, EventArgs e)
        {
            if (FrmConsultarReparaciones != null)
            {
                if (frmConsultarReparaciones.TxtIdEquipo != "")
                {
                    dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(frmConsultarReparaciones.TxtIdEquipo));
                }
                else
                {
                    dgwEquipo.DataSource = DaoEquipo.getTodosLosEquipos(txtfiltro.Text);
                }
            }
            else if (FrmEditarReparacion != null)
            {
                if (FrmEditarReparacion.TxtIdCliente() != "")
                    dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(FrmEditarReparacion.TxtIdCliente()));
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(FrmConsultarReparaciones!=null)
            {
                if (frmConsultarReparaciones.TxtIdEquipo != "")
                {
                    dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(frmConsultarReparaciones.TxtIdEquipo));
                }
                else
                {
                    dgwEquipo.DataSource = DaoEquipo.getTodosLosEquipos(txtfiltro.Text);
                }
            }
            else if(FrmEditarReparacion!=null)
            {
                dgwEquipo.DataSource = DaoEquipo.EquiposDeCliente(long.Parse(frmEditarReparacion.TxtIdCliente()));
            }
           
        }

        private void dgwEquipo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }

        private void dgwEquipo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditarEquipoCliente vFormulario = new FrmEditarEquipoCliente();
            DataGridViewRow selectedRow = dgwEquipo.CurrentRow;
            vFormulario.EquipoCliente = new ob.Equipo();
            vFormulario.FormBuscarEquipo = this;
            vFormulario.EquipoCliente.Id = long.Parse(selectedRow.Cells["Nro"].Value.ToString());
            vFormulario.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwEquipo.CurrentRow;
            if (this.FrmConsultarReparaciones != null)
            {
                this.FrmConsultarReparaciones.CargarEquipo(selectedRow.Cells["Nro"].Value.ToString(),
                    "Equipo: " + selectedRow.Cells["Tipo Equipo"].Value.ToString() + "- Marca: " + selectedRow.Cells["Marca"].Value.ToString()
                    + "- Modelo: " + selectedRow.Cells["Modelo"].Value.ToString());
            }
            else if (this.FrmEditarReparacion != null)
            {
                this.FrmEditarReparacion.CargarEquipo(selectedRow.Cells["Nro"].Value.ToString(),
                    "Equipo: " + selectedRow.Cells["Tipo Equipo"].Value.ToString() + "- Marca: " + selectedRow.Cells["Marca"].Value.ToString()
                    + "- Modelo: " + selectedRow.Cells["Modelo"].Value.ToString());
            }
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
