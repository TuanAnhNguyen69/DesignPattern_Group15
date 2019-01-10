using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Rect
    {
        private int width;
        private int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        public void Xuat()
        {
            Console.WriteLine($"({width}, {height})");
        }
    }

    class Square 
    {
        
    }
}
