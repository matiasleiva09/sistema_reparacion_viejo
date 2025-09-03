using desagotes;
using desagotes.sql;
using reparaciones2.dao;
using reparaciones2.ob.insumos;
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

namespace reparaciones2.Insumos
{
    public partial class FrmEditarInsumo : Form
    {
        private Articulo articulo = new Articulo();
        private FrmConsultarArticulo frmBusquedaArticulo = null;
        private FrmFacturasProveedor mFormularioFacturas = null;
        public FrmPresupuesto Presupuesto { get; set; }
        private String vengoDe = "";


        public FrmFacturasProveedor FormularioFacturas
        {
            get { return mFormularioFacturas; }
            set { mFormularioFacturas = value; }
        }


        public FrmConsultarArticulo FrmBusquedaArticulo
        {
            get { return frmBusquedaArticulo; }
            set { frmBusquedaArticulo = value; }
        }

        public String VengoDe
        {
            get { return vengoDe; }
            set { vengoDe = value; }
        }

        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public FrmEditarInsumo()
        {
            InitializeComponent();
        }

        public void CargarProveedor(String xId, String xNombre)
        {
            txtIdProveedor.Text = xId;
            txtProveedor.Text = xNombre;
        }

        public void CargarMarca(long xId, String xNombre)
        {
            txtIdMarca.Text = xId + "";
            txtMarca.Text = xNombre;
        }

        public void CargarTipo(long xId, String xNombre)
        {
            txtIdTipo.Text = xId + "";
            txtTipo.Text = xNombre;
        }

