using reparaciones2.ob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stocksires.ob
{
    public class Pedido
    {
        public long Id { get; set; }
        
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrega { get; set; }
        public Cliente Cliente { get; set; }
        public float Neto { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
        public float MontoUnitario { get; set; }
        public IList<ItemPedido> Items { get; set; }

        public Pedido(long xId, DateTime xFecha,DateTime xFechaEntrega, Cliente xCliente, float xNeto, float xIva, float xMontoUnitario, float xTotal)
        {
            Id = xId;
            Fecha = xFecha;
            FechaEntrega = xFechaEntrega;
            Cliente = xCliente;
            Neto = xNeto;
            Iva = xIva;
            Total = xTotal;
            MontoUnitario = xMontoUnitario;
            Items = new List<ItemPedido>();
        }

        public Pedido()
        {
            Items = new List<ItemPedido>();
        }

        public void Copy(Pedido xPresupuesto)
        {
            Id = xPresupuesto.Id;
            Fecha = xPresupuesto.Fecha;
            FechaEntrega = xPresupuesto.FechaEntrega;
            Cliente = xPresupuesto.Cliente;
            Items = xPresupuesto.Items;
            Neto = xPresupuesto.Neto;
            Iva = xPresupuesto.Iva;
            MontoUnitario = xPresupuesto.MontoUnitario;
            Total = xPresupuesto.Total;
        }
    }
}
