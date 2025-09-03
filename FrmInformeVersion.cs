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

namespace reparaciones2
{
    public partial class FrmInformeVersion : Form
    {
        public FrmInformeVersion()
        {
            InitializeComponent();
        }

        private void FrmInformeVersion_Load(object sender, EventArgs e)
        {
            txtdescripcion.Text = Utils.ObtenerDatosVersiones();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
