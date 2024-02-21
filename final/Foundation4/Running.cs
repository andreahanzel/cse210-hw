public class Running : Activity
{
    public double DistanceInMiles { get; set; }

    public Running(DateTime date, int lengthInMinutes, double distanceInMiles, int averageHeartRate)
        : base(date, lengthInMinutes, averageHeartRate)
    {
        DistanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => DistanceInMiles;
    public override double GetSpeed() => (DistanceInMiles / LengthInMinutes) * 60;
    public override double GetPace() => LengthInMinutes / DistanceInMiles;

    public override int CalculateCaloriesBurned()
    {
        
        return (int)(DistanceInMiles * 100);
    }
}
