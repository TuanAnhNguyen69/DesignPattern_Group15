using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectionProxy
{
    class Program       //Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Before *************");
            IAccount account = new Account("BAT_KY");
            account.XemDiem();
            account.SuaDiem();
            Console.WriteLine();

            Console.WriteLine("\n*********** After *************");
            IAccount accountGV = new AccountProxy("GIANG_VIEN", AccType.GiangVien);
            IAccount accountSV = new AccountProxy("SINH_VIEN", AccType.SinhVien);
            accountGV.XemDiem();
            accountGV.SuaDiem();
            Console.WriteLine();
            accountSV.XemDiem();
            accountSV.SuaDiem();

            Console.ReadKey();
        }
    }

    enum AccType
    {
        GiangVien,
        SinhVien,
        None
    }

    interface IAccount          //Object
    {
        void XemDiem();

        void SuaDiem();
    }

    class Account : IAccount    //RealObject
    {
        private string useName;
        private AccType type;

        public Account(string _useName, AccType _type = AccType.None)
        {
            useName = _useName;
            type = _type;
        }

        public AccType GetAccType()
        {
            return type;
        }
        public void SuaDiem()
        {
            Console.WriteLine($"Tai khoan {useName} da sua diem");
        }

        public void XemDiem()
        {
            Console.WriteLine($"Tai khoan {useName} da xem diem");
        }
    }

    class AccountProxy : IAccount   //Proxy
    {
        Account acc;
        string useName;
        AccType type;

        public AccountProxy(string _useName, AccType _type)
        {
            acc = null;
            useName = _useName;
            type = _type;
        }
        public void SuaDiem()
        {
            if (acc == null)
                acc = new Account(useName, type);
            if (acc.GetAccType() == AccType.GiangVien)
                acc.SuaDiem();
            else
                Console.WriteLine($"Tai khoan {useName} khong the sua diem");
        }

        public void XemDiem()
        {
            if (acc == null)
                acc = new Account(useName, type);
            if (acc.GetAccType() == AccType.GiangVien || acc.GetAccType() == AccType.SinhVien)
                acc.XemDiem();
            else
                Console.WriteLine($"Tai khoan {useName} khong the xem diem");
        }
    }
}
