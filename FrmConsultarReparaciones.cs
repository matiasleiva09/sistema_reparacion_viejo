using desagotes;
using desagotes.reportes;
using desagotes.sql;
using reparaciones2.dao;
using reparaciones2.ob.SMTP;
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
    public partial class FrmConsultarReparaciones : Form
    {
        private int index = 0;
        public FrmConsultarReparaciones()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String tipo_equipo = "";
            String marca = "";
            String modelo = "";
            String estado = "";

            if (cmbTipoEquipo.SelectedValue != null)
                tipo_equipo = cmbTipoEquipo.SelectedValue.ToString();
            if (cmbMarca.SelectedValue != null)
                marca = cmbMarca.SelectedValue.ToString();
            if (cmbModelo.SelectedValue != null)
                modelo = cmbModelo.SelectedValue.ToString();
            estado = cmbEstado.Text;
            dgwReparaciones.DataSource = DaoReparaciones.getReparaciones(checkTodasIngreso.Checked, dtpFechaDesdeIngreso.Text,
                dtpFechaIngresoHasta.Text, checkTodasEntrega.Checked, dtpFechaDesdeEntrega.Text, dtpFechaHastaEgreso.Text, txtidcliente.Text,
                txtidequipo.Text, txtnro.Text, estado, tipo_equipo, marca,
                modelo);
            dgwReparaciones.AutoResizeColumns();
            dgwReparaciones.Columns["Id"].Visible = false;
            dgwReparaciones.Columns["Nro Cliente"].Visible = false;
            dgwReparaciones.Columns["Nro Equipo"].Visible = false;
            dgwReparaciones.Columns["Tipo Equipo"].Visible = false;
            dgwReparaciones.Columns["Marca"].Visible = false;
            dgwReparaciones.Columns["Modelo"].Visible = false;
            dgwReparaciones.Columns["Telefono"].Visible = false;
            dgwReparaciones.Columns["Celular"].Visible = false;

            dgwReparaciones.Columns["Fecha Reparacion"].Visible = false;
            dgwReparaciones.Columns["Fecha Entregada"].Visible = false;
            dgwReparaciones.Columns["Entregado Por"].Visible = false;
            dgwReparaciones.Columns["Pago"].Visible = false;
            dgwReparaciones.Columns["Observaciones"].Visible = false;
            dgwReparaciones.Columns["Informe"].Visible = false;
            dgwReparaciones.Columns["Informe Interno"].Visible = false;
            dgwReparaciones.Columns["Reparado Por"].Visible = false;
            dgwReparaciones.Columns["Tomado Por"].Visible = false;
            dgwReparaciones.Columns["Accesorios"].Visible = false;
            dgwReparaciones.AllowUserToAddRows = false;
        }

        private void cargarComboCliente()
        {
          

        }

        private void cargarComboEquipoCliente()
        {

        }

        public String TxtIdEquipo
        {
            get { return txtidequipo.Text.ToString(); }
        }

        public void CargarEquipo(String xId,String xNombre)
        {
            txtidequipo.Text = xId;
            txtnombreequipocliente.Text = xNombre;
        }

        private void FrmConsultarReparaciones_Load(object sender, EventArgs e)
        {
            checkTodasIngreso.Checked = false;
            dtpFechaDesdeIngreso.Value = DateTime.Now;
            dtpFechaIngresoHasta.Value = DateTime.Now;
            dtpFechaHastaEgreso.Value = DateTime.Now;
            dtpFechaDesdeEntrega.Value = dtpFechaHastaEgreso.Value.AddMonths(-2);
            dtpFechaDesdeIngreso.Value= dtpFechaDesdeIngreso.Value.AddMonths(-2);
            cargarComboCliente();
            DataTable tableTipoEquipo = DAOEquipoDiccionario.getEquipos();
            DataRow rowDefaultTipoEquipo = tableTipoEquipo.NewRow();
            rowDefaultTipoEquipo["tipoequipo"] = "";
            tableTipoEquipo.Rows.InsertAt(rowDefaultTipoEquipo,0);
            cmbTipoEquipo.DataSource = tableTipoEquipo;
            cmbTipoEquipo.DisplayMember = "tipoequipo";
            cmbTipoEquipo.ValueMember = "tipoequipo";
            //cmbTipoEquipo.Text = "";

            DataTable tableMarca = DAOEquipoDiccionario.getMarcas();
            DataRow rowDefaultMarca = tableMarca.NewRow();
            rowDefaultMarca["marca"] = "";
            tableMarca.Rows.InsertAt(rowDefaultMarca, 0);
            cmbMarca.DataSource = tableMarca;
            cmbMarca.DisplayMember = "marca";
            cmbMarca.ValueMember = "marca";
            // cmbMarca.Text = "";

            DataTable tableModelo = DAOEquipoDiccionario.getModelos();
            DataRow rowDefaultModelo = tableModelo.NewRow();
            rowDefaultModelo["modelo"] = "";
            tableModelo.Rows.InsertAt(rowDefaultModelo, 0);
            cmbModelo.DataSource = tableModelo;
            cmbModelo.DisplayMember = "modelo";
            cmbModelo.ValueMember = "modelo";
            //cmbModelo.Text = "";
            cmbEstado.Items.Add("");
            cmbEstado.Items.Add("TOMADA");
            cmbEstado.Items.Add("EN REPARACION");
            cmbEstado.Items.Add("REPARADA");
            cmbEstado.Items.Add("ENTREGADA");
            dgwReparaciones.DataSource = DaoReparaciones.getReparaciones(checkTodasIngreso.Checked, dtpFechaDesdeIngreso.Text,
               dtpFechaIngresoHasta.Text, checkTodasEntrega.Checked, dtpFechaDesdeEntrega.Text, dtpFechaHastaEgreso.Text, txtidcliente.Text,
               txtidequipo.Text, txtnro.Text, "", "", "",
               "");
            dgwReparaciones.AutoResizeColumns();
            dgwReparaciones.Columns["Id"].Visible = false;
            dgwReparaciones.Columns["Nro Cliente"].Visible = false;
            dgwReparaciones.Columns["Nro Equipo"].Visible = false;
            dgwReparaciones.Columns["Tipo Equipo"].Visible = false;
            dgwReparaciones.Columns["Marca"].Visible = false;
            dgwReparaciones.Columns["Modelo"].Visible = false;
            dgwReparaciones.Columns["Telefono"].Visible = false;
            dgwReparaciones.Columns["Celular"].Visible = false;
     
            dgwReparaciones.Columns["Fecha Reparacion"].Visible = false;
            dgwReparaciones.Columns["Fecha Entregada"].Visible = false;
            dgwReparaciones.Columns["Entregado Por"].Visible = false;
            dgwReparaciones.Columns["Pago"].Visible = false;
            dgwReparaciones.Columns["Observaciones"].Visible = false;
            dgwReparaciones.Columns["Informe"].Visible = false;
            dgwReparaciones.Columns["Informe Interno"].Visible = false;
            dgwReparaciones.Columns["Reparado Por"].Visible = false;
            dgwReparaciones.Columns["Tomado Por"].Visible = false;
            dgwReparaciones.Columns["Accesorios"].Visible = false;
            //  dgwClientes.Columns["Geo"].Visible = false;
            dgwReparaciones.AllowUserToAddRows = false;
        }

        public void cargarCliente(String xId,String xCliente)
        {
            txtidcliente.Text = xId;
            txtnombrecliente.Text = xCliente;
           // txtidequipo.Text = "";
           // txtnombreequipocliente.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.FrmConsultarReparaciones = this;
            vFormulario.DeshabilitarEditar();
            vFormulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuscarEquipo vFormulario = new FrmBuscarEquipo();
            vFormulario.FrmConsultarReparaciones = this;
            vFormulario.deshabilitarBotonEditar();
            vFormulario.ShowDialog();
        }

        private void btnXCliente_Click(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
        }

        private void btnXEquipo_Click(object sender, EventArgs e)
        {
            txtidequipo.Text = "";
            txtnombreequipocliente.Text = "";
        }

        private void dgwReparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgwReparaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dgwReparaciones.Rows[index];
                frmEditarReparacion vFormulario = new frmEditarReparacion();
                vFormulario.VengoDeConsultar = true;
                vFormulario.IdReparacion = selectedRow.Cells["Id"].Value.ToString();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();  
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgwReparaciones.CurrentRow == null)
            {
                MessageBox.Show("Marca una reparación primero", "ATENCION!");
            }
            else
            {
                // MessageBox.Show(index + "");
                DataGridViewRow selectedRow = dgwReparaciones.CurrentRow;
                ReporteService vReporte = new ReporteService();
                vReporte.Fecha = desagotes.Utils.getFechaSinHora(selectedRow.Cells["Fecha Entrada"].Value.ToString());
                vReporte.NroOrden = selectedRow.Cells["Codigo"].Value.ToString();
                vReporte.Cliente = selectedRow.Cells["Nro Cliente"].Value.ToString() + "-" + selectedRow.Cells["Cliente"].Value.ToString();
                vReporte.Equipo = selectedRow.Cells["Nro Equipo"].Value.ToString()
                    + "- Tipo: " + selectedRow.Cells["Tipo Equipo"].Value.ToString()
                    + "- Marca: " + selectedRow.Cells["Marca"].Value.ToString()
                    + "- Modelo: " + selectedRow.Cells["Modelo"].Value.ToString();
                vReporte.Accesorios = selectedRow.Cells["Accesorios"].Value.ToString();
                vReporte.Problema = selectedRow.Cells["Falla"].Value.ToString();
                vReporte.Senia = "$" + selectedRow.Cells["Seña"].Value.ToString();
                vReporte.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                vReporte.Horario = DaoParametrosDatos.getParametro("HORARIO");
                vReporte.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                vReporte.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                vReporte.Leyenda = DaoParametrosDatos.getParametro("LEYENDA");
                bool vRes = ModuloSistemaDAO.habilitado("ENVIARMAIL");
                String vMail = DaoCliente.obtenerMail(selectedRow.Cells["Nro Cliente"].Value.ToString());
                if (vRes && vMail != "")
                {
                    DialogResult vResultadoDialogo = MessageBox.Show("Desea directamente enviar por mail el PDF?", "Generación de orden", MessageBoxButtons.YesNo);
                    if (vResultadoDialogo == DialogResult.Yes)
                    {
                        vReporte.crearPdf();
                        AdjuntoMail vAdjunto = new AdjuntoMail(vReporte.NombreDocumento, vReporte.NombreDocumentoCompleto);
                        List<AdjuntoMail> vAdjuntos = new List<AdjuntoMail>();
                        vAdjuntos.Add(vAdjunto);
                        String vMensaje = DaoParametrosDatos.getParametro("CUERPOMAILORDEN");
                        vMensaje = vMensaje.Replace("{xCliente}", selectedRow.Cells["Nro Cliente"].Value.ToString() + "-" + selectedRow.Cells["Cliente"].Value.ToString());
                        EnviarMail vCorreo = new EnviarMail("ORDEN DE REPARACION", vMail, "", "", vMensaje, vAdjuntos);
                        vCorreo.Enviar();
                        vCorreo = null;
                        vAdjuntos = null;
                        vAdjunto = null;
                        vReporte = null;
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(vReporte.crearPdf());
                    }
                }
                else
                {
                    System.Diagnostics.Process.Start(vReporte.crearPdf());
                }
            }
          
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BuscarDesdeAfuera(DataTable xDatos)
        {
            dgwReparaciones.DataSource = xDatos;
            dgwReparaciones.AutoResizeColumns();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(txtfiltro.Text!="")
            {
                dgwReparaciones.DataSource = DaoReparaciones.getReparaciones(txtfiltro.Text);
                dgwReparaciones.AutoResizeColumns();
            }
            else
            {
                dgwReparaciones.DataSource = DaoReparaciones.getReparaciones(checkTodasIngreso.Checked, dtpFechaDesdeIngreso.Text,
            dtpFechaIngresoHasta.Text, checkTodasEntrega.Checked, dtpFechaDesdeEntrega.Text, dtpFechaHastaEgreso.Text, txtidcliente.Text,
            txtidequipo.Text, txtnro.Text, "", "", "",
            "");
                dgwReparaciones.AutoResizeColumns();
            }
          
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            dgwReparaciones.DataSource = DaoReparaciones.getReparaciones(checkTodasIngreso.Checked, dtpFechaDesdeIngreso.Text,
             dtpFechaIngresoHasta.Text, checkTodasEntrega.Checked, dtpFechaDesdeEntrega.Text, dtpFechaHastaEgreso.Text, txtidcliente.Text,
             txtidequipo.Text, txtnro.Text, "", "", "",
             "");
            dgwReparaciones.AutoResizeColumns();
            txtfiltro.Text = "";
        }

        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            frmRegistroLlamadas vFormulario = new frmRegistroLlamadas();
            DataGridViewRow selectedRow = dgwReparaciones.CurrentRow;
            if(selectedRow!=null)
            {
              //  vFormulario.Codigo = selectedRow.Cells["Codigo"].Value.ToString();
                vFormulario.Codigo = selectedRow.Cells["Id"].Value.ToString();
                vFormulario.IdReparacion = selectedRow.Cells["Id"].Value.ToString();
                vFormulario.VengoDeCliente = false;
                vFormulario.VengoDeReparacion = true;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione primero una reparación", "Atención!");
            }

        }

        private void btnGenerarRecibo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwReparaciones.CurrentRow;
            if(selectedRow!=null )
            {
                float vCosto = float.Parse(selectedRow.Cells["Costo"].Value.ToString());
                float vMontoPagado = float.Parse(selectedRow.Cells["Pago"].Value.ToString());
                if (selectedRow.Cells["Estado"].Value.ToString() == "ENTREGADA" &&
                    (vCosto > vMontoPagado) || selectedRow.Cells["Estado"].Value.ToString() != "ENTREGADA")
                {
                    FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                    String vIdReparacion = selectedRow.Cells["Id"].Value.ToString();
                    vFormulario.NroReparacion = selectedRow.Cells["Id"].Value.ToString();
                    vFormulario.IdCliente = selectedRow.Cells["Nro Cliente"].Value.ToString();
                    vFormulario.IdReparacion = vIdReparacion;
                    vFormulario.Cliente = selectedRow.Cells["Nro Cliente"].Value.ToString() + "-" + selectedRow.Cells["Cliente"].Value.ToString(); ;
                    vFormulario.ReporteOrdenReparacion = null;
                    vFormulario.EntregaReporte = null;
                    vFormulario.VengoDe = "ConsultarReparaciones";
                    vFormulario.MdiParent = this.MdiParent;
                    float vMonto = float.Parse(selectedRow.Cells["Costo"].Value.ToString()) -
                        float.Parse(selectedRow.Cells["Seña"].Value.ToString());
                    vFormulario.Monto = vMonto + "";
                    vFormulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede generar un ingreso por una orden que ya está paga y entregada.", "Atención!");
                }
               
            }
            else
            {
                MessageBox.Show("Tiene que elegir una orden para generar recibos.","Atención!");
            }
            
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void txtnro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, new EventArgs());
            }
        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltrar_Click(sender, new EventArgs());
            }
        }

        private void txtnro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
          /*  if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneditardatos_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwReparaciones.CurrentRow;
            frmEditarReparacion vFormulario = new frmEditarReparacion();
            vFormulario.VengoDeConsultar = true;
            vFormulario.IdReparacion = selectedRow.Cells["Id"].Value.ToString();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Utils.ExportarDataGridViewExcel(dgwReparaciones, "Consulta de reparaciones");
        }
    }
}
