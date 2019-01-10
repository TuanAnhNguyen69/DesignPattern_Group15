using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterator
    {
        bool hasNext();
        object next();
    }

    interface IContainer
    {
        IIterator createIterator();
    }

    class BooksCollection : IContainer
    {

        private static string[] m_titles = { "Design Patterns", "1", "2", "3", "4" };

        public IIterator createIterator()
        {
            BookIterator result = new BookIterator();
            return result;
        }


        private class BookIterator : IIterator
        {

            private int m_position;

            public bool hasNext()
            {
                if (m_position < m_titles.Length)
                    return true;
                else
                    return false;
            }
            public object next()
            {
                if (this.hasNext())
                    return m_titles[m_position++];
                else
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BooksCollection books = new BooksCollection();

            for (IIterator iter = books.createIterator(); iter.hasNext();)
            {
                string name = iter.next().ToString();
                Console.WriteLine("BookName : " + name);
            }
        }
    }
}
