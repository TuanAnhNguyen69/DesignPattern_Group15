using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill_1 = new Bill("John", new CreditCard());
            bill_1.Solve();

            Bill bill_2 = new Bill("Anna", new Cash());
            bill_2.Solve();

            Bill bill_3 = new Bill("Luis", new Check());
            bill_3.Solve();

            Console.ReadKey();
        }
    }

    interface IPayment
    {
        void Pay();
    }

    class Cash : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("I pay by cash.");
        }
    }

    class CreditCard : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("I pay by credit card.");
        }
    }

    class Check : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("I pay by check.");
        }
    }

    class Bill
    {
        private string name;

        private IPayment paymentMethod;

        public Bill(string _name, IPayment _paymentMethod)
        {
            name = _name;
            paymentMethod = _paymentMethod;
        }

        public void Solve()
        {
            Console.WriteLine("\nCustomer : " + name);
            paymentMethod.Pay();
        }
    }
}
