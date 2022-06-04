using System;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ore = new int[7];
            int sum = 0;

            Console.WriteLine("Introduceti cate ore Ionel a privit in fiecare zi a saptamanii: ");

            for(int i = 0; i < 7; i++)
            {
                ore[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0 ; i < 7 ;i++)
            {
                sum = ore[i]++;
            }
            if (sum > 20)
            {
                Console.WriteLine("Ionel va fi pedepsit");
            }
            else
                Console.WriteLine("Tot normal, Ionel.");
        }
    }
}
