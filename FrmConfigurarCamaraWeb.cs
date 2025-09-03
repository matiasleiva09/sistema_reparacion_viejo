using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using reparaciones2.dao;

namespace reparaciones2
{
    public partial class FrmConfigurarCamaraWeb : Form
    {
        private FilterInfoCollection DispositivoDeVideo;
     

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cmbCamara.Items.Add(Dispositivos[0].Name.ToString());
            cmbCamara.Text = cmbCamara.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                MessageBox.Show("Conecte antes una camara para poder seleccionar.","Atención!");
            }

            else
            {
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public FrmConfigurarCamaraWeb()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        private void lblleyenda_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfigurarCamaraWeb_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String vCamara = "";
            if (cmbCamara.SelectedValue!=null && cmbCamara.SelectedValue.ToString()!="")
            {
                vCamara = cmbCamara.SelectedValue.ToString();
            }
            else
            {
                vCamara = cmbCamara.Text;
            } 
            
            if(vCamara!="")
            {
                DaoParametrosDatos.UpdateParametro(vCamara, "CAMARAWEB");
                Close();
            }
            else
            {
                MessageBox.Show("No se puede guardar nada si no se selecciono una camara","Atención!");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
