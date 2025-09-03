using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using reparaciones2.ob;
using reparaciones2.dao;

namespace reparaciones2
{
    public partial class Clientes : Form
    {
        private int index = 0;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void dgwClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dgwClientes.Rows[index];
            FrmAdminContacto vFormulario = new FrmAdminContacto();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.IdCliente = long.Parse(selectedRow.Cells["Id"].Value.ToString());
            vFormulario.Show();
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtfiltro.Text = "";
            cargarClientes();
        }

        private void cargarClientes()
        {
            dgwClientes.DataSource = DaoCliente.ListarClientes(txtfiltro.Text.Trim());
            dgwClientes.Columns["Geo"].Visible = false;
        }

        public void cargarClientesDesdeAfuera(DataTable xDatos)
        {
            dgwClientes.DataSource = xDatos;
            dgwClientes.Columns["Geo"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditarCliente vFormulario = new reparaciones2.FrmEditarCliente();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void dgwClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgwClientes.CurrentRow;
                DialogResult dr = MessageBox.Show("Desea eliminar al cliente " + selectedRow.Cells["Id"].Value.ToString() +"-"
                    + selectedRow.Cells["Nombre"].Value.ToString() +"", "Atención!", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        DaoCliente.borrar(long.Parse(selectedRow.Cells["Id"].Value.ToString()));
                        txtfiltro.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido borrar el cliente, seguramente tiene información asociada a el.","ATENCION!");
                    }
                    cargarClientes();
                }
              
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido borrar el cliente, el mismo tiene datos asociados.","ESTUPIDOO!!!");
                Console.WriteLine(ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltrar_Click(sender, new EventArgs());
            }
        }
    }
}
