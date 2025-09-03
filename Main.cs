using desagotes;
using Rebex.Net;
using reparaciones2.caja;
using reparaciones2.dao;
using reparaciones2.Insumos;
using reparaciones2.ob;
using reparaciones2.ob.caja;
using reparaciones2.presupuesto;
using reparaciones2.Presupuesto;
using reparaciones2.reportero;
using reparaciones2.service;
using reparaciones2.tarifas;
using reparaciones2.Usuarios;
using reparaciones2.whatsapp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;


namespace reparaciones2
{
    public partial class Main : Form
    {
        private Usuario mUsuarioSesion = null;

        public Usuario UsuarioSesion
        {
            get { return mUsuarioSesion; }
            set { mUsuarioSesion = value; }    
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BackgroundImage= new Bitmap(Utils.ObtenerPathFondo());
            BackgroundImageLayout = ImageLayout.Stretch;
            cajaToolStripMenuItem.Visible = true;
            hacerBackuoToolStripMenuItem.Visible = false;
            abrirCerrarCajaToolStripMenuItem.Visible = false;
            /*bool vEsAdmin = DAOUsuario.PerteneceGrupo(UsuarioSesion.Id, "Administradores") ;
            if(!vEsAdmin)
            {
                administarUsuariosToolStripMenuItem.Visible = false;
                gruposDeUsuariosToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }*/
            bool vUsuario = ModuloSistemaDAO.habilitado("USUARIOS");
            if (!vUsuario)
                usuariosToolStripMenuItem.Visible = false;
            bool vMandarMails = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            bool vInsumos = ModuloSistemaDAO.habilitado("INSUMOS");
            bool vTarifas = ModuloSistemaDAO.habilitado("TARIFAS");
            bool vMensajeria = ModuloSistemaDAO.habilitado("MENSAJERIA");
            if (!vInsumos)
                insumosToolStripMenuItem.Visible = false;
            if (!vTarifas)
                tarifasToolStripMenuItem.Visible = false;
            if (!vMandarMails)
                mailsToolStripMenuItem.Visible = false;
            if (!vMensajeria)
                mensajeríaToolStripMenuItem.Visible = false;
            ayudaToolStripMenuItem.Visible = true;  
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clientes vFormulario = new reparaciones2.Clientes();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new reparaciones2.FrmEditarCliente();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarReparaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarReparacion vFormulario = new frmEditarReparacion();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultarReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametros vFormulario = new FrmParametros();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void moduloDeReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTesting vFormulario = new reparaciones2.FrmTesting();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
         /*   if (e. == Keys.Control && e.KeyCode == Keys.P)
            {

            }*/
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
           /* if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.S))
            {
                frmEditarReparacion vFormulario = new frmEditarReparacion();
                vFormulario.MdiParent = this;
                vFormulario.Show();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.S))
            {
                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                vFormulario.MdiParent = this;
                vFormulario.Show();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.A))
            {
                Clientes vFormulario = new reparaciones2.Clientes();
                vFormulario.MdiParent = this;
                vFormulario.Show();
            }

            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.A))
            {
                FrmEditarCliente vFormulario = new reparaciones2.FrmEditarCliente();
                vFormulario.MdiParent = this;
                vFormulario.Show();
            }*/

        }

        private void configurarCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigurarCamaraWeb vFormulario = new FrmConfigurarCamaraWeb();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void testCamaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCamara vFormulario = new FrmCamara();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void informeVersiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformeVersion vFormulario = new FrmInformeVersion();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe vFormulario = new FrmAcercaDe();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes vFormulario = new FrmReportes();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarContrasena vFormulario = new FrmCambiarContrasena();
            vFormulario.MdiParent = this;
            vFormulario.UsuarioSesion = UsuarioSesion;
            vFormulario.Show();
        }

