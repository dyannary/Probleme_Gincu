using System;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti greutatea copiilor: ");
            int copil1 = Int32.Parse(Console.ReadLine());
            int copil2 = Int32.Parse(Console.ReadLine());

            if ((copil1 + copil2) > 100)
            {
                Console.WriteLine("INTRA PE RAND!");
            }
            else
                Console.WriteLine("POT INTRA IMPREUNA");
        }
    }
}
