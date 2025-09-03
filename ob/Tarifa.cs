using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    public class Tarifa
    {
        public static string TIPO_REPARACION = "REPARACION";
        public static string TIPO_SERVICE = "SERVICE";
        private long id = 0;
        private String mServicio = TIPO_REPARACION;
        private String descripcion = "";
        private float monto = 0.00f;

        public String Servicio
        {
            get { return mServicio; }
            set { mServicio = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
