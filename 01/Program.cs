using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti punctajul studentilor: ");

            int student1 = Int32.Parse(Console.ReadLine()); ;
            int student2 = Int32.Parse(Console.ReadLine()); ;


            if (student1 < student2)
            {
                Console.WriteLine($"Student: {student2} \nStudent: {student1}");
            }
            else
            {
                Console.WriteLine(student1);
                Console.WriteLine(student2);
            }
        }
    }
}