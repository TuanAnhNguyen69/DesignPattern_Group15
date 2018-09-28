using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            // Create milktea

            MilkTea milkTea = new MilkTea("BlackBorn", new List<string> {"Milk", "Tea"}, "Jelly");
            milkTea.ShowIngredient();

            // Create machiato

            Machiato machiato = new Machiato("Macha", new List<string> { "Macha", "BlackTea" });
            machiato.ShowIngredient();

            Custommer custommer = new Custommer(machiato);
            custommer.OrderItem("Customer 1");
            custommer.OrderItem("Customer 2");

            custommer.ShowIngredient();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Component' abstract class

    /// </summary>

    abstract class Beverage
    {
        protected string name;
        protected List<string> _ingredients;

        // Property
        public List<string> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public abstract void ShowIngredient();
    }

    /// <summary>

    /// The 'ConcreteComponent' class

    /// </summary>

    class MilkTea : Beverage
    {
        private string topping;

        // Constructor

        public MilkTea(string name, List<string> ingredients, string topping)
        {
            this.name = name;
            this.Ingredients = ingredients;
            this.topping = topping;
        }

        public override void ShowIngredient()
        {
            Console.WriteLine("\nMilktea ------ ");
            Console.WriteLine(" Name: {0}", name);
            Console.WriteLine(" Toping: {0}", topping);
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine("\n {0}", ingredient);
            }
        }
    }

    /// <summary>

    /// The 'ConcreteComponent' class

    /// </summary>

    class Machiato : Beverage

    {

        // Constructor

        public Machiato(string name, List<string> ingredients)
        {
            this.name = name;
            this.Ingredients = ingredients;
        }

        public override void ShowIngredient()
        {
            Console.WriteLine("\nMachiato ------ ");
            Console.WriteLine(" Name: {0}", name);
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine("\n {0}", ingredient);
            }
        }
    }

    /// <summary>

    /// The 'Decorator' abstract class

    /// </summary>

    abstract class Decorator : Beverage

    {
        protected Beverage beverage;

        // Constructor

        public Decorator(Beverage libraryItem)
        {
            this.beverage = libraryItem;
        }

        public override void ShowIngredient()
        {
            beverage.ShowIngredient();
        }
    }

    /// <summary>

    /// The 'ConcreteDecorator' class

    /// </summary>

    class Custommer : Decorator

    {
        protected List<string> custommer = new List<string>();

        // Constructor

        public Custommer(Beverage beverage)
            : base(beverage)
        {
        }

        public void OrderItem(string name)
        {
            custommer.Add(name);
        }

        public void ReturnItem(string name)
        {
            custommer.Remove(name);
        }

        public override void ShowIngredient()
        {
            base.ShowIngredient();

            foreach (string borrower in custommer)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
