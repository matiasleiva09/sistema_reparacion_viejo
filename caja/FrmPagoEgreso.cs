using desagotes;
using desagotes.sql;
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
    public partial class FrmPagoEgreso : Form
    {
        public FrmPagoEgreso()
        {
            InitializeComponent();
        }

        private void panelBarraArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPagoEgreso_Load(object sender, EventArgs e)
        {
            try
            {
                string vSQL = "select concepto from conceptoegreso order by 1 desc";
                DataTable vRes = Sql.getConsultar(vSQL);
                if (vRes != null)
                {
                    cmbconcepto.DataSource = vRes;
                    cmbconcepto.DisplayMember = "concepto";
                    cmbconcepto.ValueMember = "concepto";
                }
                cmbconcepto.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string vConcepto = "";
            if (cmbconcepto.SelectedValue == null)
                vConcepto = cmbconcepto.Text.Trim().ToUpper();
            else
                vConcepto = cmbconcepto.SelectedValue.ToString().ToUpper().Trim();
            double vMonto = double.Parse(txtmonto.Text);
            if (cmbconcepto.Text.Trim() == "" || vMonto <= 0)
            {
                MessageBox.Show("Debe elegir un concepto y colocar un monto", "ATENCION");
            }
            else
            {
                try
                {
                    string vSQL = "";
                    //PRIMERO VEMOS SI EL CONCEPTO YA ESTA INSERTADO
                    vSQL = "select distinct concepto from conceptoegreso where concepto='" +vConcepto +"'";
                    DataRow vRes = Sql.getBuscar(vSQL);
                    if(vRes==null)
                    {
                        vSQL = "insert into conceptoegreso (concepto) values ('" + vConcepto + "')";
                        Sql.ejecutar(vSQL);
                    }
                    vSQL = "insert into pagoegreso (concepto,monto,fecha)";
                    vSQL += " values ('"+vConcepto+"',"+txtmonto.Text+",current_date)";
                    Sql.ejecutar(vSQL);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }
    }
}
