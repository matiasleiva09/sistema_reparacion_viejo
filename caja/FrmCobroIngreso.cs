using reparaciones2.dao;
using reparaciones2.Insumos;
using reparaciones2.ob.insumos;
using stocksires.Insumos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.caja
{
    public partial class FrmCobroIngreso : Form
    {
        public FrmCobroIngreso()
        {
            InitializeComponent();
        }

        private void FrmCobroIngreso_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            FormBuscarCliente vFormulario = new FormBuscarCliente();
            vFormulario.CobroIngreso = this;
            vFormulario.ShowDialog();
        }

        public void CargarCliente(String xIdCliente, String xNombre)
        {
            txtidcliente.Text = xIdCliente;
            txtnombrecliente.Text = xNombre;
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new FrmEditarCliente();
            vFormulario.CobroIngreso = this;
            vFormulario.ShowDialog();
        }

        private void BtnXEquipo_Click(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombrecliente.Text = "";
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (txtidcliente.Text != null && txtidcliente.Text.Trim() != "")
            {
                long vIdCliente = long.Parse(txtidcliente.Text);
                FrmEditarCliente vFormulario = new FrmEditarCliente();
                vFormulario.CobroIngreso = this;
                vFormulario.Cliente = DaoCliente.ObtenerCliente(vIdCliente);
                vFormulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingregar un cliente antes de editarlo.", "Atención!");
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            FrmConsultarArticulo vFormulario = new FrmConsultarArticulo();
            vFormulario.CobroIngreso = this;
            vFormulario.ShowDialog();
        }

        public void AgregarItem(Articulo xArticulo)
        {
            int rowEscribir = dgwItem.Rows.Count;
            if (rowEscribir < 0)
                rowEscribir = 0;
            bool vExiste = ExisteYaitem(xArticulo.Codigo);
            if (!vExiste)
            {
                dgwItem.Rows.Add(1);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = 1;
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Monto"].Value = xArticulo.Monto;
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
                dgwItem.Rows[rowEscribir].Cells["Monto"].Value = xArticulo.Total;
            }
            else
            {
                MessageBox.Show("No se puede agregar un item que ya existe en la grilla", "ATENCION!");
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
                    dgwItem.Rows[i].Cells["Detalle"].Value = xArticulo.Nombre;
                    dgwItem.Rows[i].Cells["Monto"].Value = xArticulo.Monto;

                }

                i++;
            }
            if (!vEncontrado)
            {
                int rowEscribir = dgwItem.Rows.Count - 1;
                if (rowEscribir < 0)
                    rowEscribir = 0;
                dgwItem.Rows.Add(1);
                dgwItem.Rows[rowEscribir].Cells["Cantidad"].Value = "1";
                dgwItem.Rows[rowEscribir].Cells["Codigo"].Value = xArticulo.Codigo;
                dgwItem.Rows[rowEscribir].Cells["Detalle"].Value = xArticulo.Nombre;
                dgwItem.Rows[rowEscribir].Cells["Monto"].Value = xArticulo.Monto;
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

        private bool ExisteYaitem(String xCodigo)
        {
            bool vRes = false;
            int i = 0;
            int limite = dgwItem.Rows.Count - 1;
            while (i < limite && !vRes)
            {
                if (dgwItem.Rows[i].Cells["Codigo"].Value.ToString() == xCodigo)
                    vRes = true;
                i++;
            }
            return vRes;
        }

        private void dgwItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= (dgwItem.Rows.Count - 1) && dgwItem.Rows.Count > 0)
            {
                double vMontoUnitario = DaoArticulo.ObtenerMontoPublicCodigo(dgwItem.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                long vCantidad = long.Parse(dgwItem.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                dgwItem.Rows[e.RowIndex].Cells["Monto"].Value = Math.Round((vCantidad * vMontoUnitario), 2);
            }

        }

        private void dgwItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgwItem.Rows[e.RowIndex].Cells["Detalle"].Value != null && dgwItem.Rows[e.RowIndex].Cells["Detalle"].Value.ToString() != "")
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
                    || dgwItem.Columns[e.ColumnIndex].Name == "Monto")
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

        private void dgwItem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          

        }

        private void dgwItem_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void dgwItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int vCantidadItems = dgwItem.Rows.Count;
            if(vCantidadItems <=0 || txtidcliente.Text.Trim() == "")
            {
                MessageBox.Show("Chequee tener items y tener cargado el cliente.","ATENCION");
            }
            else
            {
                FrmGenerarRecibo vFormulario = new FrmGenerarRecibo();
                vFormulario.GenerarRecibo = this;
                vFormulario.Concepto = "POR INGRESOS VARIOS";
            
                vFormulario.IdCliente = txtidcliente.Text;
                vFormulario.Cliente = txtidcliente.Text + "-" + txtnombrecliente.Text;
                //vFormulario.
                double vMonto = 0.00f;
                //AGREGAMOS EL MONTO
                foreach (DataGridViewRow row in dgwItem.Rows)
                {
                 
                    vMonto += double.Parse(row.Cells["Monto"].Value.ToString());
                    DaoArticulo.ActualizarStock(row.Cells["Codigo"].Value.ToString(),
                        int.Parse(row.Cells["Cantidad"].Value.ToString()),1);
                }
                vFormulario.Monto = vMonto + "";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
               
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;


            if (selectedRow != null)
            {
                FrmActualizarPrecios vFormulario = new FrmActualizarPrecios();
                vFormulario.Modo = "PRESUPUESTO";
                vFormulario.CobroIngreso = this;

               // vFormulario.SetearMonto(selectedRow.Cells["Total"].Value.ToString());
                vFormulario.SetearMonto(selectedRow.Cells["Monto"].Value.ToString());
                vFormulario.ShowDialog();

            }
        }

        public void CambiarMonto(string xMonto)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            selectedRow.Cells["Monto"].Value = xMonto;
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgwItem.CurrentRow;
            if (selectedRow != null)
            {
                FrmActualizarPrecios vFormulario = new FrmActualizarPrecios();
                vFormulario.Modo = "ACTUALIZAR_CANTIDAD";
                //vFormulario.Presupuesto = this;
                vFormulario.SetearMonto(selectedRow.Cells["Cantidad"].Value.ToString());
                vFormulario.ShowDialog();
            }
        }
    }
}
