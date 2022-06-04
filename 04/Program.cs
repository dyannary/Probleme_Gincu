using System;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int[] note = new int[5];
            int i;

            Console.WriteLine("Ionel, ce note ai defapt?");
            
            for(i = 0; i < 5; i++)
            {
                note[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nCe note le-ai zis parintilor ca ai? ");

            for( i = 0; i < 5; i++)
            {
                if (note[i] > 6)
                {
                    Console.WriteLine(" ");
                    Console.Write(note[i]);
                }
            }
            Console.Write("\n");
        }
    }
}
