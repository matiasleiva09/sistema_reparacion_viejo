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
    public partial class abmEditarGrupo : Form
    {   
        public long Id { get; set; }
        public string Descripcion { get; set; }
        public abmEditarGrupo()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtfiltro.Text.Trim() != "")
            {
                if (Id == 0)
                {
                    DAOUsuario.GuardarGrupo(txtfiltro.Text.Trim());
                }
                else
                {
                    DAOUsuario.EditarGrupo(Id, txtfiltro.Text.Trim());
                }
            }
            else
                 MessageBox.Show("Debe completar el campo Descripción","ATENCION!!!");
            FrmGrupoUsuario vFormulario = new FrmGrupoUsuario();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            Close();
        }

        private void abmEditarGrupo_Load(object sender, EventArgs e)
        {
            if (Id > 0)
                txtfiltro.Text = Descripcion;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
