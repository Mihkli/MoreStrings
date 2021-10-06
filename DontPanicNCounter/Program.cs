using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dpanic = "Don't Panic".ToLower();
            int counter = 0;
            foreach(char character in dpanic)
            {
                if (character == 'n')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Lauses {dpanic} on {counter} N-tähte.");

        }
    }
}
