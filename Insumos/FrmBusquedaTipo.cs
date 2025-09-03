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
    public partial class FrmBusquedaTipo : Form
    {
        private FrmEditarInsumo mFrmEditInsumo = null;
        private FrmBusquedaTipo mFrmBusquedaTipo = null;
        
        public FrmBusquedaTipo BusquedaTipo
        {
            get { return mFrmBusquedaTipo; }
            set { mFrmBusquedaTipo = value; }
        }

        public FrmEditarInsumo FrmEditInsumo
        {
            get { return mFrmEditInsumo; }
            set { mFrmEditInsumo = value; }
        }

        public FrmBusquedaTipo()
        {
            InitializeComponent();
        }

        private void FrmBusquedaTipo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            dgwTipo.DataSource = DaoTipo.ObtenerTipoProducto(txtfiltro.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow vFilaSeleccionada = dgwTipo.CurrentRow;
            if (vFilaSeleccionada != null)
            {
                FrmEditInsumo.CargarTipo(long.Parse(vFilaSeleccionada.Cells["Id"].Value.ToString()), vFilaSeleccionada.Cells["Descripcion"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("Para seleccionar una marca marcar sobre la grilla primeramente", "ATENCION!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow vFilaSeleccionada = dgwTipo.CurrentRow;
            if (vFilaSeleccionada != null)
            {
                FrmTipo vFormulario = new Insumos.FrmTipo();
                vFormulario.SetearDatos(long.Parse(vFilaSeleccionada.Cells["Id"].ToString()),
                    vFilaSeleccionada.Cells["Descripcion"].ToString());
                vFormulario.VengoDe = "SELECCION";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para seleccionar una marca marcar sobre la grilla primeramente", "ATENCION!");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
