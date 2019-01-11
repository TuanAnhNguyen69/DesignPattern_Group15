using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Human human = new Human();
            ComputerFacade facade = new ComputerFacade(computer, human);
            facade.TurnOn();

            facade.TurnOff();

            Console.ReadKey();
        }
    }

    class Computer
    {
        public void GetElectric()
        {
            Console.WriteLine("Plugin, ");
        }

        public void ShowLoadingScreen()
        {
            Console.WriteLine("Loading, ");
        }

        public void Login()
        {
            Console.WriteLine("Logging in, ");
        }

        public void CloseEverything()
        {
            Console.WriteLine("Closing, ");
        }

        public void TurnOffScreen()
        {
            Console.WriteLine("Screen Off, ");
        }

        public void UnPlug()
        {
            Console.WriteLine("UnPlug, ");
        }
    }

    class Human
    {
        public void PressPowerButton()
        {
            Console.WriteLine("Press PowerButton, ");
        }
    }

    class ComputerFacade
    {
        private Computer computer;
        private Human human;

        public ComputerFacade(Computer computer, Human human)
        {
            this.human = human;
            this.computer = computer;
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on ============");

            this.computer.GetElectric();
            this.human.PressPowerButton();
            this.computer.ShowLoadingScreen();
            this.computer.Login();
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off ============");

            this.human.PressPowerButton();
            this.computer.CloseEverything();
            this.computer.TurnOffScreen();
            this.computer.UnPlug();
        }
    }
}