        private void FrmEditarInsumo_Load(object sender, EventArgs e)
        {
            txtArticulo.Text = Articulo.Nombre;
            txtcodigo.Text = Articulo.Codigo;
            txtCosto.Text = "" + Articulo.Costo;
            txtMonto.Text = Articulo.Monto + "";
            txtStockActual.Text = Articulo.StockActual + "";
            chkCostoAutomatico.Checked = false;
            txtMonto.Enabled = true;
            if (Articulo.Id > 0)
            {
                if (Articulo.Marca != null)
                {
                    txtMarca.Text = Articulo.Marca.Descripcion;
                    txtIdMarca.Text = Articulo.Marca.Id + "";
                }
                if (Articulo.Modelo != null)
                {
                    txtTipo.Text = Articulo.Modelo.Descripcion;
                    txtIdTipo.Text = Articulo.Modelo.Id + "";
                }
                if (Articulo.Proveedor != null)
                {
                    txtIdProveedor.Text = Articulo.Proveedor.Id + "";
                    txtProveedor.Text = Articulo.Proveedor.Nombre;
                }
                txtPorcGanancia.Text = Articulo.Ganancia + "";
                txtPorcIVA.Text = Articulo.Iva + "";
                txtStockMinimo.Text = Articulo.StockMinimo + "";
                txtStockMaximo.Text = Articulo.StockMaximo + "";
                txtStockActual.Enabled = false;
            }
            else
            {
                txtPorcIVA.Text = DaoParametrosDatos.getParametro("IVA");
                txtPorcGanancia.Text = DaoParametrosDatos.getParametro("GANANCIA");
                txtStockMaximo.Text = DaoParametrosDatos.getParametro("STOCKMAXIMO");
                txtStockMinimo.Text = DaoParametrosDatos.getParametro("STOCKMINIMO");

            }
            //txtProveedor.Text = Articulo.Proveedor;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            if (VengoDe == "" && frmBusquedaArticulo == null)
                this.Close();
            else if (FrmBusquedaArticulo != null)
            {
                FrmBusquedaArticulo.CargarGrilla();
                Close();
            }
            else if (Presupuesto != null)
            {
                if (Articulo != null && Articulo.Codigo != "")
                    Presupuesto.CambiarItem(Articulo);
                Close();
            }
            else if (VengoDe == "CONSULTA")
            {
                FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else if (VengoDe == "FACTURAS PROVEEDOR")
            {
                if (FormularioFacturas != null)
                {
                    if (Articulo != null && Articulo.Codigo != "")
                        FormularioFacturas.CambiarItem(Articulo);
                }
                Close();
            }
            else
            {
                Close();
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "" && txtCosto.Text != "" /*&& txtProveedor.Text!=""*/ &&
                txtStockActual.Text != "" && txtPorcIVA.Text != "" && txtStockMaximo.Text != ""
                && txtStockMinimo.Text != "" && txtPorcGanancia.Text != "")
            {
                if (chkCostoAutomatico.Checked)
                    CalcularTotal();
                long vStockMinimo = long.Parse(txtStockMinimo.Text);
                long vStockMaximo = long.Parse(txtStockMaximo.Text);
                long vStockActual = long.Parse(txtStockActual.Text);
                if (vStockMinimo > vStockMaximo)
                {
                    MessageBox.Show("El stock Mínimo no puede ser mayor que el máximo", "ATENCION!");
                }
                else
                {
                    Articulo.Codigo = txtcodigo.Text.ToUpper().Trim();
                    Articulo.Costo = float.Parse(txtCosto.Text);
                    Articulo.StockActual = vStockActual;
                    Articulo.Ganancia = float.Parse(txtPorcGanancia.Text);
                    Articulo.Iva = float.Parse(txtPorcIVA.Text);
                    if (txtIdMarca.Text != "")
                        Articulo.Marca = DaoMarcaDiccionario.ObtenerPorId(long.Parse(txtIdMarca.Text));
                    if (txtIdTipo.Text != "")
                        Articulo.Modelo = DaoTipo.ObtenerPorId(long.Parse(txtIdTipo.Text));
                    if (txtIdProveedor.Text != "")
                        Articulo.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                    Articulo.Nombre = txtArticulo.Text;
                    Articulo.StockMaximo = vStockMaximo;
                    Articulo.StockMinimo = vStockMinimo;
                    Articulo.Monto = float.Parse(txtMonto.Text);
                    if (Articulo.Id == 0)
                    {
                        DaoArticulo.Guardar(Articulo);
                        Cerrar();
                    }
                    else
                    {
                        DaoArticulo.Editar(Articulo);
                        Cerrar();
                    }
                }

            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios", "ATENCION!");
            }

        }

        private void txtStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtPorcIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtPorcGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor vFormulario = new FrmBuscarProveedor();
            vFormulario.FrmInsumos = this;
            vFormulario.Show();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor vFormulario = new Insumos.FrmProveedor();
            vFormulario.FrmEditInsumo = this;
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.ShowDialog();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text != "")
            {
                Proveedor vProveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                FrmProveedor vFormulario = new FrmProveedor();
                vFormulario.FrmEditInsumo = this;
                vFormulario.Proveedor = vProveedor;
                vFormulario.VengoDe = "INSUMOS";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún proveedor seleccionado", "ATENCION!");
            }
        }

