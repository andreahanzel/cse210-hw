using System;
using System.Collections.Generic;
using System.Linq;

public class ListingActivity : BaseActivity
{
    private List<string> _listingPrompts;
    private static HashSet<int> usedPromptsIndices = new HashSet<int>();

    public ListingActivity(int sessionCount) : base()
    {
        _activityName = "Listing Activity";
        _activityDescription = "List down positive aspects in a specific area of your life.";
        InitializePrompts();
    }

    private void InitializePrompts()
    {
        _listingPrompts = new List<string>
        {
            "List your recent achievements:",
            "What makes you feel grateful today?",
            "Who has been kind to you this week?",
            // Add more prompts as needed
        };

        // Reset if all prompts have been used
        if (usedPromptsIndices.Count >= _listingPrompts.Count)
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
            index = new Random().Next(_listingPrompts.Count);
        } while (usedPromptsIndices.Contains(index));

        usedPromptsIndices.Add(index);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(_listingPrompts[index]);

        // Simulate listing time
        base.ShowCountdown(_activityDuration);

        base.DisplayCompletionMessage();
    }
}
