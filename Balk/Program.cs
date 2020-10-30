using System;

namespace Balk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lengte: ");
            double lengte = double.Parse(Console.ReadLine());
            Console.Write("breedte: ");
            double breedte = double.Parse(Console.ReadLine());
            Console.Write("hoogte: ");
            double hoogte = double.Parse(Console.ReadLine());
            Console.WriteLine($"oppervlakte: {(lengte*breedte+lengte*hoogte+breedte*hoogte)*2}");
            Console.WriteLine($"inhoud: {lengte*hoogte*breedte}");
            Console.ReadLine();
        }
    }
}
