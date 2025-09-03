using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class Proveedor
    {
        private long id=0;
        private String nombre = "";
        private String condicionIVA = "";
        private String cuit = "0000000000000";
        private String calle = "";
        private String nro ="";
        private int piso = 0;
        private String dpto = "";
        private String localidad = "";
        private String provincia = "";
        private String cp = "";
        private String telefono = "";
        private String celular = "";
        private String whatsapp = "";
        private String email = "";
        
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Whatsapp
        {
            get { return whatsapp; }
            set { whatsapp = value; }
        }

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public String Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public String Dpto
        {
            get { return dpto; }
            set { dpto = value; }
        }

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public String Nro
        {
            get { return nro; }
            set { nro = value; }
        }

        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public String Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public String CondicionIVA
        {
            get { return condicionIVA; }
            set { condicionIVA = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
