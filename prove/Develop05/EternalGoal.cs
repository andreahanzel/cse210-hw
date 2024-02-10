using System;

public class EternalGoal : Goal
{
    public int CompletionCount { get; set; } // Made public for accessibility

    public EternalGoal()
    {
        // Default constructor logic if needed
    }

    public override Goal CreateGoal()
    {
        Console.Write("Enter the name of the Eternal Goal: ");
        Name = Console.ReadLine();

        Console.Write("Enter a description for the Eternal Goal: ");
        Description = Console.ReadLine();

        Console.Write("Enter the point value for each time the Eternal Goal is recorded: ");
        Points = int.TryParse(Console.ReadLine(), out int val) ? val : 0; // Default to 0 if parse fails

        CompletionCount = 0; // Initialize completion count to 0
        return this;
    }

    public override bool CheckCompletion()
    {
        // Eternal goals do not have a completion state; they can be recorded multiple times
        return false;
    }

    public override void RecordEvent()
    {
        CompletionCount++;
        Console.WriteLine($"{Name} has been recorded {CompletionCount} times.");
    }

    public override int AwardPoints()
    {
        // Points are awarded each time the goal is recorded
        return Points * CompletionCount;
    }

    public override string GetStatus()
    {
        return $"[ ] {Name} - {Description} (Recorded {CompletionCount} times)";
    }

    public override string Serialize()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}|{CompletionCount}";
    }
}
