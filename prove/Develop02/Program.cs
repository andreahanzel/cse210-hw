using System;
using System.Collections.Generic;

// Define the namespace for the application
namespace MyJournalApp
{
    // Define the main Program class
    class Program
    {
        // Entry point of the application
        static void Main()
        {
            // Create a new journal instance
            Journal journal = new Journal();

            // Initialize a list of prompts for journal entries
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            // Flag to control the main loop
            bool running = true;

            // Main loop for the application
            while (running)
            {
                // Display options to the user
                Console.WriteLine("1. Write new entry\n2. Display journal\n3. Save journal\n4. Load journal\n5. Exit");

                // Read user's choice
                string choice = Console.ReadLine();

                // Handle user's choice using a switch statement
                switch (choice)
                {
                    case "1":
                        // Write a new journal entry
                        WriteNewEntry(journal, prompts);
                        break;
                    case "2":
                        // Display all journal entries
                        journal.DisplayEntries();
                        break;
                    case "3":
                        // Save the journal to a file
                        SaveJournal(journal);
                        break;
                    case "4":
                        // Load a journal from a file
                        LoadJournal(journal);
                        break;
                    case "5":
                        // Exit the application
                        running = false;
                        break;
                    default:
                        // Handle invalid input
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Method to write a new journal entry
        private static void WriteNewEntry(Journal journal, List<string> prompts)
        {
            // Initialize a random number generator
            Random rnd = new Random();

            // Select a random prompt from the list
            string prompt = prompts[rnd.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");

            // Read the user's response to the prompt
            string response = Console.ReadLine();

            // Add the response as a new entry in the journal
            journal.AddEntry(prompt, response);
        }

        // Method to save the journal to a file
        private static void SaveJournal(Journal journal)
        {
            // Ask the user for a filename
            Console.WriteLine("Enter filename to save:");
            string fileName = Console.ReadLine();

            // Save the journal to the specified file
            journal.SaveToFile(fileName);
            Console.WriteLine("Journal saved.");
        }

        // Method to load a journal from a file
        private static void LoadJournal(Journal journal)
        {
            // Ask the user for a filename
            Console.WriteLine("Enter filename to load:");
            string fileName = Console.ReadLine();

            // Load the journal from the specified file
            journal.LoadFromFile(fileName);
            Console.WriteLine("Journal loaded.");
        }
    }
}
