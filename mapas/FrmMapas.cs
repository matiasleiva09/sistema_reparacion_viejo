using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace reparaciones2.mapas
{
    public partial class FrmMapas : Form
    {   
        public String Geo { get; set; }
        public FrmService mPadreService { get; set; }
        public FrmEditarCliente mPadreCliente { get; set; }
        public FrmParametros Parametros { get; set; }
        public FrmMapas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
           
            this.Close();
        }

        private void FrmMapas_Load(object sender, EventArgs e)
        {
            gmapDireccion.MapProvider = GMapProviders.GoogleMap;
            gmapDireccion.DragButton = MouseButtons.Left;
            //gmapDireccion.Zoom = 9;
            gmapDireccion.ShowCenter = false;
            Size siz = new System.Drawing.Size(gmapDireccion.Width, gmapDireccion.Height);
            gmapDireccion.ClientSize = siz;
            if (Geo != null && Geo.Trim() != "")
            {
                String[] vLatLong = Geo.Split(',');
                gmapDireccion.Overlays.Clear();
                GMapOverlay markers = new GMapOverlay("markers");
                Double vLong = Double.Parse(vLatLong[0].ToString().Trim());
                Double vLatitud = Double.Parse(vLatLong[1].ToString().Trim());
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
                if(vGeoPosicion!=null && vGeoPosicion.Trim()!="")
                {
                    String[] vLatLong = vGeoPosicion.Split(',');
                    gmapDireccion.Position = new PointLatLng(Double.Parse(vLatLong[0].ToString().Trim()),
                            Double.Parse(vLatLong[1].ToString().Trim()));
                }
            }
             
            gmapDireccion.MinZoom = 0;
            gmapDireccion.MaxZoom = 30;
            gmapDireccion.Zoom = 15;
        }

        private void gmapDireccion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GMapControl gm = (GMapControl)sender;
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
            markers.Markers.Add(marker);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mPadreService != null)
                mPadreService.Geo = Geo;
            if (mPadreCliente != null)
                mPadreCliente.Geo = Geo;
            if (Parametros != null)
                Parametros.Geo(Geo);
            Cerrar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
          
            Cerrar();
        }

        private void gmapDireccion_Load(object sender, EventArgs e)
        {

        }

        private void panelBarraArriba_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
