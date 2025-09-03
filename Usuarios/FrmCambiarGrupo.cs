using reparaciones2.dao;
using reparaciones2.utils;
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
    public partial class FrmCambiarGrupo : Form
    {
        public long IdGrupo { get; set; }
        public string Grupo { get; set; }
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public FrmCambiarGrupo()
        {
            InitializeComponent();
        }

        private void FrmCambiarGrupo_Load(object sender, EventArgs e)
        {
            lbldatosusuario.Text = NombreUsuario;
            UtilidadesComunes.CargarComboGrupoUsuario(cmbGrupo);
            cmbGrupo.SelectedIndex = cmbGrupo.FindStringExact(Grupo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DAOUsuario.CambiarGrupo(lbldatosusuario.Text,long.Parse(cmbGrupo.SelectedValue.ToString()));
            Cerrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();   
        }

        private void Cerrar()
        {
            FrmUsuarios vFormulario = new FrmUsuarios();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}
