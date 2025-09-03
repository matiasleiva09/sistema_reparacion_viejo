using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob.insumos
{
    public class Articulo
    {
        private long id = 0;
        private String codigo = "";
        private String nombre = "";
        private Proveedor proveedor = null;
        private Marca marca = null;
        private TipoArticulo tipo = null;
        private float costo = 0.00f;
        private float iva = 21.00f;
        private float monto = 0.00f;
        private long stockminimo = 1;
        private long stockmaximo = 1;
        private long stockActual = 1;
        private float ganancia = 0;

        public string Unidad
        {
            get; set;
        }

        public long StockActual
        {
            get { return stockActual; }
            set { stockActual = value; }
        }

        public float Ganancia
        {
            get { return ganancia; }
            set { ganancia = value; }
        }

        public long StockMaximo
        {
            get { return stockmaximo; }
            set { stockmaximo = value; }
        }

        public long StockMinimo
        {
            get { return stockminimo; }
            set { stockminimo = value; }
        }

        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public float Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        public float Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public TipoArticulo Modelo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Marca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public float MontoIVA()
        {
            float total = costo * (1f + (iva / 100f));
            float montoIva = total - costo;
            return montoIva;
        }

        public float MontoIVAGanancia()
        {
            float resultado = monto * (1f + (iva / 100f));
            return resultado;
        }

    }
}
