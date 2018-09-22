using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactoryMethod
{
    class Program
    {
        public interface ICar
        {
            void view();
        }

        public class Honda : ICar
        {
            public void view()
            {
                Console.WriteLine("Honda view");
            }
        }

        public class Toyota : ICar
        {
            public void view()
            {
                Console.WriteLine("Toyota view");
            }
        }

        public class KiA : ICar
        {
            public void view()
            {
                Console.WriteLine("KiA view");
            }
        }

        public enum CarType
        {
            HONDA,
            KIA,
            TOYOTA
        }

        public interface ICarFactory
        {
            ICar viewCar(CarType carType);
        }

        public class CarFactory : ICarFactory
        {
            public ICar viewCar(CarType carType)
            {
                ICar car;

                switch (carType)
                {
                    case CarType.HONDA:
                        car = new Honda();
                        car.view();
                        return car;
                    case CarType.KIA:
                        car = new KiA();
                        car.view();
                        return car;
                    case CarType.TOYOTA:
                        car = new Toyota();
                        car.view();
                        return car;
                    default:
                        car = new Honda();
                        car.view();
                        return car;
                }
            }
        }


        //public class Client
        //{
        //    public void viewHonda()
        //    {
        //        Honda honda = new Honda();
        //        honda.view();
        //    }
        //    public void viewNexus()
        //    {
        //        KiA kia = new KiA();
        //        kia.view();
        //    }
        //    public void viewToyota()
        //    {
        //        Toyota toyota = new Toyota();
        //        toyota.view();
        //    }
        //}

        public class Client
        {
            public void viewCar()
            {
                CarFactory car = new CarFactory();
                car.viewCar(CarType.HONDA);
                car.viewCar(CarType.KIA);
                car.viewCar(CarType.TOYOTA);
            }

        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Client client = new Client();
            client.viewCar();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
