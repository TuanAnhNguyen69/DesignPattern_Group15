using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L_true
{
    class Program
    {
        static void Main(string[] args)
        {
            Luong nv1 = new NVBanHang();
            //Luong nv2 = new NVThucTap();      báo lỗi

            Console.ReadKey();
        }
    }

    class NhanVien : CongViec, Luong
    {
        private string ten;
        private int id;

        public void CongViec()
        {

        }

        public void XuatLuong()
        {

        }
    }

    class NVBanHang : CongViec, Luong
    {
        public void CongViec()
        {
            Console.WriteLine("Ban hang");
        }

        public void XuatLuong()
        {
            Console.WriteLine("Luong 10.000.000");
        }
    }

    class NVThucTap : CongViec
    {
        public void CongViec()
        {
            Console.WriteLine("Thuc tap");
        }
    }

    interface Luong
    {
        void XuatLuong();
    }

    interface CongViec
    {
        void CongViec();
    }
}
