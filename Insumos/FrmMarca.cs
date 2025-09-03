using desagotes.sql;
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
    public partial class FrmMarca : Form
    {
        private long mId = 0;
        private String mVengoDe = "";
        private FrmEditarInsumo mFrmEditInsumo = null;
        private FrmBusquedaMarca mBusquedaMarca = null;

        public FrmBusquedaMarca FrmBusquedaMarca
        {
            get { return mBusquedaMarca; }
            set { mBusquedaMarca = value; }
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
            
        public FrmMarca()
        {
            InitializeComponent();
        }

        public void SetearDatos(long xId,String xDescripcion)
        {
            mId = xId;
            txtMarca.Text = xDescripcion;
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text.Trim() != "")
            {
                if (mId > 0)
                {
                    DaoMarcaDiccionario.Editar(txtMarca.Text.Trim(), mId);
                    if (VengoDe == "INSUMOS")
                    {
                        FrmEditInsumo.CargarMarca(mId, txtMarca.Text.Trim().ToUpper());
                    }
                    else if(VengoDe=="SELECCION")
                    {
                        FrmBusquedaMarca.CargarGrilla();
                    }
                }
                else
                {
                    DaoMarcaDiccionario.Guardar(txtMarca.Text.Trim());
                    if (VengoDe == "INSUMOS")
                    {
                        long vId = DaoMarcaDiccionario.ObtenerId(txtMarca.Text);
                        FrmEditInsumo.CargarMarca(vId, txtMarca.Text.Trim().ToUpper());
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("Debe completar los campos marcados con *","ATENCION!");
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
