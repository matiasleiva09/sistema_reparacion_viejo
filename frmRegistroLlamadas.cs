using reparaciones2.dao;
using reparaciones2.reportes;
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
    public partial class frmRegistroLlamadas : Form
    {
        private String idReparacion = null;
        private String codigo = null;
        private bool vengoDeCliente = false;
        private bool vengoDeReparacion = false;
        private bool vengoDeEditarReparacion = false;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public bool VengoDeEditarReparacion
        {
            get { return vengoDeEditarReparacion; }
            set { vengoDeEditarReparacion = value; }
        }

        public bool VengoDeReparacion
        {
            get { return vengoDeReparacion; }
            set { vengoDeReparacion = value; }
        }

        public bool VengoDeCliente
        {
            get { return vengoDeCliente; }
            set { vengoDeCliente = value; }
        }

        public String IdReparacion
        {
            get { return idReparacion; }
            set { idReparacion = value; }
        }

        public frmRegistroLlamadas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarLlamada vFormulario = new frmEditarLlamada();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.IdReparacion = this.IdReparacion;
            vFormulario.Codigo = this.Codigo;
            vFormulario.VengoDeCliente = this.VengoDeCliente;
            vFormulario.VengoDeReparacion = this.VengoDeReparacion;
            vFormulario.VengoDeEditarReparacion = this.VengoDeEditarReparacion;
            vFormulario.Show();
            this.Close();
        }

        private void frmRegistroLlamadas_Load(object sender, EventArgs e)
        {
            lbldatosOrden.Text = Codigo;
            dgwLlamadas.DataSource = DaoLlamadas.getLlamadas(IdReparacion);
            dgwLlamadas.AutoResizeColumns();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (VengoDeCliente)
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.IdCliente = long.Parse(DaoReparaciones.getClienteDeReparacion(IdReparacion));
                vFormulario.Show();
            }
            else if (VengoDeReparacion)
            {
                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
            }
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(index + "");
            DataGridViewRow selectedRow = dgwLlamadas.CurrentRow;
            RegistroLlamadas vReporte = new RegistroLlamadas();
            DateTime vFechaActual = DateTime.Now;
            String vFechaActualS = vFechaActual.Day + "/" + vFechaActual.Month + "/" + vFechaActual.Year;
            vReporte.Fecha = vFechaActualS;
            vReporte.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
            vReporte.Horario = DaoParametrosDatos.getParametro("HORARIO");
            vReporte.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
            vReporte.Calle = DaoParametrosDatos.getParametro("DIRECCION");
            vReporte.Datos = dgwLlamadas.DataSource as DataTable;
            System.Diagnostics.Process.Start(vReporte.crearPdf());
        }
    }
}
