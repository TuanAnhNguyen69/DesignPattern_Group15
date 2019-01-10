using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Extended
{
    class Singleton
    {
        private int info = 0;

        private Singleton()
        {
            Console.WriteLine("Khoi tao Singleton");
        }

        private static readonly Lazy<Singleton> lazySingleton = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazySingleton.Value;
            }
        }

        public int GetInfo()
        {
            return info;
        }

        public void SetInfo(int _info)
        {
            info = _info;
        }
    }
}
