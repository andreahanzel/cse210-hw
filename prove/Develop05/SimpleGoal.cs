using System;

public class SimpleGoal : Goal
{
    public bool IsComplete { get; set; } // Made public for accessibility

    public SimpleGoal()
    {
        // Default constructor logic if needed
    }

    public override Goal CreateGoal()
    {
        Console.Write("Enter the name of the Simple Goal: ");
        Name = Console.ReadLine();

        Console.Write("Enter a description for the Simple Goal: ");
        Description = Console.ReadLine();

        Console.Write("Enter the point value for completing the Simple Goal: ");
        Points = int.TryParse(Console.ReadLine(), out int val) ? val : 0; // Default to 0 if parse fails

        IsComplete = false;
        return this;
    }

    public override bool CheckCompletion()
    {
        return IsComplete;
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"{Name} has been marked as complete.");
        }
        else
        {
            Console.WriteLine($"{Name} is already completed.");
        }
    }

    public override int AwardPoints()
    {
        return IsComplete ? Points : 0;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} - {Description}";
    }

    public override string Serialize()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{IsComplete}";
    }
}
