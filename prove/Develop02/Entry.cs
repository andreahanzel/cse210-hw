// Define the namespace for the application
namespace MyJournalApp
{
    // Define the Entry class
    public class Entry
    {
        // Private fields for the Entry's prompt, response, and date
        private string _prompt;
        private string _response;
        private string _date;

        // Constructor for the Entry class
        public Entry(string prompt, string response, string date)
        {
            // Initialize the Entry with a prompt, response, and date
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        // Override the ToString method to define how an Entry is represented as a string
        public override string ToString()
        {
            // Format the Entry information for display
            return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
        }

        // Method to represent the Entry in a format suitable for file storage
        public string ToFileString()
        {
            // Concatenate the Entry fields with '|' as a delimiter
            return $"{_prompt}|{_response}|{_date}";
        }
    }
}
