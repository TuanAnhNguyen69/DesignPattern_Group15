using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_S_false
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nvBanHang = new NhanVien("banhang");
            nvBanHang.CongViec();

            NhanVien nvThuKho = new NhanVien("thukho");
            nvThuKho.CongViec();

            NhanVien nvKeToan = new NhanVien("ketoan");
            nvKeToan.CongViec();

            Console.ReadKey();
        }
    }
}
