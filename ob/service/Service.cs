using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.service
{
    public class Service
    {
        private long mId = 0;
        private Cliente mCliente = null;
        private String mPrioridad = "BAJA";
        private DateTime mFechaPrometida;
        private DateTime mFechaTomado;
        private DateTime mFechaRealizada;
        private String mSolucion = "";
        private String mCalle = "";
        private String mNro = "";
        private String mPiso = "";
        private String mDpto = "";
        private String mLocalidad = "";
        public String Provincia { get; set; }
        public String Problema { get; set; }
        public String Estado { get; set; }
        public String TomadoPor { get; set; }
        public String AsignadoA { get; set; }
        public float Monto { get; set; }
        public float Senia { get; set; }
        public String Coordenadas { get; set; }
        public String Cp { get; set; }
        public String ObservacionesDomicilio { get; set; }

        public String Prioridad
        {
            get { return mPrioridad; }
            set { mPrioridad = value; }
        }

        public String Localidad
        {
            get { return mLocalidad; }
            set { mLocalidad = value; }
        }

        public String Dpto
        {
            get { return mDpto; }
            set { mDpto = value; }
        }

        public String Piso
        {
            get { return mPiso; }
            set { mPiso = value; }
        }

        public String Nro
        {
            get { return mNro; }
            set { mNro = value; }
        }

        public String Calle
        {
            get { return mCalle; }
            set { mCalle = value; }
        }

        public String Solucion
        {
            get { return mSolucion; }
            set { mSolucion = value; }
        }

        public DateTime FechaRealizada
        {
            get { return mFechaRealizada; }
            set { mFechaRealizada = value; }
        }

        public DateTime FechaTomado
        {
            get { return mFechaTomado; }
            set { mFechaTomado = value; }
        }

        public DateTime FechaPrometida
        {
            get { return mFechaPrometida; }
            set { mFechaPrometida = value; }
        }

        public Cliente Cliente
        {
            get
            {
                if (mCliente == null)
                    return mCliente = new Cliente();
                else
                    return mCliente;
            }
            set
            {
                mCliente = value;
            }
        }

        public long Id
        {
            get { return mId; }
            set { mId = value; }
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
