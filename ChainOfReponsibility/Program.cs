using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    public class Request
    {
        private int m_value;
        private string m_description;

        public Request(string description, int value)
        {
            m_description = description;
            m_value = value;
        }

        public int getValue()
        {
            return m_value;
        }

        public string getDescription()
        {
            return m_description;
        }
    }

    public abstract class Handler
    {
        protected Handler m_successor;
        
        public void setSuccessor(Handler successor)
        {   // 
            m_successor = successor;
        }

        public abstract void handleRequest(Request request);
    }

    public class ConcreteHandlerOne : Handler
    {

        public override void handleRequest(Request request)
        {
            if (request.getValue() < 0)
            {           //if request is eligible handle it
                Console.WriteLine("Negative values are handled by ConcreteHandlerOne:");
                Console.WriteLine("\tConcreteHandlerOne Handled Request : " + request.getDescription()
                         + request.getValue());
            }
            else
            {
                if(m_successor != null)
                    m_successor.handleRequest(request);
            }
        }
    }

    public class ConcreteHandlerTwo : Handler
    {

        public override void handleRequest(Request request)
        {
            if (request.getValue() > 0)
            {           //if request is eligible handle it
                Console.WriteLine("Positive values are handled by ConcreteHandlerTwo:");
                Console.WriteLine("\tConcreteHandlerTwo Handled Request : " + request.getDescription()
                     + request.getValue());
            }
            else
            {
                if (m_successor != null)
                    m_successor.handleRequest(request);
            }
        }
    }

    public class ConcreteHandlerThree : Handler
    {

        public override void handleRequest(Request request)
        {
            if (request.getValue() == 0)
            {           //if request is eligible handle it
                Console.WriteLine("Zero values are handled by ConcreteHandlerThree:");
                Console.WriteLine("\tConcreteHandlerThree Handled Request : " + request.getDescription()
                     + request.getValue());
            }
            else
            {
                if (m_successor != null)
                    m_successor.handleRequest(request);
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandlerOne();
            Handler h2 = new ConcreteHandlerTwo();
            Handler h3 = new ConcreteHandlerThree();
            h1.setSuccessor(h2);
            h2.setSuccessor(h3);

            // Send requests to the chain
            h1.handleRequest(new Request("Value ", -1));
            h1.handleRequest(new Request("Value ", 0));
            h1.handleRequest(new Request("Value ", 1));
            h1.handleRequest(new Request("Value ", 2));
            h1.handleRequest(new Request("Value ", -5));

            Console.ReadKey();
        }
    }
}
