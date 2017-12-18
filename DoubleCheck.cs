using System;
using System.Threading;

namespace Patterns
{
    public class DoubleCheck
    {
        private static System.Object lockThis = new System.Object();  
        private static DoubleCheck singleton = null;
        private DoubleCheck()
        {
            Console.WriteLine("Ctor");
        }
        public static DoubleCheck Get2()
        {
            if (singleton == null)
            {
                Console.WriteLine("进入第一个if");
                lock (lockThis)
                {
                    if (singleton == null)
                    {
                        Console.WriteLine("进入第二个if");
                        Thread.Sleep(1000);
                        singleton = new DoubleCheck();
                    }
                }
            }
            Console.Write("返回实例!");
            return singleton;
        }
    }
}