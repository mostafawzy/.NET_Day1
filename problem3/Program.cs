
using System.Diagnostics;
using System;

namespace Day1
{
    internal class Class1
    {
        static void Main()
        {
            //3. Menu for Sum, Max, or Min

            Console.WriteLine("Menu:");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Max");
            Console.WriteLine("3. Min");
            Console.Write("Enter your choice (1-3): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Max: " + Math.Max(a, b));
                    break;
                case 3:
                    Console.WriteLine("Min: " + Math.Min(a, b));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }

    }
}




