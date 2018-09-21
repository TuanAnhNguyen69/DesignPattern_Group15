using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine($"*******Shallow copy********");
            Shallow s = new Shallow(3, new Name("Before Shallow"));
            Console.WriteLine($"\nTruoc khi Shallow copy");

            Shallow s1 = s;
            Console.WriteLine($"Nguyen ban {s.x}, {s.name.n}| ban sao {s1.x}, {s1.name.n}");

            Console.WriteLine($"\nSau khi Shallow copy");
            Shallow s2 = (Shallow)s.Clone();
            s.x = 1000;
            s.name.n = "After Shallow";
            Console.WriteLine($"Nguyen ban {s.x}, {s.name.n}| ban sao {s1.x}, {s1.name.n}");
            Console.WriteLine($"Nguyen ban {s.x}, {s.name.n}| ban sao {s2.x}, {s2.name.n}");


            Console.WriteLine($"\n\n*******Deep copy********");
            Deep d = new Deep(3, new Name("Before Deep"));
            Console.WriteLine($"\nTruoc khi Deep copy");
            Deep d1 = d;

            Console.WriteLine($"Nguyen ban {d.x}, {d.name.n}| ban sao {d1.x}, {d1.name.n}");

            Console.WriteLine($"\nSau khi Shallow copy");
            Deep d2 = (Deep)d.Clone();
            d.x = 1000;
            d.name.n = "After Deep";
            Console.WriteLine($"Nguyen ban {d.x}, {d.name.n}| ban sao {d1.x}, {d1.name.n}");
            Console.WriteLine($"Nguyen ban {d.x}, {d.name.n}| ban sao {d2.x}, {d2.name.n}");
            Console.ReadKey();
        }
    }

    class Shallow : ICloneable
    {
        public int x { get; set; }
        public Name name { get; set; }

        public Shallow(int _x, Name _name)
        {
            x = _x;
            name = _name;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Deep : ICloneable
    {
        public int x { get; set; }
        public Name name { get; set; }

        public Deep(int _x, Name _name)
        {
            x = _x;
            name = _name;
        }
        public object Clone()
        {
            Deep d = (Deep)this.MemberwiseClone();
            d.name = (Name)this.name.Clone();
            return d;
        }
    }

    class Name : ICloneable
    {
        public string n { get; set; }

        public Name(string _n)
        {
            n = _n;
        }
        public object Clone()
        {
            return (Name)this.MemberwiseClone();
        }
    }
}
