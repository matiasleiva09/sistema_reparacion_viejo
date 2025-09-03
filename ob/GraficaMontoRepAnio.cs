using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    class GraficaMontoRepAnio
    {
        private List<String> mSeries = new List<String>();
        private int mAnioDesde = 0;
        private int mAnioHasta = 0;
        private DataTable mDatos = null;

        public List<String> Series
        {
            get { return mSeries; }
            set { mSeries = value; }
        }

        public GraficaMontoRepAnio(int xAnioDesde,int xAnioHasta,DataTable xDatos)
        {
            mAnioDesde = xAnioDesde;
            mAnioHasta = xAnioHasta;
            mDatos = xDatos;
        }

        public void GenerarDatosParaGraficar()
        {
            
        }
    }
}
