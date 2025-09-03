using desagotes;
using reparaciones2.dao;
using reparaciones2.mapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmParametros : Form
    {
        public void Geo(string xGeo)
        {
            txtcoordenadas.Text = xGeo;
        }
        public FrmParametros()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDireccion.Text!="" && txtEmpresa.Text!="" &&
                txtHorario.Text!="" && txtLeyenda.Text!="" && txtTelefono.Text!=""
                && (txtEmail.Text.Trim()!="" && Utils.ComprobarFormatoEmail(txtEmail.Text.Trim()) 
                || txtEmail.Text.Trim()==""))
            {
                
                DaoParametrosDatos.UpdateParametro(txtDireccion.Text, "DIRECCION");
                DaoParametrosDatos.UpdateParametro(txtEmailEmpresa.Text,"EMAIL");
                DaoParametrosDatos.UpdateParametro(txtEmpresa.Text, "EMPRESA");
                DaoParametrosDatos.UpdateParametro(txtHorario.Text, "HORARIO");
                DaoParametrosDatos.UpdateParametro(txtLeyenda.Text, "LEYENDA");
                DaoParametrosDatos.UpdateParametro(txtTelefono.Text, "TELEFONO");
                DaoParametrosDatos.UpdateParametro(txtcoMail.Text, "CONTRASEÑAENVIO");
                DaoParametrosDatos.UpdateParametro(txtEmail.Text, "EMAILENVIO");
                DaoParametrosDatos.UpdateParametro(txtServidorSMTP.Text, "SERVIDOR_SMTP");
                DaoParametrosDatos.UpdateParametro(txtPuertoSMTP.Text, "PUERTO_SMTP");
                DaoParametrosDatos.UpdateParametro(txtLeyendaMail.Text, "CUERPOMAILORDEN");
                DaoParametrosDatos.UpdateParametro(txtcoordenadas.Text, "GOOGLEMAPSCENTRO");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique todos los campos obligatorios por favor.","Atencion!");
            }
        }

        private void FrmParametros_Load(object sender, EventArgs e)
        {
            txtDireccion.Text = DaoParametrosDatos.getParametro("DIRECCION");
            txtEmailEmpresa.Text = DaoParametrosDatos.getParametro("MAIL");
            txtEmpresa.Text = DaoParametrosDatos.getParametro("EMPRESA");
            txtHorario.Text = DaoParametrosDatos.getParametro("HORARIO");
            txtLeyenda.Text = DaoParametrosDatos.getParametro("LEYENDA");
            txtTelefono.Text = DaoParametrosDatos.getParametro("TELEFONO");
            txtEmail.Text = DaoParametrosDatos.getParametro("EMAILENVIO");
            txtcoMail.Text = DaoParametrosDatos.getParametro("CONTRASEÑAENVIO");
            txtServidorSMTP.Text = DaoParametrosDatos.getParametro("SERVIDOR_SMTP");
            txtPuertoSMTP.Text = DaoParametrosDatos.getParametro("PUERTO_SMTP");
            txtLeyendaMail.Text = DaoParametrosDatos.getParametro("CUERPOMAILORDEN");
            txtcoordenadas.Text = DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
            bool vMandarMail = ModuloSistemaDAO.MandarMailsHabilitado();
            if (!vMandarMail)
            {
                tabDatosMail.Enabled = false;
                txtLeyendaMail.Enabled = false;
            }
                


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            FrmMapas vFormulario = new FrmMapas();
            vFormulario.Parametros = this;
            vFormulario.Geo = txtcoordenadas.Text;
            vFormulario.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
