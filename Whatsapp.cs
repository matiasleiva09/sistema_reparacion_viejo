using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace reparaciones2
{
    public partial class Whatsapp : Form
    {
        public Whatsapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string accountSid = "AC920e1d29e1b840135444d413eb007071";
            const string authToken = "99af182bf5acfb73d4c5fe42a4fc3bdd";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                body: txtmessage.Text,
                to: new Twilio.Types.PhoneNumber("whatsapp:" + txtto.Text)
            );

            Console.WriteLine(message.Sid);
        }

        private void Whatsapp_Load(object sender, EventArgs e)
        {
            txtfrom.Text = "+12066735345";
            txtto.Text = "+542267444171";
        }
    }
}
