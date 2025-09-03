using reparaciones2.dao;
using reparaciones2.ob.insumos;
using stocksires.Insumos;
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
    public partial class FrmConsultarInsumos : Form
    {
        public FrmConsultarInsumos()
        {
            InitializeComponent();
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
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.VengoDe = "CONSULTA";
            vFormulario.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwInsumos.CurrentRow;
            if (selectedRow != null)
            {
                try
                {
                    bool vExistenItems = DaoArticulo.ExisteItem(selectedRow.Cells["Id"].Value.ToString(), selectedRow.Cells["Codigo"].Value.ToString());
                    if (vExistenItems)
                    {
                        MessageBox.Show("No se puede borrar este item, el mismo tiene asociado presupuestos, pedidos o facturas", "ATENCION!");
                    }
                    else
                    {
                        DaoArticulo.Borrar(long.Parse(selectedRow.Cells["Id"].Value.ToString()));
                        MessageBox.Show("Insumo borrado correctamente", "ATENCION!");
                        CargarGrilla();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede borrar el insumo", "ATENCION!");
                }
            }
        }

        private void dgwInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgwInsumos.CurrentRow;
            if (selectedRow != null)
            {
                Articulo vArticulo = DaoArticulo.ObtenerPorId(long.Parse(selectedRow.Cells["id"].Value.ToString()));
                FrmEditarInsumo vFormulario = new FrmEditarInsumo();
                vFormulario.VengoDe = "CONSULTA";
                vFormulario.Articulo = vArticulo;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
        }

        private void FrmConsultarInsumos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgwInsumos.DataSource = DaoArticulo.ListarArticulos(txtfiltro.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmActualizarPrecios vFormulario = new FrmActualizarPrecios();
            vFormulario.Show();
            this.Close();
        }
    }
}





/*using reparaciones2.dao;
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
    public partial class FrmConsultarInsumos : Form
    {
        public FrmConsultarInsumos()
        {
            InitializeComponent();
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
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.VengoDe = "CONSULTA";
            vFormulario.Show();
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwInsumos.CurrentRow;
            if(selectedRow!=null)
            {
                try
                {
                    DaoArticulo.Borrar(long.Parse(selectedRow.Cells["Id"].Value.ToString()));
                    MessageBox.Show("Insumo borrado correctamente", "ATENCION!");
                    CargarGrilla();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se puede borrar el insumo","ATENCION!");
                }
            }
        }

        private void dgwInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgwInsumos.CurrentRow;
            if(selectedRow!=null)
            {
                Articulo vArticulo = DaoArticulo.ObtenerPorId(long.Parse(selectedRow.Cells["id"].Value.ToString()));
                FrmEditarInsumo vFormulario = new FrmEditarInsumo();
                vFormulario.VengoDe = "CONSULTA";
                vFormulario.Articulo = vArticulo;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
        }

        private void FrmConsultarInsumos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgwInsumos.DataSource = DaoArticulo.ListarArticulos(txtfiltro.Text);
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
}*/
