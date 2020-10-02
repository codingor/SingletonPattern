using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return instance;
        }
    }
}
