using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numerele:");
            int n1=Int32.Parse(Console.ReadLine());
            int n2=Int32.Parse(Console.ReadLine());

            if ((n1 == n2 - 1) || (n1 == n2 + 1))
            {
                Console.WriteLine("Da");
            }
            else
                Console.WriteLine("NU");
        }
    }
}
