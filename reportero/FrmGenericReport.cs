using reparaciones2.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.reportero
{
    public partial class FrmGenericReport : Form
    {
        public string TipoReporte { get; set; }

        public FrmGenericReport()
        {
            InitializeComponent();
        }

        private void FrmGenericReport_Load(object sender, EventArgs e)
        {
            DataTable vReportes = DaoGenericReport.reportePorModulo(TipoReporte);
            if (vReportes != null)
            {
                cmbReporte.DisplayMember = "Text";
                cmbReporte.ValueMember = "Value";
                foreach (DataRow vDato in vReportes.Rows)
                {
                    cmbReporte.Items.Add(new { Text = vDato["descripcion"].ToString(), Value = vDato["query"].ToString() });
                    Console.WriteLine(vDato["query"].ToString());
                    Console.WriteLine("hola");

                }

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cmbReporte.SelectedValue);
            DateTimePicker vFechaDesde = new DateTimePicker();
            vFechaDesde.Name = "dtpFechaDesde";
            vFechaDesde.Value = DateTime.Now;
            vFechaDesde.Location = new Point(156,167);
            vFechaDesde.Visible = true;
            vFechaDesde.Size= new System.Drawing.Size(138, 71);
            this.Controls.Add(vFechaDesde);
        }

        private String ObtenerCamposConsulta()
        {
            return "";
        }
    }
}
