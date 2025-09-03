using desagotes;
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

namespace reparaciones2.caja
{      
     public partial class abmNotaCD : Form
    {
        public long IdCliente { get; set; }
        public FrmAdminContacto FormularioAnterior { get; set; }

        public abmNotaCD()
        {
            InitializeComponent();
        }

        private void abmNotaCD_Load(object sender, EventArgs e)
        {
            UtilidadesComunes.CargarComboTipoNota(cmbTipoNotaCD);
            txtmonto.Text = "0.00";
            txtnroNota.Text = "0000000";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FormularioAnterior.Show();
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            FormularioAnterior.Show();
            this.Close();
        }

        private void txtsaldoinicial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            float vMonto = float.Parse(txtmonto.Text.Trim());
            if (vMonto > 0 && cmbTipoNotaCD.SelectedItem != null && txtnroNota.Text.Trim()!="")
            {
                string vTipo = cmbTipoNotaCD.SelectedItem.ToString();
                if (vTipo == "ND")
                    DaoNotaCD.GuardarD(Utils.getFechaSinHoraBase(dtpFecha.Text), IdCliente,
                        vMonto, txtDescripcion.Text,txtnroNota.Text.Trim());
                else
                    DaoNotaCD.GuardarC(Utils.getFechaSinHoraBase(dtpFecha.Text), IdCliente,
                        vMonto, txtDescripcion.Text,txtnroNota.Text.Trim());
                FormularioAnterior.recargaGrillaMovimientosExterior();
                FormularioAnterior.Show();
                this.Close();
            }
            else
                MessageBox.Show("Complete los campos obligatirios","ATENCION!!!");
        }
    }
}
