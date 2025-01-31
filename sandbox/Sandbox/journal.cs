using System;
using System.Collections.Generic;
using System.IO;

namespace JournalEntryApp
{
    // The main program that serves as the entry point of the application.
    class Program
    {
        // The entry point of the application (it should be static for execution).
        public static void Main(string[] args)
        {
            JournalApp journalApp = new JournalApp(); // Create an instance of JournalApp

            while (true)  // Keep running until the user chooses to exit
            {
                journalApp.DisplayMenu(); // Show menu options to the user

                Console.Write("What is your choice? ");
                string choice = Console.ReadLine();

                // Validate user input
                if (int.TryParse(choice, out int input))
                {
                    // Handle user choices based on input
                    switch (input)
                    {
                        case 1:
                            journalApp.WriteNewEntry(); // Create a new journal entry
                            break;
                        case 2:
                            journalApp.DisplayJournal(); // Display all journal entries
                            break;
                        case 3:
                            journalApp.SaveJournalToFile(); // Save journal entries to a file
                            break;
                        case 4:
                            journalApp.LoadJournalFromFile(); // Load journal entries from a file
                            break;
                        case 5:
                            Console.Write("Would you like to save first? (yes/no) ");
                            string save = Console.ReadLine().ToLower();

                            if (save == "yes")
                            {
                                journalApp.SaveJournalToFile(); // Save journal before exiting
                            }

                            Console.WriteLine("Exiting program...");
                            return; // Exit the application
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

    // The class that manages journal entries
    class JournalApp
    {
        // List to store journal entries
        private List<JournalEntry> journal = new List<JournalEntry>();

        // Displays the main menu options
        public void DisplayMenu()
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
        }

        // Handles writing a new journal entry
        public void WriteNewEntry()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // Array of predefined journal prompts
            string[] prompts = new string[]
            {
                "What made you smile today?",
                "Describe a challenge you overcame recently.",
                "Write about a person who inspires you.",
                "What are you grateful for?",
                "Describe your perfect day."
            };

            // Selects a random prompt from the list
            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Length)];

            Console.WriteLine($"Prompt: " + prompt);
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            string date = DateTime.Now.ToString("yyyy-MM-dd"); // Get the current date

            Console.WriteLine($"Signed: {name}"); // Display name at the end

            // Add new journal entry to the list
            journal.Add(new JournalEntry { Prompt = prompt, Response = response, Date = date, Name = name });
        }

        // Displays all journal entries
        public void DisplayJournal()
        {
            if (journal.Count == 0) // Check if journal is empty
            {
                Console.WriteLine("No journal entries found.");
                return;
            }

            // Loop through and display each journal entry
            foreach (var entry in journal)
            {
                Console.WriteLine($"\nDate: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine(new string('-', 40)); // Separator for readability
            }
        }

        // Saves journal entries to a text file
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
                        sw.WriteLine(entry.Date); // Write date to file
                        sw.WriteLine(entry.Prompt); // Write prompt to file
                        sw.WriteLine(entry.Response); // Write response to file
                        sw.WriteLine(new string('-', 40)); // Separator line
                    }
                }
                Console.WriteLine("Journal saved successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving the journal: " + e.Message); // Handle errors
            }
        }

        // Loads journal entries from a text file
        public void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load the journal: ");
            string filename = Console.ReadLine();

            try
            {
                if (File.Exists(filename)) // Check if file exists
                {
                    journal.Clear(); // Clear current journal before loading new data
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        while (!sr.EndOfStream)
                        {
                            string date = sr.ReadLine(); // Read date
                            string prompt = sr.ReadLine(); // Read prompt
                            string response = sr.ReadLine(); // Read response
                            sr.ReadLine(); // Read separator

                            // Add the entry to the journal list
                            journal.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
                        }
                    }
                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found."); // Error if file is missing
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading the journal: " + e.Message); // Handle errors
            }
        }
    }

    // The class that represents a single journal entry
    class JournalEntry
    {
        public string Date { get; set; } // Stores the date of the entry
        public string Prompt { get; set; } // Stores the journal prompt
        public string Response { get; set; } // Stores the user's response
        public string Name { get; set; } // Stores the name of the user
    }
}
