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
    public partial class FrmBusquedaMarca : Form
    {
        FrmEditarInsumo mFrmEditInsumo = null;

        public FrmEditarInsumo FrmEditInsumo
        {
            get { return mFrmEditInsumo; }
            set { mFrmEditInsumo = value; }
        }

        public FrmBusquedaMarca()
        {
            InitializeComponent();
        }

        private void FrmBusquedaMarca_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla()
        {
            dgwMarcas.DataSource = DaoMarcaDiccionario.ObtenerMarcas(txtfiltro.Text);
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow vFilaSeleccionada = dgwMarcas.CurrentRow;
            if(vFilaSeleccionada!=null)
            {
                FrmEditInsumo.CargarMarca(long.Parse(vFilaSeleccionada.Cells["Id"].Value.ToString()), vFilaSeleccionada.Cells["Descripcion"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("Para seleccionar una marca marcar sobre la grilla primeramente","ATENCION!");
            }
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow vFilaSeleccionada = dgwMarcas.CurrentRow;
            if(vFilaSeleccionada!=null)
            {
                FrmMarca vFormulario = new FrmMarca();
                vFormulario.VengoDe = "SELECCION";
                vFormulario.FrmBusquedaMarca = this;
                vFormulario.SetearDatos(long.Parse(vFilaSeleccionada.Cells["Id"].Value.ToString()),
                    vFilaSeleccionada.Cells["Descripcion"].Value.ToString());
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una marca para editar.","ATENCION!");
            }
            
        }
    }
}
