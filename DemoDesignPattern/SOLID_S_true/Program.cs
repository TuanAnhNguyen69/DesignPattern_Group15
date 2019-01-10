using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S_true
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nvBanHang = new NVBanHang();
            nvBanHang.CongViec();

            NhanVien nvThuKho = new NVThuKho();
            nvThuKho.CongViec();

            NhanVien nvKeToan = new NVKeToan();
            nvKeToan.CongViec();

            Console.ReadKey();
        }
    }

    class NhanVien
    {
        public virtual void CongViec()
        {

        }
    }

    class NVBanHang : NhanVien
    {
        public override void CongViec()
        {
            Console.WriteLine("Ban hang");
        }
    }

    class NVThuKho : NhanVien
    {
        public override void CongViec()
        {
            Console.WriteLine("Quan ly kho");
        }
    }

    class NVKeToan : NhanVien
    {
        public override void CongViec()
        {
            Console.WriteLine("Bao cao");
        }
    }
}
