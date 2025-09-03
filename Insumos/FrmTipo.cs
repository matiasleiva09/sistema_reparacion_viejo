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

namespace reparaciones2.Insumos
{
    public partial class FrmTipo : Form
    {
        private long mId = 0;
        private String mVengoDe = "";
        private FrmEditarInsumo mFrmEditInsumo = null;
        private FrmBusquedaTipo mBusquedaTipo = null;

        public FrmBusquedaTipo BusquedaTipo
        {
            get { return mBusquedaTipo; }
            set { mBusquedaTipo = value; }
        }

        public FrmEditarInsumo FrmEditInsumo
        {
            get { return mFrmEditInsumo; }
            set { mFrmEditInsumo = value; }
        }

        public String VengoDe
        {
            get { return mVengoDe; }
            set { mVengoDe = value; }
        }

        public void SetearDatos(long xId, String xDescripcion)
        {
            mId = xId;
            txtTipo.Text = xDescripcion;
        }

        public FrmTipo()
        {
            InitializeComponent();
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text.Trim() != "")
            {
                if (mId > 0)
                {
                    DaoTipo.Editar(txtTipo.Text.Trim().ToUpper(), mId);
                    if (VengoDe == "INSUMOS")
                    {
                        FrmEditInsumo.CargarTipo(mId, txtTipo.Text.Trim().ToUpper());
                    }
                    else if (VengoDe == "SELECCION")
                    {
                        BusquedaTipo.CargarGrilla();
                    }
                }
                else
                {
                    DaoTipo.Guardar(txtTipo.Text.Trim().ToUpper());
                    if (VengoDe == "INSUMOS")
                    {
                        long vId = DaoTipo.ObtenerId(txtTipo.Text);
                        FrmEditInsumo.CargarTipo(vId, txtTipo.Text.Trim().ToUpper());
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("Debe completar los campos marcados con *", "ATENCION!");
        }

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
