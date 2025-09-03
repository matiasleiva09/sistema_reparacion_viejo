using desagotes;
using reparaciones2.dao;
using reparaciones2.ob.presupuestos;
using reparaciones2.Presupuesto;
using reparaciones2.reportes;
using stocksires.dao;
using stocksires.ob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.presupuesto
{
    public partial class FrmPresupuestos : Form
    {
        private int index = 0;
        public string Modo { get; set; }
        public FrmPresupuestos()
        {
            InitializeComponent();
        }


        private void CargarGrilla(String xFiltro)
        {
            if(Modo!="PEDIDOS")
            {
                dgwPresupuestos.DataSource = DaoPresupuesto.ObtenerPresupuestos(dtFechaDesde.Text, dtpfechahasta.Text,xFiltro);
                dgwPresupuestos.AutoResizeColumns();
                dgwPresupuestos.Columns["idcliente"].Visible = false;
            }
            else
            {

                dgwPresupuestos.DataSource = DaoPedidos.ObtenerPresupuestos(dtFechaDesde.Text,dtpfechahasta.Text,xFiltro);
                dgwPresupuestos.AutoResizeColumns();
                dgwPresupuestos.Columns["idcliente"].Visible = false;
                dgwPresupuestos.Columns["Neto"].Visible = false;
                dgwPresupuestos.Columns["IVA"].Visible = false;
            }
           
        }

        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            if (Modo == "PEDIDOS")
                lbltitulo.Text = "CONSULTA DE PEDIDOS";
            dtFechaDesde.Value = DateTime.Now;
            dtFechaDesde.Value = dtFechaDesde.Value.AddMonths(-2);
            dtpfechahasta.Value = DateTime.Now;
            dtpfechahasta.Value = dtpfechahasta.Value.AddMonths(2);
            CargarGrilla("");
         
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarGrilla(txtfiltro.Text);
            txtfiltro.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            CargarGrilla("");
            txtfiltro.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPresupuesto vFormulario = new FrmPresupuesto();
            vFormulario.MdiParent = this.MdiParent;
            vFormulario.Show();
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImprimirPedido()
        {
            DataGridViewRow selectedRow = dgwPresupuestos.CurrentRow;
            Pedido vPresupuesto = DaoPedidos.ObtenerPorId(long.Parse(selectedRow.Cells["Nro"].Value.ToString()));
            PedidoPDF vPesupuestoPDF = new PedidoPDF();
            vPesupuestoPDF.Fecha = DateTime.Now.ToString();
            vPesupuestoPDF.NroRecibo = vPresupuesto.Id;
            vPesupuestoPDF.NroOrden = vPresupuesto.Id + "";
            vPesupuestoPDF.Cliente = vPresupuesto.Cliente.ToString();
            vPesupuestoPDF.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
            vPesupuestoPDF.Calle = DaoParametrosDatos.getParametro("DIRECCION");
            vPesupuestoPDF.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
            vPesupuestoPDF.Horario = DaoParametrosDatos.getParametro("HORARIO");
            vPesupuestoPDF.Datos = vPresupuesto.Items;
            Console.WriteLine(vPresupuesto.Cliente.Direccion());
            vPesupuestoPDF.DireccionCliente = vPresupuesto.Cliente.Direccion();
            System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + vPesupuestoPDF.crearPdf());
        }

        private void ImprimirPresupuesto()
        {
        
                DataGridViewRow selectedRow = dgwPresupuestos.CurrentRow;
                presupuestosCliente vPresupuesto = DaoPresupuesto.ObtenerPorId(long.Parse(selectedRow.Cells["Nro"].Value.ToString()));
                PresupuestoPDF vPesupuestoPDF = new PresupuestoPDF();
                vPesupuestoPDF.Fecha = DateTime.Now.ToString();
                vPesupuestoPDF.NroRecibo = vPresupuesto.Id;
                vPesupuestoPDF.Cliente = vPresupuesto.Cliente.ToString();
                vPesupuestoPDF.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
                vPesupuestoPDF.Calle = DaoParametrosDatos.getParametro("DIRECCION");
                vPesupuestoPDF.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
                vPesupuestoPDF.Horario = DaoParametrosDatos.getParametro("HORARIO");
                vPesupuestoPDF.Datos = vPresupuesto.Items;
                Console.WriteLine(vPresupuesto.Cliente.Direccion());
               // vPesupuestoPDF.DireccionCliente = vPresupuesto.Cliente.Direccion();
                System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + vPesupuestoPDF.crearPdf());
           
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (Modo == "PEDIDOS")
                ImprimirPedido();
            else
                ImprimirPresupuesto();
           
        }

        private void dgwPresupuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Modo!="PEDIDOS")
            {
                index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dgwPresupuestos.Rows[index];
                presupuestosCliente vPresupuesto = DaoPresupuesto.ObtenerPorId(long.Parse(selectedRow.Cells["Nro"].Value.ToString()));
                FrmPresupuesto vFormulario = new FrmPresupuesto();
                vFormulario.Factura = vPresupuesto;
                vFormulario.VengoDe = "CONSULTA";
                vFormulario.Modo = "PRESUPUESTOS";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else 
            {
                index = e.RowIndex;// get the Row Index
                DataGridViewRow selectedRow = dgwPresupuestos.Rows[index];
                Pedido vPresupuesto = DaoPedidos.ObtenerPorId(long.Parse(selectedRow.Cells["Nro"].Value.ToString()));
                FrmPresupuesto vFormulario = new FrmPresupuesto();
                vFormulario.Pedido = vPresupuesto;
                vFormulario.VengoDe = "CONSULTA";
                vFormulario.Modo = "PEDIDOS";
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
           
        }

        private void dgwPresupuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla("");
        }
    }
}
