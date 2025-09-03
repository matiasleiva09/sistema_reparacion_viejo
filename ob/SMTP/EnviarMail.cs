using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.SMTP
{
    class EnviarMail
    {
        private String mEmail = "";
        private String mContrasenaEmail = "";
        private int mPuertoSMTP = 25;
        private String mServidorSMTP = "";
        private String mTitulo = "";
        private String mDestinatario = "";
        private IList<String> mDestinatarios = null;
        private String mCCO = "";
        private String mCC = "";
        private String mCuerpo = "";
        private List<AdjuntoMail> mAdjuntos = null;


        private void cargarDatos()
        {
            mEmail=dao.DaoParametrosDatos.getParametro("EMAILENVIO");
            mContrasenaEmail = dao.DaoParametrosDatos.getParametro("CONTRASEÑAENVIO");
            mPuertoSMTP = int.Parse(dao.DaoParametrosDatos.getParametro("PUERTO_SMTP"));
            mServidorSMTP = dao.DaoParametrosDatos.getParametro("SERVIDOR_SMTP");
        }

        public EnviarMail(String xTitulo,String xDestinatario,IList<String> xDestinatarios,
            String xCuerpo)
        {
            cargarDatos();
            mTitulo = xTitulo;
            mDestinatario = xDestinatario;
            mCuerpo = xCuerpo;
        }

        public EnviarMail(String xTitulo,String xDestinatario,String xCC,String xCCO,String xCuerpo)
        {
            cargarDatos();
            mTitulo = xTitulo;
            mDestinatario = xDestinatario;
            mCC = xCC;
            mCCO = xCCO;
            mCuerpo = xCuerpo;
        }

        public EnviarMail(String xTitulo,String xDestinatario,String xCC,String xCCO,
            String xCuerpo,List<AdjuntoMail> xAdjuntos)
        {
            cargarDatos();
            mTitulo = xTitulo;
            mDestinatario = xDestinatario;
            mCC = xCC;
            mCCO = xCCO;
            mCuerpo = xCuerpo;
            mAdjuntos = xAdjuntos;
        }

        private MailAddress[] ObtenerTodosLosCC()
        {
            MailAddress[] vRes;
            String vCC = PasarOtrosFormatosAcoma(mCC);
            if (vCC.Trim()!="")
            {
                if(vCC.IndexOf(",") > 0)
                {
                   String[] vCCS = vCC.Split(',');
                    int vCantidad = vCCS.Count();
                    vRes = new MailAddress[vCantidad];
                    for (int vI = 0; vI < vCCS.Count(); vI++)
                    {
                        vRes[vI]=new MailAddress(vCCS[vI]);
                    }
                      
                }
                else
                {
                    vRes = new MailAddress[1];
                    vRes[0]=new MailAddress(vCC.Trim());
                }
            }
            else
            {
                vRes = new MailAddress[0];
            }
            return vRes;
        }

        private String PasarOtrosFormatosAcoma(String xFormato)
        {
            xFormato = xFormato.Replace(" ", ",");
            xFormato = xFormato.Replace(";",",");
            return xFormato;
        }


        private MailAddress[] ObtenerTodosLosCCO()
        {
            MailAddress[] vRes;
            String vCCO = PasarOtrosFormatosAcoma(mCCO);
            if (vCCO.Trim() != "")
            {
                if (vCCO.IndexOf(",") > 0)
                {
                    String[] vCCOS = vCCO.Split(',');
                    int vCantidad = vCCOS.Count();
                    vRes = new MailAddress[vCantidad];
                    for (int vI = 0; vI < vCCOS.Count(); vI++)
                    {
                        vRes[vI] = new MailAddress(vCCOS[vI]);
                    }

                }
                else
                {
                    vRes = new MailAddress[1];
                    vRes[0] = new MailAddress(vCCO.Trim());
                }
            }
            else
            {
                vRes = new MailAddress[0];  
            }
            return vRes;
        }

        public bool Enviar()
        {
            bool vRes = false;
            SmtpClient vEnvio = new SmtpClient();
            vEnvio.UseDefaultCredentials = false;
            vEnvio.Host = mServidorSMTP;
            vEnvio.Port = mPuertoSMTP;
            vEnvio.Credentials = new NetworkCredential(mEmail,mContrasenaEmail);
            MailAddress vMailDesde = new MailAddress(mEmail);
            MailMessage vCuerpo = null;
            MailAddress vMailHacia = new MailAddress(mDestinatario);
            vCuerpo = new MailMessage(vMailDesde, vMailHacia);
            Console.WriteLine(mAdjuntos.Count());
            if(mAdjuntos!=null && mAdjuntos.Count() > 0)
            {
               foreach(AdjuntoMail vAdjunto in mAdjuntos)
               {
                    vCuerpo.Attachments.Add(vAdjunto.generarAdjunto());
               }
            }
            MailAddress[] vCCO= ObtenerTodosLosCCO();
            MailAddress[] vCC = ObtenerTodosLosCC();
            for (int vI = 0; vI < vCC.Count(); vI++)
                vCuerpo.CC.Add(vCC[vI]);
            vCC = null;
            for (int vI = 0; vI < vCCO.Count(); vI++)
               vCuerpo.Bcc.Add(vCCO[vI]);
            vCuerpo.Subject = mTitulo; 
            vCuerpo.IsBodyHtml = true;
            vCuerpo.Body = mCuerpo;
            vEnvio.EnableSsl = true;
            vEnvio.Send(vCuerpo);
            vMailHacia = null;
            vCuerpo = null;
            vEnvio.Dispose();
            vEnvio = null;
            return vRes;
        }
    }
}
