using desagotes.reportes;
using reparaciones2.dao;
using reparaciones2.ob;
using reparaciones2.ob.service;
using reparaciones2.reparaciones;
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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using reparaciones2.mapas;
using reparaciones2.Insumos;
using reparaciones2.ob.reparaciones;

namespace reparaciones2
{
    public partial class FrmService : Form
    {
        public Service Service { get ; set; }
        public string Geo { get; set; }
        
        public FrmService()
        {
            InitializeComponent();
        }

        public void CargarCliente(String xIdCliente)
        {
            if (Service == null)
                Service = new Service();
            Service.Cliente = DaoCliente.ObtenerCliente(long.Parse(xIdCliente));
            txtidcliente.Text = Service.Cliente.Id.ToString();
            txtnombrecliente.Text = Service.Cliente.ToString();
            txtcalle.Text = Service.Cliente.Calle;
            txtnro.Text = Service.Cliente.Nro;
            txtpiso.Text = Service.Cliente.Piso;
            txtdpto.Text = Service.Cliente.Dpto;
            txtlocalidad.Text = Service.Cliente.Localidad;
            txtprovincia.Text = Service.Cliente.Provincia;
            Geo = Service.Cliente.Geo;
           
            /*  if (Geo != null && Geo.Trim() != "")
              {
                  String[] vLatLong = Geo.Split(',');
                  gmapDireccion.Overlays.Clear();
                  GMapOverlay markers = new GMapOverlay("markers");
                  Double vLong = Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim());
                  Double vLatitud = Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim());
                  gmapDireccion.Position = new PointLatLng(vLong, vLatitud);
                  gmapDireccion.Zoom = 9;
                  GMapMarker marker = new GMarkerGoogle
                      (new PointLatLng(vLong, vLatitud),
                      GMarkerGoogleType.blue_pushpin);
                  gmapDireccion.Overlays.Add(markers);
                  markers.Markers.Add(marker);
              }
              else
              {
                  String vGeoPosicion = dao.DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
                  String[] vLatLong = vGeoPosicion.Split(',');
                  gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim()),
                       Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim()));
              }*/
        }

        private void CargarService()
        {
            txtidcliente.Text = Service.Cliente.Id.ToString();
            txtnombrecliente.Text = Service.Cliente.ToString();
            txtcalle.Text = Service.Calle;
            txtnro.Text = Service.Nro;
            txtpiso.Text = Service.Piso;
            txtdpto.Text = Service.Dpto;
            txtlocalidad.Text = Service.Localidad;
            txtprovincia.Text = Service.Provincia;
            txtobservaciones.Text = Service.ObservacionesDomicilio;
            txtnroservice.Text = Service.Id + "";
            dtpFechaIngreso.Value = Service.FechaTomado;
            dtpFechaPrometida.Value = Service.FechaPrometida;
            cmbTomadoPor.SelectedValue = Service.TomadoPor;
            cmbTomadoPor.Enabled = false;
            cmbUbicaciones.Enabled = false;
            cmbUbicaciones.Text = "";
            cmbPrioridades.SelectedValue = Service.Prioridad;
            cmbEstado.SelectedValue = Service.Estado;
            cmbPrioridades.SelectedValue = Service.Prioridad;
            cmbPrioridades.Text = Service.Prioridad;
            cmbEstado.Text = Service.Estado;
            cmbAsignadoA.Text = Service.AsignadoA;
            txtMontoReparacion.Text = Service.Monto + "";
            txtsenia.Text = Service.Senia + "";
            txtsolucion.Text = Service.Solucion;
            txtproblema.Text = Service.Problema;
            if (Service.FechaRealizada != null)
                dtpFechaRealizado.Value = Service.FechaRealizada;

        }

