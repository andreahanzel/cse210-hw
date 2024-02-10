using System;

public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; } // Made public for accessibility
    public int CurrentCompletions { get; set; } // Made public for accessibility
    public int BonusPoints { get; set; } // Made public for accessibility

    public ChecklistGoal()
    {
        // Default constructor logic if needed
    }

    public override Goal CreateGoal()
    {
        Console.Write("Enter the name of the Checklist Goal: ");
        Name = Console.ReadLine();

        Console.Write("Enter a description for the Checklist Goal: ");
        Description = Console.ReadLine();

        Console.Write("Enter the point value for each completion of the Checklist Goal: ");
        Points = int.TryParse(Console.ReadLine(), out int val) ? val : 0;

        Console.Write("Enter the number of completions required to achieve the goal: ");
        RequiredCompletions = int.TryParse(Console.ReadLine(), out int required) ? required : 0;

        Console.Write("Enter the bonus points awarded upon full completion of the goal: ");
        BonusPoints = int.TryParse(Console.ReadLine(), out int bonus) ? bonus : 0;

        CurrentCompletions = 0;
        return this;
    }

    public override bool CheckCompletion()
    {
        return CurrentCompletions >= RequiredCompletions;
    }

    public override void RecordEvent()
    {
        if (CurrentCompletions < RequiredCompletions)
        {
            CurrentCompletions++;
            Console.WriteLine($"{Name} progress: {CurrentCompletions}/{RequiredCompletions}.");
            if (CheckCompletion())
            {
                Console.WriteLine($"Congratulations! You've earned a bonus of {BonusPoints} points for completing this goal.");
            }
        }
        else
        {
            Console.WriteLine("This goal has already been completed the required number of times.");
        }
    }

    public override int AwardPoints()
    {
        int totalPoints = CurrentCompletions * Points;
        if (CheckCompletion())
        {
            totalPoints += BonusPoints;
        }
        return totalPoints;
    }

    public override string GetStatus()
    {
        return $"[{(CheckCompletion() ? "X" : " ")}] {Name} - {Description}. Progress: {CurrentCompletions}/{RequiredCompletions}.";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{RequiredCompletions}|{CurrentCompletions}|{BonusPoints}";
    }
}
