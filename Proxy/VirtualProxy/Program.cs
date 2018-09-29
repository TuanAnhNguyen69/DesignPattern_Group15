using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProxy
{
    class Program   //Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Before ******************");
            IRequest requestA = new Request("A");
            IRequest requestB = new Request("B");

            requestA.Reply();
            requestA.Reply();

            Console.WriteLine("\n***************  After ******************");
            IRequest request_proxyA = new RequestProxy("A");
            IRequest request_proxyB = new RequestProxy("B");

            request_proxyA.Reply();
            request_proxyA.Reply();

            Console.ReadKey();
        }
    }

    interface IRequest  //Object
    {
        void Reply();
    }

    class Request : IRequest    //RealObject
    {
        private string info;

        public Request(string _info)
        {
            info = _info;
            ReadRequest();
        }
        public void Reply()
        {
            Console.WriteLine($"Reply for request  {info}");
        }

        public void ReadRequest()
        {
            Console.WriteLine($"Read request {info}");
        }
    }

    class RequestProxy : IRequest   //Proxy
    {
        private Request request;
        private string info;

        public RequestProxy(string _info)
        {
            request = null;
            info = _info;
        }
        public void Reply()
        {
            if (request == null)
                request = new Request(info);
            request.Reply();
        }
    }
}