        private void FrmService_Load(object sender, EventArgs e)
        {
            // config map
            /*  gmapDireccion.MapProvider = GMapProviders.GoogleMap;
              gmapDireccion.DragButton = MouseButtons.Left;
              //gmapDireccion.Zoom = 9;
              gmapDireccion.ShowCenter = false;
              Size siz = new System.Drawing.Size(gmapDireccion.Width, gmapDireccion.Height);
              gmapDireccion.ClientSize = siz;*/
            //    gmapDireccion.ReloadMap(); 
            txtMontoReparacion.Enabled = false;
            UtilidadesComunes.cargarComboUsuario(cmbTomadoPor);
            UtilidadesComunes.cargarComboUsuario(cmbAsignadoA);
            UtilidadesComunes.CargarComboPrioridades(cmbPrioridades);
            if (Service == null)
                Service = new Service();
            if (Service.Id==0)
            {
                lblnroservice.Visible = false;
                txtnroservice.Visible = false;
                UtilidadesComunes.CargarComboEstadosService(cmbEstado);
                cmbEstado.Text = "TOMADO";
                cmbEstado.Enabled = false;
                /*String vGeoPosicion = dao.DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
                String[] vLatLong = vGeoPosicion.Split(',');
                gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Trim()),
                     Double.Parse(vLatLong[1].ToString().Trim()));*/
                /*  gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim()),
                       Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim()));*/
                //gmapDireccion.ReloadMap();
                btnAgregarTarifa.Enabled = false;
                btnBorrarTarifa.Enabled = false;
            }
            else
            {
                btnAgregarTarifa.Enabled = true;
                btnBorrarTarifa.Enabled = true;
                txtsenia.Enabled = false;
                //btnCobrarTarifa.Enabled = true;
                CargarGrillaTarifa();
                Geo = Service.Coordenadas;
              /*  if (Geo != null && Geo.Trim() != "")
                {
                    String[] vLatLong = Geo.Split(',');
                    gmapDireccion.Overlays.Clear();
                    GMapOverlay markers = new GMapOverlay("markers");
                  
                    Double vLong = Double.Parse(vLatLong[0].ToString().Trim());
                    Double vLatitud = Double.Parse(vLatLong[1].ToString().Trim());
                    gmapDireccion.Position = new PointLatLng(vLong, vLatitud);
                    GMapMarker marker = new GMarkerGoogle
                        (new PointLatLng(vLong, vLatitud),
                        GMarkerGoogleType.blue_pushpin);
                    gmapDireccion.Overlays.Add(markers);
                    markers.Markers.Add(marker);
                }
                else
                {
                    String vGeoPosicion = dao.DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
                    String[] vLatLong = vGeoPosicion.Split(',');
                    gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Trim()),
                        Double.Parse(vLatLong[1].ToString().Trim()));
                         gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim()),
                              Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim()));
                }*/
                if (Service.Estado == "TOMADO")
                    UtilidadesComunes.CargarComboEstadosService(cmbEstado);
                else if (Service.Estado == "EN EJECUCION")
                {
                    cmbEstado.Items.Add("EN EJECUCION");
                    cmbEstado.Items.Add("FINALIZADO");
                }
                else if (Service.Estado == "FINALIZADO")
                {
                    cmbEstado.Items.Add("FINALIZADO");
                    txtcalle.Enabled = false;
                    txtdpto.Enabled = false;
                    txtlocalidad.Enabled = false;
                    txtMontoReparacion.Enabled = false;
                    txtnro.Enabled = false;
                    txtobservaciones.Enabled = false;
                    txtpiso.Enabled = false;
                    txtproblema.Enabled = false;
                    txtprovincia.Enabled = false;
                    txtsenia.Enabled = false;
                    txtsolucion.Enabled = false;
                    cmbAsignadoA.Enabled = false;
                    cmbEstado.Enabled = false;
                    cmbPrioridades.Enabled = false;
                    dtpFechaPrometida.Enabled = false;
                    dtpFechaRealizado.Enabled = false;
                    //gmapDireccion.Enabled = false;
                }
                   
                CargarService();
                btnAgregarCliente.Enabled = false;
                btnEditarCliente.Enabled = false;
                btnXCliente.Enabled = false;
                btnBuscarCliente.Enabled = false;
                dtpFechaIngreso.Enabled = false;
                //CargarUbicaciones();
              
            }
          /*  gmapDireccion.MinZoom = 0;
            gmapDireccion.MaxZoom = 30;
            gmapDireccion.Zoom = 15;*/
        }

