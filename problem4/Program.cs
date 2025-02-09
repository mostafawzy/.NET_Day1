
using System.Diagnostics;
using System;

namespace Day1
{
    internal class Class1
    {
        static void Main()
        {

            //4.Simple Calculator 


            Console.WriteLine("  Simple Calculator  ");
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter your choice (1-4): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Result: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Result: " + (a * b));
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine("Result: " + ((double)a / b));
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }

    }
}




