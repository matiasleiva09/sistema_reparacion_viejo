using desagotes;
using reparaciones2.dao;
using reparaciones2.formularioscomunes;
using reparaciones2.ob;
using reparaciones2.ob.comunicacion;
using reparaciones2.ob.presupuestos;
using reparaciones2.ob.service;
using reparaciones2.ob.SMTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.reparaciones
{
    public partial class FrmEnviarReporte : Form
    {
        public string Reporte { get; set; }
        public Reparacion Reparacion{get;set;}
        public Service Service { get; set; }
        public presupuestosCliente Presupuesto { get; set; }


        public FrmEnviarReporte()
        {
            InitializeComponent();
        }

        private void FrmEnviarReporte_Load(object sender, EventArgs e)
        {
            //if (Presupuesto != null)
            bool vHabilitado = ModuloSistemaDAO.MandarWhatsappBusiness();
            if(!vHabilitado)
                btnWhatsapp.Visible = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Utils.ObtenerPathDOCS() + Reporte);
            System.Diagnostics.Process.Start(Utils.ObtenerPathDOCS() + Reporte);
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            bool vHabilitado = ModuloSistemaDAO.MandarWhatsappBusiness();
            if (vHabilitado)
            {
                String vTelefono = "";
                if (Reparacion != null)
                {
                    if (Reparacion.Cliente.Celular.Trim() == "")
                        vTelefono = Reparacion.Cliente.Telefono;
                    else
                        vTelefono = Reparacion.Cliente.Celular;
                }
                else
                {

                    if (Service.Cliente.Celular.Trim() == "")
                        vTelefono = Service.Cliente.Telefono;
                    else
                        vTelefono = Service.Cliente.Celular;
                }


                bool vRes = ModuloSistemaDAO.habilitado("WHATSAPP");
                if (vRes && (vTelefono.Trim() != ""))
                {
                    //SI TIENE 15 CHUPAME LAS BOLAS, PONELO BIEN FORRO
                    if (vTelefono.IndexOf("0") == 0)
                        vTelefono = vTelefono.Substring(1);
                    vTelefono = "+549" + vTelefono;
                    vTelefono = vTelefono.Replace(" ", "");

                    String vNombreEmpresa = DaoParametrosDatos.getParametro("EMPRESA");
                    WhatsappComunication vBA = new WhatsappComunication();
                    vBA.DestinyPhone = vTelefono;
                    vBA.Message += vNombreEmpresa + "\r\n";
                    if (Reparacion != null)
                    {
                        vBA.Message += "Orden de Reparación: " + Reparacion.Codigo + "\r\n";
                         vBA.Message += "Cliente " + Reparacion.Cliente.Nombre + "\r\n";
                         vBA.Message += Reparacion.Equipo.ToString() + "\r\n";
                         vBA.Message += "Accesorios:" + Reparacion.Accesorios + "\r\n";
                         vBA.Message += "Falla:" + Reparacion.Falla + "\r\n";

                        /*vBA.Message += "Estimado cliente se informa que el número de reparación de su equipo es: "
                            + Reparacion.Codigo + ". Entregando el equipo: " + Reparacion.Equipo.ToString()+  ". Accesorios: " +
                            Reparacion.Accesorios;*/
                    }
                    else if (Service != null)
                    {
                        vBA.Message += "Orden de Service: " + Service.Id + "\r\n";
                         vBA.Message += "Cliente " + Service.Cliente.Nombre + "\r\n";
                        vBA.Message += "Trabajo:" + Service.Problema + "\r\n";
                    }
                    else if(Presupuesto!=null)
                    {

                    }

                    // vBA.Message += "***************************************************";
                    vBA.Do();
                    MessageBox.Show("Mensaje enviado correctamente");
                }
            }
            else
            {
                MessageBox.Show("Actualmente no tiene instalado Whatsapp Business");
            }

           
        }

        private void mandarMail(String xCliente, String xEmail, String xTitulo, String xNombreDoc, String xNombreDocPath)
        {
            bool vRes = ModuloSistemaDAO.habilitado("ENVIARMAIL");
            if (vRes && (xEmail.Trim() != ""))
            {
                AdjuntoMail vAdjunto = new AdjuntoMail(xNombreDoc, xNombreDocPath);
                String vMensaje = DaoParametrosDatos.getParametro("CUERPOMAILORDEN");
                vMensaje = vMensaje.Replace("{xCliente}", xCliente);
                List<AdjuntoMail> vAdjuntos = new List<AdjuntoMail>();
                vAdjuntos.Add(vAdjunto);
                EnviarMail vCorreo = new EnviarMail(xTitulo, xEmail, "", "", vMensaje, vAdjuntos);
                vCorreo.Enviar();
                vAdjunto = null;
                vAdjuntos = null;
                vCorreo = null;
                MessageBox.Show("Mail enviado correctamente!");
            }
            else
            {
                //MessageBox.Show("No se ha ingresado un email, por ende no se puede enviar");
                FrmObtenerMail vFormulario = new FrmObtenerMail();
                vFormulario.FormularioEnviarReporte = this;
                vFormulario.MdiParent = this.MdiParent;
                vFormulario.Show();
                
            }
               
        }

        public void EnviarEmail()
        {
            if (Reparacion != null)
                this.mandarMail(Reparacion.Cliente.Nombre,
                      Reparacion.Cliente.Email, "ORDEN DE REPARACION",
                      Reporte,
                      Utils.ObtenerPathDOCS() + Reporte);
            else
                this.mandarMail(Service.Cliente.Nombre,
                    Service.Cliente.Email, "ORDEN DE SERVICE",
                    Reporte,
                    Utils.ObtenerPathDOCS() + Reporte);
        }

        private void btnmail_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("Mail enviado correctamente!");
            EnviarEmail();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetEmailCliente(String xEmail)
        {
         
            if (Reparacion != null)
            {
                Reparacion.Cliente.Email = xEmail;
                DaoCliente.editar(Reparacion.Cliente);
            }
            else if (Service != null)
            {
                Service.Cliente.Email = xEmail;
                DaoCliente.editar(Service.Cliente);
            }
            EnviarEmail();
        }
    }
}
