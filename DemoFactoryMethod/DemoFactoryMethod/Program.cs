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


        //public class AgencyCar
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
       
        public class AgencyCar
        {
            public void viewCar()
            {
                CarFactory carFactory = new CarFactory();
                carFactory.viewCar("HONDA");
                carFactory.viewCar("KIA");
                carFactory.viewCar("TOYOTA");
            }

        }
      
        public class CarFactory
        {
            public void viewCar(string carType)
            {
                ICar car;
                if (carType == "HONDA")
                {
                    car = new Honda();
                    car.view();
                }
                else if (carType == "KIA")
                {
                    car = new KiA();
                    car.view();
                }
                else if (carType == "TOYOTA")
                {
                    car = new Toyota();
                    car.view();
                }
            }
        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            AgencyCar agency = new AgencyCar();
            agency.viewCar();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
