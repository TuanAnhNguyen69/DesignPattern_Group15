using System;

namespace ShallowCopy
{
    class Khoa
    {
        private string tenKhoa;
        private string phong;

        public void SetTenKhoa(string _tenKhoa)
        {
            tenKhoa = _tenKhoa;
        }

        public string GetTenKhoa()
        {
            return tenKhoa;
        }

        public void SetPhong(string _phong)
        {
            phong = _phong;
        }

        public string GetPhong()
        {
            return phong;
        }

        public Khoa(string _tenKhoa, string _phong)
        {
            tenKhoa = _tenKhoa;
            phong = _phong;
        } 
    }
}