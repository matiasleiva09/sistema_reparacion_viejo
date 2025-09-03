using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace reparaciones2.whatsapp
{
    public partial class frmWhatsappEnvio : Form
    {
        public frmWhatsappEnvio()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos a enviar mensaje!");
            string from = "9999999999"; //(Enter Your Mobile Number)
            string to = txtEnviarA.Text;
            string msg = txtMensaje.Text;
            WhatsApp wa = new WhatsApp(from, "99999999999", "matias leiva", true, false);
            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Connected to WhatsApp...");
                wa.OnLoginSuccess += (phonenumber, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("Message Sent...");
                };
                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Login Failed : {0} : ", data);
                };

                wa.Login();
            };
            /* wa.OnConnectFailed += (Exception) =>
             {
                 MessageBox.Show("Connection Failed...");
             };*/
            try
            {
                wa.Connect();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                wa.Disconnect();
            }
          
            MessageBox.Show("Seguro que paso?");
        }

        private void frmWhatsappEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
