using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.SMTP
{
    class AdjuntoMail
    {
        private String mNombre;
        private String mUbicacion;

        public String Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public String Ubicacion
        {
            get { return mUbicacion; }
            set { mUbicacion = value; }
        }

        public AdjuntoMail(String xNombre,String xUbicacion)
        {
            mUbicacion = xUbicacion;
            mNombre = xNombre;
        }

        public Attachment generarAdjunto()
        {
            System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
            contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
            contentType.Name = mNombre;
            return new Attachment(mUbicacion, contentType);
        }
    }
}
