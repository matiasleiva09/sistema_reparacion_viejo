using reparaciones2.dao;
using reparaciones2.Presupuesto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reparaciones2.service;
using System.Windows.Forms;
using reparaciones2.caja;

namespace reparaciones2
{
    public partial class FormBuscarCliente : Form
    {
        private FrmConsultarReparaciones frmConsultarReparaciones;
        private frmEditarReparacion frmEditarReparacion;

        public FrmService frmEditarService { get; set; }
        public FrmPresupuesto Presupuesto { get; set; }
        public ConsultarCobros ConsultarCobros { get; set; }
        public FrmCobroIngreso CobroIngreso { get; set; }

        public void DeshabilitarEditar()
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
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        public void cargarClientes()
        {
            dgwClientes.DataSource = DaoCliente.ListarClientes(txtfiltro.Text.Trim());
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            cargarClientes();
        }

        private void dgwClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwClientes.CurrentRow;
            if (this.FrmConsultarReparaciones != null)
            {
                this.FrmConsultarReparaciones.cargarCliente(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["nombre"].Value.ToString());
            }
            else if (this.FrmEditarReparacion != null)
            {
                FrmEditarReparacion.CargarCliente(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["nombre"].Value.ToString()
                    + " Tel: " + selectedRow.Cells["telefono"].Value.ToString()
              
                    + " Cel: " + selectedRow.Cells["celular"].Value.ToString());
            }
            else if(frmEditarService!=null)
            {
                frmEditarService.CargarCliente(selectedRow.Cells["Id"].Value.ToString());
            }
            else if(this.Presupuesto!=null)
            {
                Presupuesto.CargarCliente(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["nombre"].Value.ToString()
                    + " Tel: " + selectedRow.Cells["telefono"].Value.ToString()

                    + " Cel: " + selectedRow.Cells["celular"].Value.ToString());
            }
            else if(this.ConsultarCobros!=null)
            {
                ConsultarCobros.CargarCliente(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["nombre"].Value.ToString());
            }
            else if(this.CobroIngreso!=null)
            {
                this.CobroIngreso.CargarCliente(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["nombre"].Value.ToString());
            }
            
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwClientes.CurrentRow;
            long vIdCliente = long.Parse(selectedRow.Cells["Id"].Value.ToString());
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.BuscarCliente = this;
            vFormulario.Cliente = DaoCliente.ObtenerCliente(vIdCliente);
            vFormulario.ShowDialog();
        }
    }
}
