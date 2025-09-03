using desagotes;
using reparaciones2.caja;
using reparaciones2.dao;
using reparaciones2.ob;
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
    public partial class FrmAdminContacto : Form
    {
        private int index = 0;
        private long idcliente;
        private Cliente cliente;

        public long IdCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public FrmAdminContacto()
        {
            InitializeComponent();
        }

        private void FrmAdminContacto_Load(object sender, EventArgs e)
        {
            this.cliente = DaoCliente.ObtenerCliente(this.IdCliente);
            dgwCuentaCorriente.DataSource = DaoCliente.getCuentaCorrienteCliente(this.cliente.Id +"");
            dgwCuentaCorriente.AutoResizeColumns();
            dgwService.DataSource = DAOService.ObtenerServiceDeCliente(IdCliente);
            dgwService.AutoResizeColumns();
            if(dgwCuentaCorriente.Rows.Count > 0)
            {
                float vMonto = 0.00f;
                foreach (DataGridViewRow vFila in dgwCuentaCorriente.Rows)
                {
                    if(vFila.Cells["Monto"].Value!=null)
                        vMonto += float.Parse(vFila.Cells["Monto"].Value.ToString());
                }
                lbldatosMontoAdeudado.Text = vMonto +"";
            }
           
            dgwequipos.DataSource = DaoEquipo.EquiposDeCliente(cliente.Id);
            dgwequipos.AutoResizeColumns();
            dgwreparaciones.DataSource = DaoReparaciones.getReparacionesCliente(cliente.Id);
           
            lbldatosdireccion.Text = cliente.Direccion();
            lbldatosnombre.Text = cliente.Nombre;
            lbldatostelefono.Text = cliente.Telefono;
            lbldatosemail.Text = cliente.Email;
            lbldatoscelular.Text = cliente.Celular;
            dgwreparaciones.Columns["Id"].Visible = false;
            dgwreparaciones.AutoResizeColumns();
        }

        private void btneditardatos_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.Cliente = this.cliente;
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Clientes vFormulario = new Clientes();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.cliente = null;
            this.Close();
        }

        private void btnagregarequipo_Click(object sender, EventArgs e)
        {
            FrmEditarEquipoCliente vFormulario = new FrmEditarEquipoCliente();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Cliente = this.cliente;
            vFormulario.Show();
            this.cliente = null;
            this.Close();
        }

        private void dgwequipos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwequipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarReparacion_Click(object sender, EventArgs e)
        {
            frmEditarReparacion vFrmReparacion = new frmEditarReparacion();
            vFrmReparacion.IdReparacion = null;
            vFrmReparacion.CargarCliente(this.idcliente +"",lbldatosnombre.Text + " Tel: " + lbldatostelefono.Text + " Cel: " 
                + lbldatoscelular.Text);
            vFrmReparacion.MdiParent = this.MdiParent;
            vFrmReparacion.VengoDeCliente = true;
            vFrmReparacion.Show();
            this.Close();
        }


        private void dgwreparaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgwreparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgwreparaciones.Rows[index];
            frmEditarReparacion vFormulario = new frmEditarReparacion();
            vFormulario.VengoDeCliente = true;
            vFormulario.IdReparacion = selectedRow.Cells["Id"].Value.ToString();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            frmRegistroLlamadas vFormulario = new frmRegistroLlamadas();
            DataGridViewRow selectedRow = dgwreparaciones.CurrentRow;
            vFormulario.Codigo = selectedRow.Cells["Orden"].Value.ToString();
            vFormulario.IdReparacion= selectedRow.Cells["Id"].Value.ToString();
            vFormulario.VengoDeCliente = true;
            vFormulario.VengoDeReparacion = false;
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes vFormulario = new Clientes();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.cliente = null;
            this.Close();
        }

        private void btneditardatos_Click_1(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.Cliente = this.cliente;
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Clientes vFormulario = new Clientes();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.cliente = null;
            this.Close();
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
           // if (lbldatosemail.Text.Trim() != "")
            //{
                FrmEnvioMailSimple vFormulario = new FrmEnvioMailSimple();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Destinatario = lbldatosemail.Text;
                vFormulario.Show();
            //}
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Utils.ExportarDataGridViewExcel(dgwCuentaCorriente,"Deuda" + lbldatosnombre.Text);
        }

        private void btnNotaCD_Click(object sender, EventArgs e)
        {
            abmNotaCD vFormulario = new abmNotaCD();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.FormularioAnterior = this;
            vFormulario.IdCliente = IdCliente;
            vFormulario.Show();
            this.Hide();
        }

        private void recargarGrillaMovimientos()
        {
            this.cliente = DaoCliente.ObtenerCliente(this.IdCliente);
            dgwCuentaCorriente.DataSource = DaoCliente.getCuentaCorrienteCliente(this.cliente.Id + "");
            dgwCuentaCorriente.AutoResizeColumns();
        }

        public void recargaGrillaMovimientosExterior()
        {
            recargarGrillaMovimientos();
        }

        private void btnAgregarService_Click(object sender, EventArgs e)
        {
            FrmService vFormulario = new FrmService();
            vFormulario.MdiParent = this.MdiParent;
            Console.WriteLine(IdCliente);
            vFormulario.CargarCliente(IdCliente + "");
            vFormulario.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
