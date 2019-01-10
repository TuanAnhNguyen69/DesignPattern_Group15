using System;

namespace DesignPattern.Adapter
{
    // giả sử ban đầu có cách thanh toán OldTransfer

    //class OldTransfer
    //{
    //    public void Pay()
    //    {
    //        Console.WriteLine("Thanh toán cũ...");
    //    }
    //}

    // Một vài năm sau ta có cách thanh toán mới là NewTransfer
    class NewTransferAdaptee
    {
        public void NewPay()
        {
            Console.WriteLine("Thanh toán mới");
        }
        public void Function_Two()
        {
            Console.WriteLine("Do some thing 2");
        }
        public void Funtion_Three()
        {
            Console.WriteLine("Do some thing 3");
        }
    }
    
    interface ITransferTarget
    {
        void Pay();      
       
    }

    class OldTransfer : ITransferTarget
    {
        public void Pay()
        {
            Console.WriteLine("Thanh toán cũ...");
        }
    }


    class OldTransFerToNewTransferAdapter : ITransferTarget
    {
        private NewTransferAdaptee _adaptee = new NewTransferAdaptee();     

        public void Pay()
        {
            _adaptee.NewPay();
        }
    }

    //class OldTransFerToNewTransferAdapter : NewTransferAdaptee, ITransferTarget
    //{
    //    public void Pay()
    //    {
    //        NewPay();
    //    }
    //}

    class UserClient
    {
        public void Pay(ITransferTarget itransferTarget)
        {
            itransferTarget.Pay();
        }
    }
 
    class MainApp
    {     
        static void Main()
        {
            ITransferTarget oldTranfer = new OldTransfer();           
            ITransferTarget target = new OldTransFerToNewTransferAdapter();

            UserClient user = new UserClient();
            user.Pay(target);
         
            Console.ReadKey();
        }
    }

}
