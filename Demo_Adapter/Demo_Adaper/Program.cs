using System;

namespace DoFactory.GangOfFour.Adapter.Structural
{
    /// <summary>
    /// The 'Target' interface
    /// </summary>
    interface ITarget
    {
        void Request_A_Expect();
        void Request_B_Expect();
        void Request_C_Expect();
    }

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request_A_Expect()
        {
            // Possibly do some other workand then call RequestB

            _adaptee.Request_A_Real();
        }
        public void Request_B_Expect()
        {
            // Possibly do some other workand then call RequestB

            _adaptee.Request_B_Real();
        }
        public void Request_C_Expect()
        {
            // Possibly do some other workand then call RequestB

            _adaptee.Request_C_Real();
        }
    }

    //class Adapter : Adaptee, ITarget
    //{            
    //    public void Request_A_Expect()
    //    {
    //        Request_A_Real();
    //    }

    //    public void Request_B_Expect()
    //    {
    //        Request_B_Real();
    //    }

    //    public void Request_C_Expect()
    //    {
    //        Request_C_Real();
    //    }
    //}

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    class Adaptee

    {
        public void Request_A_Real()
        {
            Console.WriteLine("Reponse from Request_A_Real()");
        }
        public void Request_B_Real()
        {
            Console.WriteLine("Reponse from Request_B_Real()");
        }
        public void Request_C_Real()
        {
            Console.WriteLine("Reponse from Request_C_Real()");
        }
    }

    /// <summary>
    /// MainApp startup class for Structural
    /// Adapter Design Pattern.
    /// </summary>

    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Create adapter and place a request

            ITarget target = new Adapter();
            target.Request_A_Expect();
            target.Request_B_Expect();
            target.Request_C_Expect();
            // Wait for user

            Console.ReadKey();
        }
    }

}
