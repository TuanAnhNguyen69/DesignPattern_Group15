using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceOnline foodOnline = new FoodOnline();
            ServiceOnline hotelOnline = new HotelOnline();

            Console.WriteLine("\nBuy food online : ");
            foodOnline.UseService();

            Console.WriteLine("\nBook hotel online : ");
            hotelOnline.UseService();

            Console.ReadKey();
        }
    }

    abstract class ServiceOnline
    {
        public virtual void Login()
        {
            Console.WriteLine("Login...");
        }

        public virtual void Choice()
        {
            Console.WriteLine("Choice service...");
        }

        public virtual void Solve()
        {
            Console.WriteLine("Solve...");
        }

        public virtual void Recive()
        {
            Console.WriteLine("Recive service...");
        }

        public void UseService()
        {
            Login();
            Choice();
            Solve();
            Recive();
        }
    }

    class FoodOnline : ServiceOnline
    {
        public override void Solve()
        {
            Console.WriteLine("Payment on delivery...");
        }

        public override void Recive()
        {
            Console.WriteLine("Get food...");
        }
    }

    class HotelOnline : ServiceOnline
    {
        public override void Solve()
        {
            Console.WriteLine("Deposit...");
            Console.WriteLine("Pay the rest when come...");
        }

        public override void Recive()
        {
            Console.WriteLine("Go to the hotel...");
        }
    }
}
