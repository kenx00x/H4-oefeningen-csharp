using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frietjes?");
            int frietjes = int.Parse(Console.ReadLine());
            string tussenprijs = Convert.ToString(frietjes * 20)+" euro";
            Console.WriteLine($"Tussenprijs = {tussenprijs}");

            Console.WriteLine("koninginnenhapjes?");
            int koninginnenhapjes = int.Parse(Console.ReadLine());
            tussenprijs = tussenprijs + " + " + Convert.ToString(10 * koninginnenhapjes) + " euro";
            Console.WriteLine($"Tussenprijs = {tussenprijs}");

            Console.WriteLine("ijsjes?");
            int ijsjes = int.Parse(Console.ReadLine());
            tussenprijs = tussenprijs + " + " + Convert.ToString(3 * ijsjes) + " euro";
            Console.WriteLine($"Tussenprijs = {tussenprijs}");

            Console.WriteLine("Dranken?");
            int dranken = int.Parse(Console.ReadLine());
            tussenprijs = tussenprijs + " + " + Convert.ToString(2 * dranken) + " euro";
            Console.WriteLine($"Tussenprijs = {tussenprijs}");

            Console.WriteLine();
            Console.WriteLine($"Het totaal te betalen bedrag is {(frietjes*20)+(koninginnenhapjes*10)+(dranken*2)+(ijsjes*3)} EURO.");
            Console.ReadLine();
        }
    }
}
