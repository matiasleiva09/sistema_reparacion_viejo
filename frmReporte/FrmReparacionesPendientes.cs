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

namespace reparaciones2.frmReporte
{
    public partial class FrmReparacionesPendientes : Form
    {
        private String mMetodo = "";

        public String Titulo
        {
            get { return lblConsultaReparaciones.Text; }
            set { lblConsultaReparaciones.Text = value; } 
        }

        public String Metodo
        {
            get { return mMetodo; }
            set { mMetodo = value; }
        }

        public FrmReparacionesPendientes()
        {
            InitializeComponent();
        }

        private void FrmReparacionesPendientes_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            dgwReparaciones.DataSource = dao.DaoReparaciones.ConsultarPorEstado(Metodo, txtfiltro.Text);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            Buscar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Utils.ExportarDataGridViewExcel(dgwReparaciones, "ConsultaReparaciones" + Metodo );
        }
    }
}
