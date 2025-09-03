using reparaciones2.dao;
using reparaciones2.ob.insumos;
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

namespace reparaciones2.Insumos
{
    public partial class FrmProveedor : Form
    {
        private Proveedor proveedor = new Proveedor();
        private FrmBuscarProveedor frmBusquedaProveedor = null;
        private FrmEditarInsumo frmEditInsumo = null;
        private String vengoDe = "";

        public FrmEditarInsumo FrmEditInsumo
        {
            get { return frmEditInsumo; }
            set { frmEditInsumo = value; }
        }

        public FrmBuscarProveedor FrmBusquedaProveedor
        {
            get { return frmBusquedaProveedor; }
            set { frmBusquedaProveedor = value; }
        }

        public String VengoDe
        {
            get { return vengoDe; }
            set { vengoDe = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public FrmProveedor()
        {
            InitializeComponent();
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text.Trim()=="" || cmbCondicionIVA.Text.ToString()==""
                || txtCuit.Text.Trim()=="")
            {
                MessageBox.Show("Debe completar los datos obligatorios.","ATENCION!");
            }
            else
            {
                try
                {
                    Proveedor.Nombre = txtnombre.Text.Trim();
                    Proveedor.Calle = txtcalle.Text.Trim();
                    Proveedor.Celular = txtcelular.Text.Trim();
                    Proveedor.CondicionIVA = cmbCondicionIVA.Text.Trim();
                    Proveedor.Cp = txtcp.Text.Trim();
                    Proveedor.Cuit = txtCuit.Text.Trim();
                    Proveedor.Dpto = txtdpto.Text.Trim();
                    Proveedor.Email = txtemail.Text.Trim();
                    Proveedor.Localidad = txtlocalidad.Text.Trim();
                    Proveedor.Nro = txtnro.Text.Trim();
                    if (txtpiso.Text.Trim() == "")
                        Proveedor.Piso = 0;
                    else
                        Proveedor.Piso = int.Parse(txtpiso.Text.Trim());
                    Proveedor.Provincia = txtprovincia.Text.Trim();
                    Proveedor.Telefono = txttelefono.Text.Trim();
                    Proveedor.Whatsapp = "";
                    if (Proveedor.Id == 0)
                        DaoProveedor.Guardar(Proveedor);
                    else
                        DaoProveedor.Editar(Proveedor);
                    if(VengoDe!="")
                    {
                        if(VengoDe=="PROVEEDORES")
                        {
                            FrmProveedores vFormulario = new FrmProveedores();
                            vFormulario.MdiParent = this.MdiParent;
                            vFormulario.Show();
                            this.Close();
                        }
                        else if(VengoDe=="SELECCION")
                        {
                            FrmBusquedaProveedor.CargarGrilla();
                            this.Close();
                        }
                        else if(VengoDe=="INSUMOS")
                        {
                            if(Proveedor.Id==0)
                            {
                                //tengo que buscar el id de este proveedor
                                try
                                {
                                    long vIdProveedor=DaoProveedor.ObtenerIdProveedor(txtnombre.Text.Trim(), cmbCondicionIVA.Text, 
                                        txtCuit.Text, txttelefono.Text, txtcelular.Text);
                                    FrmEditInsumo.CargarProveedor(vIdProveedor + "", Proveedor.Nombre);
                                    Close();
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(),"ERROR!");
                                }
                            }
                            else
                            {
                                FrmEditInsumo.CargarProveedor(Proveedor.Id.ToString(), Proveedor.Nombre);
                            }
                           
                            this.Close();
                        }
                    }
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show( ex.ToString(), "Ha ocurrido un error");
                }
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (VengoDe != "")
            {
                if (VengoDe == "PROVEEDORES")
                {
                    FrmProveedores vFormulario = new FrmProveedores();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Show();
                    this.Close();
                }
                else if (VengoDe == "SELECCION")
                {
                    FrmBusquedaProveedor.CargarGrilla();
                    this.Close();
                }
                else if(VengoDe=="INSUMOS")
                {
                    this.Close();
                }
            }
            this.Close();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            UtilidadesComunes.cargarCondicionIVA(cmbCondicionIVA);
            if (Proveedor.Id > 0)
            {
                cmbCondicionIVA.Text = Proveedor.CondicionIVA;
                txtcalle.Text = Proveedor.Calle;
                txtcelular.Text = Proveedor.Celular;
                txtcp.Text = Proveedor.Cp;
                txtCuit.Text = Proveedor.Cuit;
                txtdpto.Text = Proveedor.Dpto;
                txtemail.Text = Proveedor.Email;
                txtlocalidad.Text = Proveedor.Localidad;
                txtnombre.Text = Proveedor.Nombre;
                txtnro.Text = Proveedor.Nro;
                //txtobservaciones.Text = "";
                txtpiso.Text = "" + Proveedor.Piso;
                txtprovincia.Text = Proveedor.Provincia;
                txttelefono.Text = Proveedor.Telefono;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (VengoDe != "")
            {
                if (VengoDe == "PROVEEDORES")
                {
                    FrmProveedores vFormulario = new FrmProveedores();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.Show();
                    this.Close();
                }
                else if (VengoDe == "SELECCION" || VengoDe=="INSUMOS")
                {
                    this.Close();
                }
            }
            this.Close();
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool vRes = desagotes.Utils.ComprobarFormatoEmail(txtemail.Text);
            if (!vRes)
                MessageBox.Show("El mail asigando no es valido", "ATENCION!");
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
