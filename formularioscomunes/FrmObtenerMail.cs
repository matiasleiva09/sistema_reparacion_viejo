using reparaciones2.reparaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.formularioscomunes
{
    public partial class FrmObtenerMail : Form
    {
        public FrmImprimirEntrega FormularioImprimirEntrega { get; set; }
        public FrmEnviarReporte FormularioEnviarReporte { get; set; }

        public FrmObtenerMail()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtemail.Text.Trim() != "" && txtemail.Text.Trim().IndexOf('@') > 0)
            {
                if (FormularioImprimirEntrega != null)
                    FormularioImprimirEntrega.ActualizarEmail(txtemail.Text.Trim());
                else
                    FormularioEnviarReporte.SetEmailCliente(txtemail.Text.Trim());
                this.Close();
            }
            else
                MessageBox.Show("Ingrese un email válido");

        }
    }
}
