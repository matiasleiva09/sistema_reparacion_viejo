using desagotes.reportes;
using reparaciones2.dao;
using reparaciones2.ob.SMTP;
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
    public partial class FrmImprimirEntrega : Form
    {
        private ReporteService mReporteService = null;
        public ReporteServiceDomicilio ReporteServiceDomiciliario { get; set; }
        private ReporteEntrega mReporteEntrega = null;
        private ReciboPDF mReciboPdf = null;
        private String mNombreCliente = "";
        private String mEmailCliente = "";
        BackgroundWorker workerMail = new BackgroundWorker();
 

        public void ActualizarEmail(String xEmail)
        {
            mEmailCliente = xEmail;
        }

        public String NombreCliente
        {
            get {return mNombreCliente; }
            set { mNombreCliente = value; }
        }    

        public String EmailCliente
        {
            get { return mEmailCliente; }
            set { mEmailCliente = value; }
        }

        public ReporteService ReporteOrdenDeReparacion
        {
            get { return mReporteService; }
            set { mReporteService = value; }
        }

        public ReporteEntrega ReporteEntregaEquipo
        {
            get { return mReporteEntrega; }
            set { mReporteEntrega = value; }
        }

        public ReciboPDF ReporteReciboPDF
        {
            get { return mReciboPdf; }
            set { mReciboPdf = value; }
        }


        public FrmImprimirEntrega()
        {
            InitializeComponent();
            bool vMandarMails = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if (!vMandarMails)
                btnEnviarPorMail.Enabled = false;
        }

        public void labelBotonImprimir(String xDescripcion)
        {
            btnImprimir.Text = xDescripcion;
        }

        private void FrmImprimirEntrega_Load(object sender, EventArgs e)
        {
            if(mReporteEntrega==null && mReporteService==null && ReporteServiceDomiciliario==null)
            {
                btnImprimir.Visible = false;
            }
            if (mReciboPdf != null)
                 mReciboPdf.crearPdf();
            if (mReporteEntrega != null)
                mReporteEntrega.crearPdf();
            else if (mReporteService != null)
                 mReporteService.crearPdf();
            else if (ReporteServiceDomiciliario != null)
                ReporteServiceDomiciliario.crearPdf();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (mReporteEntrega != null)
                System.Diagnostics.Process.Start(mReporteEntrega.crearPdf());
            else if (mReporteService != null)
                System.Diagnostics.Process.Start(mReporteService.crearPdf());
            else if(ReporteServiceDomiciliario!=null)
                System.Diagnostics.Process.Start(ReporteServiceDomiciliario.crearPdf());
            else
                MessageBox.Show("No se puede acceder al archivo", "ATENCION!");
        }

        private void btnImprimirRecibo_Click(object sender, EventArgs e)
        {
            if (mReciboPdf != null)
                System.Diagnostics.Process.Start(mReciboPdf.crearPdf());
            else
                MessageBox.Show("No se puede acceder al archivo", "ATENCION!");
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarPorMail_Click(object sender, EventArgs e)
        {
            bool vRes = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if(mReporteService!=null)
                mReporteService.crearPdf();
            if (vRes && (EmailCliente != ""))
            {
                FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
                vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
                vFormularioProgreso.Show();
                this.Enabled = false;

                AdjuntoMail vAdjunto = null;
                if(mReporteService!=null)
                    vAdjunto =  new AdjuntoMail(mReporteService.NombreDocumento, mReporteService.NombreDocumentoCompleto);
                else if(mReporteEntrega!=null)
                    vAdjunto = new AdjuntoMail(mReporteEntrega.NombreDocumento, mReporteEntrega.NombreDocumentoCompleto);
                //AdjuntoMail vReciboAdjunto = new AdjuntoMail(mReciboPdf.NombreDocumento, mReciboPdf.NombreDocumentoCompleto);
                vFormularioProgreso.Barra.Value = 10;
                String vMensaje = DaoParametrosDatos.getParametro("CUERPOMAILORDEN");
                vMensaje = vMensaje.Replace("{xCliente}", NombreCliente);
                List<AdjuntoMail> vAdjuntos = new List<AdjuntoMail>();
                vAdjuntos.Add(vAdjunto);
                vFormularioProgreso.Barra.Value = 30;
                EnviarMail vCorreo = new EnviarMail("ORDEN DE REPARACION", EmailCliente, "", "", vMensaje, vAdjuntos);
                vFormularioProgreso.Barra.Value = 50;
                vCorreo.Enviar();
                vAdjunto = null;
                vAdjuntos = null;
                vCorreo = null;
                vFormularioProgreso.Barra.Value = 100;
                this.Enabled = true;
                vFormularioProgreso.Close();
                vFormularioProgreso = null;
            }
            else if (EmailCliente=="")
                MessageBox.Show("No puede enviar mails porque no ha ingresado el mismo del cliente.");
        }
    }
}
