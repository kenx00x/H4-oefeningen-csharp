using System;

namespace BMI_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());
            Console.Write("Geef je lengte in meter: ");
            double lengte = double.Parse(Console.ReadLine());
            Console.WriteLine($"Je BMI is {Math.Round((gewicht/(lengte*lengte)),2)}");
            Console.ReadLine();

        }
    }
}
