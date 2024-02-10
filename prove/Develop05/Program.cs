using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the goal tracker
        GoalTracker tracker = new GoalTracker();
        // Control variable for the main loop
        bool exit = false;

        // Main loop for the program menu
        while (!exit)
        {
            // Display current points and menu options
            Console.WriteLine($"You have {tracker.GetTotalPoints()} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read user input for menu selection
            string menuSelected = Console.ReadLine();

            // Handle user input with a switch statement
            switch (menuSelected)
            {
                case "1":
                    // Create a new goal
                    CreateNewGoal(tracker);
                    break;

                case "2":
                    // List all current goals
                    tracker.ListGoals();
                    break;

                case "3":
                    // Save current goals to a file
                    SaveGoals(tracker);
                    break;

                case "4":
                    // Load goals from a file
                    LoadGoals(tracker);
                    break;

                case "5":
                    // Record the completion of a goal
                    RecordGoalEvent(tracker);
                    break;

                case "6":
                    // Exit the program
                    Console.WriteLine("Exiting program.");
                    exit = true;
                    break;

                default:
                    // Handle invalid input
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Method for creating a new goal based on user input
    private static void CreateNewGoal(GoalTracker tracker)
    {
        // Display goal types
        Console.WriteLine("The Types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        // Read goal type selection
        string goalType = Console.ReadLine();

        // Handle goal type selection
        switch (goalType)
        {
            case "1":
                // Add a new SimpleGoal
                tracker.AddGoal(new SimpleGoal().CreateGoal());
                break;

            case "2":
                // Add a new EternalGoal
                tracker.AddGoal(new EternalGoal().CreateGoal());
                break;

            case "3":
                // Add a new ChecklistGoal
                tracker.AddGoal(new ChecklistGoal().CreateGoal());
                break;

            default:
                // Handle invalid goal type input
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    // Method for saving goals to a file
    private static void SaveGoals(GoalTracker tracker)
    {
        Console.Write("Enter filename to save goals: ");
        // Read filename
        string saveFilename = Console.ReadLine();
        // Save goals to the specified file
        tracker.SaveGoals(saveFilename);
        Console.WriteLine("Goals saved successfully.");
    }

    // Method for loading goals from a file
    private static void LoadGoals(GoalTracker tracker)
    {
        Console.Write("Enter filename to load goals: ");
        // Read filename
        string loadFilename = Console.ReadLine();
        // Load goals from the specified file
        tracker.LoadGoals(loadFilename);
        Console.WriteLine("Goals loaded successfully.");
    }

    // Method for recording the completion of a goal
    private static void RecordGoalEvent(GoalTracker tracker)
    {
        Console.Write("Enter the number of the goal to record completion: ");
        // Attempt to parse the input as an integer
        if (int.TryParse(Console.ReadLine(), out int goalNumber))
        {
            // Record completion for the specified goal
            tracker.RecordGoalCompletion(goalNumber);
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
