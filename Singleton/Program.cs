using System;

namespace Singleton
{


    //Benifit over static, 1.  lazy loaded , 2. Can implement interface or inherit class
    class Singleton
    {
        private Singleton()
        {

        }

        private static Singleton _Instance;

        public static Singleton GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new Singleton();
            }
            return _Instance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.GetInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
        }
    }
}
