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

namespace reparaciones2.tarifas
{
    public partial class FrmEditarTarifa : Form
    {
        private long id = 0;
        private String vengoDe = "";

        public void setearDatos(long xId,String xDescripcion,float xMonto,String xServicio)
        {
            id = xId;
            txtDescripcion.Text = xDescripcion;
            txtMonto.Text = xMonto +"";
            cmbServicio.Text = xServicio;
        }

        public String VengoDe
        {
           get { return vengoDe; }
           set { vengoDe = value; }
        }
     
        public FrmEditarTarifa()
        {
            InitializeComponent();
        }

        private void FrmEditarTarifa_Load(object sender, EventArgs e)
        {
            if (id == 0)
                txtMonto.Text = "0.00";
            cmbServicio.Items.Add("REPARACION");
            cmbServicio.Items.Add("SERVICIO");
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            String servicio = "";
            if (cmbServicio.SelectedValue == null)
                servicio = cmbServicio.Text;
            else
                servicio = cmbServicio.SelectedValue.ToString();
            if (txtDescripcion.Text.Trim()!="" && txtMonto.Text.Trim()!="")
            {
                if (id == 0)
                    DaoTarifa.Guardar(txtDescripcion.Text.Trim().ToUpper(), float.Parse(txtMonto.Text),servicio);
                else
                    DaoTarifa.Editar(id, txtDescripcion.Text.Trim().ToUpper(), float.Parse(txtMonto.Text),servicio);
                Cerrar();
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios (*)","ATENCION!");
            }
            
        }

        private void Cerrar()
        {
            if (VengoDe == "CONSULTA")
            {
                FrmTarifas vFormulario = new tarifas.FrmTarifas();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Close();
            }
            else
                Close();
        }

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
