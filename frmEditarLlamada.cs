using desagotes;
using reparaciones2.dao;
using reparaciones2.utils;
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
    public partial class frmEditarLlamada : Form
    {
        private String idReparacion = null;
        private String codigo = null;
        private bool vengoDeCliente = false;
        private bool vengoDeReparacion = false;
        private bool vengoDeEditarReparacion = false;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public bool VengoDeEditarReparacion
        {
            get { return vengoDeEditarReparacion; }
            set { vengoDeEditarReparacion = value; }
        }

        public bool VengoDeReparacion
        {
            get { return vengoDeReparacion; }
            set { vengoDeReparacion = value; }
        }

        public bool VengoDeCliente
        {
            get { return vengoDeCliente; }
            set { vengoDeCliente = value; }
        }

        public String IdReparacion
        {
            get { return idReparacion; }
            set { idReparacion = value; }
        }

        public frmEditarLlamada()
        {
            InitializeComponent();
        }

        private void frmEditarLlamada_Load(object sender, EventArgs e)
        {
            lbldatosOrden.Text = Codigo;
            UtilidadesComunes.cargarComboUsuario(cmbLlamadoPor);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(dtpFecha.Text.Trim() !="" && LlamadoPor().Trim()!="" && txtdescripcion.Text.Trim()!="")
            {
                DaoLlamadas.guardar(IdReparacion, Utils.getFechaYHoraBase(dtpFecha.Text), LlamadoPor(), txtdescripcion.Text);
                frmRegistroLlamadas vFormulario = new frmRegistroLlamadas();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.VengoDeCliente = this.VengoDeCliente;
                vFormulario.VengoDeReparacion = this.VengoDeReparacion;
                vFormulario.IdReparacion = IdReparacion;
                vFormulario.Codigo = this.Codigo;
                vFormulario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete todos los campos","ATENCION!");
            }
        }

        private String LlamadoPor()
        {
            String vResultado = "";
            if (cmbLlamadoPor.SelectedValue == null)
                vResultado = cmbLlamadoPor.Text;
            else
                vResultado = cmbLlamadoPor.SelectedValue.ToString();
            return vResultado;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmRegistroLlamadas vFormulario = new frmRegistroLlamadas();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.IdReparacion = IdReparacion;
            vFormulario.VengoDeCliente = this.VengoDeCliente;
            vFormulario.VengoDeReparacion = this.VengoDeReparacion;
            vFormulario.VengoDeEditarReparacion = this.VengoDeEditarReparacion;
            vFormulario.Show();
            this.Close();
        }
    }
}
