using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCommand
{

    // Receiver class.
    class StockTrade
    {
        public void buy()
        {
            Console.WriteLine("You want to buy stocks");
        }
        public void sell()
        {
            Console.WriteLine("You want to sell stocks ");
        }
    }

    // Invoker.
    class Agent
    {
        private List<Order> ordersQueue = new List<Order>();

        public Agent()
        {
        }

        public void placeOrder(Order order)
        {
            ordersQueue.Add(order);
            order.execute();
        }
    }

    // command
    interface Order
    {
        void execute();
    }

    //ConcreteCommand Class.
    class BuyStockOrder : Order
    {
        private StockTrade stock;
        public BuyStockOrder(StockTrade st)
        {
            stock = st;
        }
        public void execute()
        {
            stock.buy();
        }
    }

    //ConcreteCommand Class.
    class SellStockOrder : Order
    {
        private StockTrade stock;
        public SellStockOrder(StockTrade st)
        {
            stock = st;
        }
        public void execute()
        {
            stock.sell();
        }
    }

    // Client
    public class Client
    {
        public static void main(string[] args)
        {
            StockTrade stock = new StockTrade();
            BuyStockOrder buystock = new BuyStockOrder(stock);
            SellStockOrder sellstock = new SellStockOrder(stock);

            Agent agent = new Agent();

            agent.placeOrder(buystock); // Buy Shares
            agent.placeOrder(buystock); // Sell Shares
        }
    }
}

