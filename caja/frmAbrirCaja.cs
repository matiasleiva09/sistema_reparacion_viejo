using reparaciones2.dao;
using reparaciones2.ob.caja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.caja
{
    public partial class frmAbrirCaja : Form
    {
        public string Usuario { get; set; }
        
        public frmAbrirCaja()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbrirCaja_Load(object sender, EventArgs e)
        {
            int[] vCanCajas = DaoCaja.CajasSinAbrir();
            for (int i = 0; i < vCanCajas.Length; i++)
                cmbNroCaja.Items.Add(vCanCajas[i]);
            
        }

        private void cmbNroCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            double vMonto = DaoRecibo.ObtenerMontoPorCaja(long.Parse(cmbNroCaja.Text));
            txtsaldoinicial.Text = vMonto +"";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            double vMontoInicial = 0.00;
            if (txtsaldoinicial.Text != "")
                vMontoInicial = double.Parse(txtsaldoinicial.Text);
            if(cmbNroCaja.Text!="")
            {
                Caja vCaja = new Caja();
                vCaja.FechaApertura = DateTime.Now;
                vCaja.MontoAnteriorEfectivo = vMontoInicial;
                vCaja.Puesto = int.Parse(cmbNroCaja.Text);
                vCaja.Usuario = this.Usuario;
                DaoCaja.Guardar(vCaja);
                vCaja = null;
            }
        }
    }
}
