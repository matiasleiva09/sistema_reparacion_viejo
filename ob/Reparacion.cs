using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    public class Reparacion
    {
        private long id;
        private String fecha_entrada;
        private String fecha_realizada;
        private String fecha_entregada;
        private Cliente cliente;
        private String estado;
        private Equipo equipo;
        private String falla;
        private String informe;
        private String accesorios;
        private String tomada_por;
        private String reparada_por;
        private String entregada_por;
        private Double monto;
        private Double senia;
        private String retirada_por;
        private String codigo;
        private String observaciones = "";
        private String informeInterno = ""; 

        public String Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public String InformeInterno
        {
            get { return informeInterno; }
            set { informeInterno = value; }
        }
        
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Fecha_Entrada
        {
            get { return fecha_entrada; }
            set { fecha_entrada = value; }
        }

        public String Fecha_Realizada
        {
            get { return fecha_realizada; }
            set { fecha_realizada = value; }
        }

        public String Fecha_Entregada
        {
            get { return fecha_entregada; }
            set { fecha_entregada = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Equipo Equipo
        {
            get { return equipo; }
            set { equipo = value; }
        }

        public String Falla
        {
            get { return falla; }
            set { falla = value; }
        }

        public String Informe
        {
            get { return informe; }
            set { informe = value; }
        }

        public String Accesorios
        {
            get { return accesorios; }
            set { accesorios = value; }
        }

        public String Tomada_Por
        {
            get { return tomada_por; }
            set { tomada_por = value; }
        }

        public String Reparada_por
        {
            get { return reparada_por; }
            set { reparada_por = value; }
        }

        public String Entregada_por
        {
            get { return entregada_por; }
            set { entregada_por = value; }
        }

        public String Retirada_por
        {
            get { return retirada_por; }
            set { retirada_por = value; }
        }

        public Double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public Double Senia
        {
            get { return senia; }
            set { senia = value; }
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