        private void CargarUbicaciones()
        {
            cmbUbicaciones.DataSource = DAOService.ObtenerCallesService(Service.Cliente.Id);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.frmEditarService = this;
            vFormulario.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproblema_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXCliente_Click(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
            txtcalle.Text = "";
            txtlocalidad.Text = "";
            txtnro.Text = "";
            txtdpto.Text = "";
            txtpiso.Text = "";
            txtprovincia.Text = "";
            
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            Cliente vCliente = DaoCliente.ObtenerCliente(long.Parse(txtidcliente.Text));
            vFormulario.Cliente = vCliente;
            vFormulario.frmEditarService = this;
            vFormulario.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.frmEditarService = this;
            vFormulario.ShowDialog();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string prioridad = "";
            string tomadoPor = "";
            string estado = "";
            string asignadoA = "";

            if (cmbPrioridades.SelectedValue!=null && cmbPrioridades.SelectedValue.ToString() != "")
                prioridad = cmbPrioridades.SelectedValue.ToString();
            else
                prioridad = cmbPrioridades.Text;

            if (cmbTomadoPor.SelectedValue!=null && cmbTomadoPor.SelectedValue.ToString() != "")
                tomadoPor = cmbTomadoPor.SelectedValue.ToString();
            else
                tomadoPor = cmbTomadoPor.Text;


            if (cmbEstado.SelectedValue!=null && cmbEstado.SelectedValue.ToString() != "")
                estado = cmbEstado.SelectedValue.ToString();
            else
                estado = cmbEstado.Text;

            if (cmbAsignadoA.SelectedValue!=null && cmbAsignadoA.SelectedValue.ToString() != "")
                asignadoA = cmbAsignadoA.SelectedValue.ToString();
            else
                asignadoA = cmbAsignadoA.Text;

            if (txtMontoReparacion.Text == "")
                txtMontoReparacion.Text = "0";
            if (txtsenia.Text == "")
                txtsenia.Text = "0";

            float vMontoService = float.Parse(txtMontoReparacion.Text.Trim());
            float vMontoSenia = float.Parse(txtsenia.Text.Trim());
            if (txtcalle.Text.Trim() == "" || txtproblema.Text == "" || txtidcliente.Text == ""
                || prioridad == "" || tomadoPor == "" || estado == ""
                || (estado=="EN EJECUCION" && asignadoA=="" )
                || (estado=="FINALIZADO" && (vMontoService <= 0 || txtsolucion.Text.Trim()=="")))
            
                MessageBox.Show("Complete los campos obligatorios marcados con *");
            else
            {
                String vEstadoAnterior = Service.Estado;
                Service.Calle = txtcalle.Text;
                Service.Dpto = txtdpto.Text;
                Service.Localidad = txtlocalidad.Text;
                Service.Nro = txtnro.Text;
                Service.Piso = txtpiso.Text;
                Service.Provincia = txtprovincia.Text;
                Service.Solucion = txtsolucion.Text;
                Service.Problema = txtproblema.Text;
                Service.ObservacionesDomicilio = txtobservaciones.Text;
                Service.FechaPrometida = dtpFechaPrometida.Value;
                Service.Estado = estado;
                Service.Monto = vMontoService;
                Service.Senia = vMontoSenia;
                Service.Estado = estado;
                Service.AsignadoA = asignadoA;
                Service.Coordenadas = Geo;

                if (estado == "FINALIZADO")
                {
                    Service.FechaRealizada = dtpFechaRealizado.Value;
                    FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                    String vIdService = Service.Id + "";
                    vFormulario.NroReparacion = "";
                    vFormulario.Service = Service;
                    vFormulario.VengoDe = "editarService";
                    vFormulario.IdCliente = txtidcliente.Text;
                    vFormulario.IdService = vIdService;
                    vFormulario.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Concepto = "POR SERVICE DOMICILIARIO";
                    vFormulario.Monto = txtMontoReparacion.Text;
                    String vMailCliente = DaoCliente.obtenerMail(txtidcliente.Text);
                    vFormulario.EmailCliente = vMailCliente;
                    vFormulario.Show();
                }
                    

                if (Service.Id == 0)
                {
                    FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
                    vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
                    vFormularioProgreso.Show();
                    this.Enabled = false;
                    Service.FechaTomado = dtpFechaIngreso.Value;
                    Service.TomadoPor = tomadoPor;
                    DAOService.Guardar(Service);
                    long vId = DAOService.ObtenerId(Service);
                    Service.Id = vId;
                    ReporteServiceDomicilio vFormImprimir = new ReporteServiceDomicilio();
                    vFormImprimir.Fecha = desagotes.Utils.getFechaSinHora(dtpFechaIngreso.Text);
                    vFormImprimir.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                    vFormImprimir.ClienteDomicilio = Service.Direccion();
                    Console.WriteLine("Domicilio: " + Service.Direccion());
                    vFormImprimir.Problema = txtproblema.Text;
                    vFormImprimir.Senia = "$" + txtsenia.Text;
                    Console.WriteLine(vId);
                    vFormImprimir.NroOrden = "" + vId;
                    vFormImprimir.Leyenda = DaoParametrosDatos.getParametro("LEYENDA");
                    vFormImprimir.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                    vFormImprimir.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                    vFormImprimir.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                    vFormImprimir.Horario = DaoParametrosDatos.getParametro("HORARIO");
                    //vFormImprimir.ClienteDomicilio = Service.Cliente.Domicilio();
                    vFormularioProgreso.Barra.Value += 20;
                   // float vMonto = float.Parse(txtsenia.Text);
                    if (vMontoSenia > 0)
                    {
                        FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                        vFormulario.NroReparacion = vId + "";
                        vFormulario.IdCliente = txtidcliente.Text;
                        vFormulario.Service = Service;
                        vFormulario.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                        vFormulario.ReporteServiceDomicilio = vFormImprimir;
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Monto = vMontoSenia + "";
                        String vMailCliente = DaoCliente.obtenerMail(txtidcliente.Text);
                        vFormulario.EmailCliente = vMailCliente;
                        vFormularioProgreso.Barra.Value = 100;
                        vFormularioProgreso.Close();
                        vFormulario.Show();
                    }
                    else
                    {
                        vFormImprimir.crearPdf();
                        FrmEnviarReporte vReportes = new FrmEnviarReporte();
                        Service.Id = DAOService.ObtenerId(Service);
                        vReportes.Service = Service;
                        vReportes.Reporte = vFormImprimir.NombreDocumento;
                        Console.WriteLine(vReportes.Reporte);
                        vReportes.MdiParent = this.MdiParent;
                        vFormularioProgreso.Close();
                        vReportes.Show();
                    }

                    this.Close();
                }
                else
                {
                    if (vEstadoAnterior != "FINALIZADO")
                        DAOService.Editar(Service);
                }
                this.Close();
            }
              
               
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbPrioridades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTomadoPor_Click(object sender, EventArgs e)
        {

        }

        private void cmbTomadoPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gmapDireccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           /* GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            PointLatLng vPunto = gm.FromLocalToLatLng(hj.X, hj.Y);
            //String vLatitud = vPunto.Lat.ToString().Replace(",", ".");
            String vLatitud = vPunto.Lat.ToString();
            //String vLongitud = vPunto.Lng.ToString().Replace(",", ".");
            String vLongitud = vPunto.Lng.ToString();
            Geo = vLatitud + "," + vLongitud;
            gmapDireccion.Overlays.Clear();
            GMapOverlay markers = new GMapOverlay("markers");

            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(vPunto.Lat, vPunto.Lng),
                GMarkerGoogleType.blue_pushpin);
            gmapDireccion.Overlays.Add(markers);
            markers.Markers.Add(marker);*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            FrmMapas vFormulario = new FrmMapas();
            vFormulario.mPadreService = this;
            vFormulario.Geo = Geo;
            vFormulario.ShowDialog();
        }

        public void AgregarItem(DataGridViewRow xItem)
        {
            //id,cantidad,idtarifa,idinsumo,descripcion,monto
            // int rowEscribir = dgwTarifa.Rows.Count - 1;
            //if (rowEscribir < 0)
            //  rowEscribir = 0;
            bool vExiste = false;
            if (xItem.Cells["idp"].Value != null && xItem.Cells["idp"].Value.ToString() != "")
                vExiste = ExisteItem(xItem.Cells["idp"].Value.ToString(), "PRODUCTO");
            else
                vExiste = ExisteItem(xItem.Cells["idt"].Value.ToString(), "TARIFA");
            if (!vExiste)
            {
                DataTable dataTable = (DataTable)dgwTarifa.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                drToAdd["Cantidad"] = 1;
                drToAdd["Id"] = 0;
                if (xItem.Cells["idt"].Value.ToString() != "" && xItem.Cells["idt"].Value.ToString() != "null")
                    drToAdd["Tarifa"] = long.Parse(xItem.Cells["idt"].Value.ToString());
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
            else
            {
               
            }
            GuardarCambiosGrillaTarifa();
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
                /*   if (dgwTarifa.Rows[i].Cells["Recibo"].Value != null && dgwTarifa.Rows[i].Cells["Recibo"].Value.ToString() != "")
                   {
                       vItem.Recibo = new ReciboIngreso();
                       vItem.Recibo.Id = long.Parse(dgwTarifa.Rows[i].Cells["Recibo"].Value.ToString());
                   }   */
                vItem.Cantidad = int.Parse(dgwTarifa.Rows[i].Cells["Cantidad"].Value.ToString());
                vItem.Total = double.Parse(dgwTarifa.Rows[i].Cells["Monto"].Value.ToString());
                vMontoGrilla += vItem.Total;
                if (dgwTarifa.Rows[i].Cells["Id"].Value != null && dgwTarifa.Rows[i].Cells["Id"].Value.ToString() != "")
                    vItem.Id = long.Parse(dgwTarifa.Rows[i].Cells["Id"].Value.ToString());
                vItem.Service = DAOService.ObtenerService(this.Service.Id);
                
                double vNeto = 0.00;
                double vIva = 0.00;
                if (vItem.Tarifa != null)
                {
                    vNeto = Math.Round(vItem.Total - (vItem.Total * 0.21), 2);
                    vIva = Math.Round(vItem.Total * 0.21);
                }
                else
                {
                    vNeto = Math.Round(vItem.Total - (vItem.Total * (vItem.Articulo.Iva
                         / 100)), 2);
                    vIva = Math.Round(vItem.Total * (vItem.Articulo.Iva
                         / 100));
                }
                vItem.Neto = vNeto;
                vItem.Iva = vIva;
                if (vItem.Id > 0)
                    DaoItemService.Editar(vItem);
                else
                {
                    DaoItemService.Guardar(vItem);
                    long vId = DaoItemService.ObtenerId(vItem);
                    Console.WriteLine(vId);
                    dgwTarifa.Rows[i].Cells["Id"].Value = vId;
                }

                i++;
                vItem = null;
            }
            txtMontoReparacion.Text = vMontoGrilla + "";
        }



