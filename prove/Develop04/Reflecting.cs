using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : BaseActivity
{
    private List<string> _reflectionPrompts;
    private static HashSet<int> usedPromptsIndices = new HashSet<int>();

    public ReflectingActivity(int sessionCount) : base()
    {
        _activityName = "Reflecting Activity";
        _activityDescription = "Reflect on your personal experiences of strength and resilience.";
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        _reflectionPrompts = new List<string>
        {
            "Recall a moment you felt extremely proud of yourself.",
            "Think about a time you overcame a significant challenge.",
            // Add more prompts as needed
        };

        // Reset if all prompts have been used
        if (usedPromptsIndices.Count >= _reflectionPrompts.Count)
        {
            usedPromptsIndices.Clear();
        }
    }

    public override void RunActivity()
    {
        base.DisplayActivityIntro();
        base.QueryDuration();
        
        // Select a unique prompt
        int index;
        do
        {
            index = new Random().Next(_reflectionPrompts.Count);
        } while (usedPromptsIndices.Contains(index));

        usedPromptsIndices.Add(index);
        Console.WriteLine("Reflect on the following prompt:");
        Console.WriteLine(_reflectionPrompts[index]);

        // Simulate reflection time
        base.ShowCountdown(_activityDuration);
        
        base.DisplayCompletionMessage();
    }
}
