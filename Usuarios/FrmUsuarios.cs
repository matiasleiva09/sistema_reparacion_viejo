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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            dgwUsuario.DataSource = dao.DAOUsuario.ObtenerUsuariosTabla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgwUsuario.DataSource = dao.DAOUsuario.ObtenerUsuariosTabla(txtfiltro.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            dgwUsuario.DataSource = dao.DAOUsuario.ObtenerUsuariosTabla();
        }

        private void btnBajaAlta_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwUsuario.CurrentRow;
            if(selectedRow!=null)
            {
                DialogResult dr = MessageBox.Show("está seguro que quiere activar/desactivar el usuario "
              + selectedRow.Cells["Usuario"].Value.ToString(), "Atención!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {

                    bool vEstado = Boolean.Parse(selectedRow.Cells["Activo"].Value.ToString());
                    dao.DAOUsuario.DarDeAltaoBaja(selectedRow.Cells["Usuario"].Value.ToString(), vEstado);
                    dgwUsuario.DataSource = dao.DAOUsuario.ObtenerUsuariosTabla();
                }
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwUsuario.CurrentRow;
            if (selectedRow != null)
            {
                FrmCambiarContrasena vFormulario = new FrmCambiarContrasena();
                vFormulario.MdiParent = this.MdiParent;

                vFormulario.UsuarioSesion =DAOUsuario.getUsuario(selectedRow.Cells["Usuario"].Value.ToString());
                vFormulario.Show();
                this.Close();
            }
              
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario vFormulario = new FrmAgregarUsuario();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwUsuario.CurrentRow;
            if (selectedRow != null)
            {
                FrmCambiarGrupo vFormulario = new FrmCambiarGrupo();
                vFormulario.NombreUsuario = selectedRow.Cells["Usuario"].Value.ToString();
                vFormulario.IdGrupo = long.Parse(selectedRow.Cells["Id Grupo"].Value.ToString());
                vFormulario.Grupo = selectedRow.Cells["Grupo"].Value.ToString();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }

                
        }
    }
}
