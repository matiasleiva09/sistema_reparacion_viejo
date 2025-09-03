using reparaciones2.ob.insumos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.presupuestos
{
    public class ItemPresupuesto
    {
        public long Id { get; set; }
        public Articulo Articulo { get; set; }
        public long Cantidad { get; set; }
        public float Neto { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
        public float MontoUnitario { get; set; }

        public ItemPresupuesto(long xId,long xCantidad,Articulo xArticulo,float xNeto,float xIva,float xTotal)
        {
            Id = xId;
            Cantidad = xCantidad;
            Articulo = xArticulo;
            Neto = xNeto;
            Iva = xIva;
            Total = xTotal;
        }

        public ItemPresupuesto()
        {

        }

        public void Copy(ItemPresupuesto xItem)
        {
            Id = xItem.Id;
            Cantidad = xItem.Cantidad;
            Articulo = xItem.Articulo;
            Neto = xItem.Neto;
            Iva = xItem.Iva;
            Total = xItem.Total;
        }
    }
}
