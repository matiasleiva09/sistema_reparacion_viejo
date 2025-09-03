using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    public class Cliente
    {
        public static String RESPONSABLE_INSCRIPTO = "REPONSABLE INCRIPTO";
        public static String MONOTRIBUTISTA = "RESPONSABLE MONOTRIBUTO";
        public static String EXENTO = "EXENTO";
        public static String CONSUMIDOR_FINAL = "CONSUMIDOR FINAL";
        public static String DNI = "DNI";
        public static String LE = "LIBRETA DE ENROLAMIENTO";
        public static String LC = "LIBRETA CIVICA";
        public static String CE = "CEDULA EXTRANJERA";
        public static String PASAPORTE = "PASAPORTE";
        private long id;
        private String nombre;
        private String condicionIVA;
        private String cuit;
        private String calle;
        private String nro;
        private String piso;
        private String dpto;
        private String cp;
        private String localidad;
        private String provincia;
        private String telefono;
        private String celular;
        private String email;
        private String observaciones = "";
        private String geo = "";
        private String tipoDocumento = "";
        private String nroDocumento = "";


        public String ToString()
        {
            return "Nombre: " + nombre + ", Tel: " + telefono + ", email: " + email; 
        }
        public String NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }

        public String TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

        public String Geo
        {
            get { return geo; }
            set { geo = value; }
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

        public String CondicionIVA
        {
            get { return condicionIVA; }
            set { condicionIVA = value; }

        }

        public String Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public String Nro
        {
            get { return nro; }
            set { nro = value; }
        }

        public String Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public String Dpto
        {
            get { return dpto; }
            set { dpto = value; }
        }

        public String Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public String Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public String Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public String Direccion()
        {
            String vDireccion = "";
            if (Calle != null && Calle.Trim() != "")
            {
                vDireccion = "Calle: " + Calle;
                if (Nro != null && Nro.Trim() != "")
                    vDireccion += " Nro: " + Nro;
                else
                    vDireccion += " Nro:S/D";
                if (Piso != null && Piso.Trim() != "")
                    vDireccion += " Piso: " + Piso;
                if (Dpto != null && Dpto.Trim() != "")
                    vDireccion += " Piso: " + Dpto;
                if (Localidad != null && Localidad.Trim() != "")
                    vDireccion += " Localidad: " + Localidad;
                else
                    vDireccion += " Localidad: S/D";
                if (Cp != null && Cp.Trim() != "")
                    vDireccion += " Cp: " + Localidad;
                else
                    vDireccion += " Cp: S/D";
                if (Provincia != null && Provincia.Trim() != "")
                    vDireccion += " Provincia: " + Provincia;
                else
                    vDireccion += " Provincia: S/D";
            }
            return vDireccion;
        }
    }
}
