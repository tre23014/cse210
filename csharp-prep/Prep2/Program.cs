using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        
        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is : {letter}");


        if (grade >= 70)
        {
            Console.WriteLine("You have passed the class.");
            Console.WriteLine("Congrulations on passing!");
        }
        else 
        {
            Console.WriteLine("You did not pass the class.");
            Console.WriteLine("I hope you learned a lot. Please try again and pass next time!");
        }

    }

}