using System;
using System.Reflection;
using System.Threading;
using Patterns.SimpleFactory;
namespace Patterns
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Program a = new Program();
            for(int i = 0;i<100;i++)
            {
            Thread t = new Thread(a.Test);
            t.Start();
            }
        }

        public void Test()
        {
            Thread.Sleep(r.Next(100));
            DoubleCheck temp = DoubleCheck.Get2();       
        }
    }
}
