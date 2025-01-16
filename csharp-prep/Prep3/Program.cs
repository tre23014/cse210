using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int number = -1;

        while (number != magic)
        {

            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());



            if (number < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (number > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}