using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class TipoArticulo
    {
        private long mId = 0;
        private String mDescripcion = null;

        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public String Descripcion
        {
            get { return mDescripcion; }
            set { mDescripcion = value; }
        }
    }
}
