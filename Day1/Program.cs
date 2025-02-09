
using System.Diagnostics;
using System;

namespace Day1
{
    internal class Class1
    {
        static void Main()
        {
            //1.Take Two Integers and Get the Sum and Average 


            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double sum = num1 + num2;
            double average = sum / 2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");


        
        }

    }
}




