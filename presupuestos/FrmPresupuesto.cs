using desagotes;
using reparaciones2.dao;
using reparaciones2.Insumos;
using reparaciones2.ob;
using reparaciones2.ob.insumos;
using reparaciones2.ob.presupuestos;
using reparaciones2.presupuesto;
using reparaciones2.reportes;
using stocksires.dao;
using stocksires.Insumos;
using stocksires.ob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace reparaciones2.Presupuesto
{
    public partial class FrmPresupuesto : Form
    {
        public string Modo { get; set; }
        private presupuestosCliente factura = new presupuestosCliente();
        private frmEditarReparacion FormReparacion { get; set; }
        private String vengoDe = "";
        public Reparacion Reparacion { get; set; }
        public Pedido Pedido { get; set; }

        public String VengoDe
        { 
            get { return vengoDe; }
            set { vengoDe = value; }
        }

        public presupuestosCliente Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public FrmPresupuesto()
        {
            InitializeComponent();
        }

        public void CargarCliente(String xId, String xNombre)
        {
            txtIdProveedor.Text = xId;
            txtProveedor.Text = xNombre;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ExisteYaitem(String xCodigo)
        {
            bool vRes = false;
            int i = 0;
            int limite = dgwItem.Rows.Count - 1;
            while (i< limite && !vRes)
            {
                if (dgwItem.Rows[i].Cells["Codigo"].Value.ToString() == xCodigo)
                    vRes = true;
                i++;
            }
            return vRes;
        }

        public void AgregarItem(ItemPedido xItemPedido)
        {
            int rowEscribir = dgwItem.Rows.Count;
            if (rowEscribir < 0)
                rowEscribir = 0;
            bool vExiste = ExisteYaitem(xItemPedido.Articulo.Codigo);
            if (!vExiste)
            {
                dgwItem.Rows.Add(1);
           
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = xItemPedido.Cantidad;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xItemPedido.Articulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xItemPedido.Articulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = xItemPedido.Neto;
                //  float vTotal = xArticulo.Costo * (1 + (xArticulo.Iva / 100));
                //  float vIva = vTotal - xArticulo.Costo;
                dgwItem.Rows[rowEscribir].Cells["MontoU"].Value = xItemPedido.MontoUnitario;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = xItemPedido.Iva;
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xItemPedido.Total;
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
            }
        }

        public void AgregarItem(Articulo xArticulo)
        {
            int rowEscribir = dgwItem.Rows.Count;
           if (rowEscribir < 0)
                rowEscribir = 0;
            bool vExiste = ExisteYaitem(xArticulo.Codigo);
            if(!vExiste)
            {
                dgwItem.Rows.Add(1);
                double vNeto = Math.Round(xArticulo.Monto / ((xArticulo.Iva / 100) + 1), 2);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = 1;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = vNeto;
                //  float vTotal = xArticulo.Costo * (1 + (xArticulo.Iva / 100));
                //  float vIva = vTotal - xArticulo.Costo;
                dgwItem.Rows[rowEscribir].Cells["MontoU"].Value =xArticulo.Monto;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = xArticulo.Monto - vNeto;
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xArticulo.Monto;
                if(Pedido!=null && Pedido.Id > 0)
                {
                    DaoPedidos.AgregarItem(Pedido.Id, xArticulo.Codigo, vNeto, (xArticulo.Monto - vNeto), xArticulo.Monto,
                  xArticulo.Monto, 1);
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
            }
            
        }

        private void AgregarItem(ItemPresupuesto xArticulo)
        {
            int rowEscribir = dgwItem.Rows.Count - 1;
            if (rowEscribir < 0)
                rowEscribir = 0;
            bool vExiste = ExisteYaitem(xArticulo.Articulo.Codigo);
            if (!vExiste)
            {
                dgwItem.Rows.Add(1);

                double vNeto = Math.Round(xArticulo.Total / (1 + (xArticulo.Iva / 100f)), 2);
                double vIva = Math.Round(xArticulo.Total - vNeto, 2);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = xArticulo.Cantidad;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Articulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Articulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = vNeto;
                dgwItem.Rows[rowEscribir].Cells["MontoU"].Value = xArticulo.MontoUnitario;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = vIva;
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xArticulo.Total;
                if (Pedido != null && Pedido.Id > 0)
                {
                    DaoPedidos.AgregarItem(Pedido.Id, xArticulo.Articulo.Codigo, vNeto, (xArticulo.Total - vNeto), xArticulo.Total,
                  xArticulo.MontoUnitario, 1);
                }
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
            }
            
        }

       

        private void CargarPedidos()
        {
            this.lbltitulo.Text = "PEDIDOS";
            lblfechaentrega.Visible = false;
            dtpFechaEntrega.Visible = false;
            if (Pedido.Id > 0)
            {
                btnAgregar.Enabled = false;
            
                btnBorrar.Enabled = true;
                BtnBorrarItem.Enabled = true;
                btnBuscarItem.Enabled = true;
                btnBuscarProveedor.Enabled = false;
                btnEditar.Enabled = true;
                btnEditarInsumo.Enabled = true;
                btnXProveedor.Enabled = false;
                txtItemABuscar.Enabled = true;
                cmbFecha.Enabled = false;
                dgwItem.Enabled = true;
                btnAgregar.Enabled = true;
                btnAgregarInsumo.Enabled = true;
                cmbFecha.Value = Pedido.Fecha;
                txtIdProveedor.Text = Pedido.Cliente.Id + "";
                txtProveedor.Text = Pedido.Cliente.Nombre;

                foreach (ItemPedido vItem in Pedido.Items)
                {
                    AgregarItem(vItem);
                }
            }
        }

        private void CargarPresupuesto()
        {
                this.lbltitulo.Text = "PRESUPUESTO";

            if (Factura.Id > 0)
            {
                btnAgregar.Enabled = false;
                lblfechaentrega.Visible = false;
                dtpFechaEntrega.Visible = false;
                btnBorrar.Enabled = false;
                BtnBorrarItem.Enabled = false;
                btnBuscarItem.Enabled = false;
                btnBuscarProveedor.Enabled = false;
                btnEditar.Enabled = false;
                btnEditarInsumo.Enabled = false;
                btnXProveedor.Enabled = false;
                txtItemABuscar.Enabled = false;
                cmbFecha.Enabled = false;
                dgwItem.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarInsumo.Enabled = false;
                cmbFecha.Value = Factura.Fecha;
                txtIdProveedor.Text = Factura.Cliente.Id + "";
                txtProveedor.Text = Factura.Cliente.Nombre;

                foreach (ItemPresupuesto vItem in Factura.Items)
                {
                    AgregarItem(vItem);
                }

            }
        }

        private void FrmPresupuesto_Load(object sender, EventArgs e)
        {
            if(Modo !="PEDIDOS")
            {
                CargarPresupuesto();
            }
            else
            {
                CargarPedidos();
            }
            //dgwItem.AllowUserToAddRows = false;
            // DataColumn vColTotal = dgwItem.Columns["Total"];
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            /* FrmBuscarProveedor vFormulario = new FrmBuscarProveedor();
            vFormulario.FrmFacturaProveedor = this;
            vFormulario.ShowDialog(); */
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.Presupuesto = this;
            vFormulario.ShowDialog();
            
        }

        private void btnXProveedor_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Text = "";
            txtProveedor.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            if(VengoDe=="CONSULTA")
            {
                FrmPresupuestos vFormulario = new FrmPresupuestos();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Modo = Modo;
                vFormulario.Show();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            FrmConsultarArticulo vFormulario = new FrmConsultarArticulo();
            vFormulario.Presupuesto = this;
            vFormulario.ShowDialog();
        }

        private void BtnBorrarItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if (selectedRow != null)
            {
                if(Pedido!=null && Pedido.Id > 0)
                {
                    DaoPedidos.borrarItem(Pedido.Id, selectedRow.Cells["Codigo"].Value.ToString());
                }
                dgwItem.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un item para borrar", "ATENCION!");
            }
        }

        private void txtItemABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarItem();
            }
        }

        public void CambiarItem(Articulo xArticulo)
        {
            bool vEncontrado = false;
            int i = 0;
            int limite = dgwItem.Rows.Count - 1;
            while (i <= limite && !vEncontrado)
            {
                Console.WriteLine(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                Console.WriteLine(xArticulo.Codigo.ToString());
                if (dgwItem.Rows[i].Cells["Codigo"].Value.ToString() == xArticulo.Codigo)
                {
                    vEncontrado = true;
                    DataRow vDatos = DaoArticulo.ObtenerMontoNetoIVA(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                    int vCantidad = int.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                    float vMonto = float.Parse(vDatos["monto"].ToString());
                    float vPorIva = float.Parse(vDatos["iva"].ToString());
                    double vMontoTotal = vMonto * vCantidad;
                    double vNeto = Math.Round(vMontoTotal / (1 + (vPorIva / 100f)),2);
                    double vMontoIva = Math.Round(vMontoTotal - vNeto,2);

                    dgwItem.Rows[i].Cells["Detalle"].Value = xArticulo.Nombre;
                    dgwItem.Rows[i].Cells["Neto"].Value = vNeto;
                    dgwItem.Rows[i].Cells["IVA"].Value = vMontoIva;
                    dgwItem.Rows[i].Cells["MontoU"].Value = vMonto;
                    dgwItem.Rows[i].Cells["Total"].Value = vMontoTotal;
          

                }
                  
                i++;
            }
            if(!vEncontrado)
            {
                int rowEscribir = dgwItem.Rows.Count;
                if (rowEscribir < 0)
                    rowEscribir = 0;
                double vNeto = Math.Round(xArticulo.Monto / (1 + (xArticulo.Iva / 100f)),2);
                dgwItem.Rows.Add(1);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = "1";
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value =vNeto;
                dgwItem.Rows[rowEscribir].Cells["MontoU"].Value = xArticulo.Monto;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = Math.Round(xArticulo.Monto - vNeto,2);
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xArticulo.Monto;
            }
        }

        private void BuscarItem()
        {
            if (txtItemABuscar.Text.Trim() != "")
            {
                Articulo vArticulo = DaoArticulo.BuscarPorCodigo(txtItemABuscar.Text.ToUpper().Trim());
                if (vArticulo == null)
                    MessageBox.Show("No se ha encontrado ningún producto con ese código", "ATENCION!");
                else
                {
                    AgregarItem(vArticulo);
                    txtItemABuscar.Text = "";
                }
            }

            else
                MessageBox.Show("Ingrese algo para buscar", "ATENCION!");
        }

        private void dgwItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(dgwItem.Rows[e.RowIndex].Cells["Detalle"].Value!=null && dgwItem.Rows[e.RowIndex].Cells["Detalle"].Value.ToString()!="")
            {
                if (dgwItem.Columns[e.ColumnIndex].Name == "Cantidad")
                {
                    long cantidad = 0;
                    DataGridViewRow row = dgwItem.Rows[e.RowIndex];
                    if (!long.TryParse(e.FormattedValue.ToString(), out cantidad))
                    {

                        row.ErrorText = "Debe ingresar un número valido";
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                        row.ErrorText = "";
                    }

                }
            }
        }

        private void dgwItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <= (dgwItem.Rows.Count - 1) && dgwItem.Rows.Count > 0)
            {
                // Articulo vArticulo = DaoArticulo.BuscarPorCodigo(dgwItem.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                DataRow vDatos = DaoArticulo.ObtenerMontoNetoIVA(dgwItem.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                long vCantidad = long.Parse(dgwItem.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                float vMonto = float.Parse(vDatos["monto"].ToString());
                float vPorIva = float.Parse(vDatos["iva"].ToString());
                float vMontoTotal = vMonto * vCantidad;
                double vNeto = Math.Round(vMontoTotal / (1 + (vPorIva / 100f)),2);
                double vMontoIva = Math.Round(vMontoTotal - vNeto,2);
              
              
                dgwItem.Rows[e.RowIndex].Cells["IVA"].Value = vMontoIva;
                dgwItem.Rows[e.RowIndex].Cells["Neto"].Value = vNeto;
                dgwItem.Rows[e.RowIndex].Cells["MontoU"].Value = vMonto;
                dgwItem.Rows[e.RowIndex].Cells["Total"].Value = vMontoTotal;
                if(Pedido!=null && Pedido.Id > 0)
                {
                    DaoPedidos.EditarItem(Pedido.Id, dgwItem.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                        vNeto, vMontoIva, vMontoTotal, vMonto, vCantidad);
                }
            }
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if(selectedRow!=null)
            {
                FrmEditarInsumo vFormulario = new FrmEditarInsumo();
                vFormulario.Articulo = DaoArticulo.BuscarPorCodigo(selectedRow.Cells["Codigo"].Value.ToString());
                vFormulario.Presupuesto = this;
                vFormulario.VengoDe = "PRESUPUESTO";
                vFormulario.ShowDialog();
            }
          
        }

        public void Editar(String xCodigo,String xDescripcion,float xNeto,float xIVA)
        {
            float vTotal = Utils.CalcularMontoFinal(xNeto, xIVA);
            float vIva = vTotal - xNeto;
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            selectedRow.Cells["Codigo"].Value = xCodigo;
            selectedRow.Cells["Descripcion"].Value = xDescripcion;
            selectedRow.Cells["Neto"].Value = xNeto;
            selectedRow.Cells["IVA"].Value = vIva;
            selectedRow.Cells["Total"].Value = vTotal;
        }

        private void GuardarPedido()
        {
            if (Pedido.Id == 0)
            {
                if (cmbFecha.Text == "" || txtIdProveedor.Text == "" || dgwItem.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Completar todos los campos.", "ATENCION!");
                }
                else
                {
                    //  try
                    //{
                    //   Factura.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                    Pedido.Cliente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text.Trim()));
                  
                    //Pedido.Reparacion = Reparacion;
                    // Factura.NroFactura = txtNro.Text;
                    //Factura.TipoFactura = cmbTipoFactura.Text;
                    Pedido.Fecha = cmbFecha.Value;
                    float neto = 0.00f;
                    float iva = 0.00f;
                    float total = 0.00f;
                    float montoU = 0.00f;
                    ItemPedido vItemFactura = null;
                    for (int i = 0; i < dgwItem.Rows.Count; i++)
                    {
                        if (dgwItem.Rows[i].Cells["Codigo"].Value != null)
                        {
                            vItemFactura = new ItemPedido();
                            vItemFactura.Iva = float.Parse(dgwItem.Rows[i].Cells["IVA"].Value.ToString());
                            vItemFactura.Neto = float.Parse(dgwItem.Rows[i].Cells["Neto"].Value.ToString());
                            vItemFactura.Total = float.Parse(dgwItem.Rows[i].Cells["Total"].Value.ToString());
                            Console.WriteLine(vItemFactura.Total);
                            vItemFactura.Articulo = DaoArticulo.BuscarPorCodigo(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                            vItemFactura.Cantidad = long.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                            vItemFactura.MontoUnitario = float.Parse(dgwItem.Rows[i].Cells["MontoU"].Value.ToString());
                            neto += vItemFactura.Neto;
                            iva += vItemFactura.Iva;
                            total += vItemFactura.Total;
                            montoU += vItemFactura.MontoUnitario;
                            Pedido.Items.Add(vItemFactura);
                            vItemFactura = null;
                        }

                    }
                    Pedido.Neto = neto;
                    Pedido.Iva = iva;
                    Pedido.Total = total;
                    Pedido.MontoUnitario = montoU;

                    DaoPedidos.Guardar(Pedido);
                    long vId = DaoPedidos.ObtenerUltimoId(txtIdProveedor.Text.Trim());
                    PedidoPDF vPesupuestoPDF = new PedidoPDF();
                    vPesupuestoPDF.Fecha = DateTime.Now.ToString();
                    vPesupuestoPDF.NroOrden = vId + "";
                    vPesupuestoPDF.NroRecibo = vId;
                    Cliente vCLiente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text));
                    vPesupuestoPDF.Cliente = txtIdProveedor.Text + "-" + txtProveedor.Text;
                    vPesupuestoPDF.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                    vPesupuestoPDF.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                    vPesupuestoPDF.DireccionCliente = vCLiente.Direccion();
                    vPesupuestoPDF.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                    vPesupuestoPDF.Horario = DaoParametrosDatos.getParametro("HORARIO");
                    vPesupuestoPDF.Datos = Pedido.Items;
                    System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + vPesupuestoPDF.crearPdf());

                    Cerrar();
                }
            }
            else
            {
                if (cmbFecha.Text == "" || txtIdProveedor.Text == "" || dgwItem.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Completar todos los campos.", "ATENCION!");
                }
                else
                {
                    Pedido.Cliente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text));
                    //Pedido.Reparacion = Reparacion;
                    // Factura.NroFactura = txtNro.Text;
                    //Factura.TipoFactura = cmbTipoFactura.Text;
                    Pedido.Fecha = cmbFecha.Value;
                    Pedido.Iva = 0.00f;
                    Pedido.MontoUnitario = 0.00f;
                    Pedido.Neto = 0.00f;
                    Pedido.Total = 0.00f;
                    float neto = 0.00f;
                    float iva = 0.00f;
                    float total = 0.00f;
                    float montoU = 0.00f;
                    ItemPedido vItemFactura = null;
                    Pedido.Items.Clear();
                    for (int i = 0; i < dgwItem.Rows.Count; i++)
                    {
                        if (dgwItem.Rows[i].Cells["Codigo"].Value != null)
                        {
                            vItemFactura = new ItemPedido();
                            vItemFactura.Iva = float.Parse(dgwItem.Rows[i].Cells["IVA"].Value.ToString());
                            vItemFactura.Neto = float.Parse(dgwItem.Rows[i].Cells["Neto"].Value.ToString());
                            vItemFactura.Total = float.Parse(dgwItem.Rows[i].Cells["Total"].Value.ToString());
                            vItemFactura.Articulo = DaoArticulo.BuscarPorCodigo(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                            vItemFactura.Cantidad = long.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                            vItemFactura.MontoUnitario = float.Parse(dgwItem.Rows[i].Cells["MontoU"].Value.ToString());
                            neto += vItemFactura.Neto;
                            iva += vItemFactura.Iva;
                            total += vItemFactura.Total;
                            montoU += vItemFactura.MontoUnitario;
                            Pedido.Items.Add(vItemFactura);
                            vItemFactura = null;
                        }

                    }
                    Pedido.Neto = neto;
                    Pedido.Iva = iva;
                    Pedido.Total = total;
                    Pedido.MontoUnitario = montoU;

                    DaoPedidos.Editar(Pedido);
                   
                    PedidoPDF vPesupuestoPDF = new PedidoPDF();
                    vPesupuestoPDF.Fecha = DateTime.Now.ToString();
                    vPesupuestoPDF.NroRecibo = Pedido.Id;
                    Cliente vCLiente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text));
                    vPesupuestoPDF.Cliente = txtIdProveedor.Text + "-" + txtProveedor.Text;
                    vPesupuestoPDF.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                    vPesupuestoPDF.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                    vPesupuestoPDF.DireccionCliente = vCLiente.Direccion();
                    vPesupuestoPDF.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                    vPesupuestoPDF.Horario = DaoParametrosDatos.getParametro("HORARIO");
                    vPesupuestoPDF.Datos = Pedido.Items;
                    System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + vPesupuestoPDF.crearPdf());
                    Cerrar();
                }
                   
            }
        }

        private void GuardarPresupuesto()
        {
            if (Factura.Id == 0)
            {
                if (cmbFecha.Text == "" || txtIdProveedor.Text == "" || dgwItem.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Completar todos los campos.", "ATENCION!");
                }
                else
                {
                    //  try
                    //{
                    //   Factura.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                    Factura.Cliente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text));
                    Factura.Reparacion = Reparacion;
                    // Factura.NroFactura = txtNro.Text;
                    //Factura.TipoFactura = cmbTipoFactura.Text;
                    Factura.Fecha = cmbFecha.Value;
                    float neto = 0.00f;
                    float iva = 0.00f;
                    float total = 0.00f;
                    float montoU = 0.00f;
                    ItemPresupuesto vItemFactura = null;
                    for (int i = 0; i < dgwItem.Rows.Count; i++)
                    {
                        if (dgwItem.Rows[i].Cells["Codigo"].Value != null)
                        {
                            vItemFactura = new ItemPresupuesto();
                            vItemFactura.Iva = float.Parse(dgwItem.Rows[i].Cells["IVA"].Value.ToString());
                            vItemFactura.Neto = float.Parse(dgwItem.Rows[i].Cells["Neto"].Value.ToString());
                            vItemFactura.Total = float.Parse(dgwItem.Rows[i].Cells["Total"].Value.ToString());
                            vItemFactura.Articulo = DaoArticulo.BuscarPorCodigo(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                            vItemFactura.Cantidad = long.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                            vItemFactura.MontoUnitario = float.Parse(dgwItem.Rows[i].Cells["MontoU"].Value.ToString());
                            neto += vItemFactura.Neto;
                            iva += vItemFactura.Iva;
                            total += vItemFactura.Total;
                            montoU += vItemFactura.MontoUnitario;
                            Factura.Items.Add(vItemFactura);
                            vItemFactura = null;
                        }

                    }
                    Factura.Neto = neto;
                    Factura.Iva = iva;
                    Factura.Total = total;
                    Factura.MontoUnitario = montoU;

                    DaoPresupuesto.Guardar(Factura);
                    long vId = DaoPresupuesto.ObtenerUltimoId(txtIdProveedor.Text);
                    PresupuestoPDF vPesupuestoPDF = new PresupuestoPDF();
                    vPesupuestoPDF.Fecha = DateTime.Now.ToString();
                    vPesupuestoPDF.NroRecibo = vId;
                    Cliente vCLiente = DaoCliente.ObtenerCliente(long.Parse(txtIdProveedor.Text));
                    vPesupuestoPDF.Cliente = txtIdProveedor.Text + "-" + txtProveedor.Text;
                    vPesupuestoPDF.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                    vPesupuestoPDF.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                   // vPesupuestoPDF.DireccionCliente = vCLiente.Direccion();
                    vPesupuestoPDF.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                    vPesupuestoPDF.Horario = DaoParametrosDatos.getParametro("HORARIO");
                    vPesupuestoPDF.Datos = Factura.Items;
                    System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + vPesupuestoPDF.crearPdf());

                    Cerrar();
                }
            }
            else
            {
                Cerrar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Modo != "PEDIDOS")
            {
                GuardarPresupuesto();
            }
            else
            {
                GuardarPedido();
            }

            
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.Presupuesto = this;
            vFormulario.VengoDe = "PRESUPUESTO";
            vFormulario.ShowDialog();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.Presupuesto = this;
            vFormulario.ShowDialog();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text != null && txtIdProveedor.Text.Trim() != "")
            {
                long vIdCliente = long.Parse(txtIdProveedor.Text);
                FrmEditarCliente vFormulario = new FrmEditarCliente();
                vFormulario.Presupuesto = this;
                vFormulario.Cliente = DaoCliente.ObtenerCliente(vIdCliente);
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingregar un cliente antes de editarlo.", "Atención!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
           

            if (selectedRow != null)
            {
                FrmActualizarPrecios vFormulario = new FrmActualizarPrecios();
                vFormulario.Modo = "PRESUPUESTO";
                vFormulario.Presupuesto = this;
              
                vFormulario.SetearMonto(selectedRow.Cells["Total"].Value.ToString());
                vFormulario.ShowDialog();

            }

        }

        public void AumentarMontoTotal(string xMonto)
        {
            float vMonto = float.Parse(xMonto);
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            DataRow vDatos = DaoArticulo.ObtenerMontoNetoIVA(selectedRow.Cells["Codigo"].Value.ToString());
            long vCantidad = long.Parse(selectedRow.Cells["Cantidad"].Value.ToString());

            float vPorIva = float.Parse(vDatos["iva"].ToString());
            float vMontoTotal = vMonto;
            double vNeto = Math.Round(vMontoTotal / (1 + (vPorIva / 100f)), 2);
            double vMontoIva = Math.Round(vMontoTotal - vNeto, 2);

            float vMontoUnitario = vMonto / vCantidad;
            selectedRow.Cells["IVA"].Value = vMontoIva;
            selectedRow.Cells["Neto"].Value = vNeto;
            selectedRow.Cells["MontoU"].Value = vMontoUnitario;
            selectedRow.Cells["Total"].Value = vMonto;
        }

        public void ActualizarCantidad(string xCantidad)
        {
            long vCantidad = long.Parse(xCantidad);
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            DataRow vDatos = DaoArticulo.ObtenerMontoNetoIVA(selectedRow.Cells["Codigo"].Value.ToString());
          //  long vCantidad = long.Parse(selectedRow.Cells["Cantidad"].Value.ToString());
            float vMonto = float.Parse(vDatos["monto"].ToString());
            float vPorIva = float.Parse(vDatos["iva"].ToString());
            float vMontoTotal = vMonto * vCantidad;
            double vNeto = Math.Round(vMontoTotal / (1 + (vPorIva / 100f)), 2);
            double vMontoIva = Math.Round(vMontoTotal - vNeto, 2);

            selectedRow.Cells["Cantidad"].Value = vCantidad;
            selectedRow.Cells["IVA"].Value = vMontoIva;
            selectedRow.Cells["Neto"].Value = vNeto;
            selectedRow.Cells["MontoU"].Value = vMonto;
            selectedRow.Cells["Total"].Value = vMontoTotal;
            if (Pedido != null && Pedido.Id > 0)
            {
                DaoPedidos.EditarItem(Pedido.Id, selectedRow.Cells["Codigo"].Value.ToString(),
                    vNeto, vMontoIva, vMontoTotal, vMonto, vCantidad);
            }
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if (selectedRow != null)
            {
                FrmActualizarPrecios vFormulario = new FrmActualizarPrecios();
                vFormulario.Modo = "ACTUALIZAR_CANTIDAD";
                vFormulario.Presupuesto = this;
                vFormulario.SetearMonto(selectedRow.Cells["Cantidad"].Value.ToString());
                vFormulario.ShowDialog();
            }
        }
    }
}
