using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class ItemFactura
    {
        private long id = 0;
        private FacturaProveedor factura = null;
        private Articulo articulo = null;
        private long cantidad = 1;
        private float porcentaje_iva = 0.00f;
        private float neto = 0.00f;
        private float iva = 0.00f;
        private float total = 0.00f;

        public float Porcentaje_iva
        {
            get { return porcentaje_iva; }
            set { porcentaje_iva = value; }
        }

        public long Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public FacturaProveedor Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
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

        

    }
}
