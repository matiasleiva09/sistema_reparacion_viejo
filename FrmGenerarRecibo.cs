using desagotes;
using desagotes.reportes;
using reparaciones2.caja;
using reparaciones2.dao;
using reparaciones2.ob.caja;
using reparaciones2.ob.insumos;
using reparaciones2.ob.service;
using reparaciones2.reportes;
using reparaciones2.service;
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
    public partial class FrmGenerarRecibo : Form
    {
        private String mNroReparacion = "";
        private String mCliente = "";
        private String mIdCliente = "";
        private String mIdReparacion = "";
        public String IdService { get; set; }
        private String mMonto = "0.00";
        private String mConcepto = "POR REPARACION DE EQUIPO INFORMATICO";
        private String mVengoDe = "editarReparacion";
        private ReporteEntrega mReporteEntrega;
        private ReporteService mReporteService;
        private DataRow mReparacion;
        private String mEmailCliente = "";
        private Tarjeta vTarjeta = null;
        private Efectivo vEfectivo = null;
        private Cheque vCheque = null;
        private DepositoBancario vDeposito = null;
        public Service Service { get; set; }
        public ReporteServiceDomicilio ReporteServiceDomicilio { get; set; }
        public List<Articulo> Articulo { get; set; }
        public FrmCobroIngreso GenerarRecibo { get; set; }

        public String EmailCliente
        {
            get { return mEmailCliente; }
            set { mEmailCliente = value; }
        }

        public String IdCliente
        {
            get { return mIdCliente; }
            set { mIdCliente = value; }
        }

        public String IdReparacion
        {
            get { return mIdReparacion; }
            set { mIdReparacion = value; }
        }

        public ReporteService ReporteOrdenReparacion
        {
            get { return mReporteService; }
            set { mReporteService = value; }
        }

        public ReporteEntrega EntregaReporte
        {
            get { return mReporteEntrega; }
            set { mReporteEntrega = value; }
        }

        public String Concepto
        {
            get { return mConcepto; }
            set { mConcepto = value; }
        }

        public String VengoDe
        {
            get { return mVengoDe; }
            set { mVengoDe = value; }
        }

        public String NroReparacion
        {
            get { return mNroReparacion; }
            set { mNroReparacion = value; }
        }

        public String Cliente
        {
            get { return mCliente; }
            set { mCliente = value; }
        }

        public String Monto
        {
            get { return mMonto; }
            set { mMonto = value; }
        }
            
        public FrmGenerarRecibo()
        {
            InitializeComponent();
        }

        private void FrmGenerarRecibo_Load(object sender, EventArgs e)
        {
            lbldatosreparacion.Text = NroReparacion.Trim();
            if(Concepto =="")
            {
                if (Service == null)
                    txtconcepto.Text = "POR REPARACION DE EQUIPO INFORMATICO";
                else
                    txtconcepto.Text = "POR SERVICE DOMICILIARIO";
            }
            else
            {
                txtconcepto.Text = Concepto;
            }
            
            txtCliente.Text = Cliente;
            float vMonto = float.Parse(Monto);
            if (vMonto < 0)
                vMonto = 0;
            txtmonto.Text = vMonto + "";
           /* txtmontocheque.Text = "0.00";
            txtmontodeposito.Text = "0.00";
            txtmontotarjeta.Text = "0.00";*/
           // radioEfectivo.Checked = true;
            if(IdReparacion!="")
            {
                mReparacion = DaoReparaciones.getReparacion(long.Parse(IdReparacion));
            }
           
            if (mVengoDe == "editarReparacion" || Service!=null)
            {
                txtmonto.Enabled = true;
                btnSalir.Visible = false;
                btnSalir.Enabled = false;
            }
            utils.UtilidadesComunes.CargarTipoTarjeta(cmbtipotarjeta);
        }

        private ReciboPDF CargarReciboPDF(float xMonto)
        {
            String vMedioDePago = "EFECTIVO";
           // long vNroRecibo = long.Parse(DAOParametros.ObtenerProximoValorRecibo());
          /*  if (radioTarjeta.Checked)
                vMedioDePago = "TARJETA";
            else if (radioEfectivo.Checked)
                vMedioDePago = "EFECTIVO";
            else if (radioCheque.Checked)
                vMedioDePago = "CHEQUE";
            else if (radioDepositoBancario.Checked)
                vMedioDePago = "DEPOSITO BANCARIO";*/

            ReciboPDF vReporte = new ReciboPDF();
            //vReporte.Fecha = desagotes.Utils.getFechaSinHora(selectedRow.Cells["Fecha Entrada"].Value.ToString());
            vReporte.Cliente = txtCliente.Text;
            vReporte.Monto = xMonto;
            vReporte.MedioEfectivo = vEfectivo;
            vReporte.MedioTarjeta = vTarjeta;
            vReporte.MedioDeposito = vDeposito;
            vReporte.MedioCheque = vCheque;
            vReporte.MedioDePago = vMedioDePago;
            vReporte.Concepto = txtconcepto.Text;
            if (NroReparacion != "")
                DaoReparaciones.actualizarMontoPago(NroReparacion, xMonto + "");
            string vIdService = "";
            if (Service != null)
                vIdService = Service.Id + "";
            
            long vIdRecibo=DaoRecibo.GuardarRecibo(IdCliente, xMonto + "",
               txtconcepto.Text, IdReparacion, vIdService, vMedioDePago, this.vEfectivo, this.vTarjeta, this.vCheque, this.vDeposito);
            vReporte.NroRecibo = vIdRecibo;
            vReporte.Telefono = DaoParametrosDatos.getParametro("TELEFONO");
            vReporte.Horario = DaoParametrosDatos.getParametro("HORARIO");
            vReporte.Empresa = DaoParametrosDatos.getParametro("EMPRESA");
            vReporte.Calle = DaoParametrosDatos.getParametro("DIRECCION");
           
           
        //    DAOParametros.ActualizarParametroRecibo(vNroRecibo + "");
            return vReporte;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float vMontoRecibo = 0f;
          

            if (Utils.isNumeric(txtmonto.Text))
            {
                vMontoRecibo = float.Parse(txtmonto.Text);
                vEfectivo = new Efectivo();
                vEfectivo.Monto = vMontoRecibo;
            }
               

            if (Utils.isNumeric(txtmontocheque.Text))
            {
                vMontoRecibo += float.Parse(txtmontocheque.Text);
                vCheque = new Cheque();
                vCheque.Monto= float.Parse(txtmontocheque.Text);
                vCheque.Nro = txtnrocheque.Text;
                vCheque.Titular = txttitularcheque.Text;
                vCheque.Banco = txtbancocheque.Text;
                vCheque.FechaVencimiento = dtpFechaVcheque.Value;
            }
           
            if (Utils.isNumeric(txtmontodeposito.Text))
            {
                vMontoRecibo += float.Parse(txtmontodeposito.Text);
                vDeposito = new DepositoBancario();
                vDeposito.Monto = float.Parse(txtmontodeposito.Text);
                vDeposito.NroDeCuenta = txtnrocuentadeposito.Text;
                vDeposito.Banco = txtbancodeposito.Text;
                vDeposito.Comprobante = txtcompdep.Text;
            }
            if (Utils.isNumeric(txtmontotarjeta.Text))
            {
                vMontoRecibo += float.Parse(txtmontotarjeta.Text);
                vTarjeta = new Tarjeta();
                vTarjeta.Monto = float.Parse(txtmontotarjeta.Text);
                vTarjeta.Nro = txtnrotarjeta.Text;
                vTarjeta.Empresa = txtempresatarjeta.Text;
                vTarjeta.Tipo = cmbtipotarjeta.SelectedItem.ToString();
            }


            if (txtconcepto.Text == "" || vMontoRecibo == 0 || txtCliente.Text == "")
                MessageBox.Show("Debe completar todos los campos para continuar.", "Atención!");
            else
            {
                ReciboPDF vReciboPDF = CargarReciboPDF(vMontoRecibo);
                if (VengoDe == "editarReparacion")
                {
                    FrmImprimirEntrega vFormulario = new FrmImprimirEntrega();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.EmailCliente = this.EmailCliente;
                    if (ReporteOrdenReparacion != null)
                    {
                        vFormulario.labelBotonImprimir("IMPRIMIR ORDEN");
                        vFormulario.ReporteOrdenDeReparacion = ReporteOrdenReparacion;
                    }
                    else if (EntregaReporte != null)
                    {
                        vFormulario.labelBotonImprimir("IMPRIMIR ENTREGA");
                        vFormulario.ReporteEntregaEquipo = EntregaReporte;
                    }
                    else if (Service != null)
                    {
                        vFormulario.labelBotonImprimir("IMPRIMIR SERVICE");
                        vFormulario.ReporteServiceDomiciliario = this.ReporteServiceDomicilio;
                       
                    }
                    vFormulario.ReporteReciboPDF = vReciboPDF;
                    vFormulario.Show();
                    this.Close();

                }
                else if (VengoDe == "editarService")
                {

                    FrmImprimirEntrega vFormulario = new FrmImprimirEntrega();
                    vFormulario.MdiParent = this.MdiParent;
                    vFormulario.EmailCliente = this.EmailCliente;
                    vFormulario.ReporteReciboPDF = vReciboPDF;
                    vFormulario.Show();
                    this.Close();
                }
                else
                {
                    System.Diagnostics.Process.Start(vReciboPDF.crearPdf());
                    //ACA TENEMOS UN TEMA, CUANDO VIENE DE CONSULTAR REPARACION,SI EL ESTADO NO ES ENTREGADA,
                    //ENTONCES EL RECIBO SE DEBE TOMAR COMO SEÑA
                    if (mReparacion!=null && mReparacion["Estado"].ToString() != "ENTREGADA")
                        DaoReparaciones.ActualizarSenia(IdReparacion, vMontoRecibo + "");
                    if(Service!=null)
                        DAOService.ActualizarSeña(vMontoRecibo, Service.Id);
                    DondeIr();
                }
            }
        }

        private void DondeIr()
        {
            if (VengoDe == "ConsultarReparaciones")
            {
                FrmConsultarReparaciones vFormulario = new FrmConsultarReparaciones();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
            else if (VengoDe == "ConsultarServices")
            {
                FrmServices vFormulario = new FrmServices();
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                this.Close();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DondeIr();
            this.Close();
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtmonto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
