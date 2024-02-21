public class Swimming : Activity
{
    public int NumberOfLaps { get; set; }
    private const double LapLengthMeters = 50;
   
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, int lengthInMinutes, int numberOfLaps, int averageHeartRate)
        : base(date, lengthInMinutes, averageHeartRate)
    {
        NumberOfLaps = numberOfLaps;
    }

    public override double GetDistance() => NumberOfLaps * LapLengthMeters * MetersToMiles;

    public override double GetSpeed()
    {
        double distanceMiles = GetDistance();
        return distanceMiles / (LengthInMinutes / 60.0);
    }

    public override double GetPace() => LengthInMinutes / GetDistance();

    public override int CalculateCaloriesBurned()
    {
        // Simplified calculation, assuming swimming burns approximately 10 calories per minute
        return (int)(10 * LengthInMinutes);
    }
}
