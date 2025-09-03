using desagotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.Configuracion
{
    public partial class FrmConfiguracionDatos : Form
    {
        public FrmConfiguracionDatos()
        {
            InitializeComponent();
        }

        private void FrmConfiguracionDatos_Load(object sender, EventArgs e)
        {
            try
            {
                String vStringDB = Utils.ObtenerPathBase();
                Char vDelimitador = ';';
                String[] vStringSeparado = vStringDB.Split(vDelimitador);
                txtDireccionIP.Text = vStringSeparado[0].Replace("Server=", "").Trim();
                txtPuerto.Text = vStringSeparado[1].Replace("Port=", "").Trim();
                txtUsuarioDB.Text = vStringSeparado[2].Replace("User Id=", "").Trim();
                txtContrasenaDB.Text = vStringSeparado[3].Replace("Password=", "").Trim();
                txtNombreDB.Text = vStringSeparado[4].Replace("Database=", "").Trim();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtDireccionIP.Text.Trim()!="" && txtPuerto.Text.Trim()!="" && txtContrasenaDB.Text.Trim()!=""
                && txtNombreDB.Text.Trim()!="" && txtUsuarioDB.Text.Trim()!="")
            {
                String vPath = "Server=" + txtDireccionIP.Text.Trim() + ";Port=" + txtPuerto.Text.Trim() +
                    ";User Id=" +
                    txtUsuarioDB.Text.Trim() + ";Password=" + txtContrasenaDB.Text.Trim() + ";Database=" + txtNombreDB.Text.Trim() + ";";
                bool vRes = Utils.GuardarConfiguraciones("", vPath, "");
                if (vRes)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("NO SE HAN PODIDO GUARDAR LOS CAMBIOS", "ERROR!");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios (*)", "ATENCION!");
            }
        }
    }
}
