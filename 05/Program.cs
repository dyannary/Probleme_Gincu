using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numerele: ");

            int a = Int32.Parse(Console.ReadLine()); 
            int b = Int32.Parse(Console.ReadLine());

            float c;

            if (b != 0)
            {
                c = (float)a / (float)b;
                Console.WriteLine(String.Format("{0:0.00}", c));
            }
            else
                Console.WriteLine("Impartire imposibila!");
        }
    }
}
