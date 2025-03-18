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
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

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
                    RecordEvent();
                    break;
                case "6":
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
            return;
        }

        foreach (var goal in goals)
        {
            string status = goal.isComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal.GetName()} - {goal.GetDescription()} - {goal.GetPoints()} points");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Completed {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTargetCount()} times");
            }
        }
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        Console.Write("\nEnter the number of the goal you completed: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            if (goals[choice] is ChecklistGoal checklistGoal)
            {
                checklistGoal.RecordProgress();
            }
            else if (goals[choice] is SimpleGoal simpleGoal)
            {
                simpleGoal.MarkComplete();
            }

            Console.WriteLine($"Progress recorded for {goals[choice].GetName()}!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    static void SaveGoals()
{
    Console.Write("Enter filename to save: ");
    string filename = Console.ReadLine();

    using (StreamWriter sw = new StreamWriter(filename))
    {
        sw.WriteLine(totalPoints);
        foreach (var goal in goals)
        {
            if (goal is SimpleGoal)
                sw.WriteLine($"Simple|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.isComplete()}");
            else if (goal is EternalGoal)
                sw.WriteLine($"Eternal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
            else if (goal is ChecklistGoal checklistGoal)
                sw.WriteLine($"Checklist|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{checklistGoal.GetTargetCount()}|{checklistGoal.GetTimesCompleted()}|{checklistGoal.GetPoints()}");
        }
    }
    Console.WriteLine("Goals saved successfully.");
}

static void LoadGoals()
{
    Console.Write("Enter filename to load: ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    goals.Clear();
    using (StreamReader sr = new StreamReader(filename))
    {
        totalPoints = int.Parse(sr.ReadLine()); // Load total points

        string line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] parts = line.Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete) goal.MarkComplete();
                goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "Checklist")
            {
                int targetCount = int.Parse(parts[4]);
                int timesCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonus);
                for (int i = 0; i < timesCompleted; i++) goal.RecordProgress();
                goals.Add(goal);
            }
        }
    }
    Console.WriteLine("Goals loaded successfully.");
}



}