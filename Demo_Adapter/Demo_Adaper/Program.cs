using System;

namespace DoFactory.GangOfFour.Adapter.Structural
{

    interface ITarget
    {
        void Request_A();
        void Request_B();
    }


    class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request_A()
        {           
            _adaptee.Request_A_Real();
        }
        public void Request_B()
        {           
            _adaptee.Request_B_Real();
        }
    }

    //class Adapter : Adaptee, ITarget
    //{            
    //    public void Request_A()
    //    {
    //        Request_A_Real();
    //    }

    //    public void Request_B()
    //    {
    //        Request_B_Real();
    //    }   
    //}


    class Adaptee
    {
        public void Request_A_Real()
        {
            Console.WriteLine("Reponse from Request_A_Real() of Adaptee");
        }
        public void Request_B_Real()
        {
            Console.WriteLine("Reponse from Request_B_Real() of adaptee");
        }
        public void Funtion_Three()
        {
            // do some thing
        }
    }

    
    class MainApp
    {     
        static void Main()
        {       
            ITarget target = new Adapter();
            target.Request_A();
            target.Request_B();
         
            Console.ReadKey();
        }
    }

}
