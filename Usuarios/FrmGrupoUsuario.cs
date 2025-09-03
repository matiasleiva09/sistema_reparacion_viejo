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

namespace reparaciones2.Usuarios
{
    public partial class FrmGrupoUsuario : Form
    {
        public FrmGrupoUsuario()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGrupoUsuario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgwGrupoUsuario.DataSource= DAOUsuario.getGruposDeUsuario();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            abmEditarGrupo vFormulario = new abmEditarGrupo();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwGrupoUsuario.CurrentRow;
            if (selectedRow != null)
            {
                abmEditarGrupo vFormulario = new abmEditarGrupo();
                vFormulario.Id = long.Parse(selectedRow.Cells["Id"].Value.ToString());
                vFormulario.Descripcion = selectedRow.Cells["Descripcion"].Value.ToString();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else
                MessageBox.Show("Seleccione primero un grupo","ATENCION!!!");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgwGrupoUsuario.DataSource=DAOUsuario.BuscarGrupo(txtfiltro.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
