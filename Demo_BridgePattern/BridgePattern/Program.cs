using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();           
            IMessageSender sms = new SMSSender();
            Message message;

            message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();         

            message.MessageSender = sms;
            message.Send();


            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "attach a comment";

            message = usermsg;
            message.MessageSender = email;
            message.Send();
            message.MessageSender = sms;
            message.Send();

            Console.ReadKey();
        }
    }
}
