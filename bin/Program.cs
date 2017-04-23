using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton st = Singleton.getInstance();
            st.temp = 123;
            st.doSomthing();
            //Console.WriteLine(st.temp);

            Singleton st2 = Singleton.getInstance();
            st2.temp = 456;
            //Console.WriteLine(st2.temp);
            st2.doSomthing();
            st.doSomthing();
        }
    }
}
