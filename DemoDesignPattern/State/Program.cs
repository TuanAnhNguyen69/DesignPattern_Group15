using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Moto moto = new Moto();

            Transport transport = new Transport();

            IMotionState goStraight = new GoStraight();
            transport.SetState(goStraight);
            transport.GetState().Notification(transport);
            Console.WriteLine("Current state : " + transport.GetState().NameState());

            IMotionState turnLeft = new TurnLeft();
            turnLeft.Notification(transport);
            Console.WriteLine("Current state : " + transport.GetState().NameState());

            IMotionState turnRight = new TurnRight();
            turnRight.Notification(transport);
            Console.WriteLine("Current state : " + transport.GetState().NameState());

            Console.ReadKey();
        }
    }

    class Transport
    {
        public string name;

        private IMotionState currentMotionState;

        public Transport()
        {
            name = "Transport";
            currentMotionState = null;
        }

        public void SetState(IMotionState _state)
        {
            currentMotionState = _state;
        }

        public IMotionState GetState()
        {
            return currentMotionState;
        }
    }

    /*
    class Car : Transport
    {
        public Car()
        {
            name = "Car";
        }
    }

    class Moto : Transport
    {
        public Moto()
        {
            name = "Moto";
        }
    }
    */

    interface IMotionState
    {
        void Notification(Transport transport);

        String NameState();
    }

    class TurnLeft : IMotionState
    {
        public string NameState()
        {
            return "Turn Left";
        }

        public void Notification(Transport transport)
        {
            Console.WriteLine($"\nThe {transport.name} is turning left !");
            transport.SetState(this);
        }
    }

    class TurnRight : IMotionState
    {
        public string NameState()
        {
            return "Turn Right";
        }

        public void Notification(Transport transport)
        {
            Console.WriteLine($"\nThe {transport.name} is turning right !");
            transport.SetState(this);
        }
    }

    class GoStraight : IMotionState
    {
        public string NameState()
        {
            return "Go Straight";
        }

        public void Notification(Transport transport)
        {
            Console.WriteLine($"\nThe {transport.name} is going straight !");
            transport.SetState(this);
        }
    }

    
}

