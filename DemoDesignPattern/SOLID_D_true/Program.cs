using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_D_true
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email("abc@gmail.com");
            SMS sms = new SMS(01697123456);

            ThongBao thongBao = new ThongBao();
            thongBao.setType(email);
            thongBao.GuiThongBao();

            thongBao.setType(sms);
            thongBao.GuiThongBao();

            Console.ReadKey();
        }
    }

    class ThongBao
    {
        private Message message;

        public void setType(Message msType)
        {
            message = msType;
        }

        public void GuiThongBao()
        {
            message.SendMessage();
        }
    }

    interface Message
    {
        void SendMessage();
    }

    class Email : Message
    {
        private string address;

        public Email(string _add)
        {
            address = _add;
        }
        public void SendMessage()
        {
            Console.WriteLine($"Gui thong bao bang Email qua dia chi {address}");
        }
    }

    class SMS : Message
    {
        private int phoneNumber;

        public SMS(int _pn)
        {
            phoneNumber = _pn;
        }
        public void SendMessage()
        {
            Console.WriteLine($"Gui thong bao bang SMS qua sdt {phoneNumber}");
        }
    }

}
