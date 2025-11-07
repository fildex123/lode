using System;
namespace lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pocet hracu:");
            int pocetHracu;
            while (!int.TryParse(Console.ReadLine(), out pocetHracu))
            {
                Console.WriteLine("špatnej datovej typ");
            }
            Console.WriteLine("Velikost pole:");
            int vel;
            while (!int.TryParse(Console.ReadLine(), out vel))
            {
                Console.WriteLine("špatnej datovej typ");
            }
            Console.WriteLine("Budget:");
            int budget;
            while (!int.TryParse(Console.ReadLine(), out budget))
            {
                Console.WriteLine("špatnej datovej typ");
            }
            Hrac[] hraci = new Hrac[pocetHracu];
            for(int i=0; i < pocetHracu; i++)
            {
                hraci[i] = new Hrac(vel, budget);
            }
        }
    }
}
