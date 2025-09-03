using reparaciones2.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.comunicacion
{
    public abstract class Communication
    {
        public string SSID
        { get;set;}
        public string Token
        { get; set; }
        public string OriginPhone
        { get; set; }
        public string DestinyPhone
        { get; set; }
        public string Message
        { get; set; }
        //esta funcion toma los datos de la base de datos para despues laburarlos
        //en las clases que heredan este comportamiento
        protected void ObtainDataFromLogin()
        {
            SSID = DaoParametrosDatos.getParametro("WHATSAPPSSID");
            Token = DaoParametrosDatos.getParametro("WHATSAPPTOKEN");
            OriginPhone = DaoParametrosDatos.getParametro("WHATSAPPNUMERO");
        }

        public void Do()
        {
            this.ObtainDataFromLogin();
            this.Execute();
        }
        protected abstract void Execute();

        
    }
}
