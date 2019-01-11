using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    interface Beverage
    {
        String GetIngredient();
    }

    class Tea : Beverage
    {
        public String ingredient;

        public Tea()
        {
            this.ingredient = "Tea, hot water";
        }

        public String GetIngredient()
        {
            return this.ingredient;
        }
    }

    class MachiatoTea : Beverage
    {
        Beverage tea;

        public MachiatoTea(Beverage tea)
        {
            this.tea = tea;
        }

        public String GetIngredient()
        {
            return tea.GetIngredient() + ", machiato";

        }
    }

    class ColdTea : Beverage
    {
        Beverage tea;

        public ColdTea(Beverage tea)
        {
            this.tea = tea;
        }

        public String GetIngredient()
        {
            return tea.GetIngredient() + ", Ice";

        }
    }


    class Program
    {
        static void Main()
        {
            Tea tea = new Tea();
            Console.WriteLine("TEA");
            Console.WriteLine(tea.GetIngredient());

    
            MachiatoTea machiato = new MachiatoTea(tea);
            Console.WriteLine("MachiatoTEA");
            Console.WriteLine(machiato.GetIngredient());

            ColdTea coldTea = new ColdTea(tea);
            Console.WriteLine("ColdTEA");
            Console.WriteLine(coldTea.GetIngredient());

            ColdTea coldMachiatoTea = new ColdTea(machiato);
            Console.WriteLine("ColdMachiatoTEA");
            Console.WriteLine(coldMachiatoTea.GetIngredient());


            // Wait for user
            Console.ReadKey();
        }
    }
}
