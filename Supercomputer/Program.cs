using System;

namespace Supercomputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef kommagetal 1: ");
            double getal1 = double.Parse(Console.ReadLine());
            Console.Write("Geef kommagetal 2: ");
            double getal2 = double.Parse(Console.ReadLine());
            Console.Write("Geef kommagetal 3: ");
            double getal3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Het gemiddelde is {(getal1+getal2+getal3)/3}");
            Console.ReadLine();
        }
    }
}
