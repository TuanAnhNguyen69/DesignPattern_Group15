using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // Receiver class
    class Light
    {
        public void switchOn()
        {
            Console.WriteLine("Switch light on");            
        }

        public void switchOff()
        {
            Console.WriteLine("Switch light off");            
        }
    }

    // command interface
    interface Command
    {
        void execute();
    }

    //ConcreteCommand Class.
    class CommandOff : Command
    {
        Light light;
        public CommandOff(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.switchOff();
        }
    }
    class CommandOn : Command
    {
        Light light;
        public CommandOn(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.switchOn();
        }
    }

    // invoker
    class RemoteControl
    {
        private Queue commandQueue = new Queue();       
        public void pressButton(Command command)
        {
            commandQueue.Enqueue(command);
            //foreach(var item in commandQueue)
            //{
                
            //}
            command.execute();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Light light = new Light();
            Command c1 = new CommandOff(light);
            Command c2 = new CommandOn(light);

            //
            RemoteControl remote = new RemoteControl();          
            remote.pressButton(c1);

           
            //remote.pressButton(c2);

            Console.ReadKey();
        }
    }
}
