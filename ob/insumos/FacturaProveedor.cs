using desagotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class FacturaProveedor
    {
        public static String TIPO_A = "A";
        public static String TIPO_B = "B";
        public static String TIPO_C = "C";
        public static String TIPO_REMITO = "X";

        private long id = 0;
        private String tipoFactura = TIPO_A;
        private String nroFactura = "00001-00001";
        private Proveedor proveedor = null;
        private DateTime fecha = DateTime.Now;
        private float neto = 0.00f;
        private float iva = 0.00f;
        private float total = 0.00f;
        private List<ItemFactura> items = new List<ItemFactura>();


        public String NroFactura
        {
            get { return nroFactura; }
            set { nroFactura = value; }
        }

        public List<ItemFactura> Items
        {
            get { return items; }
            set { items = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public float IVA
        {
            get { return iva; }
            set { iva = value; }
        }

        public float Neto
        {
            get { return neto; }
            set { neto = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public String TipoFactura
        {
            get { return tipoFactura; }
            set { tipoFactura = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String FechaBase()
        {
            return Utils.getFechaBase(this.Fecha+"");
        }
    }
}
