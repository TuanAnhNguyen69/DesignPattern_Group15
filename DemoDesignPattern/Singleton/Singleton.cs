using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton Instance = null;

        private int info = 0;

        private Singleton()
        {
            Console.WriteLine("Khoi tao Singleton");
        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
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
