using System;

class Program
{
    static void Main()
    {
//..................................     1     ................................

        //Console.Write("Enter the number of integers: ");
        //int count = Convert.ToInt32(Console.ReadLine());

        //int[] numbers = new int[count];
        //int sum = 0, max, min;

        //Console.WriteLine("Enter the integers:");
        //for (int i = 0; i < count; i++)
        //{
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //    sum += numbers[i];
        //}

        //max = min = numbers[0];

        //for (int i = 1; i < count; i++)
        //{
        //    if (numbers[i] > max) max = numbers[i];
        //    if (numbers[i] < min) min = numbers[i];
        //}

        //double average = (double)sum / count;

        //Console.WriteLine($"Sum: {sum}");
        //Console.WriteLine($"Average: {average}");
        //Console.WriteLine($"Max: {max}");
        //Console.WriteLine($"Min: {min}");


        //..................................    2     ................................

        Console.Write("Enter an equation : ");
        string equation = Console.ReadLine();

        int result = 0;

        if (equation.Contains("+"))
        {
            string[] parts = equation.Split('+');
            result = int.Parse(parts[0]) + int.Parse(parts[1]);
        }
        else if (equation.Contains("-"))
        {
            string[] parts = equation.Split('-');
            result = int.Parse(parts[0]) - int.Parse(parts[1]);
        }
        else if (equation.Contains("*"))
        {
            string[] parts = equation.Split('*');
            result = int.Parse(parts[0]) * int.Parse(parts[1]);
        }
        else if (equation.Contains("/"))
        {
            string[] parts = equation.Split('/');
            result = int.Parse(parts[0]) / int.Parse(parts[1]);
        }

        Console.WriteLine($"Result: {result}");
    }
}