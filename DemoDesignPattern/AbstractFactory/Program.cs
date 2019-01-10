using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   

    class UIT  //Abstract Product
    {
        public virtual void Info()
        {
        }
    }

    class CNPM : UIT    //Product
    {
        public override void Info()
        {
            Console.WriteLine("Sinh vien khoa CNPM");
        }
    }
    class HTTT : UIT    //Product
    {
        public override void Info()
        {
            Console.WriteLine("Sinh vien khoa HTTT");
        }
    }

    class USSH  //Abstract Product
    {
        public virtual void Info()
        {
        }
    }

    class DuLich : USSH     //Product
    {
        public override void Info()
        {
            Console.WriteLine("Sinh vien khoa Du lich");
        }
    }

    class BaoChi : USSH    //Product
    {
        public override void Info()
        {
            Console.WriteLine("Sinh vien khoa Bao chi");
        }
    }

    interface SinhVien      //Abstract Factory
    {
        UIT GetSV_UIT(string _uit);
        USSH GetSV_USSH(string _ussh);

        void HeDaoTao();
    }

    class SVChinhQuy : SinhVien    //Concrete Factory
    {
        public void HeDaoTao()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("He chinh quy");
        }
        public UIT GetSV_UIT(string _uit)
        {   
            switch(_uit)
            {
                case "CNPM":
                    return new CNPM();
                case "HTTT":
                    return new HTTT();
                default:
                    return null; 
            }
        }

        public USSH GetSV_USSH(string _ussh)
        {
            return null;
        }
    }

    class SVTuXa : SinhVien   //Concrete Factory
    {
        public void HeDaoTao()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("He tu xa");
        }
        public UIT GetSV_UIT(string _uit)
        {
            return null;
        }

        public USSH GetSV_USSH(string _ussh)
        {
            switch (_ussh)
            {
                case "DuLich":
                    return new DuLich();
                case "BaoChi":
                    return new BaoChi();
                default:
                    return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien chinhquy = new SVChinhQuy();
            SinhVien tuxa = new SVTuXa();

            chinhquy.HeDaoTao();
            chinhquy.GetSV_UIT("CNPM").Info();

            tuxa.HeDaoTao();
            tuxa.GetSV_USSH("BaoChi").Info();

            Console.ReadKey();
        }
    }

}
