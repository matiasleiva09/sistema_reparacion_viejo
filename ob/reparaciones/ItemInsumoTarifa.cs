using reparaciones2.ob.caja;
using reparaciones2.ob.insumos;
using reparaciones2.ob.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.reparaciones
{
    public class ItemInsumoTarifa
    {
        public long Id { get; set; }
        public Tarifa Tarifa { get;set; }
        public Articulo Articulo { get; set; }
        public ReciboIngreso Recibo { get; set; }
        public Reparacion Reparacion { get; set; }
        public Service Service { get; set; }
        public int Cantidad { get; set; }
        public double Neto { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }

        public ItemInsumoTarifa()
        {

        }


        public long IdTarifa()
        {
            if (Tarifa != null)
                return Tarifa.Id;
            else
                return 0;
        }

        public string IdTarifaParaBase()
        {
            if (Tarifa != null)
                return Tarifa.Id + "";
            else
                return "null";
        }

        public string IdReciboParaBase()
        {
            if (Recibo != null)
                return Recibo.Id + "";
            else
                return "null";
        }

        public string IdArticuloParaBase()
        {
            if (Articulo != null)
                return Articulo.Id + "";
            else
                return "null";
        }

        public long IdArticulo()
        {
            if (Articulo != null)
                return Articulo.Id;
            else
                return 0;
        }

        public String Descripcion()
        {
            
            if (Tarifa != null)
                return Tarifa.Descripcion;
            else if (Articulo != null)
                return Articulo.Nombre;
            else
                return "";
        }

       
    }
}