        private void btnXProveedor_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Text = "";
            txtProveedor.Text = "";
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            FrmBusquedaMarca vFormulario = new FrmBusquedaMarca();
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void BtnXMarca_Click(object sender, EventArgs e)
        {
            txtIdMarca.Text = "";
            txtMarca.Text = "";
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca vFormulario = new FrmMarca();
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            FrmMarca vFormulario = new FrmMarca();
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.SetearDatos(long.Parse(txtIdMarca.Text), txtMarca.Text);
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            FrmBusquedaTipo vFormulario = new FrmBusquedaTipo();
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnXTipo_Click(object sender, EventArgs e)
        {
            txtIdTipo.Text = "";
            txtTipo.Text = "";
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            FrmTipo vFormulario = new FrmTipo();
            vFormulario.FrmEditInsumo = this;
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.ShowDialog();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            if (txtIdTipo.Text != "")
            {
                FrmTipo vFormulario = new Insumos.FrmTipo();
                vFormulario.FrmEditInsumo = this;
                vFormulario.SetearDatos(long.Parse(txtIdTipo.Text), txtTipo.Text);
                vFormulario.VengoDe = "INSUMOS";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede editar un tipo sin haberlo seleccionado antes", "ATENCION!");
            }

        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void VerificarTenerDatos()
        {

        }

        public void CalcularTotal()
        {
            /* if (txtCosto.Text == "")
                 txtCosto.Text = "0";
             else if (txtPorcGanancia.Text == "")
                 txtPorcGanancia.Text = "10";
             else if (txtPorcIVA.Text == "")
                 txtPorcIVA.Text = "21";*/
            if (txtCosto.Text != "" && txtPorcIVA.Text != "" && txtPorcGanancia.Text != "")
            {
                try
                {
                    float vCosto = float.Parse(txtCosto.Text);
                    float vIva = float.Parse(txtPorcIVA.Text);
                    float vGanancia = float.Parse(txtPorcGanancia.Text);
                    float vCostoTotal = vCosto * (1 + (vIva / 100));
                    float vMontoPublico = vCostoTotal * (1 + (vGanancia / 100));
                    txtMonto.Text = vMontoPublico + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR!");
                }
            }

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            VerificarCodigo();
        }

        private void VerificarCodigo()
        {
            bool vRes = DaoArticulo.ExisteCodigo(txtcodigo.Text.Trim(), Articulo.Id);
            if (vRes)
                MessageBox.Show("El código ingresado ya existe, ingrese otro", "ATENCION!");
        }

        private void txtPorcIVA_Leave(object sender, EventArgs e)
        {
        }

        private void txtPorcGanancia_Leave(object sender, EventArgs e)
        {
        }


        private void txtCosto_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtPorcIVA_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtPorcGanancia_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void txtPorcIVA_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void txtPorcGanancia_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void chkCostoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked)
            {
                CalcularTotal();
                txtMonto.Enabled = false;
            }
            else
                txtMonto.Enabled = true;
        }
    }
}





