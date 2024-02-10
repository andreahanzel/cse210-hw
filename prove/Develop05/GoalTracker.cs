using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalTracker
{
    private List<Goal> goals = new List<Goal>();

    public GoalTracker() { }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ListGoals()
    {
        if (goals.Any())
        {
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
            }
        }
        else
        {
            Console.WriteLine("No goals currently tracked.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        goals.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            Goal goal = null;

            switch (parts[0])
            {
                case "SimpleGoal":
                    goal = new SimpleGoal()
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3]),
                        IsComplete = bool.Parse(parts[4])
                    };
                    break;
                case "EternalGoal":
                    goal = new EternalGoal()
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3]),
                        CompletionCount = int.Parse(parts[4])
                    };
                    break;
                case "ChecklistGoal":
                    goal = new ChecklistGoal()
                    {
                        Name = parts[1],
                        Description = parts[2],
                        Points = int.Parse(parts[3]),
                        RequiredCompletions = int.Parse(parts[4]),
                        CurrentCompletions = int.Parse(parts[5]),
                        BonusPoints = int.Parse(parts[6])
                    };
                    break;
            }

            if (goal != null)
            {
                goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordGoalCompletion(int goalNumber)
    {
        if (goalNumber <= 0 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        var goal = goals[goalNumber - 1];
        goal.RecordEvent();
        Console.WriteLine($"Points awarded: {goal.AwardPoints()}. Total points: {GetTotalPoints()}.");
    }

    public int GetTotalPoints()
    {
        return goals.Sum(goal => goal.AwardPoints());
    }
}
