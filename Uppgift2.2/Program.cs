using System;
namespace Uppgift2.__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            double Elin =double. Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter");
            double Alma =double.Parse(Console.ReadLine());
            double dif= Elin - Alma;
            Console.WriteLine("Elin hoppade " + dif + "meter högre än Alma");
        }
    }
}
