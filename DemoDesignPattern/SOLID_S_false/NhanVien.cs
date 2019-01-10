using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum LOAINV
{
    banhang,
    thukho,
    ketoan,
}

namespace SOLID_S_false
{
    class NhanVien
    {
        private LOAINV loaiNV;

        public NhanVien(string _loai)
        {
            if (_loai == "banhang")
                loaiNV = LOAINV.banhang;
            else if (_loai == "thukho")
                loaiNV = LOAINV.thukho;
            else if (_loai == "ketoan")
                loaiNV = LOAINV.ketoan;
        }

        public void BanHang()
        {
            Console.WriteLine("Ban hang");
        }

        public void QuanLyKho()
        {
            Console.WriteLine("Quan ly kho");
        }

        public void BaoCao()
        {
            Console.WriteLine("Bao cao");
        }

        public void CongViec()
        {
            if (loaiNV == LOAINV.banhang)
                BanHang();
            else if (loaiNV == LOAINV.thukho)
                QuanLyKho();
            else if (loaiNV == LOAINV.ketoan)
                BaoCao();
            else 
                Console.WriteLine("Khong phai nhan vien");
        }
    }
}
