public class Cycling : Activity
{
    public double SpeedInMph { get; set; } // Speed in miles per hour

    public Cycling(DateTime date, int lengthInMinutes, double speedInMph, int averageHeartRate)
        : base(date, lengthInMinutes, averageHeartRate)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetDistance() => SpeedInMph * (LengthInMinutes / 60.0);

    public override double GetSpeed() => SpeedInMph;

    public override double GetPace() => 60 / SpeedInMph;

    public override int CalculateCaloriesBurned()
    {
        // Simplified calculation, assuming cycling burns approximately 8.5 calories per minute
        return (int)(8.5 * LengthInMinutes);
    }
}
