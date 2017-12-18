using System;

namespace Patterns.Singleton
{
    public class Multiton<T> where T : class,new()
    {
        private static Random r = new Random();
        private static T[] singletons = new T[3];
        private static Object lockobject = new Object();
        public static T Get()
        {
            int i = r.Next(singletons.Length);
            if (singletons[i] == null)
            {
                lock (lockobject)
                {
                    if (singletons[i] == null)
                    {
                        singletons[i] = new T();
                    }
                }
            }
            return singletons[i];
        }
    }
}