/*using desagotes;
using desagotes.sql;
using reparaciones2.dao;
using reparaciones2.ob.insumos;
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

namespace reparaciones2.Insumos
{
    public partial class FrmEditarInsumo : Form
    {
        private Articulo articulo = new Articulo();
        private FrmConsultarArticulo frmBusquedaArticulo = null;
        private FrmFacturasProveedor mFormularioFacturas = null;
        public FrmPresupuesto Presupuesto { get; set; }
        private String vengoDe = "";


        public FrmFacturasProveedor FormularioFacturas
        {
            get { return mFormularioFacturas; }
            set { mFormularioFacturas = value; }
        }


        public FrmConsultarArticulo FrmBusquedaArticulo
        {
            get { return frmBusquedaArticulo; }
            set { frmBusquedaArticulo = value; }
        }

        public String VengoDe
        {
            get { return vengoDe; }
            set { vengoDe = value; }
        }

        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public FrmEditarInsumo()
        {
            InitializeComponent();
        }

        public void CargarProveedor(String xId,String xNombre)
        {
            txtIdProveedor.Text = xId;
            txtProveedor.Text = xNombre;
        }

        public void CargarMarca(long xId,String xNombre)
        {
            txtIdMarca.Text = xId + "";
            txtMarca.Text = xNombre;
        }

        public void CargarTipo(long xId,String xNombre)
        {
            txtIdTipo.Text = xId + "";
            txtTipo.Text = xNombre;
        }

        private void FrmEditarInsumo_Load(object sender, EventArgs e)
        {
            txtArticulo.Text = Articulo.Nombre;
            txtcodigo.Text = Articulo.Codigo;
            txtCosto.Text = ""+Articulo.Costo;
            txtMonto.Text = Articulo.Monto + "";
            txtStockActual.Text = Articulo.StockActual +"";
            chkCostoAutomatico.Checked = false;
            txtMonto.Enabled = true;
            if (Articulo.Id > 0)
            {
                if(Articulo.Marca!=null)
                {
                    txtMarca.Text = Articulo.Marca.Descripcion;
                    txtIdMarca.Text = Articulo.Marca.Id + "";
                }
                if(Articulo.Modelo!=null)
                {
                    txtTipo.Text = Articulo.Modelo.Descripcion;
                    txtIdTipo.Text = Articulo.Modelo.Id + "";
                }
                if(Articulo.Proveedor!=null)
                {
                    txtIdProveedor.Text = Articulo.Proveedor.Id + "";
                    txtProveedor.Text = Articulo.Proveedor.Nombre;
                }
                txtPorcGanancia.Text = Articulo.Ganancia + "";
                txtPorcIVA.Text = Articulo.Iva + "";
                txtStockMinimo.Text = Articulo.StockMinimo +"";
                txtStockMaximo.Text = Articulo.StockMaximo + "";
                txtStockActual.Enabled = false;    
            }
            else
            {
                txtPorcIVA.Text = DaoParametrosDatos.getParametro("IVA");
                txtPorcGanancia.Text = DaoParametrosDatos.getParametro("GANANCIA");
                txtStockMaximo.Text = DaoParametrosDatos.getParametro("STOCKMAXIMO");
                txtStockMinimo.Text= DaoParametrosDatos.getParametro("STOCKMINIMO");
              
            }
            //txtProveedor.Text = Articulo.Proveedor;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            if(VengoDe=="" && frmBusquedaArticulo==null)
               this.Close();
            else if (FrmBusquedaArticulo!=null)
            {
                FrmBusquedaArticulo.CargarGrilla();
                Close();
            }
            else if(Presupuesto!=null)
            {
                if(Articulo!=null && Articulo.Codigo!="")
                    Presupuesto.CambiarItem(Articulo);
                Close();
            }
            else if(VengoDe=="CONSULTA")
            {
                FrmConsultarInsumos vFormulario = new FrmConsultarInsumos();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else if(VengoDe=="FACTURAS PROVEEDOR")
            {
                if(FormularioFacturas!=null)
                {
                    if (Articulo != null && Articulo.Codigo != "")
                        FormularioFacturas.CambiarItem(Articulo);
                }
                Close();
            }
            else
            {
                Close();
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtcodigo.Text!="" && txtCosto.Text!="" &&
                txtStockActual.Text!="" && txtPorcIVA.Text!="" && txtStockMaximo.Text!=""
                && txtStockMinimo.Text!="" && txtPorcGanancia.Text!="")
            {
                if(chkCostoAutomatico.Checked)
                    CalcularTotal();
                long vStockMinimo = long.Parse(txtStockMinimo.Text);
                long vStockMaximo = long.Parse(txtStockMaximo.Text);
                long vStockActual = long.Parse(txtStockActual.Text);
                if(vStockMinimo > vStockMaximo)
                {
                    MessageBox.Show("El stock Mínimo no puede ser mayor que el máximo","ATENCION!");
                }
                else
                {
                    Articulo.Codigo = txtcodigo.Text.ToUpper().Trim();
                    Articulo.Costo = float.Parse(txtCosto.Text);
                    Articulo.StockActual = vStockActual;
                    Articulo.Ganancia = float.Parse(txtPorcGanancia.Text);
                    Articulo.Iva = float.Parse(txtPorcIVA.Text);
                    if (txtIdMarca.Text != "")
                        Articulo.Marca = DaoMarcaDiccionario.ObtenerPorId(long.Parse(txtIdMarca.Text));
                    if (txtIdTipo.Text != "")
                        Articulo.Modelo = DaoTipo.ObtenerPorId(long.Parse(txtIdTipo.Text));
                    if (txtIdProveedor.Text != "")
                        Articulo.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                    Articulo.Nombre = txtArticulo.Text;
                    Articulo.StockMaximo = vStockMaximo;
                    Articulo.StockMinimo = vStockMinimo;
                    Articulo.Monto = float.Parse(txtMonto.Text);
                    if (Articulo.Id == 0)
                    {
                        DaoArticulo.Guardar(Articulo);
                        Cerrar();
                    }
                    else
                    {
                        DaoArticulo.Editar(Articulo);
                        Cerrar();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Complete los campos obligatorios","ATENCION!");
            }
           
        }

        private void txtStockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtPorcIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtPorcGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = Utils.ValidarNumero(e);
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor vFormulario = new FrmBuscarProveedor();
            vFormulario.FrmInsumos = this;
            vFormulario.Show();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor vFormulario = new Insumos.FrmProveedor();
            vFormulario.FrmEditInsumo = this;
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.ShowDialog();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if(txtIdProveedor.Text!="")
            {
                Proveedor vProveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                FrmProveedor vFormulario = new FrmProveedor();
                vFormulario.FrmEditInsumo = this;
                vFormulario.Proveedor = vProveedor;
                vFormulario.VengoDe = "INSUMOS";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún proveedor seleccionado","ATENCION!");
            }
        }

        private void btnXProveedor_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Text = "";
            txtProveedor.Text = "";
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            FrmBusquedaMarca vFormulario = new FrmBusquedaMarca();
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void BtnXMarca_Click(object sender, EventArgs e)
        {
            txtIdMarca.Text = "";
            txtMarca.Text = "";
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca vFormulario = new FrmMarca();
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            FrmMarca vFormulario = new FrmMarca();
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.SetearDatos(long.Parse(txtIdMarca.Text),txtMarca.Text);
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            FrmBusquedaTipo vFormulario = new FrmBusquedaTipo();
            vFormulario.FrmEditInsumo = this;
            vFormulario.ShowDialog();
        }

        private void btnXTipo_Click(object sender, EventArgs e)
        {
            txtIdTipo.Text = "";
            txtTipo.Text = "";
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            FrmTipo vFormulario = new FrmTipo();
            vFormulario.FrmEditInsumo = this;
            vFormulario.VengoDe = "INSUMOS";
            vFormulario.ShowDialog();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            if(txtIdTipo.Text!="")
            {
                FrmTipo vFormulario = new Insumos.FrmTipo();
                vFormulario.FrmEditInsumo = this;
                vFormulario.SetearDatos(long.Parse(txtIdTipo.Text), txtTipo.Text);
                vFormulario.VengoDe = "INSUMOS";
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se puede editar un tipo sin haberlo seleccionado antes","ATENCION!");
            }
           
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if(chkCostoAutomatico.Checked==true)
                 CalcularTotal();
        }

        private void VerificarTenerDatos()
        {
           
        }

        public void CalcularTotal()
        {
          
            if(txtCosto.Text!="" && txtPorcIVA.Text!="" && txtPorcGanancia.Text!="")
            {
                try
                {
                    float vCosto = float.Parse(txtCosto.Text);
                    float vIva = float.Parse(txtPorcIVA.Text);
                    float vGanancia = float.Parse(txtPorcGanancia.Text);
                    float vCostoTotal = vCosto * (1 + (vIva / 100));
                    float vMontoPublico = vCostoTotal * (1 + (vGanancia / 100));
                    txtMonto.Text = vMontoPublico + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR!");
                }
            }
            
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            VerificarCodigo();
        }

        private void VerificarCodigo()
        {
            bool vRes = DaoArticulo.ExisteCodigo(txtcodigo.Text.Trim(),Articulo.Id);
            if (vRes)
                MessageBox.Show("El código ingresado ya existe, ingrese otro", "ATENCION!");
        }

        private void txtPorcIVA_Leave(object sender, EventArgs e)
        {
        }

        private void txtPorcGanancia_Leave(object sender, EventArgs e)
        {
        }


        private void txtCosto_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtPorcIVA_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtPorcGanancia_MouseLeave(object sender, EventArgs e)
        {
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void txtPorcIVA_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void txtPorcGanancia_TextChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked == true)
                CalcularTotal();
        }

        private void chkCostoAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCostoAutomatico.Checked)
            {
                CalcularTotal();
                txtMonto.Enabled = false;
            }  
            else
                txtMonto.Enabled = true;
        }
    }
}*/
