using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Singleton
    {
        private static Singleton st;

        private Singleton()
        {
            Console.WriteLine("Singleton instance instantiated...");
        }

        public static Singleton getInstance()
        {
            if (st==null)
            {
                st = new Singleton();
            }

            return st;
        }

        public void Show()
        {
            Console.WriteLine("Single instance...");
        }
    }
}
