using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestada eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Palun sisestada perekonnanimi;");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Tere, {firstname[0]}. {lastname[0]}.!");
        }
    }
}
