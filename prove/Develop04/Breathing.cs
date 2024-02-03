using System;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will guide you through a series of deep breathing exercises.";
    }

    public override void RunActivity()
    {
        base.DisplayActivityIntro();
        base.QueryDuration();
        Console.WriteLine("Follow the breathing instructions.\n");

        DateTime endTime = base.CalculateEndTime(_activityDuration);
        while (DateTime.Now < endTime)
        {
            // Enhanced animation: simulate breathing with dynamic text.
            Console.Write("Breathe in...  ");
            DynamicTextAnimation("inhale", 4);  // Simulate inhale
            Console.Write("Hold...       ");
            DynamicTextAnimation("hold", 2);    // Simulate hold
            Console.Write("Breathe out...");
            DynamicTextAnimation("exhale", 6);  // Simulate exhale
        }

        base.DisplayCompletionMessage();
    }

    private void DynamicTextAnimation(string action, int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
