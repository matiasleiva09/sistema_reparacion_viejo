using reparaciones2.dao;
using reparaciones2.ob;
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
    public partial class FrmEditarEquipoCliente : Form
    {
        private Cliente cliente;
        private Equipo equipo;
        private frmEditarReparacion frmEditarReparacion;
        private FrmBuscarEquipo frmBuscarEquipo;
       
       public FrmBuscarEquipo FormBuscarEquipo
        {
            get { return frmBuscarEquipo; }
            set { frmBuscarEquipo = value; }
        }

        public Equipo EquipoCliente
        {
            get { return equipo; }
            set { equipo = value; }
        }

        public frmEditarReparacion FrmEditarReparacion
        {
            get { return frmEditarReparacion; }
            set { frmEditarReparacion = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public FrmEditarEquipoCliente()
        {
            InitializeComponent();
        }

        private void FrmEditarEquipoCliente_Load(object sender, EventArgs e)
        {
            cmbTipoEquipo.DataSource = DAOEquipoDiccionario.getEquipos();
            cmbTipoEquipo.DisplayMember = "tipoequipo";
            cmbTipoEquipo.ValueMember = "tipoequipo";
            if(EquipoCliente!=null && EquipoCliente.Id!=0)
            {
                long vId = EquipoCliente.Id;
                equipo = DaoEquipo.ObtenerEquipoPorId(vId);
                cmbTipoEquipo.Text = equipo.TipoEquipo;
                cmbmarca.Text = equipo.Marca;
                cmbModelo.Text = equipo.Modelo;
            }
        }

        private void cmbmarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModelo.DataSource = DAOEquipoDiccionario.getModelos(cmbmarca.SelectedValue.ToString());
            cmbModelo.DisplayMember = "modelo";
            cmbModelo.ValueMember = "modelo";
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbTipoEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarca.DataSource = DAOEquipoDiccionario.getMarcas(cmbTipoEquipo.SelectedValue.ToString());
            cmbmarca.DisplayMember = "marca";
            cmbmarca.ValueMember = "marca";
        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            String vDatoTipo = "";
            String vDatoMarca = "";
            String vDatoModelo = "";
            if (cmbTipoEquipo.SelectedValue == null)
                vDatoTipo = cmbTipoEquipo.Text.ToString().Trim().ToUpper();
            else
                vDatoTipo = cmbTipoEquipo.SelectedValue.ToString();

            if (cmbmarca.SelectedValue == null)
                vDatoMarca = cmbmarca.Text.ToString().Trim().ToUpper();
            else
                vDatoMarca = cmbmarca.SelectedValue.ToString();

            if (cmbModelo.SelectedValue == null)
                vDatoModelo = cmbModelo.Text.ToString().Trim().ToUpper();
            else
                vDatoModelo = cmbModelo.SelectedValue.ToString();


            if (vDatoModelo != "" && vDatoMarca != "" && vDatoTipo != "")
            {
                bool vExiste = DAOEquipoDiccionario.Existe(vDatoTipo, vDatoMarca, vDatoModelo);
                if (!vExiste)
                    DAOEquipoDiccionario.Guardar(vDatoTipo, vDatoMarca, vDatoModelo);
                if ((EquipoCliente != null && EquipoCliente.Id != 0))
                {
                    equipo.TipoEquipo = vDatoTipo;
                    equipo.Marca = vDatoMarca;
                    equipo.Modelo = vDatoModelo;
                    DaoEquipo.editar(equipo);
                    if (this.frmEditarReparacion != null)
                    {
                        this.FrmEditarReparacion.CargarEquipo(equipo.Id + "", "Equipo: " + equipo.TipoEquipo + "- Marca: " +
                           equipo.Marca
                        + "- Modelo: " + equipo.Modelo);
                    }
                    else if (FormBuscarEquipo ==null)
                    {
                        FrmAdminContacto vFormulario = new FrmAdminContacto();
                        vFormulario.IdCliente = cliente.Id;
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Show();
                    }
                    else
                    {
                        FormBuscarEquipo.resetearGrilla();
                    }
                    equipo = null;
                    this.Close();
                }
                else
                {
                    equipo = new Equipo();
                    equipo.Cliente = Cliente;
                    equipo.TipoEquipo = vDatoTipo;
                    equipo.Marca = vDatoMarca;
                    equipo.Modelo = vDatoModelo;
                    DaoEquipo.Guardar(equipo);
                    if (this.frmEditarReparacion != null)
                    {
                        String vIdReparacion = DaoEquipo.IdEquipoCliente(equipo.Cliente.Id.ToString(), equipo.TipoEquipo, equipo.Marca,
                            equipo.Modelo);
                        this.FrmEditarReparacion.CargarEquipo(vIdReparacion, "Equipo: " + equipo.TipoEquipo + "- Marca: " +
                           equipo.Marca
                        + "- Modelo: " + equipo.Modelo);
                    }
                    else
                    {
                        FrmAdminContacto vFormulario = new FrmAdminContacto();
                        vFormulario.IdCliente = cliente.Id;
                        vFormulario.MdiParent = this.MdiParent;
                        vFormulario.Show();
                    }
                    equipo = null;
                    
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Complete todos los campos","Atención!!!");
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarModelo_Click(object sender, EventArgs e)
        {
           
            if (frmEditarReparacion != null)
                this.Close();
            else
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.IdCliente = cliente.Id;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (frmEditarReparacion == null)
                this.Close();
            else
            {
                FrmAdminContacto vFormulario = new FrmAdminContacto();
                vFormulario.IdCliente = cliente.Id;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
