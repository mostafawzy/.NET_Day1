
using System.Diagnostics;
using System;

namespace Day1
{
    internal class Class1
    {
        static void Main()
        {
            //2.Take Two Integers and Get the Max


            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max number is: " + Math.Max(a, b));
        }

    }
}