        private bool ExisteItem(string xId, string xTipo)
        {

            bool vRes = false;
            int i = 0;
            int limite = dgwTarifa.Rows.Count - 1;
            while (i < limite && !vRes)
            {
                if (xTipo == "TARIFA")
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

        private void CargarGrillaTarifa()
        {
            dgwTarifa.DataSource = DaoItemService.ObtenerItemDeReparacion(Service.Id);
            dgwTarifa.Columns["Id"].Visible = false;
            dgwTarifa.Columns["Tarifa"].Visible = false;
            dgwTarifa.Columns["Insumo"].Visible = false;
            //  dgwTarifa.Columns["Recibo"].Visible = false;
            dgwTarifa.Columns["Descripcion"].ReadOnly = true;
            dgwTarifa.Columns["Descripcion"].HeaderText = "Descripción";
            dgwTarifa.Columns["Monto"].ReadOnly = true;
        }


        private void btnAgregarTarifa_Click(object sender, EventArgs e)
        {
            FrmConsultarArticulo vFormulario = new FrmConsultarArticulo();
            vFormulario.FrmService = this;
            vFormulario.Modo = "ITEMSSERVICE";
            vFormulario.ShowDialog();
        }

        private void btnBorrarTarifa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwTarifa.CurrentRow;
            if (selectedRow != null)
            {
             //   if (selectedRow.Cells["Recibo"].Value.ToString() == "")
               // {
                    long vId = long.Parse(selectedRow.Cells["Id"].Value.ToString());
                    double vMonto = double.Parse(txtMontoReparacion.Text.ToString());
                    if (vMonto > 0)
                    {
                        vMonto -= double.Parse(selectedRow.Cells["Monto"].Value.ToString());
                        txtMontoReparacion.Text = vMonto + "";
                    }
                    dgwTarifa.Rows.Remove(selectedRow);
                    DaoItemService.Borrar(vId);
               /* }
                else
                {
                    MessageBox.Show("No se puede borrar un item facturado");
                }*/


            }
            else
            {
                MessageBox.Show("Debe Seleccionar un item para borrar", "ATENCION!");
            }
        }
    }
}
