using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Singleton Extended");

            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine($"info = {singleton1.GetInfo()}");

            singleton1.SetInfo(2);
            Console.WriteLine($"info = {singleton1.GetInfo()}");

            singleton2.SetInfo(3);
            Console.WriteLine($"info = {singleton2.GetInfo()}");

            Console.ReadKey();
        }
    }
}
