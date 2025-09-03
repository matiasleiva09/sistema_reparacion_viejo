using desagotes;
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
    public partial class FrmFacturasProveedor : Form
    {
        private FacturaProveedor factura = new FacturaProveedor();
        private String vengoDe = "";

        public String VengoDe
        {
            get { return vengoDe; }
            set { vengoDe = value; }
        }

        public FacturaProveedor Factura
        {
            get { return factura; }
            set { factura = value; }
        }

        public FrmFacturasProveedor()
        {
            InitializeComponent();
        }

        public void CargarProveedor(String xId, String xNombre)
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

        public void AgregarItem(Articulo xArticulo)
        {
            int rowEscribir = dgwItem.Rows.Count - 1;
            if (rowEscribir < 0)
                rowEscribir = 0;
            bool vExiste = ExisteYaitem(xArticulo.Codigo);
            if(!vExiste)
            {
                dgwItem.Rows.Add(1);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = 1;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = xArticulo.Costo;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = xArticulo.MontoIVA();
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xArticulo.Costo + xArticulo.MontoIVA();
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
            }
            
        }

        private void AgregarItem(ItemFactura xArticulo)
        {
            int rowEscribir = dgwItem.Rows.Count - 1;
            bool vExiste = ExisteYaitem(xArticulo.Articulo.Codigo);
            if (!vExiste)
            {
                dgwItem.Rows.Add(1);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = xArticulo.Cantidad;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Articulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Articulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = xArticulo.Neto;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = xArticulo.IVA;
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = xArticulo.Total;
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
            }
            
        }

        private void FrmFacturasProveedor_Load(object sender, EventArgs e)
        {
            UtilidadesComunes.CargarTiposDeComprobante(cmbTipoFactura);
            if(Factura.Id>0)
            {
                btnAgregar.Enabled = false;
                btnBorrar.Enabled = false;
                BtnBorrarItem.Enabled = false;
                btnBuscarItem.Enabled = false;
                btnBuscarProveedor.Enabled = false;
                btnEditar.Enabled = false;
                btnEditarInsumo.Enabled = false;
                btnXProveedor.Enabled = false;
                txtItemABuscar.Enabled = false;
                txtNro.Enabled = false;
                cmbFecha.Enabled = false;
                cmbTipoFactura.Enabled = false;
                dgwItem.Enabled = false;
                btnAgregar.Enabled = false;

                cmbFecha.Value = Factura.Fecha;
                cmbTipoFactura.Text = Factura.TipoFactura;
                txtIdProveedor.Text = Factura.Proveedor.Id + "";
                txtProveedor.Text = Factura.Proveedor.Nombre;
                txtNro.Text = Factura.NroFactura;

                foreach(ItemFactura vItem in Factura.Items)
                {
                    AgregarItem(vItem);
                }

            }
            //dgwItem.AllowUserToAddRows = false;
            // DataColumn vColTotal = dgwItem.Columns["Total"];
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            FrmBuscarProveedor vFormulario = new FrmBuscarProveedor();
            vFormulario.FrmFacturaProveedor = this;
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
                FrmFacturasDeProveedor vFormulario = new FrmFacturasDeProveedor();
                vFormulario.MdiParent = this.MdiParent;
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
            vFormulario.FacturaProveedor = this;
            vFormulario.ShowDialog();
        }

        private void BtnBorrarItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if (selectedRow != null)
            {
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
            while (i < limite && !vEncontrado)
            {
                if (dgwItem.Rows[i].Cells["Codigo"].Value.ToString() == xArticulo.Codigo)
                {
                    vEncontrado = true;
                    float vNuevoNeto= xArticulo.Costo * long.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                    float vTotal = vNuevoNeto * (1f + (xArticulo.Iva / 100f));
                    float vNuevoIVA = vTotal - vNuevoNeto;
                    dgwItem.Rows[i].Cells["Detalle"].Value = xArticulo.Nombre;
                    dgwItem.Rows[i].Cells["Neto"].Value = vNuevoNeto;
                    dgwItem.Rows[i].Cells["IVA"].Value = vNuevoIVA;
                    dgwItem.Rows[i].Cells["Total"].Value = vTotal; 

                }
                  
                i++;
            }
            if(!vEncontrado)
            {
                int rowEscribir = dgwItem.Rows.Count;
                if (rowEscribir < 0)
                    rowEscribir = 0;
                dgwItem.Rows.Add(1);
                float vNuevoNeto = xArticulo.Costo;
                double vTotal = Math.Round(vNuevoNeto * (1f + (xArticulo.Iva / 100f)),2);
                double vNuevoIVA = Math.Round(vTotal - vNuevoNeto,2);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value ="1";
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Neto"].Value = vNuevoNeto;
                dgwItem.Rows[rowEscribir].Cells["IVA"].Value = vNuevoIVA;
                dgwItem.Rows[rowEscribir].Cells["Total"].Value = vTotal;
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
                else if (dgwItem.Columns[e.ColumnIndex].Name == "IVA"
                    || dgwItem.Columns[e.ColumnIndex].Name == "Total")
                {
                    float monto = 0;
                    DataGridViewRow row = dgwItem.Rows[e.RowIndex];
                    if (!float.TryParse(e.FormattedValue.ToString(), out monto))
                    {
                        row.ErrorText = "Debe ingresar un número valido";
                        e.Cancel = true;
                    }
                    else
                    {
                        row.ErrorText = "";
                        e.Cancel = false;
                    }

                }
            }
        }

        private void dgwItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < (dgwItem.Rows.Count -1))
            {

                /* float vMontoUnitario = (float)dgwItem.Rows[e.RowIndex].Cells["Neto"].Value * (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoNeto = vMontoUnitario / (1 + ((float)dgwItem.Rows[e.RowIndex].Cells["IVA"].Value / 100));
                 float vMontoIva = vMontoUnitario - vMontoNeto;*/

                DataRow vMontos =DaoArticulo.ObtenerMontoNetoIVA(dgwItem.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                long vCantidad = long.Parse(dgwItem.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                float vNetoUnitario = float.Parse(vMontos["costo"].ToString());
                float vIvaUnitario = float.Parse(vMontos["iva"].ToString());
                float vMonto = vNetoUnitario * vCantidad;
                float vMontoTotal = vMonto * (1 + (vIvaUnitario / 100));

                float vIva = vMontoTotal - vMonto;
               // dgwItem.Rows[e.RowIndex].Cells["Neto"].Value =
               dgwItem.Rows[e.RowIndex].Cells["Total"].Value =vMontoTotal;
               dgwItem.Rows[e.RowIndex].Cells["Iva"].Value = vIva;
               dgwItem.Rows[e.RowIndex].Cells["Neto"].Value = vMonto;

            }
        }

        private void btnEditarInsumo_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if(selectedRow!=null)
            {
                FrmEditarInsumo vFormulario = new FrmEditarInsumo();
                vFormulario.Articulo = DaoArticulo.BuscarPorCodigo(selectedRow.Cells["Codigo"].Value.ToString());
                vFormulario.FormularioFacturas = this;
                vFormulario.VengoDe = "FACTURAS PROVEEDOR";
                vFormulario.ShowDialog();
            }
          
        }

        public void Editar(String xCodigo,String xDescripcion,float xNeto,float xIVA)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            selectedRow.Cells["Codigo"].Value = xCodigo;
            selectedRow.Cells["Descripcion"].Value = xDescripcion;
            selectedRow.Cells["Neto"].Value = xNeto;
            selectedRow.Cells["IVA"].Value = xIVA;
            selectedRow.Cells["Total"].Value = Utils.CalcularMontoFinal(xNeto,xIVA);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (Factura.Id==0)
            {
                if (cmbTipoFactura.Text == "" || txtNro.Text == "" || txtIdProveedor.Text == "" || dgwItem.Rows.Count == 0)
                {
                    MessageBox.Show("Debe Completar todos los campos.","ATENCION!");
                }
                else
                {
                  //  try
                    //{
                        Factura.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(txtIdProveedor.Text));
                        Factura.NroFactura = txtNro.Text;
                        Factura.TipoFactura = cmbTipoFactura.Text;
                        Factura.Fecha = cmbFecha.Value;
                        float neto = 0.00f;
                        float iva = 0.00f;
                        float total = 0.00f;
                        ItemFactura vItemFactura = null;
                        for (int i = 0; i < dgwItem.Rows.Count; i++)
                        {
                            if(dgwItem.Rows[i].Cells["Codigo"].Value!=null)
                            {
                                vItemFactura = new ItemFactura();
                                vItemFactura.IVA = float.Parse(dgwItem.Rows[i].Cells["IVA"].Value.ToString());
                                vItemFactura.Neto = float.Parse(dgwItem.Rows[i].Cells["Neto"].Value.ToString());
                                vItemFactura.Total = float.Parse(dgwItem.Rows[i].Cells["Total"].Value.ToString());
                                vItemFactura.Articulo = DaoArticulo.BuscarPorCodigo(dgwItem.Rows[i].Cells["Codigo"].Value.ToString());
                                vItemFactura.Cantidad = long.Parse(dgwItem.Rows[i].Cells["Cantidad"].Value.ToString());
                                neto += vItemFactura.Neto;
                                iva += vItemFactura.IVA;
                                total += vItemFactura.Total;
                                Factura.Items.Add(vItemFactura);
                                vItemFactura = null;
                             }
                            
                         }
                    Factura.Neto = neto;
                    Factura.IVA = iva;
                    Factura.Total = total;
                    DaoFacturaProveedor.Guardar(Factura);

                    // }
                    /* catch(Exception ex)
                     {
                         MessageBox.Show(ex.ToString(),"Error!");
                     }*/
                    Cerrar();
                }

               
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            FrmEditarInsumo vFormulario = new FrmEditarInsumo();
            vFormulario.FormularioFacturas = this;
            vFormulario.VengoDe = "FACTURAS PROVEEDOR";
            vFormulario.ShowDialog();
        }
    }
}
