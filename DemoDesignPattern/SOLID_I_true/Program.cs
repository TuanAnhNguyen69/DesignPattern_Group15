using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_I_true
{
    interface IAnimal
    {
        void Move();

        void Eat();

        void Drink();
    }

    interface IBird
    {
        void Fly();
    }

    class Dog : IAnimal
    {
        public void Drink()
        {
            Console.WriteLine("Dog is drinking");
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving");
        }
    }

    class Dove : IAnimal, IBird
    {
        public void Drink()
        {
            Console.WriteLine("Dove is drinking");

        }

        public void Eat()
        {
            Console.WriteLine("Dove is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Dove is flying");
        }

        public void Move()
        {
            Console.WriteLine("Dove is moving");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Dove dove = new Dove();

            dog.Drink();
            dog.Eat();
            dog.Move();
            //dog.Fly();

            Console.WriteLine();

            dove.Drink();
            dove.Eat();
            dove.Move();
            dove.Fly();

            Console.ReadKey();
        }
    }
}
