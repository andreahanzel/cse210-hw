using System;

class MindfulnessProgram
{
    // Initialize counters for each type of activity to track how many times they've been completed.
    static int breathingActivityCount = 0;
    static int reflectingActivityCount = 0;
    static int listingActivityCount = 0;

    static void Main(string[] args)
    {
        // Continuously display the main menu and handle user input until the program is exited.
        while (true)
        {
            try
            {
                // Attempt to clear the console for a clean display of the menu options.
                Console.Clear(); 
            }
            catch (System.IO.IOException)
            {
                // Catch and handle the exception if the console cannot be cleared, such as when running without a console window.
                Console.WriteLine("Running in an environment without a console window.");
            }

            // Display the main menu including the mindfulness program title and usage statistics for each activity.
            Console.WriteLine("Mindfulness Activity Program");
            Console.WriteLine($"Breathing Activities Completed: {breathingActivityCount}");
            Console.WriteLine($"Reflecting Activities Completed: {reflectingActivityCount}");
            Console.WriteLine($"Listing Activities Completed: {listingActivityCount}");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            // Prompt the user to choose an option from the menu.
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            // Handle the user's menu selection.
            switch (choice)
            {
                case "1":
                    // Create and run a new instance of the BreathingActivity class, then increment its counter.
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivityCount++;
                    break;
                case "2":
                    // Create and run a new instance of the ReflectingActivity class, then increment its counter.
                    var reflectingActivity = new ReflectingActivity(reflectingActivityCount);
                    reflectingActivity.RunActivity();
                    reflectingActivityCount++;
                    break;
                case "3":
                    // Create and run a new instance of the ListingActivity class, then increment its counter.
                    var listingActivity = new ListingActivity(listingActivityCount);
                    listingActivity.RunActivity();
                    listingActivityCount++;
                    break;
                case "4":
                    // Exit the program after thanking the user for their participation.
                    Console.WriteLine("Thank you for participating in mindfulness activities. Goodbye!");
                    return;
                default:
                    // Handle invalid menu options by prompting the user to try again.
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
