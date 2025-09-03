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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgwProveedores.DataSource = DaoProveedor.ObtenerProveedores(txtfiltro.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            CargarGrilla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void dgwProveedores_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwProveedores.CurrentRow;
            if(selectedRow!=null)
            {
                try
                {
                    FrmProveedor vFormulario = new Insumos.FrmProveedor();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Proveedor = DaoProveedor.ObtenerProveedor(int.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    Console.WriteLine(int.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    vFormulario.VengoDe = "PROVEEDORES";
                    vFormulario.Show();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"ERROR!");
                }
                
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmProveedor vFormulario = new FrmProveedor();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.VengoDe = "PROVEEDORES";
            vFormulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwProveedores.CurrentRow;
            try
            {
                DaoProveedor.Borrar(int.Parse(selectedRow.Cells["Id"].Value.ToString()));
                MessageBox.Show("Proveedor borrado correctamente","ATENCION!");
                CargarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"ERROR!");
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
