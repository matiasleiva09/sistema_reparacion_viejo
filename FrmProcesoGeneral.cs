using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmProcesoGeneral : Form
    {
        public String Texto
        {
            get
            {
                return lbltexto.Text;
            }
            set
            {
                lbltexto.Text = value;
            }
        }

        public ProgressBar Barra
        {
            get { return barraProgreso; }
        }
        public FrmProcesoGeneral()
        {
            InitializeComponent();
        }

        private void FrmProcesoGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
