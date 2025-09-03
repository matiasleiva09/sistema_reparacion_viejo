using desagotes.sql;
using reparaciones2.caja;
using reparaciones2.Insumos;
using reparaciones2.Presupuesto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stocksires.Insumos
{
    public partial class FrmActualizarPrecios : Form
    {
        public string Modo { get; set; }
        public FrmPresupuesto Presupuesto { get; set; }
        public FrmCobroIngreso CobroIngreso { get; set; }
        public void SetearMonto(string xMonto)
        {
            txtporcentaje.Text = xMonto;
        }

        public FrmActualizarPrecios()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Modo == "PRESUPUESTO")
            {
                Console.WriteLine(CobroIngreso);
                if (Presupuesto != null)
                    Presupuesto.AumentarMontoTotal(txtporcentaje.Text);
                else if (CobroIngreso != null)
                    CobroIngreso.CambiarMonto(txtporcentaje.Text);              
                Close();
            }
            else if(Modo =="ACTUALIZAR_CANTIDAD")
            {
                if(Presupuesto!=null)
                    Presupuesto.ActualizarCantidad(txtporcentaje.Text);
                Close();
            }
            else
            {
                string vSQL = "";
                vSQL = "update producto set monto= monto + (monto * " + txtporcentaje.Text + "/100)";
                Sql.ejecutar(vSQL);
                Console.WriteLine(vSQL);
                MessageBox.Show("Se han actualizados los precios al " + txtporcentaje.Text + "%");
                FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
                vFormulario.Show();
                Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Se han actualizados los precios al " + txtporcentaje.Text + "%");
            FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
            vFormulario.Show();
            Close();
        }

        private void FrmActualizarPrecios_Load(object sender, EventArgs e)
        {
            if (Modo == "ACTUALIZAR_CANTIDAD")
            {
                txtporcentaje.Text = "1";
                lblporcentaje.Text += " en %";
            }
                
        }
    }
}

