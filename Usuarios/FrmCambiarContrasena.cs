using reparaciones2.ob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.Usuarios
{
    public partial class FrmCambiarContrasena : Form
    {
        private Usuario mUsuarioSesion = null;

        public Usuario UsuarioSesion
        {
            get { return mUsuarioSesion; }
            set { mUsuarioSesion = value; }
        }
        public FrmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void FrmCambiarContrasena_Load(object sender, EventArgs e)
        {
            lbldatosusuario.Text = UsuarioSesion.Descripcion;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txtconactual.Text.Trim()!="" && 
                txtconnueva.Text.Trim()!="" && txtconnuevarep.Text.Trim()!="")
            {
                bool vConActuaOk = false;
                bool vConIgualesOK = false;
                if (txtconnueva.Text.Trim() == txtconnuevarep.Text.Trim())
                    vConIgualesOK = true;
                MD5 md5Hash = MD5.Create();
                String vHasMd5 = CriptoGrafia.GetMd5Hash(MD5.Create(), txtconactual.Text);
                md5Hash = null;
                if (vHasMd5 == mUsuarioSesion.Contrasena)
                    vConActuaOk=true;

                if (vConIgualesOK && vConActuaOk)
                {
                    UsuarioSesion.actualizarContrasena(txtconnueva.Text);
                    MessageBox.Show("Contraseña actualizada correctamente.","Felicidades!");
                    this.Close();
                }
                else if (!vConIgualesOK && !vConActuaOk)
                    MessageBox.Show("La contraseña que puso como actual no coincide con la suya. Además,"
                        +" las contraseñas en el campo nueva y repetir nueva, no coinciden","ATENCION!");
                else if(!vConIgualesOK && vConActuaOk)
                    MessageBox.Show("Las contraseñas en el campo nueva y repetir nueva, no coinciden.", "ATENCION!");
                else
                    MessageBox.Show("La contraseña que puso como actual no coincide con la suya.", "ATENCION!");
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios","ATENCIÓN!");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
