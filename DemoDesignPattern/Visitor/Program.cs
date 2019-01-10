using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal bird = new Bird();
            bird.Accept(new Sound());
            bird.Accept(new Benefit());
            bird.Accept(new Birth());

            IAnimal cat = new Cat();
            cat.Accept(new Sound());
            cat.Accept(new Benefit());
            cat.Accept(new Birth());

            Console.ReadKey();
        }
    }

    interface IAnimal
    {
        void Accept(IVisitor visitor);
    }

    class Bird : IAnimal
    {
        public Bird()
        {
            Console.WriteLine("\nBird");
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }

    class Cat : IAnimal
    {
        public Cat()
        {
            Console.WriteLine("\nCat");
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visitor(this);
        }
    }

    interface IVisitor
    {
        void Visitor(Bird animal);

        void Visitor(Cat animal);
    }

    class Sound : IVisitor
    {
        public void Visitor(Bird animal)
        {
            Console.WriteLine("Keu: Chip chip");
        }

        public void Visitor(Cat animal)
        {
            Console.WriteLine("Keu: Meo meo");
        }
    }

    class Benefit : IVisitor
    {
        public void Visitor(Bird animal)
        {
            Console.WriteLine("Cong dung: Lam canh");
        }

        public void Visitor(Cat animal)
        {
            Console.WriteLine("Cong dung: Bat chuot");
        }
    }

    class Birth : IVisitor
    {
        public void Visitor(Bird animal)
        {
            Console.WriteLine("Phuong thuc de: De trung");
        }

        public void Visitor(Cat animal)
        {
            Console.WriteLine("Phuong thuc de: De con");
        }
    }
}