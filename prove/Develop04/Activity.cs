using System;
using System.Threading;

abstract public class BaseActivity
{
    protected string _activityName;
    protected string _activityDescription;
    protected int _activityDuration;

    public BaseActivity()
    {
        _activityName = "General Activity";
        _activityDescription = "A basic structure for mindfulness activities.";
        _activityDuration = 0; // Default duration to be overridden by user input
    }

    protected void DisplayActivityIntro()
    {
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"{_activityDescription}\n");
    }

    protected void QueryDuration()
    {
        Console.Write("Please enter the desired duration for this activity in seconds: ");
        _activityDuration = int.TryParse(Console.ReadLine(), out int duration) ? duration : 60; // Default to 60 seconds if input is invalid
        Console.WriteLine($"Duration set to {_activityDuration} seconds.\nPreparing to start...");
        Thread.Sleep(2000); // Simulate preparation time with a delay
    }

    abstract public void RunActivity();

    protected void DisplayCompletionMessage()
    {
        Console.WriteLine("\nCongratulations, you've completed this activity!");
        Thread.Sleep(1000); // Brief pause before continuing
    }

    protected void ShowCountdown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write($"\rStarting in {i} seconds... ");
            Thread.Sleep(1000); // Wait for a second between each countdown step
        }
        Console.WriteLine("\rStart now!              "); // Clear the countdown message
    }

    protected DateTime CalculateEndTime(int seconds)
    {
        return DateTime.Now.AddSeconds(seconds);
    }

    // Example of a simple spinner animation that could be used during activities
    protected void DisplaySpinner(int durationInSeconds)
    {
        Console.Write("Processing ");
        for (int i = 0; i < durationInSeconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(250); // Adjust the sleep time to control the speed of the spinner
        }
        Console.WriteLine(" Done!");
    }
}
