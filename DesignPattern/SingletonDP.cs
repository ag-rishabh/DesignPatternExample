using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SingletonDP
    {
        private static SingletonDP Instance = null;
        private readonly static Object _lock = new object();

        private SingletonDP() 
        {
            Console.WriteLine("Object Created");
        }

        public static SingletonDP GetInstance()
        {
            if(Instance == null)
            {
                lock (_lock)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonDP();
                    }
                }
            }
           
            return Instance;
        }

        public void PrintMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
