using System;

namespace Patterns.Singleton
{
    public class Singleton<T> where T : class,new()  
    {
        private static T singleton = null;
        private static Object lockobject = new Object();
        public static T Get()
        {
            if(singleton==null)
            {
                lock(lockobject)
                {
                    if(singleton==null)
                    {
                        singleton = new T();
                    }   
                }
            }
            return singleton;
        } 
    }
}