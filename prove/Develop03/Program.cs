using System;

namespace MemorizationHelper
{
    class Program
    {
        static void Main()
        {
            // Initialize a new scripture object with book, chapter, verse and the scripture text.
            Scripture passage = new Scripture("Luke", 12, 27, 
                "Consider the lilies, how they grow: they neither toil nor spin, yet I tell you, " +
                "even Solomon in all his glory was not arrayed like one of these.");

            // Clear the console for a clean display.
            TryClearConsole();

            // Display the scripture initially.
            passage.PresentScripture();
            Console.WriteLine("\nEnter to advance, or type 'exit' to leave.");

            // Loop for user interaction.
            while (true)
            {
                string userInput = Console.ReadLine();
                // Check if user wants to exit the program.
                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nSession ended.");
                    break;
                }

                // Hide a random word in the scripture.
                // If no more words to hide, end the session.
                if (!passage.MaskWord())
                {
                    Console.WriteLine("\nWell done! You've memorized the verse entirely!");
                    break;
                }

                // Clear the console and display the scripture again.
                TryClearConsole();
                passage.PresentScripture();
                Console.WriteLine("\nEnter to proceed, or type 'exit' to quit.");
            }
        }

        // Method to clear the console with exception handling.
        private static void TryClearConsole()
        {
            try
            {
                // Attempt to clear the console.
                Console.Clear();
            }
            catch (System.IO.IOException)
            {
                // If there's an IO error, it is ignored to avoid crashing the program.
            }
        }
    }
}
