using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // Class-level variable to store goals
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        bool programDone = false;

        while (!programDone)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    DisplayGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    programDone = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1-5.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.Write("\nWhich type of goal would you like to create? (1 = Simple, 2 = Eternal, 3 = Checklist) ");
        string goalChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string goalDescription = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalChoice == "1")
        {
            goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalChoice == "2")
        {
            goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (goalChoice == "3")
        {
            Console.Write("Enter target count to complete goal: ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points upon completion: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints));
        }
    }

    static void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
        }
    }
}