using System;

namespace Vierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("zijde: ");
            double zijde = double.Parse(Console.ReadLine());
            Console.WriteLine($"omtrek: {zijde*4}");
            Console.WriteLine($"oppervlakte: {zijde*zijde}");
            Console.ReadLine();
        }
    }
}
