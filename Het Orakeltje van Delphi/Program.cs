using System;
namespace Het_Orakeltje_van_Delphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random willekeurig = new Random();
            Console.WriteLine($"Je zal nog {willekeurig.Next(0,126)} jaar leven.");
            Console.ReadLine();
        }
    }
}
