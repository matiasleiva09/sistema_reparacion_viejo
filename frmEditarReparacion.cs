using desagotes;
using desagotes.reportes;
using reparaciones2.dao;
using reparaciones2.Insumos;
using reparaciones2.ob;
using reparaciones2.ob.caja;
using reparaciones2.ob.reparaciones;
using reparaciones2.ob.SMTP;
using reparaciones2.reportes;
using reparaciones2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class frmEditarReparacion : Form
    {
        private String idreparacion = null;
        private bool vengoDeConsultar = false;
        private DataRow reparacion = null;
        private String estadoAnterior = "";
        private bool vengoDeCliente = false;
        private List<Image> mImagenes = new List<Image>();
        private long mCantidadAnteriorTarifa = 0;

        public List<Image> Imagenes
        {
            get { return mImagenes; }
            set { mImagenes = value; }
        }

        public String IdEquipo()
        {
            if (txtidequipo.Text != "")
                return txtidequipo.Text;
            else
                return "";
        }

        public bool VengoDeCliente
        {
            get { return vengoDeCliente; }
            set { vengoDeCliente = value; }
        }

        public bool VengoDeConsultar            
        {
            get { return vengoDeConsultar; }
            set { vengoDeConsultar = value; }
        }

        public String IdReparacion
        {
            get { return idreparacion; }
            set { idreparacion = value; }
        }

        public String TxtIdCliente()
        {
            return txtidcliente.Text.ToString();
        }

        public void CargarCliente(String xIdCliente,String xNombre)
        {
            txtidcliente.Text = xIdCliente;
            txtnombrecliente.Text = xNombre;
            txtidequipo.Text = "";
            txtNombreEquipo.Text = "";
        }

        public void CargarEquipo(String xIdEquipo, String xNombre)
        {
            txtidequipo.Text = xIdEquipo;
            txtNombreEquipo.Text = xNombre;
        }

        public frmEditarReparacion()
        {
            InitializeComponent();
            bool vMandarMail = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if (!vMandarMail)
                btnmail.Enabled = false;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMontoReparacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMontoSenia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CargarGrillaTarifa()
        {
            long vIdReparacion = long.Parse(IdReparacion);
            dgwTarifa.DataSource = DaoItemReparacion.ObtenerItemDeReparacion(vIdReparacion);
            dgwTarifa.Columns["Id"].Visible = false;
            dgwTarifa.Columns["Tarifa"].Visible = false;
            dgwTarifa.Columns["Insumo"].Visible = false;
          //  dgwTarifa.Columns["Recibo"].Visible = false;
            dgwTarifa.Columns["Descripcion"].ReadOnly = true;
            dgwTarifa.Columns["Descripcion"].HeaderText = "Descripción";
            dgwTarifa.Columns["Monto"].ReadOnly = true;
        }

        private void frmEditarReparacion_Load(object sender, EventArgs e)
        {
            
            UtilidadesComunes.cargarComboEstadosReparacion(cmbEstado);
            UtilidadesComunes.cargarComboUsuario(cmbTomadoPor);
            UtilidadesComunes.cargarComboUsuario(cmbArregladoPor);
            UtilidadesComunes.cargarComboUsuario(cmbEntregadoPor);
            txtMontoReparacion.Enabled = false;
            txtmontoSenia.Enabled = false;
            if (IdReparacion == null)
            {
                txtEntregadoA.Enabled = false;
                txtInformeSolucion.Enabled = false;
                txtinformeinterno.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaFinalizacion.Enabled = false;
                cmbArregladoPor.Enabled = false;
                cmbEntregadoPor.Enabled = false;
                cmbTomadoPor.Enabled = true;
              //  txtMontoReparacion.Enabled = false;
                cmbEstado.SelectedIndex = 0;
                cmbEstado.Enabled = false;
                //  lbldatoNroOrden.Text = DAOParametros.getObtenerProximoValorReparacion();
                lbldatoNroOrden.Visible = false;
                lblNroOrden.Visible = false;
                btnLlamadas.Enabled = false;
                //btnPresupuesto.Enabled = false;
                btnmail.Enabled = false;
                tabTarifa.Enabled = false;
                txtmontoSenia.Enabled = true;
            }
            else
            {
                dtFechaIngreso.Enabled = false;
                cmbTomadoPor.Enabled = false;
                btnAgregarCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                btnXCliente.Enabled = false;
                btnAgregarEquipo.Enabled = false;
                btnBuscarEquipo.Enabled = false;
                BtnXEquipo.Enabled = false;
                btnEditarEquipo.Enabled = false;
                btnEditarCliente.Enabled = false;
                txtEntregadoA.Enabled = false;
                txtInformeSolucion.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaFinalizacion.Enabled = false;
                cmbArregladoPor.Enabled = false;
                cmbEntregadoPor.Enabled = false;
             //   txtMontoReparacion.Enabled = false;
                txtinformeinterno.Enabled = false;
                reparacion = DaoReparaciones.getReparacion(long.Parse(IdReparacion));
                estadoAnterior = reparacion["estado"].ToString();
                chkgarantia.Checked = Boolean.Parse(reparacion["En Garantia"].ToString());
                txtobservaciones.Text = reparacion["Observaciones"].ToString();
                txtinformeinterno.Text = reparacion["Informe Interno"].ToString();
                dtFechaIngreso.Text = reparacion["Fecha Entrada"].ToString();
                //  lbldatoNroOrden.Text = reparacion["Codigo"].ToString();
                lbldatoNroOrden.Text = IdReparacion;
                cmbTomadoPor.SelectedValue = reparacion["Tomado por"];
                cmbEstado.Text = reparacion["Estado"].ToString().Trim();
                txtAccesorios.Text = reparacion["Accesorios"].ToString();
                txtFalla.Text = reparacion["Falla"].ToString();
                txtInformeSolucion.Text = reparacion["Informe"].ToString();
                txtmontoSenia.Text = reparacion["Seña"].ToString();
                txtMontoReparacion.Text = reparacion["Costo"].ToString();
                txtidcliente.Text = reparacion["Nro Cliente"].ToString();
                txtnombrecliente.Text = reparacion["Cliente"].ToString() + " Tel: " + reparacion["Telefono"]
                    + " Cel: " + reparacion["celular"];
                txtidequipo.Text = reparacion["Nro Equipo"].ToString();
                txtNombreEquipo.Text = "Tipo: " + reparacion["Tipo Equipo"] + " - Marca: " + reparacion["Marca"] +
                    " - Modelo: " + reparacion["Modelo"];
                cmbArregladoPor.SelectedValue = reparacion["Reparado Por"];
                cmbEntregadoPor.SelectedValue = reparacion["Entregado Por"];
                if (reparacion["Fecha Reparacion"] != null && reparacion["Fecha Reparacion"].ToString() != "")
                    dtFechaFinalizacion.Text = reparacion["Fecha Reparacion"].ToString();

                if (reparacion["Fecha Entregada"] != null && reparacion["Fecha Entregada"].ToString() != "")
                    dtFechaEntrega.Text = reparacion["Fecha Entregada"].ToString();
                if (reparacion["Estado"].ToString() != "TOMADA" && reparacion["Estado"].ToString()!="ENTREGADA")
                {
                    btnAgregarTarifa.Enabled = true;
                    btnBorrarTarifa.Enabled = true;
                    //btnCobrarTarifa.Enabled = true;
                    CargarGrillaTarifa();
                }
                else
                {
                    btnAgregarTarifa.Enabled = false;
                    btnBorrarTarifa.Enabled = false;
                   // btnCobrarTarifa.Enabled = false;
                    if (reparacion["Estado"].ToString() == "ENTREGADA")
                    {
                        CargarGrillaTarifa();
                    }
                }

                if(reparacion["Estado"].ToString()=="EN REPARACION")
                {
                    cmbEstado.Items.Remove("TOMADA");
                    txtEntregadoA.Enabled = false;
                    txtInformeSolucion.Enabled = false;
                    dtFechaEntrega.Enabled = false;
                    dtFechaFinalizacion.Enabled = false;
                    cmbArregladoPor.Enabled = false;
                    cmbEntregadoPor.Enabled = false;
                    txtMontoReparacion.Enabled = false;
                    cmbEstado.Enabled = true;
                    txtFalla.Enabled = true;
                    txtAccesorios.Enabled = true;
                    //txtmontoSenia.Enabled = true;
                    txtInformeSolucion.Enabled = true;
                    txtinformeinterno.Enabled = true;
                    tabDatos.SelectedTab = tabDatosArreglo;
                }

                if (reparacion["Estado"].ToString() == "ENTREGADA")
                {
                    cmbEstado.Items.Remove("TOMADA");
                    cmbEstado.Items.Remove("EN REPARACION");
                    cmbEstado.Items.Remove("REPARADA");
                    txtEntregadoA.Enabled = false;
                    txtInformeSolucion.Enabled = false;
                    dtFechaEntrega.Enabled = false;
                    dtFechaFinalizacion.Enabled = false;
                    cmbArregladoPor.Enabled = false;
                    cmbEntregadoPor.Enabled = false;
                    txtMontoReparacion.Enabled = false;
                    cmbEstado.SelectedIndex = 0;
                    cmbEstado.Enabled = false;
                    txtFalla.Enabled = false;
                    txtAccesorios.Enabled = false;
                    txtmontoSenia.Enabled = false;
                    btnCapturar.Enabled = false;
                    txtobservaciones.Enabled = false;
                    txtinformeinterno.Enabled = false;
                    btnLlamadas.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                else if(reparacion["Estado"].ToString() == "REPARADA")
                {
                    cmbEstado.Items.Remove("TOMADA");
                    cmbEstado.Items.Remove("EN REPARACION");
                    cmbArregladoPor.Enabled = true;
                    dtFechaFinalizacion.Enabled = true;
                    //txtMontoReparacion.Enabled = true;
                    txtinformeinterno.Enabled = true;
                    tabDatos.SelectedTab = tabDatosArreglo;
                }

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.FrmEditarReparacion = this;
            vFormulario.ShowDialog();
        }

        private void btnXCliente_Click(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
            txtidequipo.Text = "";
            txtNombreEquipo.Text = "";
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.FrmReparacion = this;
            vFormulario.ShowDialog();
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            if(txtidcliente.Text!="")
            {
                DataTable vRes =DaoEquipo.EquiposDeCliente(long.Parse(txtidcliente.Text));
                if (vRes.Rows.Count > 0)
                {
                    FrmBuscarEquipo vFormulario = new FrmBuscarEquipo();
                    vFormulario.FrmEditarReparacion = this;
                    vFormulario.ShowDialog();
                }
                else
                    MessageBox.Show("El cliente no tiene ningún equipo para seleccionar","ATENCION!");
               
            }
            else
            {
                MessageBox.Show("Debe elegir primero un cliente","ATENCIÓN!");
            }
        }

        private void BtnXEquipo_Click(object sender, EventArgs e)
        {
            txtidequipo.Text = "";
            txtNombreEquipo.Text = "";
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            if(txtidcliente.Text!="")
            {
                FrmEditarEquipoCliente vFormulario = new FrmEditarEquipoCliente();
                vFormulario.Cliente = DaoCliente.ObtenerCliente(long.Parse(txtidcliente.Text.ToString()));
                vFormulario.FrmEditarReparacion = this;
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe elegir primero un cliente", "ATENCIÓN!");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (VengoDeCliente)
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.IdCliente = long.Parse(txtidcliente.Text);
                vFormulario.Show();
            }
            else if (VengoDeConsultar)
            {
                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
            }
            this.Close();
        }

        private String ArregladoPor()
        {
            String vResultado = "";
            if (cmbArregladoPor.SelectedValue == null)
                vResultado = cmbArregladoPor.Text;
            else
                vResultado = cmbArregladoPor.SelectedValue.ToString();
            return vResultado;
        }

        private String EntregadoPor()
        {
            String vResultado = "";
            if (cmbEntregadoPor.SelectedValue == null)
                vResultado = cmbEntregadoPor.Text;
            else
                vResultado = cmbEntregadoPor.SelectedValue.ToString();
            return vResultado;
        }

        private String TomadoPor()
        {
            String vResultado = "";
            if (cmbTomadoPor.SelectedValue == null)
                vResultado = cmbTomadoPor.Text;
            else
                vResultado = cmbTomadoPor.SelectedValue.ToString();
            return vResultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            String estado = "";
            if (cmbEstado.SelectedValue == null)
                estado = cmbEstado.Text;
            else
                estado = cmbEstado.SelectedValue.ToString();
            if (idreparacion == null)
            {
                if (TomadoPor() == "" || txtFalla.Text.Trim() == "" ||
                    (!Utils.isNumeric(txtmontoSenia.Text))
                    || (txtidcliente.Text == "" || txtidequipo.Text == ""))
                {
                    MessageBox.Show("Debe ingresar los campos obligatorios para continuar!!!", "ATENCION!!");
                }
                else
                {
                    FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
                    vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
                    vFormularioProgreso.Show();
                    this.Enabled = false;
                    DaoReparaciones.guardar( txtidcliente.Text, txtidequipo.Text,
                        dtFechaIngreso.Text, txtAccesorios.Text, txtFalla.Text, cmbTomadoPor.Text, txtmontoSenia.Text, estado,
                        txtobservaciones.Text,txtinformeinterno.Text,chkgarantia.Checked);
                    long vIdReparacion = DaoReparaciones.getIdPorDatos(dtFechaIngreso.Text,txtAccesorios.Text, txtFalla.Text, txtmontoSenia.Text,
                        Estado(),  txtobservaciones.Text,TomadoPor(), chkgarantia.Checked);
                    vFormularioProgreso.Barra.Value = 10;
                    Console.WriteLine(vIdReparacion);
                   // DAOParametros.ActualizarParametroOrdenReparacion(lbldatoNroOrden.Text);
                    vFormularioProgreso.Barra.Value += 20;
                    /*  if (this.VengoDeConsultar)
                      {
                          FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                          vFormulario.MdiParent = this.MdiParent;
                          vFormulario.Show();

                      }*/
                    if(mImagenes!=null && mImagenes.Count > 0)
                    {
                        // long vIdReparacion =long.Parse(DaoReparaciones.ObtenerIdDeNroDeOrden(lbldatoNroOrden.Text)["idreparacion"].ToString());
                      
                        for (int vI=0;vI<mImagenes.Count;vI++)
                        {
                            string ruta = Path.Combine(Utils.ObtenerPathDOCS(), mImagenes[vI].Tag.ToString());
                            mImagenes[vI].Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                            DaoFotosReparacion.GuardarFoto(vIdReparacion, mImagenes[vI].Tag.ToString());
                        }
                        vFormularioProgreso.Barra.Value += 20;
                    }
                    ReporteService vFormImprimir = new ReporteService();
                    vFormImprimir.Fecha = desagotes.Utils.getFechaSinHora(dtFechaIngreso.Text);
                    vFormImprimir.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                    vFormImprimir.Equipo = txtidequipo.Text + "-" + txtNombreEquipo.Text;
                    vFormImprimir.Accesorios = txtAccesorios.Text;
                    vFormImprimir.Problema = txtFalla.Text;
                    vFormImprimir.Senia = "$" + txtmontoSenia.Text;
                    // vFormImprimir.NroOrden = lbldatoNroOrden.Text;
                    vFormImprimir.NroOrden = vIdReparacion + "";
                    vFormImprimir.Leyenda = DaoParametrosDatos.getParametro("LEYENDA");
                    vFormImprimir.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                    vFormImprimir.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                    vFormImprimir.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                    vFormImprimir.Horario = DaoParametrosDatos.getParametro("HORARIO");
                    vFormularioProgreso.Barra.Value += 20;
                    float vMonto = float.Parse(txtmontoSenia.Text);
                    if (vMonto > 0)
                    {
                        FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                        //  String vIdReparacion = DaoReparaciones.ObtenerIdDeNroDeOrden(lbldatoNroOrden.Text)["idreparacion"].ToString();
                        // vFormulario.NroReparacion = lbldatoNroOrden.Text;
                        vFormulario.NroReparacion = vIdReparacion + "";
                        vFormulario.IdCliente = txtidcliente.Text;
                        vFormulario.IdReparacion = vIdReparacion + "";
                        
                        vFormulario.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                        vFormulario.ReporteOrdenReparacion= vFormImprimir;
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Monto = vMonto + "";
                        String vMailCliente = DaoCliente.obtenerMail(txtidcliente.Text);
                        vFormulario.EmailCliente = vMailCliente;
                        vFormularioProgreso.Barra.Value =100;
                        vFormularioProgreso.Close();
                        vFormulario.Show();
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(vFormImprimir.crearPdf());
                        vFormularioProgreso.Barra.Value += 10;
                        String vMailCliente = DaoCliente.obtenerMail(txtidcliente.Text);
                        if(vMailCliente!=null && vMailCliente.Trim()!="")
                             this.mandarMail(txtnombrecliente.Text, vMailCliente, "ORDEN DE REPARACION", vFormImprimir.NombreDocumento, vFormImprimir.NombreDocumentoCompleto);
                        vFormularioProgreso.Barra.Value += 10;
                        vFormularioProgreso.Close();
                        if (VengoDeCliente)
                        {
                            FrmAdminContacto vFormulario = new FrmAdminContacto();
                            vFormulario.MdiParent = this.MdiParent;
                            vFormulario.IdCliente = long.Parse(txtidcliente.Text);
                            vFormulario.Show();
                        }
                    }
                   
                    this.Close();
                }
            }
            else
            {
                if (!Utils.isNumeric(txtmontoSenia.Text) || (!Utils.isNumeric(txtMontoReparacion.Text) && txtMontoReparacion.Enabled)
                    || (ArregladoPor()=="" && cmbArregladoPor.Enabled) ||
                     (txtEntregadoA.Text == "" && txtEntregadoA.Enabled) ||
                     (EntregadoPor() == "" && cmbEntregadoPor.Enabled) || Estado()=="")
                {
                    MessageBox.Show("Debe ingresar los campos obligatorios para continuar!!!", "ATENCION!!");
                }
                else
                {
                    if(Estado()!="ENTREGADA")
                    {
                        FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
                        vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
                        vFormularioProgreso.Show();
                        vFormularioProgreso.Barra.Value = 30;
                        Cliente vCliente = DaoCliente.ObtenerCliente(long.Parse(txtidcliente.Text.ToString()));
                       // mandarMail(Estado(), estadoAnterior, vCliente.Nombre, vCliente.Email, "Estado de Reparación", "ESTAMOS TRABAJANDO EN TU MAQUINA");
                        vFormularioProgreso.Barra.Value = 50;
                
                        DaoReparaciones.Editar(IdReparacion, txtAccesorios.Text, txtFalla.Text, txtmontoSenia.Text, txtMontoReparacion.Text,
                  ObtenerFechaEntrega(), ObtenerFechaReparacion(), ArregladoPor(),
                  EntregadoPor(), Estado(), txtInformeSolucion.Text,txtobservaciones.Text,txtinformeinterno.Text,txtEntregadoA.Text.Trim(),chkgarantia.Checked);
                      
                        if (VengoDeCliente)
                        {
                            FrmAdminContacto vFormulario = new FrmAdminContacto();
                            vFormulario.MdiParent = this.MdiParent;
                            vFormulario.IdCliente = long.Parse(txtidcliente.Text);
                            vFormularioProgreso.Barra.Value = 100;
                            vFormularioProgreso.Close();
                            vFormulario.Show();
                        }
                        else if(VengoDeConsultar)
                        {
                            FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                            vFormulario.MdiParent = this.MdiParent;
                            vFormularioProgreso.Barra.Value = 100;
                            vFormularioProgreso.Close();
                            vFormulario.Show(); 
                        }
                        this.Close();
                    }
                    else
                    {
                        if (estadoAnterior!= "ENTREGADA" && estadoAnterior !="")
                        {
                            FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
                            vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
                            vFormularioProgreso.Show();
                           
                            vFormularioProgreso.Barra.Value = 10;
                            Console.WriteLine(dtFechaEntrega.Enabled);
                            DaoReparaciones.Editar(IdReparacion, txtAccesorios.Text, txtFalla.Text, txtmontoSenia.Text, txtMontoReparacion.Text,
                  ObtenerFechaEntrega(), ObtenerFechaReparacion(), ArregladoPor(),
                  EntregadoPor(), Estado(),txtInformeSolucion.Text,txtobservaciones.Text,txtinformeinterno.Text,
                  txtEntregadoA.Text.Trim(),chkgarantia.Checked);
                            this.Enabled = false;
                            vFormularioProgreso.Barra.Value = 30;
                            ReporteEntrega vFormImprimir = new ReporteEntrega();
                            //  DateTime vFechaActual = new DateTime();
                            vFormImprimir.Fecha = dtFechaEntrega.Text;
                            vFormImprimir.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                            vFormImprimir.Equipo = txtidequipo.Text + "-" + txtNombreEquipo.Text;
                            vFormImprimir.Accesorios = txtAccesorios.Text;
                            vFormImprimir.Problema = txtFalla.Text;
                            vFormImprimir.Senia = txtmontoSenia.Text;
                            vFormImprimir.NroOrden = lbldatoNroOrden.Text;
                            vFormImprimir.Retira = txtEntregadoA.Text;
                            vFormImprimir.Solucion = txtInformeSolucion.Text;
                            vFormImprimir.MontoReparacion = txtMontoReparacion.Text;
                            //vFormImprimir.Diferencia = "$" + (Double.Parse(txtMontoReparacion.Text) - Double.Parse(txtmontoSenia.Text)).ToString();
                            vFormImprimir.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                            vFormImprimir.Horario = DaoParametrosDatos.getParametro("HORARIO");
                            vFormImprimir.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                            vFormImprimir.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                            vFormImprimir.Leyenda = DaoParametrosDatos.getParametro("LEYENDA");
                            float vMontoRestante = float.Parse(txtMontoReparacion.Text) - float.Parse(txtmontoSenia.Text);
                            vFormularioProgreso.Barra.Value = 100;
                            vFormularioProgreso.Close();
                            if (vMontoRestante > 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("Desea imprimir un Recibo?", "Generación de recibo", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                                    vFormulario.NroReparacion = lbldatoNroOrden.Text;
                                    vFormulario.IdCliente = txtidcliente.Text;
                                    vFormulario.IdReparacion = IdReparacion;
                                    vFormulario.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                                    vFormulario.EntregaReporte = vFormImprimir;
                                    vFormulario.MdiParent = this.MdiParent;
                                    vFormulario.Monto = vMontoRestante + "";
                                    vFormulario.Show();
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    System.Diagnostics.Process.Start(vFormImprimir.crearPdf());
                                }
                            }
                            else
                            {
                                System.Diagnostics.Process.Start(vFormImprimir.crearPdf());
                            }
                           
                           this.Close();
                        }
                        else
                        {
                            if (VengoDeCliente)
                            {
                                FrmAdminContacto vFormulario = new FrmAdminContacto();
                                vFormulario.MdiParent = this.MdiParent;
                                vFormulario.IdCliente = long.Parse(txtidcliente.Text);
                                vFormulario.Show();
                            }
                            else if (VengoDeConsultar)
                            {
                                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                                vFormulario.MdiParent = this.MdiParent;
                                vFormulario.Show();
                            }
                            this.Close();
                        }
                    }
                    
                }
               
               
            }
        }

        private String ObtenerFechaReparacion()
        {
            Console.WriteLine(dtFechaFinalizacion.Enabled);
            if (dtFechaFinalizacion.Enabled)
                return dtFechaFinalizacion.Text;
            else
                return "";
        }

        private String ObtenerFechaEntrega()
        {
            Console.WriteLine(dtFechaEntrega.Enabled);
            if (dtFechaEntrega.Enabled)
                return dtFechaEntrega.Text;
            else
                return "";
        }

        private String Estado()
        {
            String estado = "";
            if (cmbEstado.SelectedValue == null)
                estado = cmbEstado.Text;
            else
                estado = cmbEstado.SelectedValue.ToString();
            return estado;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Estado()=="REPARADA")
            {
                cmbArregladoPor.Enabled = true;
                dtFechaFinalizacion.Enabled = true;
                txtInformeSolucion.Enabled = true;
              //  txtMontoReparacion.Enabled = true;
                cmbEntregadoPor.Enabled = false;
                txtEntregadoA.Enabled = false;
                dtFechaEntrega.Enabled = false;
                txtinformeinterno.Enabled = true;
                tabDatos.SelectedTab=tabDatosArreglo;
                btnAgregarTarifa.Enabled = true;
                btnBorrarTarifa.Enabled = true;
                //btnCobrarTarifa.Enabled = true;
                CargarGrillaTarifa();

            }
            else if(Estado()=="EN REPARACION")
            {
                cmbArregladoPor.Enabled = false;
                cmbEntregadoPor.Enabled = false;
                cmbTomadoPor.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaFinalizacion.Enabled = false;
                dtFechaIngreso.Enabled = false;
                dtFechaEntrega.Enabled = false;
                txtMontoReparacion.Enabled = false;
                txtEntregadoA.Enabled = false;
                txtInformeSolucion.Enabled = true;
                txtinformeinterno.Enabled = true;
                tabDatos.SelectedTab = tabDatosArreglo;
                btnAgregarTarifa.Enabled = true;
                btnBorrarTarifa.Enabled = true;
                //btnCobrarTarifa.Enabled = true;
                CargarGrillaTarifa();
            }
            else if(Estado()=="TOMADA" && idreparacion!=null)
            {
                cmbArregladoPor.Enabled = false;
                cmbEntregadoPor.Enabled = false;
                cmbTomadoPor.Enabled = false;
                dtFechaEntrega.Enabled = false;
                dtFechaFinalizacion.Enabled = false;
                dtFechaIngreso.Enabled = false;
                dtFechaEntrega.Enabled = false;
                txtMontoReparacion.Enabled = false;
                txtEntregadoA.Enabled = false;
                txtInformeSolucion.Enabled = false;
                tabDatos.SelectedTab = tabTomaEquipo;
                btnAgregarTarifa.Enabled = false;
                btnBorrarTarifa.Enabled = false;
                //btnCobrarTarifa.Enabled = true;
                CargarGrillaTarifa();
            }
            else if(Estado()=="ENTREGADA")
            {
                cmbArregladoPor.Enabled = true;
                dtFechaFinalizacion.Enabled = true;
                cmbEntregadoPor.Enabled = true;
                dtFechaEntrega.Enabled = true;
                txtInformeSolucion.Enabled = true;
             //   txtMontoReparacion.Enabled = true;
                txtEntregadoA.Enabled = true;
                txtinformeinterno.Enabled = true;
                tabDatos.SelectedTab = tabDatosEntrega;
                btnAgregarTarifa.Enabled = true;
                btnBorrarTarifa.Enabled = true;
                //btnCobrarTarifa.Enabled = true;
                CargarGrillaTarifa();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            FrmCamara vFormulario = new FrmCamara();
            vFormulario.FormularioReparacion = this;
            // vFormulario.NroOrden = lbldatoNroOrden.Text;
            if (IdReparacion != null && IdReparacion != "")
                vFormulario.Reparacion = long.Parse(IdReparacion);
            else if (mImagenes != null && mImagenes.Count > 0)
                vFormulario.mListaImagenes = mImagenes;
            vFormulario.ShowDialog();

        }

        private void lblFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GuardarCambiosGrillaTarifa()
        {
            ItemInsumoTarifa vItem = null;
            int i = 0;
            int limite = dgwTarifa.Rows.Count - 1;
            double vMontoGrilla = 0.00;
            while (i <= limite)
            {
                    
                vItem = new ItemInsumoTarifa();
                if (dgwTarifa.Rows[i].Cells["Tarifa"].Value != null && dgwTarifa.Rows[i].Cells["Tarifa"].Value.ToString() != "")
                    vItem.Tarifa = DaoTarifa.obtenerTarifa(long.Parse(dgwTarifa.Rows[i].Cells["Tarifa"].Value.ToString()));
                if (dgwTarifa.Rows[i].Cells["Insumo"].Value != null && dgwTarifa.Rows[i].Cells["Insumo"].Value.ToString() != "")
                    vItem.Articulo = DaoArticulo.ObtenerPorId(long.Parse(dgwTarifa.Rows[i].Cells["Insumo"].Value.ToString()));
                vItem.Cantidad = int.Parse(dgwTarifa.Rows[i].Cells["Cantidad"].Value.ToString());
                vItem.Total = double.Parse(dgwTarifa.Rows[i].Cells["Monto"].Value.ToString());
                vMontoGrilla += vItem.Total;
                if (dgwTarifa.Rows[i].Cells["Id"].Value !=null && dgwTarifa.Rows[i].Cells["Id"].Value.ToString()!="")
                   vItem.Id = long.Parse(dgwTarifa.Rows[i].Cells["Id"].Value.ToString());
                vItem.Reparacion = DaoReparaciones.getReparacionObj(long.Parse(this.IdReparacion));
                double vNeto = 0.00;
                double vIva = 0.00;
                if(vItem.Tarifa!=null)
                {
                    vNeto = Math.Round(vItem.Total - (vItem.Total * 0.21),2);
                    vIva = Math.Round(vItem.Total *0.21);  
                }
                else
                {
                    vNeto = Math.Round(vItem.Total - (vItem.Total * (vItem.Articulo.Iva
                         /100)), 2);
                    vIva = Math.Round(vItem.Total * (vItem.Articulo.Iva
                         / 100));
                   
                }
                vItem.Neto = vNeto;
                vItem.Iva = vIva;
                if (vItem.Id > 0)
                {
                    DaoItemReparacion.Editar(vItem);
                    if(vItem.Articulo!=null)
                        DaoArticulo.ActualizarStock(vItem.Articulo.Id, vItem.Cantidad, mCantidadAnteriorTarifa);
                    
                }    
                else
                {
                    DaoItemReparacion.Guardar(vItem);
                    if(vItem.Articulo!=null)
                        DaoArticulo.ActualizarStock(vItem.Articulo.Id, 1, 1);
                    long vId = DaoItemReparacion.ObtenerId(vItem);
                    Console.WriteLine(vId);
                    dgwTarifa.Rows[i].Cells["Id"].Value = vId;
                }
                  
                i++;
                vItem = null;
            }
            txtMontoReparacion.Text = vMontoGrilla + "";
        }

        public void AgregarItem(DataGridViewRow xItem)
        {
            //id,cantidad,idtarifa,idinsumo,descripcion,monto
           // int rowEscribir = dgwTarifa.Rows.Count - 1;
            //if (rowEscribir < 0)
              //  rowEscribir = 0;
            bool vExiste =false;
            if (xItem.Cells["idp"].Value != null && xItem.Cells["idp"].Value.ToString() != "")
                vExiste = ExisteItem(xItem.Cells["idp"].Value.ToString(),"PRODUCTO");
            else
                vExiste = ExisteItem(xItem.Cells["idt"].Value.ToString(), "TARIFA");
            if (!vExiste)
            {
                DataTable dataTable = (DataTable)dgwTarifa.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                
                drToAdd["Cantidad"] = 1;
                drToAdd["Id"] = 0;
                if (xItem.Cells["idt"].Value.ToString() != "" && xItem.Cells["idt"].Value.ToString() != "null")
                {
                    drToAdd["Tarifa"] = long.Parse(xItem.Cells["idt"].Value.ToString());
                   // DaoArticulo.ActualizarStock(long.Parse(xItem.Cells["co"].Value.ToString()),1);
                }
                    
                /*else
                    drToAdd["Tarifa"] = 0;*/
                if (xItem.Cells["idp"].Value.ToString() != "" && xItem.Cells["idp"].Value.ToString() != "null")
                    drToAdd["Insumo"] = xItem.Cells["idp"].Value.ToString();
              /*  else
                    drToAdd["Insumo"] = 0;*/
                drToAdd["Descripcion"] = xItem.Cells["descripcion"].Value.ToString();
                drToAdd["Monto"] = double.Parse(xItem.Cells["monto"].Value.ToString());
                double vMonto = double.Parse(txtMontoReparacion.Text.ToString());
                vMonto += double.Parse(xItem.Cells["monto"].Value.ToString());
                txtMontoReparacion.Text = vMonto + "";
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
               
            }
            GuardarCambiosGrillaTarifa();
        }

        private bool ExisteItem(string xId,string xTipo)
        {

            bool vRes = false;
            int i = 0;
            int limite = dgwTarifa.Rows.Count - 1;
            while (i < limite && !vRes)
            {
                if(xTipo=="TARIFA")
                {
                    if (dgwTarifa.Rows[i].Cells["Tarifa"].Value.ToString() == xId)
                        vRes = true;
                }
                else
                {
                    if (dgwTarifa.Rows[i].Cells["Insumo"].Value.ToString() == xId)
                        vRes = true;
                }
              
                i++;
            }
            return vRes;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text != null && txtidcliente.Text.Trim() != "")
            {
                long vIdCliente = long.Parse(txtidcliente.Text);
                FrmEditarCliente vFormulario = new FrmEditarCliente();
                vFormulario.FrmReparacion = this;
                vFormulario.Cliente = DaoCliente.ObtenerCliente(vIdCliente);
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingregar un cliente antes de editarlo.","Atención!");
            }
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VengoDeCliente)
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.IdCliente = long.Parse(txtidcliente.Text);
                vFormulario.Show();
            }
            else if (VengoDeConsultar)
            {
                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
            }
            this.Close();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (txtidequipo.Text!="")
            {
                FrmEditarEquipoCliente vFormulario = new FrmEditarEquipoCliente();
                vFormulario.Cliente = DaoCliente.ObtenerCliente(long.Parse(txtidcliente.Text.ToString()));
                vFormulario.EquipoCliente = new Equipo();
                vFormulario.EquipoCliente.Id = long.Parse(txtidequipo.Text.ToString());
                vFormulario.FrmEditarReparacion = this;
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe haber un equipo seleccionado primero", "ATENCIÓN!");
            }
        }

        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            frmRegistroLlamadas vFormulario = new frmRegistroLlamadas();
            vFormulario.Codigo = lbldatoNroOrden.Text;
            vFormulario.IdReparacion = IdReparacion;
            vFormulario.VengoDeCliente = false;
            vFormulario.VengoDeReparacion = false;
            vFormulario.VengoDeEditarReparacion = true;
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
        }

        private void mandarMail( String xCliente, String xEmail, String xTitulo, String xNombreDoc,String xNombreDocPath)
        {
            bool vRes = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if (vRes && ( xEmail.Trim() != ""))
            {
                AdjuntoMail vAdjunto = new AdjuntoMail(xNombreDoc, xNombreDocPath);
                String vMensaje = DaoParametrosDatos.getParametro("CUERPOMAILORDEN");
                vMensaje = vMensaje.Replace("{xCliente}", xCliente);
                List<AdjuntoMail> vAdjuntos = new List<AdjuntoMail>();
                vAdjuntos.Add(vAdjunto);
                EnviarMail vCorreo = new EnviarMail(xTitulo, xEmail, "", "", vMensaje, vAdjuntos);
                vCorreo.Enviar();
                vAdjunto = null;
                vAdjuntos = null;
                vCorreo = null;
            }
        }

        private void mandarMail(String xEstadoActual,String xEstadoAnterior,String xCliente,String xEmail,String xTitulo, String xMensaje)
        {
            bool vRes = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if(vRes && (xEstadoAnterior != xEstadoActual && xEmail != ""))
            {
                EnviarMail vCorreo = new EnviarMail(xTitulo, xEmail, null, xMensaje);
                vCorreo.Enviar();
                vCorreo = null;
            }
        }

        private void btnmail_Click(object sender, EventArgs e)
        {
            FrmEnvioMailSimple vFormulario = new FrmEnvioMailSimple();
            vFormulario.Destinatario = DaoCliente.obtenerMail(txtidcliente.Text.ToString());
            vFormulario.Show();
        }

        private void bw_DoWorkMail(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress((i * 10));
                }
            }
        }

        private void bw_RunWorkerMailCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                // this.tbProgress.Text = "Canceled!";
                MessageBox.Show("Se ha cancelado la operación","ATENCIÓN!");
            }

            else if (!(e.Error == null))
            {
                //this.tbProgress.Text = ("Error: " + e.Error.Message);
                MessageBox.Show("Error:" + e.Error.Message,"Error!");
            }

            else
            {
                //this.tbProgress.Text = "Done!";
                MessageBox.Show("Se ha completado correctamente");
            }
        }
        private void bw_ProgressMailChanged(object sender, ProgressChangedEventArgs e)
        {
          //  this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void lblTomadoPor_Click(object sender, EventArgs e)
        {

        }

        private void cmbTomadoPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        public void CargarGrillaItems()
        {

        }

        private void btnAgregarTarifa_Click(object sender, EventArgs e)
        {
            FrmConsultarArticulo vFormulario = new FrmConsultarArticulo();
            vFormulario.FrmRep = this;
            vFormulario.Modo = "ITEMSREPARACION";
            vFormulario.ShowDialog();
        }

        private void dgwTarifa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgwTarifa.Rows[e.RowIndex].Cells["Descripcion"].Value != null && dgwTarifa.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString() != "")
            {
                if (dgwTarifa.Columns[e.ColumnIndex].Name == "Cantidad" /*&& dgwTarifa.Rows[e.RowIndex].Cells["Recibo"].Value.ToString()==""*/)
                {
                    long cantidad = 0;
                    DataGridViewRow row = dgwTarifa.Rows[e.RowIndex];
                    if (!long.TryParse(e.FormattedValue.ToString(), out cantidad))
                    {

                        row.ErrorText = "Debe ingresar un número valido";
                        e.Cancel = true;
                    }
                 /*   else if(row.Cells["Recibo"].Value.ToString().Trim()!="")
                    {
                        row.ErrorText = "No se puede editar un ítem facturado";
                        MessageBox.Show("No se puede editar un ítem facturado!");
                        e.Cancel = true;
                    }*/
                    else
                    {
                        e.Cancel = false;
                        row.ErrorText = "";
                    }

                }
                else if (dgwTarifa.Columns[e.ColumnIndex].Name == "Total")
                {
                    float monto = 0;
                    DataGridViewRow row = dgwTarifa.Rows[e.RowIndex];
                    if (!float.TryParse(e.FormattedValue.ToString(), out monto))
                    {
                        row.ErrorText = "Debe ingresar un número valido";
                        e.Cancel = true;
                    }
                    else
                    {
                        row.ErrorText = "";
                        e.Cancel = false;
                    }

                }
            }
        }

        private void dgwTarifa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex <= (dgwTarifa.Rows.Count - 1))
            { 

                /* float vMontoUnitario = (float)dgwItem.Rows[e.RowIndex].Cells["Neto"].Value * (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoNeto = vMontoUnitario / (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoIva = vMontoUnitario - vMontoNeto;*/     
                double vMonto = 0.00;
                Console.WriteLine("Tarifa: " + dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString());
                Console.WriteLine("Insumo: " + dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString());
                if (dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value != null && dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString() != "")
                    vMonto = DaoTarifa.getMontoTarifa(dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString());
                if (dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value != null && dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString() != "")
                    vMonto = DaoArticulo.ObtenerMontoPublico(dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString());
           
               
                int cantidad = int.Parse(dgwTarifa.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                Console.WriteLine("Cantidad: " +cantidad);
                double vNuevoMonto = cantidad * vMonto;
                dgwTarifa.Rows[e.RowIndex].Cells["Monto"].Value = vNuevoMonto;
                GuardarCambiosGrillaTarifa();

            }
        }

        private void btnBorrarTarifa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwTarifa.CurrentRow;
            if (selectedRow != null)
            {
               // if(selectedRow.Cells["Recibo"].Value.ToString()=="")
             //   {
                    long vId = long.Parse(selectedRow.Cells["Id"].Value.ToString());
                    double vMonto = double.Parse(txtMontoReparacion.Text.ToString());
                    if(vMonto > 0)
                    {
                        vMonto -= double.Parse(selectedRow.Cells["Monto"].Value.ToString());
                        txtMontoReparacion.Text = vMonto + "";
                    }
                    dgwTarifa.Rows.Remove(selectedRow);
                    DaoItemReparacion.Borrar(vId);
            //    }
             //   else
            //    {
                //    MessageBox.Show("No se puede borrar un item facturado");
               // }
                
                
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un item para borrar", "ATENCION!");
            }
        }

        private void lblInformeSolucion_Click(object sender, EventArgs e)
        {

        }

        private void btnImpInformTec_Click(object sender, EventArgs e)
        {
            ReporteInformeTecnico vReporte = new ReporteInformeTecnico();
            vReporte.Equipo = txtNombreEquipo.Text;
            vReporte.NombreCliente = txtnombrecliente.Text;
            vReporte.NroOrden = lbldatoNroOrden.Text;
            vReporte.Fecha = DateTime.Now.ToString();
            vReporte.Escrito = txtInformeSolucion.Text;
            vReporte.DatosEmpresa = DaoParametrosDatos.ObtenerParametrosPDF();
            System.Diagnostics.Process.Start(vReporte.crearPDF());
        }

        private void btnCobrarTarifa_Click(object sender, EventArgs e)
        {

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgwTarifa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex <= (dgwTarifa.Rows.Count - 1))
            {

                /* float vMontoUnitario = (float)dgwItem.Rows[e.RowIndex].Cells["Neto"].Value * (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoNeto = vMontoUnitario / (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoIva = vMontoUnitario - vMontoNeto;*/
               /* double vMonto = 0.00;
                Console.WriteLine("Tarifa: " + dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString());
                Console.WriteLine("Insumo: " + dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString());
                if (dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value != null && dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString() != "")
                    vMonto = DaoTarifa.getMontoTarifa(dgwTarifa.Rows[e.RowIndex].Cells["Tarifa"].Value.ToString());
                if (dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value != null && dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString() != "")
                    vMonto = DaoArticulo.ObtenerMontoPublico(dgwTarifa.Rows[e.RowIndex].Cells["Insumo"].Value.ToString());
               */

                int cantidad = int.Parse(dgwTarifa.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                Console.WriteLine("Cantidad Anterior: " + cantidad);
                mCantidadAnteriorTarifa = cantidad;
              //  double vNuevoMonto = cantidad * vMonto;
              //  dgwTarifa.Rows[e.RowIndex].Cells["Monto"].Value = vNuevoMonto;
                //GuardarCambiosGrillaTarifa();

            }
        }
    }
}
