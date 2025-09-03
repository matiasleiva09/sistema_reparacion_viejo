using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class ItemFacturaAuxiliar
    {
        public float MontoNeto_unitario { get; set; }
        public float MontoIva_unitario { get; set; }
        public float MontoTotal_unitario { get; set; }
        public ItemFactura Item { get; set; }

        public void DesglozarMontos()
        {
          //  Item.Neto = MontoNeto_unitario * Item.Cantidad;
          //  Item.Total= Item.Neto
        }

    }
}
