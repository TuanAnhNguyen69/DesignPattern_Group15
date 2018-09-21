
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    class SinhVien : ICloneable
    {
        private int mssv;
        private Khoa khoa;

        public void SetMSSV(int _mssv)
        {
            mssv = _mssv;
        }

        public int GetMSSV()
        {
            return mssv;
        }

        public void SetKhoa(Khoa _khoa)
        {
            khoa = _khoa;
        }

        public Khoa GetKhoa()
        {
            return khoa;
        }
        
        public SinhVien(int _mssv, Khoa _khoa)
        {
            mssv = _mssv;
            khoa = _khoa;
        }
        

        public object Clone()
        {
            //return new SinhVien(this.mssv, this.khoa);
            return this.MemberwiseClone();
        }

        /*
        public object Clone()
        {
            //SinhVien sv = new SinhVien(this.mssv, new Khoa(this.khoa.GetTenKhoa(), this.khoa.GetPhong()));
            //return sv;
            return new SinhVien(this.mssv, new Khoa(this.khoa.GetTenKhoa(), this.khoa.GetPhong()));
            //return MemberwiseClone();
        }
        */
    }
}
