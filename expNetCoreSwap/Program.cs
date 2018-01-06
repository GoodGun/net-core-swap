using System;
using System.ComponentModel.DataAnnotations;

namespace expNetCoreSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number to swap with another:");
            var x = int.Parse(Console.ReadLine());

            Console.Write("\nEnter second number to swap with another:");
            var y = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nFirst Number:{x} Second Number:{y}");

            Console.WriteLine("\nPress any key to swap numbers...");
            Console.ReadKey();

            var temp = x;
            x = y;
            y = temp;

            Console.WriteLine($"\nFirst Number:{x} Second Number:{y}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
