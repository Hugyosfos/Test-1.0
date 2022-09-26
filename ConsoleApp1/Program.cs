using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.szám:");
            var elso = int.Parse(Console.ReadLine());
            Console.Write("2.szám:");
            var maso = int.Parse(Console.ReadLine());

            Console.WriteLine($"A {Math.Max(elso, maso)} a nagyobb.");

            Console.ReadKey();
           
        }
    }
}
