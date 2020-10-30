using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een hoek in graden: ");
            double hoek = double.Parse(Console.ReadLine());
            double radialen = hoek * Math.PI / 180;
            Console.WriteLine($"Hoek in radialen: {radialen}");
            Console.WriteLine($"Sinus: {Math.Sin(radialen)}");
            Console.WriteLine($"Cosinus: {Math.Cos(radialen)}");
            Console.WriteLine($"Tangens: {Math.Tan(radialen)}");
            Console.ReadLine();
        }
    }
}
