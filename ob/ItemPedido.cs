using reparaciones2.ob.insumos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stocksires.ob
{
    public class ItemPedido
    {
        public long Id { get; set; }
        public Articulo Articulo { get; set; }
        public long Cantidad { get; set; }
        public float Neto { get; set; }
        public float Iva { get; set; }
        public float MontoUnitario { get; set; }
        public float Total { get; set; }

        public ItemPedido(long xId, long xCantidad, Articulo xArticulo,
            float xNeto, float xIva, float xMontoUnitario, float xTotal)
        {
            Id = xId;
            Cantidad = xCantidad;
            Articulo = xArticulo;
            Neto = xNeto;
            Iva = xIva;
            MontoUnitario = xMontoUnitario;
            Total = xTotal;
        }

        public ItemPedido()
        {

        }

        public void Copy(ItemPedido xItem)
        {
            Id = xItem.Id;
            Cantidad = xItem.Cantidad;
            Articulo = xItem.Articulo;
            Neto = xItem.Neto;
            Iva = xItem.Iva;
            MontoUnitario = xItem.MontoUnitario;
            Total = xItem.Total;
        }
    }
}
