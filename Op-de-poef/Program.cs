using System;

namespace Op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            double poef=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Voer bedrag in?");
                poef=double.Parse(Console.ReadLine())+poef;
                Console.WriteLine($"De poef staat op {poef} euro.");
            }
            Console.WriteLine("*************************");
            Console.WriteLine($"Het totaal van de poef is {poef} en zal {Math.Ceiling(poef/10)} weken duren om volledig afbetaald te worden.");
            Console.ReadLine();
        }
    }
}
