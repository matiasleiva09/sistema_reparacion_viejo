using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using reparaciones2.caja;
using reparaciones2.dao;
using reparaciones2.mapas;
using reparaciones2.ob;
using reparaciones2.Presupuesto;
using reparaciones2.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmEditarCliente : Form
    {
        public Cliente cliente= null;
        private frmEditarReparacion frmReparacion = null;
        private String mGeo = "";
        private FormBuscarCliente buscarCliente = null;
        public FrmService frmEditarService { get; set; }
        public FrmCobroIngreso CobroIngreso { get; set; }
        public FrmPresupuesto Presupuesto { get; set; }
        public FormBuscarCliente BuscarCliente
        {
            get { return buscarCliente; }
            set { buscarCliente = value; }
        }
       

        public String Geo
        {
            get { return mGeo; }
            set { mGeo = value; }
        }

        public frmEditarReparacion FrmReparacion
        {
            get { return frmReparacion; }
            set { frmReparacion = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        { 
            cargarPorDefecto();
        }

        private void cargarPorDefecto()
        {

            // config map
           /* Size size = new System.Drawing.Size(gmapDireccion.Width, gmapDireccion.Height);
            gmapDireccion.ClientSize = size;
            gmapDireccion.MapProvider = GMapProviders.GoogleMap;
            gmapDireccion.DragButton = MouseButtons.Left;
            gmapDireccion.ShowCenter = false;*/
    
           
            UtilidadesComunes.cargarCondicionIVA(cmbCondicionIVA);
            UtilidadesComunes.cargarTipoDocumento(cmbTipoDocumento);
           
            if (this.Cliente!=null)
            {
                txtnombre.Text = Cliente.Nombre;
                txtcalle.Text = Cliente.Calle;
                txtcelular.Text = Cliente.Celular;
                txtcp.Text = Cliente.Cp;
                txtdpto.Text = Cliente.Dpto;
                txtemail.Text = Cliente.Email;
                txtlocalidad.Text = Cliente.Localidad;
                txtnro.Text = Cliente.Nro;
                txtpiso.Text = Cliente.Piso;
                txtcp.Text = Cliente.Cp;
                txttelefono.Text = Cliente.Telefono;
                txtprovincia.Text = Cliente.Provincia;
                txttelefono.Text = Cliente.Telefono;
                txtobservaciones.Text = Cliente.Observaciones;
                cmbCondicionIVA.Text = Cliente.CondicionIVA;
                cmbTipoDocumento.Text = Cliente.TipoDocumento;
                txtNroDocumento.Text = Cliente.NroDocumento;
                txtCuit.Text = Cliente.Cuit;
                Geo = Cliente.Geo;
               /* if(Geo!=null && Geo.Trim()!="")
                {
                    String[] vLatLong = Geo.Split(',');
                    gmapDireccion.Overlays.Clear();
                    GMapOverlay markers = new GMapOverlay("markers");
                    Double vLong = Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim());
                    Double vLong = Convert.ToDouble(vLatLong[0].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                     Double vLatitud = Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim());
                    Double vLatitud = Convert.ToDouble(vLatLong[1].ToString().Trim(), CultureInfo.CreateSpecificCulture("en-US"));
                    gmapDireccion.Position = new PointLatLng(vLong,vLatitud);
                   GMapMarker marker = new GMarkerGoogle
                        (new PointLatLng(vLong,vLatitud),
                        GMarkerGoogleType.blue_pushpin);
                    gmapDireccion.Overlays.Add(markers);
                    markers.Markers.Add(marker);
                }
                else
                {
                    String vGeoPosicion = dao.DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
                    String[] vLatLong = vGeoPosicion.Split(',');
                    Double vLat = Convert.ToDouble(vLatLong[0].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    Double vLong = Convert.ToDouble(vLatLong[1].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                    gmapDireccion.Position = new PointLatLng(vLat,vLong);
                }*/
               
            }
            else
            {
                /*String vGeoPosicion = dao.DaoParametrosDatos.getParametro("GOOGLEMAPSCENTRO");
                String[] vLatLong = vGeoPosicion.Split(',');
                Double vLat = Convert.ToDouble(vLatLong[0].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                Double vLong = Convert.ToDouble(vLatLong[1].ToString(), CultureInfo.CreateSpecificCulture("en-US"));
                gmapDireccion.Position = new PointLatLng(vLat, vLong);
                  gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Replace(".", ",").Trim()),
                       Double.Parse(vLatLong[1].ToString().Replace(".", ",").Trim()));*/
                cmbCondicionIVA.Text = Cliente.CONSUMIDOR_FINAL;
                cmbTipoDocumento.Text = Cliente.DNI;
            }
            //gmapDireccion.Position = new PointLatLng(-37.1135099, -56.8584895);
           /* gmapDireccion.MinZoom = 0;
            gmapDireccion.MaxZoom = 30;
            gmapDireccion.Zoom = 15;*/
         
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            if (txtnombre.Text.Trim() == "" || txttelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los campos obligatorios (*)", "ATENCION!");
                validado = false;
            }

            if(validado)
            {
                if (this.Cliente == null)
                {
                    Cliente vCliente = new ob.Cliente();
                    vCliente.Calle = Security.TextoSinComas(txtcalle.Text.Trim());
                    vCliente.Celular = txtcelular.Text.Trim();
                    vCliente.Telefono = txttelefono.Text.Trim();
                    vCliente.Email = Security.TextoSinComas(txtemail.Text.Trim());
                    vCliente.Cp = Security.TextoSinComas(txtcp.Text.Trim());
                    vCliente.Dpto = Security.TextoSinComas(txtdpto.Text.Trim());
                    vCliente.Localidad = Security.TextoSinComas(txtlocalidad.Text.Trim());
                    vCliente.Nombre = Security.TextoSinComas(txtnombre.Text);
                    vCliente.Nro = txtnro.Text.Trim();
                    vCliente.TipoDocumento = TipoDocumento();
                    vCliente.CondicionIVA = CondicionIVA();
                    vCliente.Cuit = txtCuit.Text;
                    vCliente.NroDocumento = txtNroDocumento.Text;
                    vCliente.Observaciones = Security.TextoSinComas(txtobservaciones.Text.Trim());
                    vCliente.Piso = Security.TextoSinComas(txtpiso.Text.Trim());
                    vCliente.Provincia = Security.TextoSinComas(txtprovincia.Text.Trim());
                    vCliente.Telefono = txttelefono.Text.Trim();
                    vCliente.Geo = Geo;
                    DaoCliente.guardar(vCliente);

                    if (FrmReparacion == null && CobroIngreso == null)
                    {
                        Clientes vFormulario = new Clientes();
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Show();
                    }
                    else
                    {
                        String vId = DaoCliente.ObtenerId(vCliente.Nombre, vCliente.Calle, vCliente.Piso, vCliente.Dpto,
                            vCliente.Localidad, vCliente.Provincia, vCliente.Telefono, vCliente.Celular,
                            vCliente.Email, vCliente.Observaciones, vCliente.Geo, vCliente.TipoDocumento,
                            vCliente.NroDocumento, vCliente.CondicionIVA, vCliente.Cuit);
                        if (Presupuesto != null)
                            Presupuesto.CargarCliente(vId.Trim(), vCliente.Nombre + " Tel: " + vCliente.Telefono + " Cel:" + vCliente.Celular);
                        if (FrmReparacion!=null)
                           FrmReparacion.CargarCliente(vId, vCliente.Nombre + " Tel: " + vCliente.Telefono + " Cel:" + vCliente.Celular);
                        if (CobroIngreso != null)
                            CobroIngreso.CargarCliente(vId, vCliente.Nombre + " Tel: " + vCliente.Telefono + " Cel:" + vCliente.Celular);
                    }
                   this.Close(); 
                }
                else
                {
                   Cliente.Calle = Security.TextoSinComas(txtcalle.Text.Trim());
                   Cliente.Celular = Security.TextoSinComas(txtcelular.Text.Trim());
                   Cliente.Cp = Security.TextoSinComas(txtcp.Text.Trim());
                   Cliente.Dpto = Security.TextoSinComas(txtdpto.Text.Trim());
                   Cliente.Localidad = Security.TextoSinComas(txtlocalidad.Text.Trim());
                   Cliente.Nombre = Security.TextoSinComas(txtnombre.Text);
                   Cliente.Nro = Security.TextoSinComas(txtnro.Text.Trim());
                   Cliente.Email = Security.TextoSinComas(txtemail.Text.Trim());
                   Cliente.Observaciones = Security.TextoSinComas(txtobservaciones.Text.Trim());
                   Cliente.Piso = Security.TextoSinComas(txtpiso.Text.Trim());
                   Cliente.Provincia = Security.TextoSinComas(txtprovincia.Text.Trim());
                   Cliente.Telefono = Security.TextoSinComas(txttelefono.Text.Trim());
                    Cliente.TipoDocumento = TipoDocumento();
                   Cliente.CondicionIVA = CondicionIVA();
                   Cliente.Cuit = txtCuit.Text;
                   Cliente.NroDocumento = txtNroDocumento.Text;
                   Cliente.Geo = Geo;
                   DaoCliente.editar(Cliente);
                    if (FrmReparacion == null && BuscarCliente ==null && CobroIngreso==null)
                    {

                        FrmAdminContacto vFormulario = new FrmAdminContacto();
                        vFormulario.IdCliente = Cliente.Id;
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Show();
                    }
                    else if (Presupuesto != null)
                        Presupuesto.CargarCliente(Cliente.Id + "", Cliente.Nombre + " Tel: " + Cliente.Telefono + " Cel:" + Cliente.Celular);
                    else if(FrmReparacion!=null)
                    {
                        FrmReparacion.CargarCliente(Cliente.Id + "", Cliente.Nombre + " Tel: " + Cliente.Telefono + " Cel:" + Cliente.Celular);
                    }
                    else if(frmEditarService!=null)
                    {
                        frmEditarService.CargarCliente(Cliente.Id + "");

                    }
                    else if(BuscarCliente!=null)
                    {
                        BuscarCliente.cargarClientes();
                    }
                    else if(CobroIngreso!=null)
                    {
                        CobroIngreso.CargarCliente(Cliente.Id + "", Cliente.Nombre + " Tel: " + Cliente.Telefono + " Cel:" + Cliente.Celular);
                        Console.WriteLine("Test");
                    }

                   Cliente = null;
                   this.Close();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if(Cliente==null)
            {
                if(this.FrmReparacion==null)
                {
                    Clientes vFormulario = new Clientes();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Show();
                }
                this.Close();
            }
            else
            {
                if(BuscarCliente==null)
                {
                    FrmAdminContacto vFormulario = new FrmAdminContacto();
                    vFormulario.IdCliente = Cliente.Id;
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Show();
                    Cliente = null;
                }
                else
                {
                    BuscarCliente.cargarClientes();
                }
                this.Close();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                if (this.FrmReparacion == null)
                {
                    Clientes vFormulario = new Clientes();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Show();
                }
                this.Close();
            }
            else
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.IdCliente = Cliente.Id;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                Cliente = null;
                this.Close();
            }
        }

        private void gmapDireccion_MouseClick(object sender, MouseEventArgs e)
        {
          
           
        }

        private void gmapDireccion_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        private void gmapDireccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           /* GMapControl gm = (GMapControl)sender;
            MouseEventArgs hj = (MouseEventArgs)e;
            PointLatLng vPunto = gm.FromLocalToLatLng(hj.X, hj.Y);
            // String vLatitud = vPunto.Lat.ToString().Replace(",", ".");
            String vLatitud = vPunto.Lat.ToString() ;
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

        private String CondicionIVA()
        {
            String condicion = "";
            if (cmbCondicionIVA.SelectedValue == null)
                condicion = cmbCondicionIVA.Text;
            else
                condicion = cmbCondicionIVA.SelectedValue.ToString();
            return condicion;
        }

        private String TipoDocumento()
        {
            String documento = "";
            if (cmbTipoDocumento.SelectedValue == null)
                documento = cmbTipoDocumento.Text;
            else
                documento = cmbTipoDocumento.SelectedValue.ToString();
            return documento;
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            bool vRes=desagotes.Utils.ComprobarFormatoEmail(txtemail.Text);
            if (!vRes)
                MessageBox.Show("El mail asigando no es valido","ATENCION!");
                
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != ' ' ))
            {
                e.Handled = true;
            }
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            FrmMapas vFormulario = new FrmMapas();
            vFormulario.mPadreCliente = this;
            vFormulario.Geo = Geo;
            vFormulario.ShowDialog();
        }
    }
}
