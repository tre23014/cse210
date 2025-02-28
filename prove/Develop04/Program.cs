using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Program p = new Program();
        p.Display();
        p.Welcome();

        Console.Write("What activity would you like? ");
        string choice = Console.ReadLine();

        int chosenTime = GetUserTime(); // Ask user for time ONCE and use it for all activities

        if (choice == "1")
        {
            BreathingActivity a1 = new BreathingActivity("Welcome to the Breathing Activity!",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                chosenTime,
                "Get ready...",
                "Thanks for participating!",
                "Breathe In...",
                "Breathe Out...");

            RunActivity(a1);
            // Simulating activity duration using chosen time
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(a1.GetTime());

            Console.WriteLine($"Starting activity for {a1.GetTime()} seconds...");

            Console.WriteLine(a1.GetReady());
            Animation();

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(a1.GetBreathIn());
                int seconds = 4;
                for (int num = seconds; num > 0; num--)
                {
                    Console.Write(num + "...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine(a1.GetBreathOut());
                int secondsOut = 6;
                for (int num = secondsOut; num > 0; num--)
                {
                    Console.Write(num + "...");
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine(a1.GetExit());
        }
        else if (choice == "2")
        {
            ReflectionActivity a2 = new ReflectionActivity("Welcome to the Reflection Activity!",
                "This activity will help you reflect on times in your life when you have shown strengths and resilience.",
                chosenTime,
                "Get ready...",
                "Thanks for participating!",
                "Think of a time when you did something hard.",
                "How did you feel after completing it?",
                "What was your favorite thing about this experiance?");

            RunActivity(a2);
            // Simulating activity duration using chosen time
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(a2.GetTime());

            Console.WriteLine($"Starting activity for {a2.GetTime()} seconds...");

            Console.WriteLine(a2.GetReady());
            Animation();

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(a2.GetPrompt());
                Thread.Sleep(5000);
                Console.WriteLine(a2.GetQuestion1());
                Animation();
                Thread.Sleep(5000);
                Console.WriteLine(a2.GetQuestion2());
                Animation();
                Thread.Sleep(5000);
            }

            Console.WriteLine(a2.GetExit());
        }
        else if (choice == "3")
        {
            ListingActivity a3 = new ListingActivity("Welcome to the Listing Activity!",
                "This activity will help you reflect on the good in your life by having you list as many things as you can in a certain area.",
                chosenTime,
                "Get ready...",
                "Thanks for participating!",
                "List as many responses you can to the following prompt:",
                " --- When have you felt the Holy Ghost this month? ---");

            RunActivity(a3);
            // Simulating activity duration using chosen time
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(a3.GetTime());

            Console.WriteLine($"Starting activity for {a3.GetTime()} seconds...");

            Console.WriteLine(a3.GetReady());
            Animation();
            List<string> responses = new List<string>();
            Console.WriteLine(a3.GetPrompt());
            Console.WriteLine(a3.GetList());
            Animation();
            Thread.Sleep(5000);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                responses.Add(response);
            }
            Console.WriteLine($"\nYou listed {responses.Count} items.");
            Console.WriteLine(a3.GetExit());
        }
        else if (choice == "4")
        {
            Console.WriteLine("Goodbye!");
        }
    }

    public void Welcome()
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.WriteLine($"Welcome {firstname}!");
    }

    public void Display()
    {
        Console.WriteLine("1: Breathing Activity");
        Console.WriteLine("2: Reflecting Activity");
        Console.WriteLine("3: Listing Activity");
        Console.WriteLine("4: Quit");
    }

    // Get the time from the user
    public static int GetUserTime()
    {
        Console.Write("How long (in seconds) would you like to do this activity? ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int chosenTime) && chosenTime > 0)
            {
                return chosenTime;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }

    // General method to run any activity
    public static void RunActivity(Activity activity)
    {
        Console.WriteLine(activity.GetIntro());
        Thread.Sleep(1000);
        Console.WriteLine(activity.GetInstructions());
        Thread.Sleep(1000);
    }
    public static void Animation()
    {
        Console.Write("+");

        Thread.Sleep(5000);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
    }
}
