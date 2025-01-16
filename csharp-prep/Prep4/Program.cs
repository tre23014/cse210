using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int bNumber = -1;
        while (bNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string response = Console.ReadLine();
            bNumber = int.Parse(response);

            if (bNumber != 0)
            {
                numbers.Add(bNumber);
            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        Console.WriteLine($"The sum is: {total}");


        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}