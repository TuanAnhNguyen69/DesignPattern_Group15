using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("SMS\n{0}\n{1}\n", subject, body);
        }
    }
}
