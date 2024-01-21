// Define the namespace for the application
namespace MyJournalApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    // Define the Journal class
    public class Journal
    {
        // Private field to store journal entries
        private List<Entry> _entries;

        // Constructor for the Journal class
        public Journal()
        {
            // Initialize the list of entries when a new Journal is created
            _entries = new List<Entry>();
        }

        // Method to add a new entry to the journal
        public void AddEntry(string prompt, string response)
        {
            // Add a new Entry object to the list with the current date
            _entries.Add(new Entry(prompt, response, DateTime.Now.ToShortDateString()));
        }

        // Method to display all entries in the journal
        public void DisplayEntries()
        {
            // Iterate through each entry in the journal
            foreach (var entry in _entries)
            {
                // Print each entry to the console
                Console.WriteLine(entry);
            }
        }

        // Method to save the journal entries to a file
        public void SaveToFile(string fileName)
        {
            // Create a StreamWriter to write to the specified file
            using (StreamWriter file = new StreamWriter(fileName))
            {
                // Iterate through each entry in the journal
                foreach (var entry in _entries)
                {
                    // Write each entry's data to the file in a specific format
                    file.WriteLine(entry.ToFileString());
                }
            }
        }

        // Method to load journal entries from a file
        public void LoadFromFile(string fileName)
        {
            // Clear current entries in the journal
            _entries.Clear();

            // Read all lines from the specified file
            string[] lines = File.ReadAllLines(fileName);

            // Iterate through each line in the file
            foreach (string line in lines)
            {
                // Split the line into parts based on the '|' delimiter
                var parts = line.Split('|');

                // Check if the line is correctly formatted with 3 parts
                if (parts.Length == 3)
                {
                    // Add a new Entry object to the journal using the parts
                    _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }
    }
}
