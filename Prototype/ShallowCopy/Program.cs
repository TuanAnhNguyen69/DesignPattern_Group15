using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    interface IClone
    {
        object Clone();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Truoc khi thay doi");
            SinhVien sv1 = new SinhVien(111, new Khoa("CNPM", "P11"));
            Console.WriteLine($"Sinh vien {sv1.GetMSSV()} thuoc khoa {sv1.GetKhoa().GetTenKhoa()}");

            SinhVien sv2 = (SinhVien)sv1.Clone();
            Console.WriteLine($"Sinh vien {sv2.GetMSSV()} thuoc khoa {sv2.GetKhoa().GetTenKhoa()}");

            SinhVien sv3 = (SinhVien)sv1.Clone();
            Console.WriteLine($"Sinh vien {sv3.GetMSSV()} thuoc khoa {sv3.GetKhoa().GetTenKhoa()}");

            Console.WriteLine("\nSau khi thay doi");
            sv2.SetMSSV(222);
            sv2.GetKhoa().SetTenKhoa("HTTT");
            sv3.SetMSSV(333);
            sv1.GetKhoa().SetTenKhoa("KTMT");
            Console.WriteLine($"Sinh vien {sv1.GetMSSV()} thuoc khoa {sv1.GetKhoa().GetTenKhoa()}");
            Console.WriteLine($"Sinh vien {sv2.GetMSSV()} thuoc khoa {sv2.GetKhoa().GetTenKhoa()}");            
            Console.WriteLine($"Sinh vien {sv3.GetMSSV()} thuoc khoa {sv3.GetKhoa().GetTenKhoa()}");

            Console.ReadKey();
        }
    }
}
