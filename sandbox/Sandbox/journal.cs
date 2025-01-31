using System;
using System.Collections.Generic;
using System.IO;

namespace JournalEntryApp
{
    class Program
    {
        public void Main(string[] args)
        {
            JournalApp journalApp = new JournalApp(); // Create an instance of JournalApp

            while (true)  // Keep running until the user chooses to exit
            {
                journalApp.DisplayMenu();

                Console.Write("What is your choice? ");
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out int input)) // Validating input
                {
                    switch (input)
                    {
                        case 1:
                            journalApp.WriteNewEntry();
                            break;
                        case 2:
                            journalApp.DisplayJournal();
                            break;
                        case 3:
                            journalApp.SaveJournalToFile();
                            break;
                        case 4:
                            journalApp.LoadJournalFromFile();
                            break;
                        case 5:
                            Console.Write("Would you like to save first? (yes/no) ");
                            string save = Console.ReadLine().ToLower();

                            if (save == "yes")
                            {
                                journalApp.SaveJournalToFile();
                            }

                            Console.WriteLine("Exiting program...");
                            return; // Exit the program
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1-5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
    }

    class JournalApp
    {
        private List<JournalEntry> journal = new List<JournalEntry>(); // Moved inside JournalApp

        public void DisplayMenu()
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
        }

        public void WriteNewEntry()
        {
            string[] prompts = new string[]
            {
                "What made you smile today?",
                "Describe a challenge you overcame recently.",
                "Write about a person who inspires you.",
                "What are you grateful for?",
                "Describe your perfect day."
            };

            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Length)];

            Console.WriteLine("\nPrompt: " + prompt);
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            journal.Add(new JournalEntry { Prompt = prompt, Response = response, Date = date });
        }

        public void DisplayJournal()
        {
            if (journal.Count == 0)
            {
                Console.WriteLine("No journal entries found.");
                return;
            }

            foreach (var entry in journal)
            {
                Console.WriteLine($"\nDate: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine(new string('-', 40));
            }
        }

        public void SaveJournalToFile()
        {
            Console.Write("Enter filename to save the journal: ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var entry in journal)
                    {
                        sw.WriteLine(entry.Date);
                        sw.WriteLine(entry.Prompt);
                        sw.WriteLine(entry.Response);
                        sw.WriteLine(new string('-', 40));
                    }
                }
                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving the journal: " + e.Message);
            }
        }

        public void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load the journal: ");
            string filename = Console.ReadLine();

            try
            {
                if (File.Exists(filename))
                {
                    journal.Clear();
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        while (!sr.EndOfStream)
                        {
                            string date = sr.ReadLine();
                            string prompt = sr.ReadLine();
                            string response = sr.ReadLine();
                            sr.ReadLine(); // Read the separator

                            journal.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
                        }
                    }
                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading the journal: " + e.Message);
            }
        }
    }

    class JournalEntry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }
    }
}
