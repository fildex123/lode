using System;
namespace lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vel;
            while(!int.TryParse(Console.ReadLine(), out vel))
            {
                Console.WriteLine("špatnej datovej typ");
            }
        }
    }
}
