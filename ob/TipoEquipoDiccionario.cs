using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    class TipoEquipoDiccionario
    {
        private long id;
        private String tipoEquipo;
        private String marca;
        private String modelo;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String TipoEquipo
        {
            get { return tipoEquipo; }
            set { tipoEquipo = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
    }
}
