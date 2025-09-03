using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace reparaciones2.ob.comunicacion
{
    public class SMSComunication : Communication
    {
        protected override void Execute()
        {
            try
            {
                TwilioClient.Init(this.SSID, this.Token);

                var message = MessageResource.Create(
                    from: new Twilio.Types.PhoneNumber(this.OriginPhone),
                    body: this.Message,
                    to: new Twilio.Types.PhoneNumber(this.DestinyPhone)
                );
                Console.WriteLine(message.Sid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
