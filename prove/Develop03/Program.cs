using System;

namespace MemorizationHelper
{
    class Program
    {
        static void Main()
        {
            // Create a new Scripture object 
            Scripture passage = new Scripture("Luke", 12, 27, "Consider the lilies, how they grow: they neither toil nor spin, yet I tell you, even Solomon in all his glory was not arrayed like one of these.");
            
            // Clear the console screen.
            TryClearConsole();

            // Display the scripture verse initially.
            passage.PresentScripture();
            Console.WriteLine("\nEnter to advance, or type 'exit' to leave.");

            // Start a loop for user interaction.
            while (true)
            {
                // Read user input.
                string userInput = Console.ReadLine();
                // Check if user wants to exit the program.
                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nSession ended.");
                    break;
                }

                // Hide a word in the verse for memorization practice.
                // If no more words to hide, congratulate the user.
                if (!passage.MaskWord())
                {
                    Console.WriteLine("\nWell done! You've memorized the verse entirely!");
                    break;
                }

                // Clear the console and present the modified scripture for further memorization.
                TryClearConsole();
                passage.PresentScripture();
                Console.WriteLine("\nEnter to proceed, or type 'exit' to quit.");
            }
        }

        // Clear the console window.
        private static void TryClearConsole()
        {
            try
            {
                // Clear the console.
                Console.Clear();
            }
            catch (System.IO.IOException)
            {
                // Exception caught but not handled, which means any error during clear operation is ignored.
            }
        }
    }
}
