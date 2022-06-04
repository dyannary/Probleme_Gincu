using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numerele: ");

            int n1= Int32.Parse(Console.ReadLine());
            int n2= Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                n1 = n1 * 2;
                n2 = n2 * 3;
                Console.WriteLine($"n1>n2: {n1} ; {n2}");
            }
            else
            {
                n1 = n1 * 3;
                n2 = n2 * 2;
                Console.WriteLine($"n1<n2:  {n1} ; {n2}");
            }
        }
    }
}
