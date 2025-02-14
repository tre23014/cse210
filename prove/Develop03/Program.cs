using System;
using System.Xml.Serialization;

class Program
{
    private bool isFinished = false;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        // Create scripture with verses
        Scripture scripture = new Scripture();
        scripture.AddVerse(new Verse("Proverbs 3:5", "Trust in the Lord with all thine heart and lean not unto thine own understanding;"));
        scripture.AddVerse(new Verse("Proverbs 3:6", "In all thy ways acknowledge Him, and He shall direct thy paths."));

        while (!isFinished)
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue, type 'hide' to hide words, or 'quit' to exit:");
            string choice = Console.ReadLine()?.ToLower();

            if (choice == "quit")
            {
                isFinished = true;
                break;
            }
            else if (choice == "hide")
            {
                scripture.HideWords();
            }
        }
    }
}