using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }
    public int AverageHeartRate { get; set; }
    protected const double StandardWeight = 70; 

    protected Activity(DateTime date, int lengthInMinutes, int averageHeartRate)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
        AverageHeartRate = averageHeartRate;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract int CalculateCaloriesBurned(); 

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy}: {GetType().Name} ({LengthInMinutes} min) - " +
               $"Heart Rate: {AverageHeartRate} bpm, Calories Burned: {CalculateCaloriesBurned()} kcal";
    }
}
