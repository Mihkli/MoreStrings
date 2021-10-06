using System;

namespace DontPanicReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string panic = "Don't panic".ToUpper();
            for (int i = panic.Length - 1; i >= 0; i--)
            {
                Console.Write(panic[i]);
            }
            Console.Read();
        }
    }
}
