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
using desagotes;
using System.IO;
using reparaciones2.ob;

namespace reparaciones2
{
    public partial class FrmCamara : Form
    {
        private FilterInfoCollection mDispositivos = null;
        private FilterInfo mDispositivo = null;
        private VideoCaptureDevice mFuenteDeVideo = null;
        private String mValorCamara = null;
        private long mReparacion = 0;
        private String mNroOrden = "";
        public List<Image> mListaImagenes = new List<Image>();
        private int mFotoActual = 0;
        private frmEditarReparacion mFormularioReparacion = null;

        public frmEditarReparacion FormularioReparacion
        {
            get { return mFormularioReparacion; }
            set { mFormularioReparacion = value; }
        }

        public String NroOrden
        {
            get { return mNroOrden; }
            set { mNroOrden = value; }
        }

        public long Reparacion
        {
            get { return mReparacion; }
            set { mReparacion = value; }
        }

        public void CargarYaGuardadas()
        {
            DataTable vImagenes = DaoFotosReparacion.ObtenerFotosReparacion(mReparacion);
            Image vImagen = null;
            for (int vI = 0; vI < vImagenes.Rows.Count; vI++)
            {
                vImagen = Image.FromFile(Utils.ObtenerPathDOCS() + vImagenes.Rows[vI]["frarchivo"].ToString());
                vImagen.Tag = vImagenes.Rows[vI]["frarchivo"].ToString();
                mListaImagenes.Add(vImagen);
                    vImagen = null;
                }
                if(mListaImagenes.Count >0)
                {
                    panelImagen.BackgroundImage = mListaImagenes[0];
                }
        }

        public FrmCamara()
        {
            InitializeComponent();
            mValorCamara = DaoParametrosDatos.getParametro("CAMARAWEB");
            cargarDispositivoPorDefecto();
           
            DaleConLaCamara();
        }

        private void cargarDispositivoPorDefecto()
        {
            mDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            bool vEncontrado = false;
            int i = 0;
            while (!vEncontrado && i< mDispositivos.Count)
            {
                if(mDispositivos[0].Name.ToString()== mValorCamara)
                {
                    vEncontrado = true;
                    mDispositivo = mDispositivos[0];
                }
                i++;
            }

       }
       
        public void TerminarFuenteDeVideo()
        {
            if (!(mFuenteDeVideo == null))
                if (mFuenteDeVideo.IsRunning)
                {
                    mFuenteDeVideo.SignalToStop();
                    mFuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            imagenVideo.Image = Imagen;

        }

        private void DaleConLaCamara()
        {
            mFuenteDeVideo = new VideoCaptureDevice(mDispositivo.MonikerString);
            mFuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
            mFuenteDeVideo.Start();
        }

        private void FrmCamara_Load(object sender, EventArgs e)
        {
            if (mReparacion > 0)
            {
                CargarYaGuardadas();
            }
            else
            {
                if(mListaImagenes!=null && mListaImagenes.Count > 0)
                    panelImagen.BackgroundImage = mListaImagenes[0];
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            if (mReparacion == 0  && mListaImagenes.Count > 0)
                this.mFormularioReparacion.Imagenes=mListaImagenes;
            Close();
        }

        private void FrmCamara_FormClosing(object sender, FormClosingEventArgs e)
        {
            TerminarFuenteDeVideo();
            if (mReparacion == 0 && mListaImagenes.Count > 0)
                this.mFormularioReparacion.Imagenes=mListaImagenes;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (imagenVideo.Image != null)
            {
                String vNombreArchivo = "";
                Random vRandom = new Random();
                int vValorUno = vRandom.Next();
                vNombreArchivo = vValorUno + "" + vRandom.Next(vValorUno, (vValorUno + 100));
                vNombreArchivo += ".jpg";
                imagenVideo.Image.Tag = vNombreArchivo;
                if (mReparacion > 0)
                {
                    string ruta = Path.Combine(Utils.ObtenerPathDOCS(), vNombreArchivo);
                    imagenVideo.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                    DaoFotosReparacion.GuardarFoto(mReparacion, vNombreArchivo);
                }
                mListaImagenes.Add(imagenVideo.Image);
                mFotoActual = mListaImagenes.Count - 1;
                panelImagen.BackgroundImage = mListaImagenes[mListaImagenes.Count -1];
                MessageBox.Show("Imagen guardarda correctamente", "Atención!");
            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            mListaImagenes.Remove(panelImagen.BackgroundImage);
            if (mReparacion > 0)
            {
                File.Delete(Utils.ObtenerPathDOCS() + panelImagen.BackgroundImage.ToString());
                DaoFotosReparacion.BorrarFoto(mReparacion, panelImagen.BackgroundImage.Tag.ToString());
            }

            if (mListaImagenes.Count > 0)
            {
                panelImagen.BackgroundImage = mListaImagenes[0];
            }
            else
            {
                panelImagen.BackgroundImage = null;
            }
           
            MessageBox.Show("Imagen guardarda correctamente", "Atención!");
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if ((mFotoActual + 1) < mListaImagenes.Count)
            {
                mFotoActual++;
                panelImagen.BackgroundImage = mListaImagenes[mFotoActual];
            }
           /* else
            {
                mFotoActual = mListaImagenes.Count - 1;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((mFotoActual - 1) >=0)
            {
                mFotoActual--;
                panelImagen.BackgroundImage = mListaImagenes[mFotoActual];
            }
            else
            {
                mFotoActual = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
