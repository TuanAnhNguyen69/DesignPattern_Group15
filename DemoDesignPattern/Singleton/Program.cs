using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Singleton");

            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Console.WriteLine($"info = {singleton1.GetInfo()}");

            singleton1.SetInfo(2);
            Console.WriteLine($"info = {singleton2.GetInfo()}");

            singleton2.SetInfo(3);
            Console.WriteLine($"info = {singleton1.GetInfo()}");

            Console.ReadKey();
        }
    }
}
