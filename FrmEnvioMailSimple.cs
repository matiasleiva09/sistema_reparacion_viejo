using MarkupConverter;
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
    public partial class FrmEnvioMailSimple : Form
    {
        private bool mBold = false;
        private bool mItalic = false;
        private bool mSubrayado = false;
        // private IList<AdjuntoLabel> mAdjuntos = new List<AdjuntoLabel>();
        private AdjuntoLabel[] mAdjuntos = new AdjuntoLabel[6];
        private int mIndiceAdjunto = 0;

        public FrmEnvioMailSimple()
        {
            InitializeComponent();
            dgwAdjunto.AutoResizeColumns();
            /* mAdjuntos[0] = new AdjuntoLabel();
             mAdjuntos[0].NombreArchivo = "";
             mAdjuntos[0].LinkForm = lnkAdjunto1;
             mAdjuntos[0].LabelBorrar = lblborrarAdjunto1;
             mAdjuntos[0].NoVisible();

             mAdjuntos[1] = new AdjuntoLabel();
             mAdjuntos[1].NombreArchivo = "";
             mAdjuntos[1].LinkForm = lnkAdjunto2;
             mAdjuntos[1].LabelBorrar = lblborrarAdjunto2;
             mAdjuntos[1].NoVisible();

             mAdjuntos[2] = new AdjuntoLabel();
             mAdjuntos[2].NombreArchivo = "";
             mAdjuntos[2].LinkForm = lnkAdjunto3;
             mAdjuntos[2].LabelBorrar = lblborrarAdjunto3;
             mAdjuntos[2].NoVisible();

             mAdjuntos[3] = new AdjuntoLabel();
             mAdjuntos[3].NombreArchivo = "";
             mAdjuntos[3].LinkForm = lnkAdjunto4;
             mAdjuntos[3].LabelBorrar = lblborrarAdjunto4;
             mAdjuntos[3].NoVisible();

             mAdjuntos[4] = new AdjuntoLabel();
             mAdjuntos[4].NombreArchivo = "";
             mAdjuntos[4].LinkForm = lnkAdjunto5;
             mAdjuntos[4].LabelBorrar = lblborrarAdjunto5;
             mAdjuntos[4].NoVisible();

             mAdjuntos[5] = new AdjuntoLabel();
             mAdjuntos[5].NombreArchivo = "";
             mAdjuntos[5].LinkForm = lnkAdjunto6;
             mAdjuntos[5].LabelBorrar = lblborrarAdjunto6;
             mAdjuntos[5].NoVisible();*/


        }

        private void lblPara_Click(object sender, EventArgs e)
        {

        }

        public String Destinatario
        {
            set { txtdestinatario.Text = value; }
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtdestinatario.Text.Trim() != "" && txtsubject.Text.Trim() != "" && txtcuerpo.Text.Trim() != "")
            {
                FrmProcesoGeneral vFormularioEspera = new FrmProcesoGeneral();
                this.Enabled = false;
                vFormularioEspera.Show();
                vFormularioEspera.Texto = "ENVIANDO EMAIL, POR FAVOR ESPERE";
                vFormularioEspera.Barra.Value = 30;

                List<AdjuntoMail> vAdjuntos = new List<AdjuntoMail>();
                if (dgwAdjunto.Rows.Count >= 1)
                {
                    foreach (DataGridViewRow vFila in dgwAdjunto.Rows)
                    {
                        if(vFila.Cells["Archivo"].Value!=null)
                        {
                            vAdjuntos.Add(new AdjuntoMail(vFila.Cells["Archivo"].Value.ToString(), vFila.Cells["PathArchivo"].Value.ToString()));
                        }
                       
                    }
                }
                String vTextoHtml=RtfToHtmlConverter.ConvertRtfToHtml(txtcuerpo.Rtf);
                Console.WriteLine(vTextoHtml);
                EnviarMail vSendMail = new EnviarMail(txtsubject.Text, txtdestinatario.Text,txtcc.Text, txtcco.Text, vTextoHtml, vAdjuntos);
                vSendMail.Enviar();
                vFormularioEspera.Barra.Value = 100;
                vFormularioEspera.Close();
                this.Close();
            }
            else
            {
               MessageBox.Show("Complete los campos obligatrios de Para, Asunto y el propio mensaje","ATENCION!");
            }
          
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void modificacionTexto()
        {
            FontStyle vFuenteNueva;

            if (mBold && mItalic && mSubrayado)
                vFuenteNueva = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline;
            else if (!mBold && mItalic && mSubrayado)
                vFuenteNueva = FontStyle.Italic | FontStyle.Underline;
            else if (!mBold && !mItalic && mSubrayado)
                vFuenteNueva = FontStyle.Underline;
            else if (mBold && !mItalic && !mSubrayado)
                vFuenteNueva = FontStyle.Bold;
            else if (mBold && !mItalic && mSubrayado)
                vFuenteNueva = FontStyle.Bold | FontStyle.Underline;
            else if (mBold && mItalic && !mSubrayado)
                vFuenteNueva = FontStyle.Bold | FontStyle.Italic;
            else if (!mBold && mItalic && !mSubrayado)
                vFuenteNueva =  FontStyle.Italic;
            else
                vFuenteNueva = FontStyle.Regular;
            txtcuerpo.SelectionFont = new Font(txtcuerpo.SelectionFont.FontFamily, txtcuerpo.SelectionFont.Size, vFuenteNueva);
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            mBold = !mBold;
            modificacionTexto();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            mItalic = !mItalic;
            modificacionTexto();
        }

        private void btnsubrayado_Click(object sender, EventArgs e)
        {
            mSubrayado = !mSubrayado;
            modificacionTexto();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            DialogResult vResultado =ofdBuscarArchivo.ShowDialog();
            if(vResultado == DialogResult.OK)
            {
                String vPathCompletoArchivo = ofdBuscarArchivo.FileName;
                string[] vPathSeparado = ofdBuscarArchivo.FileName.Split('\\');
                String vNombreArchivo = vPathSeparado[(vPathSeparado.Count() - 1)];
                Console.WriteLine(vPathCompletoArchivo);
                dgwAdjunto.Rows.Add(vPathCompletoArchivo, vNombreArchivo);

                /*mAdjuntos[mIndiceAdjunto].NombreArchivo = vNombreArchivo;
                mAdjuntos[mIndiceAdjunto].PathCompleto = vPathCompletoArchivo;
                if (vNombreArchivo.Count() > 20)
                    mAdjuntos[mIndiceAdjunto].LinkForm.Text = vNombreArchivo.Substring(0, 20) +"...";
                else
                    mAdjuntos[mIndiceAdjunto].LinkForm.Text = vNombreArchivo;
                mAdjuntos[mIndiceAdjunto].Visible();
                mIndiceAdjunto++;*/
            }
        }

        private void adjuntar(String xPathArchivo)
        {
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(dgwAdjunto.Rows.Count > 0)
                dgwAdjunto.Rows.Remove(dgwAdjunto.CurrentRow);
        }

        private void dgwAdjunto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwAdjunto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgwAdjunto.CurrentRow!=null && dgwAdjunto.CurrentRow.Cells["archivo"]!=null)
            {
                System.Diagnostics.Process.Start(dgwAdjunto.CurrentRow.Cells["PathArchivo"].Value.ToString());
            }
        }
    }
}
