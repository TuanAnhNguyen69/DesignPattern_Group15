﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
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

        public object Clone()
        {
            //return this.MemberwiseClone();
            return new Khoa(this.tenKhoa, this.phong);  
        }
    }
}