        private void administarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios vFormulario = new FrmUsuarios();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void hacerBackuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEspera vFormulario = new FrmEspera();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void mailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEnvioMailSimple vFormulario = new FrmEnvioMailSimple();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void txtCajaBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String vValorBuscado = txtCajaBusqueda.Text.Trim();
                if (Utils.isNumeric(vValorBuscado))
                {
                    //COMO PRIMER CRITERIO SI ES NUMERICO, BUSCO EN LAS ORDENES

                    DataRow vReparacion=DaoReparaciones.ObtenerIdDeNroDeOrden(vValorBuscado);
                    if(vReparacion!=null)
                    {
                        frmEditarReparacion vFormulario = new frmEditarReparacion();
                        vFormulario.VengoDeConsultar = true;
                        vFormulario.IdReparacion = vReparacion["idreparacion"].ToString();
                        vFormulario.MdiParent = this;
                        vFormulario.Show();
                        txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                    }
                    else
                    {
                        Cliente vCliente = DaoCliente.ObtenerCliente(long.Parse(vValorBuscado));
                        if (vCliente != null)
                        {
                            FrmAdminContacto vFormulario = new FrmAdminContacto();
                            vFormulario.MdiParent = this;
                            vFormulario.IdCliente = vCliente.Id;
                            vFormulario.Show();
                            txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                        }
                        else
                        {
                            MessageBox.Show("No se han encontrado resultados para: " + txtCajaBusqueda.Text);
                            txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                        }
                    }
                }
                else
                {
                    //AHORA SUPONGAMOS QUE NO ES UN NUMERO, POR ENDE BUSCARIAMOS OTRA COSA.

                    DataTable vReparaciones = DaoReparaciones.getReparaciones(vValorBuscado);
                    if (vReparaciones.Rows.Count == 1)
                    {
                        frmEditarReparacion vFormulario = new frmEditarReparacion();
                        vFormulario.VengoDeConsultar = true;
                        vFormulario.IdReparacion = vReparaciones.Rows[0]["Id"].ToString();
                        vFormulario.MdiParent = this;
                        vFormulario.Show();
                        txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                    }
                    else if(vReparaciones.Rows.Count > 1)
                    {
                        FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                        vFormulario.MdiParent = this;
                        vFormulario.Show();
                        vFormulario.BuscarDesdeAfuera(vReparaciones);
                        txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                    }
                    else
                    {
                        //BUSCAR UN  CLIENTE
                        DataTable vClientes = DaoCliente.ListarClientes(vValorBuscado);
                        if (vClientes != null)
                        {
                            if (vClientes.Rows.Count == 1)
                            {
                                FrmAdminContacto vFormulario = new FrmAdminContacto();
                                vFormulario.MdiParent = this;
                                vFormulario.IdCliente = long.Parse(vClientes.Rows[0]["Id"].ToString());
                                vFormulario.Show();
                            }
                            else if(vClientes.Rows.Count > 1)
                            {
                                Clientes vFormulario = new Clientes();
                                vFormulario.MdiParent = this;
                                vFormulario.Show();
                                vFormulario.cargarClientesDesdeAfuera(vClientes);
                                txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                            }
                            else
                            {
                                MessageBox.Show("No se han encontrado resultados para: " + txtCajaBusqueda.Text);
                                txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
                            }
                        }
                    } 
                }
            }
        }

        private void txtCajaBusqueda_Click(object sender, EventArgs e)
        {
            if (txtCajaBusqueda.Text == "Ingresa lo que estas buscando")
                txtCajaBusqueda.Text = "";
        }

        private void txtCajaBusqueda_Leave(object sender, EventArgs e)
        {
                txtCajaBusqueda.Text = "Ingresa lo que estas buscando";
        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmReportes vFormulario = new FrmReportes();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void whatsappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWhatsappEnvio vFormulario = new frmWhatsappEnvio();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor vFormulario = new FrmProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProveedores vFormulario = new FrmProveedores();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void insumosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultarInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void ingresosDeMercaderíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturasProveedor vFormulario = new FrmFacturasProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void facturasDeProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmFacturasDeProveedor vFormulario = new FrmFacturasDeProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void facturasDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturasDeProveedor vFormulario = new FrmFacturasDeProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarTarifa vFormulario = new FrmEditarTarifa();
            vFormulario.MdiParent = this;
            vFormulario.Show(); 
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTarifas vFormulario = new FrmTarifas();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmService vFormulario = new FrmService();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServices vFormulario = new FrmServices();
            vFormulario.MdiParent = this;
            vFormulario.Show();

        }

        private void agregarProveedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProveedor vFormulario = new FrmProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores vFormulario = new FrmProveedores();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultarInsumosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void ingresoDeMercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturasProveedor vFormulario = new FrmFacturasProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void facturasDeProveedorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmFacturasDeProveedor vFormulario = new FrmFacturasDeProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPresupuesto vFormulario = new FrmPresupuesto();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPresupuestos vFormulario = new FrmPresupuestos();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void facturasDeProveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmFacturasDeProveedor vFormulario = new FrmFacturasDeProveedor();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void abrirCerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja vCaja = DaoCaja.ObtenerCajaAbiertaDelDia(UsuarioSesion.Nombre);
            if(vCaja==null)
            {
                frmAbrirCaja vFormulario = new frmAbrirCaja();
                vFormulario.Usuario = UsuarioSesion.Nombre;
                vFormulario.MdiParent = this;
                vFormulario.Show();
            }
            else
            {
                MessageBox.Show("Ya Existe caja abierta para este usuario");
            }
            
           
        }

        private void administrarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrupoUsuario vFormulario = new FrmGrupoUsuario();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmEditarGrupo vFormulario = new abmEditarGrupo();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCobros vFormulario = new ConsultarCobros();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void agregarCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCobroIngreso vFormulario = new FrmCobroIngreso();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void egresosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPagoEgreso vFormulario = new FrmPagoEgreso();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void consultarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarEgresos vFormulario = new FrmConsultarEgresos();
            vFormulario.MdiParent = this;
            vFormulario.Show();
        }

        private void reportes2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenericReport vFormulario = new FrmGenericReport();
            vFormulario.MdiParent = this;
            vFormulario.TipoReporte = "reparaciones";
            vFormulario.Show();
        }
    }
}
