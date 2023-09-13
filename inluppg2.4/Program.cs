using System;

namespace inluppg2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön nummer 1:");
            int lon1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön nummer 2:");
            int lon2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön nummer 3:");
            int lon3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Medellönen är {(lon1 + lon2 + lon3) / 3}");
        }
    }
}