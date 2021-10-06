using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string hworld = "Hello World".ToLower();
            int counterH = 0;
            int CounterO = 0;
            int counterL = 0;
            foreach(char character in hworld)
            {
                if (character == 'h')
                {
                    counterH++;
                }
                else if (character == 'o')
                {
                    CounterO++;
                }
                else if (character == 'l')
                {
                    counterL++;
                }
            }
            Console.WriteLine($"Lauses {hworld} on {counterH} H-tähte, {CounterO} O-tähte ja {counterL} L-tähte.");
        }
    }
}
