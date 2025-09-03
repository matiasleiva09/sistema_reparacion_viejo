using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.presupuestos
{
   public class presupuestosCliente
    {
        public long Id { get; set; }
        public Reparacion Reparacion { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public float Neto { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
        public float MontoUnitario { get; set; }
        public IList<ItemPresupuesto> Items { get; set; }

        public presupuestosCliente(long xId,DateTime xFecha,Cliente xCliente,Reparacion xReparacion,float xNeto,float xIva,float xTotal)
        {
            Id = xId;
            Fecha = xFecha;
            Cliente = xCliente;
            Neto = xNeto;
            Iva = xIva;
            Total = xTotal;
            Items = new List<ItemPresupuesto>();
        }

        public presupuestosCliente()
        {
            Items = new List<ItemPresupuesto>();
        }

        public void Copy(presupuestosCliente xPresupuesto)
        {
            Id = xPresupuesto.Id;
            Fecha = xPresupuesto.Fecha;
            Cliente = xPresupuesto.Cliente;
            Reparacion = xPresupuesto.Reparacion;
            Items = xPresupuesto.Items;
            Neto = xPresupuesto.Neto;
            Iva = xPresupuesto.Iva;
            Total = xPresupuesto.Total;
            MontoUnitario = xPresupuesto.MontoUnitario;
        }
    }
}
