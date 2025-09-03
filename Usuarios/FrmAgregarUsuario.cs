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
    public partial class FrmAgregarUsuario : Form
    {
        private bool vExisteUsuario = false;
        public long Id { get; set; }
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cerrar()
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() != "" && txtconnueva.Text.Trim() != "" &&
                txtconnuevarep.Text.Trim() != "" && txtdescripcion.Text.Trim() != ""
                && cmbGrupo.SelectedValue != null)
            {
                if (vExisteUsuario)
                    MessageBox.Show("Atención, el nombre de usuario ya existe en el sistema", "ATENCION!!");
                else if (txtconnueva.Text.Trim() != txtconnuevarep.Text.Trim())
                    MessageBox.Show("Las contraseñas ingresadas no coinciden", "ATENCION!!");
                else
                {
                    DAOUsuario.GuardarUsuario(txtnombre.Text, txtconnueva.Text, txtdescripcion.Text,
                        checkActivo.Checked, long.Parse(cmbGrupo.SelectedValue.ToString()));
                    this.Close();
                }
            }
            else
                MessageBox.Show("Complete los campos marcados con (*)","ATENCION!!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            CargarComboGrupo();
        }

        private void CargarComboGrupo()
        {
            cmbGrupo.DataSource = DAOUsuario.CmbGrupos();
            cmbGrupo.DisplayMember = "value";
            cmbGrupo.ValueMember = "id";
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
           bool vExisteUsuario = DAOUsuario.ExisteUsuario(txtnombre.Text.Trim());
            if (vExisteUsuario)
                MessageBox.Show("Atención, el nombre de usuario ya existe en el sistema","ATENCION!!");
        }
    }
}
